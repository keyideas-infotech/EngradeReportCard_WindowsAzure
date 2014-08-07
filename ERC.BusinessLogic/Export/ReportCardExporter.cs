using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using ERC.DataAccess;
using ERC.DataModel;

namespace ERC.BusinessLogic.Export
{
	public static class ReportCardExporter
	{
		public static MemoryStream GetReportCard(IDataRepo repo, int studentID, int schoolPeriodID, int templateID)
		{
			var schoolPeriod = repo.GetSchoolPeriod(schoolPeriodID, SchoolPeriodInclude.GradingTerms, SchoolPeriodInclude.ReportCardTemplates);
			var student = repo.GetStudent(studentID, StudentInclude.ClassEnrollments_StudentGrades_GradingStandard, StudentInclude.ClassEnrollments_StudentGrades_GradingTerm, StudentInclude.ClassEnrollments_Class);
			var standards = student.ClassEnrollments.SelectMany(p => p.StudentGrades).Select(p => p.GradingStandard).Distinct();
			var template = repo.GetReportCardTemplate(templateID);
			var enrollment = student.ClassEnrollments.First(p => p.Class.SchoolPeriodID == schoolPeriodID);

			return ProcessReportCard(schoolPeriod, standards, template, enrollment);
		}


		public static MemoryStream GetReportCards(IDataRepo repo, List<int> studentIds, int schoolPeriodID, int templateID)
		{
			var schoolPeriod = repo.GetSchoolPeriod(schoolPeriodID, SchoolPeriodInclude.GradingTerms, SchoolPeriodInclude.ReportCardTemplates);
			var students = repo.GetStudents(StudentInclude.ClassEnrollments_StudentGrades_GradingStandard, StudentInclude.ClassEnrollments_StudentGrades_GradingTerm, StudentInclude.ClassEnrollments_Class).Where(p => studentIds.Any(i => p.StudentID == i));
			var standards = students.SelectMany(p => p.ClassEnrollments).SelectMany(p => p.StudentGrades).Select(p => p.GradingStandard).Distinct();
			var template = repo.GetReportCardTemplate(templateID);
			var enrollments = students.SelectMany(p => p.ClassEnrollments).Where(p => p.Class.SchoolPeriodID == schoolPeriodID);

			return ProcessReportCard(schoolPeriod, standards, template, enrollments);
		}


		private static MemoryStream ProcessReportCard(SchoolPeriod schoolPeriod, IEnumerable<GradingStandard> gradingStandards, ReportCardTemplate template, ClassEnrollment enrollment)
		{
			var parser = GetParser(template.FileType);

			parser.Initialize(schoolPeriod, schoolPeriod.GradingTerms, gradingStandards, template.TemplateData);
			return parser.Process(enrollment, enrollment.Student.ClassEnrollments.SelectMany(p => p.StudentGrades));
		}

		private static MemoryStream ProcessReportCard(SchoolPeriod schoolPeriod, IEnumerable<GradingStandard> gradingStandards, ReportCardTemplate template, IEnumerable<ClassEnrollment> enrollments)
		{
			IReportCardParser parser = GetParser(template.FileType);

			parser.Initialize(schoolPeriod, schoolPeriod.GradingTerms, gradingStandards, template.TemplateData);
			return parser.Process(enrollments);
		}

		/*private static MemoryStream ProcessReportCard(SchoolPeriod schoolPeriod, IEnumerable<GradingStandard> gradingStandards, ReportCardTemplate template, IEnumerable<Student> students)
		{
			var parser = GetParser(template.FileType);

			parser.Initialize(schoolPeriod, schoolPeriod.GradingTerms, gradingStandards, template.TemplateData);
			return parser.Process(students);
		}*/


		private static IReportCardParser GetParser(ReportCardTemplateFileType fileType)
		{
			IReportCardParser parser = null;

			switch (fileType)
			{
				case ReportCardTemplateFileType.Docx:
					parser = new DocxReportCardParser();
					break;
				case ReportCardTemplateFileType.Pdf:
					parser = new PdfReportCardParser();
					break;
			}

			return parser;
		}

	}
}
