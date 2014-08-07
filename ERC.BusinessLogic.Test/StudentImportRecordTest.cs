using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for StudentImportRecordTest and is intended
    ///to contain all StudentImportRecordTest Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentImportRecordTest
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
        ///A test for StudentImportRecord Constructor
        ///</summary>
        [TestMethod()]
        public void StudentImportRecordConstructorTest()
        {
            StudentImportRecord target = new StudentImportRecord();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            object obj = null; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.Equals(obj);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetHashCode
        ///</summary>
        [TestMethod()]
        public void GetHashCodeTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FirstName = expected;
            actual = target.FirstName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GradeLevel
        ///</summary>
        [TestMethod()]
        public void GradeLevelTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.GradeLevel = expected;
            actual = target.GradeLevel;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IDNumber
        ///</summary>
        [TestMethod()]
        public void IDNumberTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.IDNumber = expected;
            actual = target.IDNumber;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for LastName
        ///</summary>
        [TestMethod()]
        public void LastNameTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LastName = expected;
            actual = target.LastName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MiddleName
        ///</summary>
        [TestMethod()]
        public void MiddleNameTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.MiddleName = expected;
            actual = target.MiddleName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchoolID
        ///</summary>
        [TestMethod()]
        public void SchoolIDTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SchoolID = expected;
            actual = target.SchoolID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StudentID
        ///</summary>
        [TestMethod()]
        public void StudentIDTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.StudentID = expected;
            actual = target.StudentID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeacherID
        ///</summary>
        [TestMethod()]
        public void TeacherIDTest()
        {
            StudentImportRecord target = new StudentImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TeacherID = expected;
            actual = target.TeacherID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
