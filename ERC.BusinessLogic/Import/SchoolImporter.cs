using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataAccess;
using ERC.DataModel;

namespace ERC.BusinessLogic.Import
{
	public class SchoolImporter : ISchoolImporter
	{
		private readonly IDataRepo _repo;

		public SchoolImporter(IDataRepo repo)
		{
			_repo = repo;
		}

		public SchoolImportResult ImportSchools(int districtID, IEnumerable<SchoolImportRecord> importRecords)
		{
			var result = new SchoolImportResult();
			result.MarkStart();

			var schools = _repo.GetSchools(districtID);

			foreach (var record in importRecords)
			{
				//Increment the number of records processed
				result.NumRecordsProcessed++;

				if (String.IsNullOrWhiteSpace(record.Name))
				{
					result.SkippedRecords.Add(new School() { ImportID = record.SchoolID, SchoolDistrictID = districtID }, ImportRecordSkipReason.NameIncomplete);
					continue;
				}

				var existingSchool = schools.FirstOrDefault(p => p.ImportID == record.SchoolID);

				if (existingSchool != null)
				{
					existingSchool.Name = record.Name;
					result.UpdatedRecords.Add(existingSchool);
					continue;
				}
				else
				{
					var school = _repo.CreateSchool(districtID, record.Name, record.SchoolID, false);
					result.InsertedRecords.Add(school);
					continue;
				}


			}

			//Persist all changes (Inserts & Updates)
			_repo.Save();

			//Mark the end date stamp
			result.MarkEnd();

			return result;
		}

	}

	public class SchoolImportResult : ImportResult<School>
	{
	}
}
