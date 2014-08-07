using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using TinyLog;
using LumenWorks.Framework.IO.Csv;
using System.Reflection;

namespace ERC.BusinessLogic.Import
{
	public class ImportManager : IImportManager
	{
		private const string TAG = "ImportManager";

		private readonly ITeacherImporter _teacherImporter;
		private readonly ISchoolImporter _schoolImporter;
		private readonly IStudentImporter _studentImporter;

		public ImportManager(ITeacherImporter teacherImporter, ISchoolImporter schoolImporter, IStudentImporter studentImporter)
		{
			_teacherImporter = teacherImporter;
			_schoolImporter = schoolImporter;
			_studentImporter = studentImporter;
		}

		public TeacherImportResult ImportTeachers(int districtID, Stream stream)
		{
			var result = _teacherImporter.ImportTeachers(districtID, GetCsvRecords<TeacherImportRecord>(stream), TeacherImportOptions.CreateSchoolIfNotExist);

			TinyLogger.Info(TAG, "{0} teacher records processed. {0} inserted. {1} updated. {2} skipped", result.NumRecordsProcessed, result.NumRecordsInserted, result.NumRecordsUpdated, result.NumRecordsSkipped);

			return result;
		}

		public SchoolImportResult ImportSchools(int districtID, Stream stream)
		{
			var result = _schoolImporter.ImportSchools(districtID, GetCsvRecords<SchoolImportRecord>(stream));

			TinyLogger.Info(TAG, "{0} teacher records processed. {0} inserted. {1} updated. {2} skipped", result.NumRecordsProcessed, result.NumRecordsInserted, result.NumRecordsUpdated, result.NumRecordsSkipped);

			return result;
		}


		public StudentImportResult ImportStudents(int districtID, int reportingPeriodID, Stream stream)
		{
			var result = _studentImporter.ImportStudents(districtID, reportingPeriodID, GetCsvRecords<StudentImportRecord>(stream), StudentImportOptions.AutoCreateClasses, StudentImportOptions.AutoCreateSchoolPeriods);

			TinyLogger.Info(TAG, "{0} teacher records processed. {0} inserted. {1} updated. {2} skipped", result.NumRecordsProcessed, result.NumRecordsInserted, result.NumRecordsUpdated, result.NumRecordsSkipped);
			TinyLogger.Info(TAG, "{0} classes auto created, {1} school periods auto created, {2} enrollments created", result.NumClassesCreated, result.NumSchoolPeriodsCreated, result.NumEnrollmentsCreated);

			return result;
		}

		private List<T> GetCsvRecords<T>(Stream stream, bool errorOnDuplicatIds = true)
		{
			var csv = new CsvReader(new StreamReader(stream), true);

			var missingFields = GetMissingRequiredFields<T>(csv);
			if (missingFields.Count > 0)
			{
				throw new ImportMissingFieldsException(missingFields);
			}

			int fieldCount = csv.FieldCount;
			string[] headers = csv.GetFieldHeaders();

			var records = new List<T>();
			Type recordType = typeof(T);
			var recordFields = recordType.GetFields();
			var recordProps = recordType.GetProperties();

			while (csv.ReadNextRecord())
			{
				T record = Activator.CreateInstance<T>();

				for (int i = 0; i < fieldCount; i++)
				{
					string header = headers[i];

					var field = recordFields.FirstOrDefault(p => p.Name.Equals(header, StringComparison.InvariantCultureIgnoreCase));

					if (field != null)
					{
						field.SetValue(record, GetValue(field, csv[i]));
						continue;
					}

					var prop = recordProps.FirstOrDefault(p => p.Name.Equals(header, StringComparison.InvariantCultureIgnoreCase));

					if (prop != null)
					{
						prop.SetValue(record, GetValue(prop, csv[i]), null);
					}
				}

				records.Add(record);
			}

			//Check for duplicates
			if (errorOnDuplicatIds)
			{
				int totalCount = records.Count;
				int uniqueCount = records.Distinct().Count();
				int duplicateCount = totalCount - uniqueCount;

				if (duplicateCount > 0)
				{
					throw new ImportException("Multiple records with the same ID were found. Import cancelled due to potential data inconsistencies");
				}
			}

			return records;
		}



		private object GetValue(FieldInfo field, String value)
		{
			return GetValue(field.FieldType, value);
		}

		private object GetValue(PropertyInfo prop, String value)
		{
			return GetValue(prop.PropertyType, value);
		}

		private object GetValue(Type valueType, String value)
		{

			if (valueType == typeof(String))
			{
				return value;
			}
			if (valueType == typeof(Int32))
			{
				int v;
				int.TryParse(value, out v);
				return v;
			}
			if (valueType == typeof(int?))
			{
				int v;
				var success = int.TryParse(value, out v);
				return success ? (int?)v : null;
			}
			if (valueType == typeof(Boolean))
			{
				bool b;
				Boolean.TryParse(value, out b);
				return b;
			}
			if (valueType == typeof(bool?))
			{
				bool b;
				bool success = Boolean.TryParse(value, out b);
				return success ? (bool?)b : null;
			}

			return String.Empty;
		}




		private List<string> GetMissingRequiredFields<T>(CsvReader csvReader)
		{
			var fields = new List<string>();
			var headers = csvReader.GetFieldHeaders().ToList();
			var type = typeof(T);

			foreach (var field in type.GetFields())
			{
				foreach (ImportFieldRequired attr in field.GetCustomAttributes(typeof(ImportFieldRequired), true))
				{
					if (!headers.Any(p => p.Equals(field.Name, StringComparison.InvariantCultureIgnoreCase)))
					{
						fields.Add(field.Name);
					}
				}
			}

			foreach (var prop in type.GetProperties())
			{
				foreach (ImportFieldRequired attr in prop.GetCustomAttributes(typeof(ImportFieldRequired), true))
				{
					if (!headers.Any(p => p.Equals(prop.Name, StringComparison.InvariantCultureIgnoreCase)))
					{
						fields.Add(prop.Name);
					}
				}
			}

			return fields;
		}
	}
}
