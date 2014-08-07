using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public interface ISchoolImporter
	{
		SchoolImportResult ImportSchools(int districtID, IEnumerable<SchoolImportRecord> importRecords);
	}
}