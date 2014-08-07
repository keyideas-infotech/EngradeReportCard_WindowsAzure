using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataAccess;
using ERC.DataModel;

namespace ERC.BusinessLogic.Import
{
	public class StudentImporter : IStudentImporter
	{
		private readonly IDataRepo _repo;

		public StudentImporter(IDataRepo repo)
		{
			_repo = repo;
		}

		public StudentImportResult ImportStudents(int districtID, int reportingPeriodID, IEnumerable<StudentImportRecord> importRecords, params StudentImportOptions[] importOptions)
		{
			//Create the result object, and mark the start time
			var result = new StudentImportResult();
			result.MarkStart();

			//Get the list of schools for the School District, along with each schools list of teachers and school periods
			var schools = _repo.GetSchools(districtID, SchoolInclude.Teachers, SchoolInclude.SchoolPeriods).ToList();

			//Get a list of the class sessions in this school district, that are in the school period specifieid, and include the Class Type for each class
			var existingClasses = _repo.GetClasses(ClassInclude.ClassType, ClassInclude.ClassEnrollments).Where(p => p.SchoolPeriod.ReportingPeriodID == reportingPeriodID).ToList();

			//Also get a dedicated list of class types for the district (including the ones that are unique to specific schools in this district)
			var classTypes = _repo.GetClassTypes(districtID, false).ToList();

			//Get a list of all the students in this district
			var students = _repo.GetStudents(districtID).ToList();

			//Loop through each reacord in the imported data set
			foreach (var record in importRecords)
			{
				result.NumRecordsProcessed++;

				//Create a new student record
				//If we find an existing student later, we will use this object to update the existing student
				var newStudent = new Student
				{
					ImportID = record.StudentID,
					FirstName = record.FirstName,
					MiddleName = record.MiddleName,
					LastName = record.LastName,
					IDNumber = record.IDNumber,
					GradeLevel = (byte)record.GradeLevel
				};

				//Skip if there is no school to link the imported record to
				if (String.IsNullOrWhiteSpace(record.SchoolID))
				{
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.NoSystemSchoolIdAvailable);
					continue;
				}

				//Skip if there is no teacher to link the imported record to
				if (String.IsNullOrWhiteSpace(record.TeacherID))
				{
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.NoSystemTeacherIDAvailable);
					continue;
				}

				//Skip if the grade level is out of range
				if (record.GradeLevel < 0 || record.GradeLevel > 12)
				{
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.GradeLevelOutOfRange);
					continue;
				}

				//Find school the student belongs to
				var school = schools.FirstOrDefault(p => p.ImportID == record.SchoolID);

				//Skip if the school could not be found
				if (school == null)
				{
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.SchoolNotFound);
					continue;
				}

				//Find the school period
				var schoolPeriod = school.SchoolPeriods.FirstOrDefault(p => p.ReportingPeriodID == reportingPeriodID);

				//Create the school period if necessary
				if (schoolPeriod == null && importOptions.Contains(StudentImportOptions.AutoCreateSchoolPeriods))
				{
					//TODO: Somehow determine how many terms we should create
					schoolPeriod = new SchoolPeriod { NumTerms = 3, School = school, ReportingPeriodID = reportingPeriodID };

					//link to school
					foreach (int i in Enumerable.Range(1, 3))
					{
						var term = new GradingTerm { TermNum = (byte)i, GradingOpen = false };
						schoolPeriod.GradingTerms.Add(term);
					}

					//Add to repo for persistance
					//(Linking to school should do this anyway, but just in case)
					_repo.AddSchoolPeriod(schoolPeriod, false);

					//Add new school period to result object
					result.SchoolPeriodsCreated.Add(schoolPeriod);
				}
				else if (schoolPeriod == null)
				{
					//Skip if the school period couldn't be found, and we aren't suppose to auto create it
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.NoSchoolPeriodAvailable);
					continue;
				}

				//Try and find an existing student
				var existingStudent = students.FirstOrDefault(p => p.ImportID == record.StudentID && p.SchoolID == school.SchoolID);

				//Alternatively, if selected, try to find the student by their ID number
				if (existingStudent == null && importOptions.Contains(StudentImportOptions.AllowStudentMatchOnIdNumber) && !String.IsNullOrWhiteSpace(record.IDNumber) && record.IDNumber.Length > 1)
				{
					existingStudent = students.FirstOrDefault(p => p.IDNumber == record.IDNumber && p.SchoolID == school.SchoolID);
				}

				if (existingStudent != null)
				{
					//Update existing student
					existingStudent.ImportID = newStudent.ImportID;
					existingStudent.FirstName = newStudent.FirstName;
					existingStudent.MiddleName = newStudent.MiddleName;
					existingStudent.LastName = newStudent.LastName;
					existingStudent.IDNumber = newStudent.IDNumber;
					existingStudent.GradeLevel = newStudent.GradeLevel;

					result.UpdatedRecords.Add(existingStudent);
				}
				else
				{
					//Link student to school
					newStudent.School = school;

					//Add to repo for persistance 
					//(which would probably happen anyway now that they are linked to a school)
					_repo.AddStudent(newStudent, false);

					result.InsertedRecords.Add(newStudent);
				}

				//Use either the existing student, or new student, depending on 
				var student = existingStudent ?? newStudent;

				//Get the teacher that is teaching the enrolled class
				var teacher = school.Teachers.FirstOrDefault(p => p.ImportID == record.TeacherID);

				//Skip if teacher was not found
				if (teacher == null)
				{
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.TeacherNotFound);
					continue;
				}

				//Find or create the class the student would be enrolled in
				Class enrolledClass = existingClasses.FirstOrDefault(p => (p.TeacherID == teacher.TeacherID || p.Teacher == teacher) && p.ClassType.GradeLevel == record.GradeLevel);

				if (enrolledClass == null && importOptions.Contains(StudentImportOptions.AutoCreateClasses))
				{
					ClassType classType = classTypes.FirstOrDefault(p => p.GradeLevel == record.GradeLevel && (p.SchoolID == null || p.SchoolID == school.SchoolID));

					//Create the class type if necessary as well
					if (classType == null)
					{
						classType = new ClassType();
						classType.GradeLevel = (byte)record.GradeLevel;
						classType.Name = classType.GradeLevelLong;
						classType.SchoolDistrictID = school.SchoolDistrictID; //link to district
						classType.SchoolID = null; //make available district wide

						//Add class type creation to result object
						result.ClassTypesCreated.Add(classType);

						//persist the new class type
						_repo.AddClassType(classType, false);

						//Add the new class type to the local collection for future use
						classTypes.Add(classType);
					}

					enrolledClass = new Class();
					enrolledClass.ClassType = classType;
					enrolledClass.Name = String.Format("{0}'s {1}", teacher.FullName, student.GradeLevelLong);
					enrolledClass.Teacher = teacher;
					enrolledClass.SchoolPeriod = schoolPeriod;

					//add new class to result object
					result.ClassesCreated.Add(enrolledClass);

					//persist new class
					_repo.AddClass(enrolledClass, false);

					//add new class to local collection for future use
					existingClasses.Add(enrolledClass);
				}
				else if (enrolledClass == null)
				{
					result.SkippedRecords.Add(newStudent, ImportRecordSkipReason.ClassNotAvailable);
					continue;
				}

				//Find existing enrollment
				var enrollment = enrolledClass.ClassEnrollments.FirstOrDefault(p => p.Student == student);

				//Create the class enrollment if necessary
				if (enrollment == null)
				{
					enrollment = new ClassEnrollment();
					enrollment.Student = student;
					enrollment.Class = enrolledClass;

					//persist
					_repo.AddClassEnrollment(enrollment, false);

					result.EnrollmentsCreated.Add(enrollment);
				}
			}

			//Save changes
			_repo.Save();

			result.MarkEnd();

			return result;
		}
	}

	public enum StudentImportOptions
	{
		AutoCreateClasses,
		AutoCreateSchoolPeriods,
		AllowStudentMatchOnIdNumber
	}

	public class StudentImportResult : ImportResult<Student>
	{
		public int NumClassesCreated { get { return ClassesCreated.Count; } }

		public int NumSchoolPeriodsCreated { get { return SchoolPeriodsCreated.Count; } }

		public int NumEnrollmentsCreated { get { return EnrollmentsCreated.Count; } }

		public int NumClassTypesCreated { get { return ClassTypesCreated.Count; } }

		public List<Class> ClassesCreated { get { return _classesCreated ?? (_classesCreated = new List<Class>()); } }
		private List<Class> _classesCreated;

		public List<SchoolPeriod> SchoolPeriodsCreated { get { return _schoolPeriodsCreated ?? (_schoolPeriodsCreated = new List<SchoolPeriod>()); } }
		private List<SchoolPeriod> _schoolPeriodsCreated;

		public List<ClassEnrollment> EnrollmentsCreated { get { return _enrollmentsCreated ?? (_enrollmentsCreated = new List<ClassEnrollment>()); } }
		private List<ClassEnrollment> _enrollmentsCreated;

		public List<ClassType> ClassTypesCreated { get { return _classTypesCreated ?? (_classTypesCreated = new List<ClassType>()); } }
		private List<ClassType> _classTypesCreated;

	}
}
