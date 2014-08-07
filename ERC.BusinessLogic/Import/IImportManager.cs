using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ERC.BusinessLogic.Import
{
	public interface IImportManager
	{
		TeacherImportResult ImportTeachers(int districtID, Stream stream);
		SchoolImportResult ImportSchools(int districtID, Stream stream);
		StudentImportResult ImportStudents(int districtID, int reportingPeriodID, Stream stream);
	}
}