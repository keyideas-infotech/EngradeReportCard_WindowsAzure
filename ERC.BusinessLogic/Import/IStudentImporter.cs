using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public interface IStudentImporter
	{
		StudentImportResult ImportStudents(int districtID, int reportingPeriodID, IEnumerable<StudentImportRecord> importRecords, params StudentImportOptions[] importOptions);
	}
}