using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataModel;
using System.Text.RegularExpressions;
using System.IO;
using iTextSharp.text.pdf;
using iTextSharp.text;

namespace ERC.BusinessLogic.Export
{
	public class PdfReportCardParser : IReportCardParser
	{
		private byte[] Template { get; set; }
		private SchoolPeriod Period { get; set; }
		private List<GradingTerm> Terms { get; set; }
		private List<GradingStandard> Standards { get; set; }


		public void Initialize(SchoolPeriod schoolPeriod, IEnumerable<GradingTerm> gradingTerms, IEnumerable<GradingStandard> gradingStandards, byte[] templateData)
		{
			Template = templateData;
			Period = schoolPeriod;
			Terms = gradingTerms.ToList();
			Standards = gradingStandards.ToList();
		}

		private static readonly Regex KeyPattern = new Regex(@"^(?<ph>.+?)(-(?<term>\d+?))?$", RegexOptions.Compiled);


		/*public MemoryStream Process(IEnumerable<Student> students)
		{
            
		}*/

		public MemoryStream Process(IEnumerable<ClassEnrollment> enrollments)
		{
			//Loop through each enrollment to process one report card per student
			var pdfReaders = enrollments.Select(enrollment => new PdfReader(Process(enrollment, enrollment.StudentGrades.ToList()).ToArray())).ToList();

			//Now merge all the pdf streams into one document
			var outputStream = new MemoryStream();
			var pdfDoc = new Document();
			pdfDoc.SetMargins(0, 0, 0, 0);
			var writer = PdfWriter.GetInstance(pdfDoc, outputStream);
			pdfDoc.Open();
			var pdfContentByte = writer.DirectContent;

			foreach (var reader in pdfReaders)
			{
				for (var page = 1; page <= reader.NumberOfPages; page++)
				{
					var importedPage = writer.GetImportedPage(reader, page);
					pdfDoc.SetPageSize(importedPage.BoundingBox);
					pdfDoc.NewPage();
					pdfContentByte.AddTemplate(importedPage, 0, 0);
				}
			}

			outputStream.Flush();
			pdfDoc.Close();
			outputStream.Close();

			return outputStream;
		}

		public MemoryStream Process(ClassEnrollment enrollment, IEnumerable<StudentGrade> grades)
		{
			var gradeList = grades.ToList();
			var placeholderHelper = new CommonPlaceholderHelper();
			placeholderHelper.SetValues(enrollment.Student, enrollment.Class.Teacher);
			placeholderHelper.SetValues(Period, Period.ReportingPeriod, Period.School, Period.School.SchoolDistrict);

			//string filename = String.Format("{0}{2} {1}.pdf", @"d:\cards\", enrollment.Student.LastName, enrollment.Student.FirstName);

			//FileStream stream = new FileStream(filename, FileMode.Create);
			var stream = new MemoryStream();
			var reader = new PdfReader(Template);
			var stamper = new PdfStamper(reader, stream);

			var form = stamper.AcroFields;
			var fieldKeys = form.Fields.Keys;

			foreach (var fieldKey in fieldKeys)
			{
				var match = KeyPattern.Match(fieldKey);

				if (match.Success)
				{
					var key = match.Groups["ph"].Value;
					var term = 1;

					var termGroup = match.Groups["term"];
					if (termGroup.Success)
					{
						int.TryParse(termGroup.Value, out term);
					}

					var standard = Standards.FirstOrDefault(p => p.Placeholder == key);

					if (standard == null)
					{
						form.SetField(fieldKey, placeholderHelper.GetValue(fieldKey));
						continue;
					}

					var gradingTerm = Terms.FirstOrDefault(p => p.TermNum == term);

					if (gradingTerm == null)
					{
						form.SetField(fieldKey, string.Empty);
						continue;
					}

					var grade = gradeList.FirstOrDefault(p => p.GradingStandard == standard && p.GradingTermID == gradingTerm.GradingTermID);

					if (grade == null)
					{
						form.SetField(fieldKey, string.Empty);
						continue;
					}

					form.SetField(fieldKey, grade.Grade);
				}
				else
				{
					form.SetField(fieldKey, string.Empty);
				}
			}

			// "Flatten" the form so it wont be editable/usable anymore  
			stamper.FormFlattening = true;

			stamper.Close();
			reader.Close();

			return stream;
		}
	}
}
