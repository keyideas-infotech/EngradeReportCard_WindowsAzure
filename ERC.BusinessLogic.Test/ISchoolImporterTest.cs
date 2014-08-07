using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ISchoolImporterTest and is intended
    ///to contain all ISchoolImporterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ISchoolImporterTest
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


        internal virtual ISchoolImporter CreateISchoolImporter()
        {
            // TODO: Instantiate an appropriate concrete class.
            ISchoolImporter target = null;
            return target;
        }

        /// <summary>
        ///A test for ImportSchools
        ///</summary>
        [TestMethod()]
        public void ImportSchoolsTest()
        {
            ISchoolImporter target = CreateISchoolImporter(); // TODO: Initialize to an appropriate value
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
