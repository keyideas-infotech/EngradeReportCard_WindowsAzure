using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataAccess;
using ERC.DataModel;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for StudentImporter2Test and is intended
    ///to contain all StudentImporter2Test Unit Tests
    ///</summary>
    [TestClass()]
    public class StudentImporter2Test
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
        ///A test for StudentImporter2 Constructor
        ///</summary>
        [TestMethod()]
        public void StudentImporter2ConstructorTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            StudentImporter2 target = new StudentImporter2(repo);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for FindOrCreateClass
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void FindOrCreateClassTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            StudentImporter2_Accessor target = new StudentImporter2_Accessor(param0); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            School school = null; // TODO: Initialize to an appropriate value
            int schoolPeriodID = 0; // TODO: Initialize to an appropriate value
            Teacher teacher = null; // TODO: Initialize to an appropriate value
            NewStudentImport newStudentImport = null; // TODO: Initialize to an appropriate value
            Class expected = null; // TODO: Initialize to an appropriate value
            Class actual;
            actual = target.FindOrCreateClass(districtID, school, schoolPeriodID, teacher, newStudentImport);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImportStudents
        ///</summary>
        [TestMethod()]
        public void ImportStudentsTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            StudentImporter2 target = new StudentImporter2(repo); // TODO: Initialize to an appropriate value
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

        /// <summary>
        ///A test for ImportStudents
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ImportStudentsTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            StudentImporter2_Accessor target = new StudentImporter2_Accessor(param0); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            int reportingPeriodID = 0; // TODO: Initialize to an appropriate value
            IEnumerable<StudentImportRecord> importRecords = null; // TODO: Initialize to an appropriate value
            target.ImportStudents(districtID, reportingPeriodID, importRecords);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MatchClasses
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void MatchClassesTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            StudentImporter2_Accessor target = new StudentImporter2_Accessor(param0); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            int schoolPeriodID = 0; // TODO: Initialize to an appropriate value
            IEnumerable<NewStudentImport> newStudentImports = null; // TODO: Initialize to an appropriate value
            target.MatchClasses(districtID, schoolPeriodID, newStudentImports);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MatchSchools
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void MatchSchoolsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            StudentImporter2_Accessor target = new StudentImporter2_Accessor(param0); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            IEnumerable<NewStudentImport> newStudentImports = null; // TODO: Initialize to an appropriate value
            target.MatchSchools(districtID, newStudentImports);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for MatchSchools
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void MatchSchoolsTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            StudentImporter2_Accessor target = new StudentImporter2_Accessor(param0); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            IEnumerable<ExistingStudentImport> existingStudentImports = null; // TODO: Initialize to an appropriate value
            target.MatchSchools(districtID, existingStudentImports);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for TransferStudentSchool
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void TransferStudentSchoolTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            StudentImporter2_Accessor target = new StudentImporter2_Accessor(param0); // TODO: Initialize to an appropriate value
            Student student = null; // TODO: Initialize to an appropriate value
            School fromSchool = null; // TODO: Initialize to an appropriate value
            School toSchool = null; // TODO: Initialize to an appropriate value
            target.TransferStudentSchool(student, fromSchool, toSchool);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
