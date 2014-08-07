using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ERC.BusinessLogic.Import
{
	public abstract class ImportResult<T>
	{
		public DateTimeOffset ImportStarted { get; set; }

		public DateTimeOffset ImportFinished { get; set; }

		public int NumRecordsProcessed { get; set; }

		public int NumRecordsInserted { get { return InsertedRecords.Count; } }

		public int NumRecordsUpdated { get { return UpdatedRecords.Count; } }

		public int NumRecordsSkipped { get { return SkippedRecords.Count; } }

		public List<T> InsertedRecords { get { return _insertedRecords ?? (_insertedRecords = new List<T>()); } }
		private List<T> _insertedRecords;

		public List<T> UpdatedRecords { get { return _updatedRecords ?? (_updatedRecords = new List<T>()); } }
		private List<T> _updatedRecords;

		public Dictionary<T, ImportRecordSkipReason> SkippedRecords { get { return _skippedRecords ?? (_skippedRecords = new Dictionary<T, ImportRecordSkipReason>()); } }
		private Dictionary<T, ImportRecordSkipReason> _skippedRecords;

		public void MarkStart()
		{
			ImportStarted = DateTimeOffset.Now;
		}

		public void MarkEnd()
		{
			ImportFinished = DateTimeOffset.Now;
		}
	}
}
