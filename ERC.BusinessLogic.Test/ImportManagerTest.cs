using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using System.Collections.Generic;
using LumenWorks.Framework.IO.Csv;
using System.Reflection;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ImportManagerTest and is intended
    ///to contain all ImportManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImportManagerTest
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
        ///A test for ImportManager Constructor
        ///</summary>
        [TestMethod()]
        public void ImportManagerConstructorTest()
        {
            ITeacherImporter teacherImporter = null; // TODO: Initialize to an appropriate value
            ISchoolImporter schoolImporter = null; // TODO: Initialize to an appropriate value
            IStudentImporter studentImporter = null; // TODO: Initialize to an appropriate value
            ImportManager target = new ImportManager(teacherImporter, schoolImporter, studentImporter);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for GetCsvRecords
        ///</summary>
        public void GetCsvRecordsTestHelper<T>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ImportManager_Accessor target = new ImportManager_Accessor(param0); // TODO: Initialize to an appropriate value
            Stream stream = null; // TODO: Initialize to an appropriate value
            bool errorOnDuplicatIds = false; // TODO: Initialize to an appropriate value
            List<T> expected = null; // TODO: Initialize to an appropriate value
            List<T> actual;
            actual = target.GetCsvRecords<T>(stream, errorOnDuplicatIds);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void GetCsvRecordsTest()
        {
            GetCsvRecordsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetMissingRequiredFields
        ///</summary>
        public void GetMissingRequiredFieldsTestHelper<T>()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ImportManager_Accessor target = new ImportManager_Accessor(param0); // TODO: Initialize to an appropriate value
            CsvReader csvReader = null; // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            actual = target.GetMissingRequiredFields<T>(csvReader);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void GetMissingRequiredFieldsTest()
        {
            GetMissingRequiredFieldsTestHelper<GenericParameterHelper>();
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void GetValueTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ImportManager_Accessor target = new ImportManager_Accessor(param0); // TODO: Initialize to an appropriate value
            PropertyInfo prop = null; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetValue(prop, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void GetValueTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ImportManager_Accessor target = new ImportManager_Accessor(param0); // TODO: Initialize to an appropriate value
            Type valueType = null; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetValue(valueType, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void GetValueTest2()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ImportManager_Accessor target = new ImportManager_Accessor(param0); // TODO: Initialize to an appropriate value
            FieldInfo field = null; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.GetValue(field, value);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImportSchools
        ///</summary>
        [TestMethod()]
        public void ImportSchoolsTest()
        {
            ITeacherImporter teacherImporter = null; // TODO: Initialize to an appropriate value
            ISchoolImporter schoolImporter = null; // TODO: Initialize to an appropriate value
            IStudentImporter studentImporter = null; // TODO: Initialize to an appropriate value
            ImportManager target = new ImportManager(teacherImporter, schoolImporter, studentImporter); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            Stream stream = null; // TODO: Initialize to an appropriate value
            SchoolImportResult expected = null; // TODO: Initialize to an appropriate value
            SchoolImportResult actual;
            actual = target.ImportSchools(districtID, stream);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImportStudents
        ///</summary>
        [TestMethod()]
        public void ImportStudentsTest()
        {
            ITeacherImporter teacherImporter = null; // TODO: Initialize to an appropriate value
            ISchoolImporter schoolImporter = null; // TODO: Initialize to an appropriate value
            IStudentImporter studentImporter = null; // TODO: Initialize to an appropriate value
            ImportManager target = new ImportManager(teacherImporter, schoolImporter, studentImporter); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            int reportingPeriodID = 0; // TODO: Initialize to an appropriate value
            Stream stream = null; // TODO: Initialize to an appropriate value
            StudentImportResult expected = null; // TODO: Initialize to an appropriate value
            StudentImportResult actual;
            actual = target.ImportStudents(districtID, reportingPeriodID, stream);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ImportTeachers
        ///</summary>
        [TestMethod()]
        public void ImportTeachersTest()
        {
            ITeacherImporter teacherImporter = null; // TODO: Initialize to an appropriate value
            ISchoolImporter schoolImporter = null; // TODO: Initialize to an appropriate value
            IStudentImporter studentImporter = null; // TODO: Initialize to an appropriate value
            ImportManager target = new ImportManager(teacherImporter, schoolImporter, studentImporter); // TODO: Initialize to an appropriate value
            int districtID = 0; // TODO: Initialize to an appropriate value
            Stream stream = null; // TODO: Initialize to an appropriate value
            TeacherImportResult expected = null; // TODO: Initialize to an appropriate value
            TeacherImportResult actual;
            actual = target.ImportTeachers(districtID, stream);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
