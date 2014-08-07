using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ImportResultTest and is intended
    ///to contain all ImportResultTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImportResultTest
    {


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        // 
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //
        #endregion


        /// <summary>
        ///A test for MarkEnd
        ///</summary>
        public void MarkEndTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            target.MarkEnd();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        internal virtual ImportResult<T> CreateImportResult<T>()
        {
            // TODO: Instantiate an appropriate concrete class.
            ImportResult<T> target = null;
            return target;
        }

        [TestMethod()]
        public void MarkEndTest()
        {
            MarkEndTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for MarkStart
        ///</summary>
        public void MarkStartTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            target.MarkStart();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        [TestMethod()]
        public void MarkStartTest()
        {
            MarkStartTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ImportFinished
        ///</summary>
        public void ImportFinishedTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            DateTimeOffset expected = new DateTimeOffset(); // TODO: Initialize to an appropriate value
            DateTimeOffset actual;
            target.ImportFinished = expected;
            actual = target.ImportFinished;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ImportFinishedTest()
        {
            ImportFinishedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for ImportStarted
        ///</summary>
        public void ImportStartedTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            DateTimeOffset expected = new DateTimeOffset(); // TODO: Initialize to an appropriate value
            DateTimeOffset actual;
            target.ImportStarted = expected;
            actual = target.ImportStarted;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void ImportStartedTest()
        {
            ImportStartedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for InsertedRecords
        ///</summary>
        public void InsertedRecordsTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.InsertedRecords;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void InsertedRecordsTest()
        {
            InsertedRecordsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for NumRecordsInserted
        ///</summary>
        public void NumRecordsInsertedTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumRecordsInserted;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void NumRecordsInsertedTest()
        {
            NumRecordsInsertedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for NumRecordsProcessed
        ///</summary>
        public void NumRecordsProcessedTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.NumRecordsProcessed = expected;
            actual = target.NumRecordsProcessed;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void NumRecordsProcessedTest()
        {
            NumRecordsProcessedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for NumRecordsSkipped
        ///</summary>
        public void NumRecordsSkippedTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumRecordsSkipped;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void NumRecordsSkippedTest()
        {
            NumRecordsSkippedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for NumRecordsUpdated
        ///</summary>
        public void NumRecordsUpdatedTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumRecordsUpdated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void NumRecordsUpdatedTest()
        {
            NumRecordsUpdatedTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for SkippedRecords
        ///</summary>
        public void SkippedRecordsTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            Dictionary<T, ImportRecordSkipReason> actual;
            actual = target.SkippedRecords;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void SkippedRecordsTest()
        {
            SkippedRecordsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for UpdatedRecords
        ///</summary>
        public void UpdatedRecordsTestHelper<T>()
        {
            ImportResult<T> target = CreateImportResult<T>(); // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.UpdatedRecords;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        public void UpdatedRecordsTest()
        {
            UpdatedRecordsTestHelper<GenericParameterHelper>();
        }
    }
}
