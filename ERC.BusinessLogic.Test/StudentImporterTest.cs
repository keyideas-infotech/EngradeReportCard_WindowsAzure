using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataAccess;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for StudentImporterTest and is intended
    ///to contain all StudentImporterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentImporterTest
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
        ///A test for StudentImporter Constructor
        ///</summary>
        [TestMethod()]
        public void StudentImporterConstructorTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            StudentImporter target = new StudentImporter(repo);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportStudents
        ///</summary>
        [TestMethod()]
        public void ImportStudentsTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            StudentImporter target = new StudentImporter(repo); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            int reportingPeriodID = 0; // TODO: Initialize to an appropriate value
            IEnumerable<StudentImportRecord> importRecords = null; // TODO: Initialize to an appropriate value
            StudentImportOptions[] importOptions = null; // TODO: Initialize to an appropriate value
            StudentImportResult expected = null; // TODO: Initialize to an appropriate value
            StudentImportResult actual;
            actual = target.ImportStudents(districtID, reportingPeriodID, importRecords, importOptions);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
