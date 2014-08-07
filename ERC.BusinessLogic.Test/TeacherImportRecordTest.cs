using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for TeacherImportRecordTest and is intended
    ///to contain all TeacherImportRecordTest Unit Tests
    ///</summary>
    [TestClass()]
    public class TeacherImportRecordTest
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
        ///A test for TeacherImportRecord Constructor
        ///</summary>
        [TestMethod()]
        public void TeacherImportRecordConstructorTest()
        {
            TeacherImportRecord target = new TeacherImportRecord();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Equals
        ///</summary>
        [TestMethod()]
        public void EqualsTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
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
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GetHashCode();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Email
        ///</summary>
        [TestMethod()]
        public void EmailTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Email = expected;
            actual = target.Email;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for FirstName
        ///</summary>
        [TestMethod()]
        public void FirstNameTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.FirstName = expected;
            actual = target.FirstName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IDNumber
        ///</summary>
        [TestMethod()]
        public void IDNumberTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
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
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.LastName = expected;
            actual = target.LastName;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Phone
        ///</summary>
        [TestMethod()]
        public void PhoneTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.Phone = expected;
            actual = target.Phone;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SchoolID
        ///</summary>
        [TestMethod()]
        public void SchoolIDTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.SchoolID = expected;
            actual = target.SchoolID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TeacherID
        ///</summary>
        [TestMethod()]
        public void TeacherIDTest()
        {
            TeacherImportRecord target = new TeacherImportRecord(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            target.TeacherID = expected;
            actual = target.TeacherID;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
