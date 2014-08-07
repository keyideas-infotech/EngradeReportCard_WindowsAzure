using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.IO;
using ERC.DataModel;
using DocumentFormat.OpenXml.Packaging;

namespace ERC.BusinessLogic.Export
{
	public class DocxReportCardParser : IReportCardParser
	{
		public static Regex PlaceholderPattern = new Regex(@"\[\[(?<ph>.+?)(-(?<term>\d+?))?\]\]", RegexOptions.Compiled);

		private MemoryStream TemplateStream { get; set; }
		private SchoolPeriod Period { get; set; }
		private IEnumerable<GradingTerm> Terms { get; set; }
		private IEnumerable<GradingStandard> Standards { get; set; }

		public void Initialize(SchoolPeriod schoolPeriod, IEnumerable<GradingTerm> gradingTerms, IEnumerable<GradingStandard> gradingStandards, byte[] templateData)
		{
			this.Period = schoolPeriod;
			this.Terms = gradingTerms;
			this.Standards = gradingStandards;
			this.TemplateStream = new MemoryStream(templateData);
		}


		public MemoryStream Process(IEnumerable<ClassEnrollment> enrollments)
		{
			var outputStream = new MemoryStream();
			var templateText = string.Empty;

			using (var templateDoc = WordprocessingDocument.Open(TemplateStream, false))
			{
				using (var reader = new StreamReader(templateDoc.MainDocumentPart.GetStream()))
				{
					templateText = reader.ReadToEnd();
				}
			}

			using (var doc = WordprocessingDocument.Create(TemplateStream, DocumentFormat.OpenXml.WordprocessingDocumentType.Document))
			{
				using (var writer = new StreamWriter(outputStream))
				{
					foreach (var enrollment in enrollments)
					{
						writer.Write(ProcessText(templateText, enrollment, enrollment.StudentGrades));
					}
				}
			}

			return outputStream;
		}

		public MemoryStream Process(ClassEnrollment enrollment, IEnumerable<StudentGrade> grades)
		{
			using (var doc = WordprocessingDocument.Open(TemplateStream, true))
			{
				var text = string.Empty;

				//Get Text
				using (var reader = new StreamReader(doc.MainDocumentPart.GetStream()))
				{
					text = reader.ReadToEnd();
				}

				//Modify Text
				text = ProcessText(text, enrollment, grades);


				//Write text
				using (var writer = new StreamWriter(doc.MainDocumentPart.GetStream(FileMode.Create)))
				{
					writer.Write(text);
				}
			}

			return TemplateStream;
		}


		private string ProcessText(string input, ClassEnrollment enrollment, IEnumerable<StudentGrade> grades)
		{
			while (PlaceholderPattern.IsMatch(input))
			{
				Match match = PlaceholderPattern.Match(input);

				string key = match.Groups["ph"].Value;
				int term = 1;

				Group termGroup = match.Groups["term"];
				if (termGroup.Success)
				{
					term = int.Parse(termGroup.Value);
				}

				var standard = Standards.FirstOrDefault(p => p.Placeholder == key);

				if (standard == null)
				{
					input = RemovePlaceholder(input, match);
					continue;
				}

				var grade = grades.FirstOrDefault(p => p.GradingStandard == standard);

				if (grade == null)
				{
					input = RemovePlaceholder(input, match);
					continue;
				}

				input = ReplacePlaceholder(input, match, grade.Grade);
			}

			return input;
		}



		private string RemovePlaceholder(string text, Match match)
		{
			return ReplacePlaceholder(text, match, String.Empty);
		}

		private string ReplacePlaceholder(string text, Match match, string replacement)
		{
			return ReplacePlaceholder(text, match.Index, match.Length, replacement);
		}

		private string ReplacePlaceholder(string text, int start, int length, string replacement)
		{
			text = text.Remove(start, length);
			return text.Insert(start, replacement);
		}
	}
}
