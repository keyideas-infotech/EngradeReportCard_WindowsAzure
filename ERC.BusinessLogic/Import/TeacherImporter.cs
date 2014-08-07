using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataAccess;
using ERC.DataModel;

namespace ERC.BusinessLogic.Import
{
	public class TeacherImporter : ITeacherImporter
	{
		private readonly IDataRepo _repo;

		public TeacherImporter(IDataRepo repo)
		{
			_repo = repo;
		}

		public TeacherImportResult ImportTeachers(int districtID, IEnumerable<TeacherImportRecord> importRecords, params TeacherImportOptions[] importOptions)
		{
			var result = new TeacherImportResult();
			result.MarkStart();

			var schools = _repo.GetSchools(districtID, SchoolInclude.Teachers).ToList();

			foreach (var record in importRecords)
			{
				//Increment the number of records processed
				result.NumRecordsProcessed++;

				//Create the Teacher Entity object
				var teacher = new Teacher
				{
					FirstName = record.FirstName,
					LastName = record.LastName,
					ImportID = record.TeacherID,
					IDNumber = record.IDNumber,
					Email = record.Email,
					Phone = record.Phone
				};

				//Check if we have a school system id available
				if (String.IsNullOrWhiteSpace(record.SchoolID))
				{
					result.SkippedRecords.Add(teacher, ImportRecordSkipReason.NoSystemSchoolIdAvailable);
					continue;
				}

				//Check if the name is complete
				if (String.IsNullOrWhiteSpace(record.FirstName) || String.IsNullOrWhiteSpace(record.LastName))
				{
					result.SkippedRecords.Add(teacher, ImportRecordSkipReason.NameIncomplete);
					continue;
				}

				//Locate the existing school (if any)
				var school = schools.FirstOrDefault(p => p.ImportID == record.SchoolID);

				//Create the school, if requested, and if doesn't exist)
				if (school == null && importOptions.Contains(TeacherImportOptions.CreateSchoolIfNotExist))
				{
					school = new School
					{
						SchoolDistrictID = districtID,
						ImportID = record.SchoolID,
						Name = String.Format("Untitled School {0}", record.SchoolID)
					};

					_repo.AddSchool(school, false);

					//Add this school to the local collection so it doesn't get created twice
					schools.Add(school);
				}
				else if (school == null)
				{
					//Error with school not found otherwise
					result.SkippedRecords.Add(teacher, ImportRecordSkipReason.SchoolNotFound);
					continue;
				}

				//Locate the existing teacher (if any)
				Teacher existingTeacher = null;

				//Serach just the school that the teacher belongs to
				if (!String.IsNullOrWhiteSpace(teacher.ImportID))
				{
					existingTeacher = school.Teachers.FirstOrDefault(p => p.ImportID == teacher.ImportID);
				}

				//If no teacher was found, and MatchByIdNumber is selected, try that next
				if (existingTeacher == null && importOptions.Contains(TeacherImportOptions.MatchByIdNumber))
				{
					existingTeacher = school.Teachers.FirstOrDefault(p => p.IDNumber == teacher.IDNumber);
				}

				//If not teacher was still found, and MatchByName is selected, lastly try that
				if (existingTeacher == null && importOptions.Contains(TeacherImportOptions.MatchByName))
				{
					existingTeacher = school.Teachers.FirstOrDefault(p =>
						p.FirstName.Equals(teacher.FirstName, StringComparison.InvariantCultureIgnoreCase) &&
						p.LastName.Equals(teacher.LastName, StringComparison.InvariantCultureIgnoreCase));
				}

				//If existing teacher was found, update that record instead
				if (existingTeacher != null)
				{
					existingTeacher.FirstName = teacher.FirstName;
					existingTeacher.LastName = teacher.LastName;
					existingTeacher.ImportID = teacher.ImportID;
					existingTeacher.IDNumber = teacher.IDNumber;
					existingTeacher.Email = teacher.Email;
					existingTeacher.Phone = teacher.Phone;

					//Record the update result
					result.UpdatedRecords.Add(existingTeacher);
				}
				else
				{
					//Associate the teacher to the school
					teacher.School = school;

					//Add add it to the repository for persistance
					_repo.AddTeacher(teacher, false);

					//Record the insert result
					result.InsertedRecords.Add(teacher);
				}
			}

			//Persist all changes (Inserts & Updates)
			_repo.Save();

			//Mark the end date stamp
			result.MarkEnd();

			//return the result
			return result;
		}
	}

	public enum TeacherImportOptions
	{
		CreateSchoolIfNotExist,
		MatchByIdNumber,
		MatchByName
	}

	public class TeacherImportResult : ImportResult<Teacher>
	{
	}
}
