using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Property, AllowMultiple = false, Inherited = true)]
	internal class ImportFieldRequired : Attribute
	{
		public ImportFieldRequired()
		{
		}
	}
}
