using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public class TeacherImportRecord : IImportRecord
	{
		[ImportFieldRequired()]
		public string SchoolID { get; set; }

		[ImportFieldRequired()]
		public string TeacherID { get; set; }

		[ImportFieldRequired()]
		public string FirstName { get; set; }

		[ImportFieldRequired()]
		public string LastName { get; set; }

		public string IDNumber { get; set; }

		public string Email { get; set; }

		public string Phone { get; set; }


		public override bool Equals(object obj)
		{
			if (obj is TeacherImportRecord)
			{
				var teacher = (TeacherImportRecord)obj;
				return TeacherID == teacher.TeacherID && SchoolID == teacher.SchoolID;
			}
			else
			{
				return false;
			}
		}

		//Overriding so the .Distinct() method on the import
		//Will catch two records with the same id
		public override int GetHashCode()
		{
			return String.Format("{0}-{1}", SchoolID, TeacherID).GetHashCode();
		}
	}
}
