using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataAccess;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for SchoolImporterTest and is intended
    ///to contain all SchoolImporterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class SchoolImporterTest
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
        ///A test for SchoolImporter Constructor
        ///</summary>
        [TestMethod()]
        public void SchoolImporterConstructorTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            SchoolImporter target = new SchoolImporter(repo);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportSchools
        ///</summary>
        [TestMethod()]
        public void ImportSchoolsTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            SchoolImporter target = new SchoolImporter(repo); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            IEnumerable<SchoolImportRecord> importRecords = null; // TODO: Initialize to an appropriate value
            SchoolImportResult expected = null; // TODO: Initialize to an appropriate value
            SchoolImportResult actual;
            actual = target.ImportSchools(districtID, importRecords);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
