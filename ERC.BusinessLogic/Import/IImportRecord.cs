using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public interface IImportRecord
	{
	}

	public enum ImportRecordSkipReason
	{
		NameIncomplete,
		NoSystemSchoolIdAvailable,
		SchoolNotFound,
		NoSchoolPeriodAvailable,
		NoSystemTeacherIDAvailable,
		TeacherNotFound,
		ClassNotAvailable,
		GradeLevelOutOfRange
	}
}
