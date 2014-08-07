using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public class SchoolImportRecord : IImportRecord
	{
		[ImportFieldRequired()]
		public string SchoolID { get; set; }

		[ImportFieldRequired()]
		public string Name { get; set; }


		public override bool Equals(object obj)
		{
			if (obj is SchoolImportRecord)
			{
				return SchoolID == ((SchoolImportRecord)obj).SchoolID;
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
			return SchoolID.GetHashCode();
		}

	}

}
