using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for StudentImportResultTest and is intended
    ///to contain all StudentImportResultTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentImportResultTest
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
        ///A test for StudentImportResult Constructor
        ///</summary>
        [TestMethod()]
        public void StudentImportResultConstructorTest()
        {
            StudentImportResult target = new StudentImportResult();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ClassTypesCreated
        ///</summary>
        [TestMethod()]
        public void ClassTypesCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            List<ClassType> actual;
            actual = target.ClassTypesCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ClassesCreated
        ///</summary>
        [TestMethod()]
        public void ClassesCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            List<Class> actual;
            actual = target.ClassesCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EnrollmentsCreated
        ///</summary>
        [TestMethod()]
        public void EnrollmentsCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            List<ClassEnrollment> actual;
            actual = target.EnrollmentsCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumClassTypesCreated
        ///</summary>
        [TestMethod()]
        public void NumClassTypesCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumClassTypesCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumClassesCreated
        ///</summary>
        [TestMethod()]
        public void NumClassesCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumClassesCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumEnrollmentsCreated
        ///</summary>
        [TestMethod()]
        public void NumEnrollmentsCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumEnrollmentsCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for NumSchoolPeriodsCreated
        ///</summary>
        [TestMethod()]
        public void NumSchoolPeriodsCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.NumSchoolPeriodsCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchoolPeriodsCreated
        ///</summary>
        [TestMethod()]
        public void SchoolPeriodsCreatedTest()
        {
            StudentImportResult target = new StudentImportResult(); // TODO: Initialize to an appropriate value
            List<SchoolPeriod> actual;
            actual = target.SchoolPeriodsCreated;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
