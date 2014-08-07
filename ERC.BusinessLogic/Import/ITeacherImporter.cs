using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public interface ITeacherImporter
	{
		TeacherImportResult ImportTeachers(int districtID, IEnumerable<TeacherImportRecord> importRecords, params TeacherImportOptions[] importOptions);
	}
}