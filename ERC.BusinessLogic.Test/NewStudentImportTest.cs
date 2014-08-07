using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for NewStudentImportTest and is intended
    ///to contain all NewStudentImportTest Unit Tests
    ///</summary>
    [TestClass()]
    public class NewStudentImportTest
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
        ///A test for NewStudentImport Constructor
        ///</summary>
        [TestMethod()]
        public void NewStudentImportConstructorTest()
        {
            NewStudentImport target = new NewStudentImport();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportRecord
        ///</summary>
        [TestMethod()]
        public void ImportRecordTest()
        {
            NewStudentImport target = new NewStudentImport(); // TODO: Initialize to an appropriate value
            StudentImportRecord expected = null; // TODO: Initialize to an appropriate value
            StudentImportRecord actual;
            target.ImportRecord = expected;
            actual = target.ImportRecord;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Student
        ///</summary>
        [TestMethod()]
        public void StudentTest()
        {
            NewStudentImport target = new NewStudentImport(); // TODO: Initialize to an appropriate value
            Student expected = null; // TODO: Initialize to an appropriate value
            Student actual;
            target.Student = expected;
            actual = target.Student;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
