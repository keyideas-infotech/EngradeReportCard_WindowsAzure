using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataModel;
using System.IO;

namespace ERC.BusinessLogic.Export
{
	public interface IReportCardParser
	{
		void Initialize(SchoolPeriod schoolPeriod, IEnumerable<GradingTerm> gradingTerms, IEnumerable<GradingStandard> gradingStandards, byte[] templateData);

		MemoryStream Process(ClassEnrollment enrollment, IEnumerable<StudentGrade> grades);

		MemoryStream Process(IEnumerable<ClassEnrollment> enrollments);
	}
}
