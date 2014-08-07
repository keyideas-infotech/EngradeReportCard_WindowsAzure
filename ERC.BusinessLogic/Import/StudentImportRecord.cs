using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ERC.DataModel;

namespace ERC.BusinessLogic.Import
{
	public class StudentImportRecord : IImportRecord
	{

		[ImportFieldRequired()]
		public string SchoolID { get; set; }

		[ImportFieldRequired()]
		public string StudentID { get; set; }

		[ImportFieldRequired()]
		public string FirstName { get; set; }

		public string MiddleName { get; set; }

		[ImportFieldRequired()]
		public string LastName { get; set; }

		public string IDNumber { get; set; }

		[ImportFieldRequired()]
		public int GradeLevel { get; set; }

		[ImportFieldRequired()]
		public string TeacherID { get; set; }


		public override bool Equals(object obj)
		{
			if (obj is StudentImportRecord)
			{
				return StudentID == ((StudentImportRecord)obj).StudentID;
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
			return StudentID.GetHashCode();
		}

	}

	public class NewStudentImport
	{
		public StudentImportRecord ImportRecord { get; set; }
		public Student Student { get; set; }
	}

	public class ExistingStudentImport
	{
		public StudentImportRecord ImportRecord { get; set; }
		public Student ExistingStudent { get; set; }
	}
}
