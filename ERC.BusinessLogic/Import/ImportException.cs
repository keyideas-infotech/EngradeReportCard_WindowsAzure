using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	[Serializable]
	public class ImportException : Exception
	{
		public ImportException() { }
		public ImportException(string message) : base(message) { }
		public ImportException(string message, Exception inner) : base(message, inner) { }
		protected ImportException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}

	[Serializable]
	public class ImportMissingFieldsException : ImportException
	{
		public List<string> MissingFields { get; set; }


		public ImportMissingFieldsException(List<string> missingFields)
		{
			this.MissingFields = missingFields;
		}

		public ImportMissingFieldsException(List<string> missingFields, string message)
			: base(message)
		{
			this.MissingFields = missingFields;
		}

		protected ImportMissingFieldsException(
		  System.Runtime.Serialization.SerializationInfo info,
		  System.Runtime.Serialization.StreamingContext context)
			: base(info, context) { }
	}
}
