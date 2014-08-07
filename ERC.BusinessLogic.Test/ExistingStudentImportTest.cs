using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ExistingStudentImportTest and is intended
    ///to contain all ExistingStudentImportTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ExistingStudentImportTest
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
        ///A test for ExistingStudentImport Constructor
        ///</summary>
        [TestMethod()]
        public void ExistingStudentImportConstructorTest()
        {
            ExistingStudentImport target = new ExistingStudentImport();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ExistingStudent
        ///</summary>
        [TestMethod()]
        public void ExistingStudentTest()
        {
            ExistingStudentImport target = new ExistingStudentImport(); // TODO: Initialize to an appropriate value
            Student expected = null; // TODO: Initialize to an appropriate value
            Student actual;
            target.ExistingStudent = expected;
            actual = target.ExistingStudent;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImportRecord
        ///</summary>
        [TestMethod()]
        public void ImportRecordTest()
        {
            ExistingStudentImport target = new ExistingStudentImport(); // TODO: Initialize to an appropriate value
            StudentImportRecord expected = null; // TODO: Initialize to an appropriate value
            StudentImportRecord actual;
            target.ImportRecord = expected;
            actual = target.ImportRecord;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
