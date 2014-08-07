using ERC.BusinessLogic.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using ERC.DataModel;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for CommonPlaceholderHelperTest and is intended
    ///to contain all CommonPlaceholderHelperTest Unit Tests
    ///</summary>
    [TestClass()]
    public class CommonPlaceholderHelperTest
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
        ///A test for Values
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ValuesTest()
        {
            CommonPlaceholderHelper_Accessor target = new CommonPlaceholderHelper_Accessor(); // TODO: Initialize to an appropriate value
            Dictionary<string, string> actual;
            actual = target.Values;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SetValues
        ///</summary>
        [TestMethod()]
        public void SetValuesTest()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper(); // TODO: Initialize to an appropriate value
            SchoolPeriod schoolPeriod = null; // TODO: Initialize to an appropriate value
            ReportingPeriod reportingPeriod = null; // TODO: Initialize to an appropriate value
            School school = null; // TODO: Initialize to an appropriate value
            SchoolDistrict district = null; // TODO: Initialize to an appropriate value
            target.SetValues(schoolPeriod, reportingPeriod, school, district);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetValues
        ///</summary>
        [TestMethod()]
        public void SetValuesTest1()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper(); // TODO: Initialize to an appropriate value
            Student student = null; // TODO: Initialize to an appropriate value
            Teacher teacher = null; // TODO: Initialize to an appropriate value
            target.SetValues(student, teacher);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetValue
        ///</summary>
        [TestMethod()]
        public void SetValueTest()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper(); // TODO: Initialize to an appropriate value
            CommonPlacholder placeholder = new CommonPlacholder(); // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            target.SetValue(placeholder, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SetValue
        ///</summary>
        [TestMethod()]
        public void SetValueTest1()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper(); // TODO: Initialize to an appropriate value
            string placeholder = string.Empty; // TODO: Initialize to an appropriate value
            string value = string.Empty; // TODO: Initialize to an appropriate value
            target.SetValue(placeholder, value);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        public void GetValueTest()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper(); // TODO: Initialize to an appropriate value
            string placeholder = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetValue(placeholder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetValue
        ///</summary>
        [TestMethod()]
        public void GetValueTest1()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper(); // TODO: Initialize to an appropriate value
            CommonPlacholder placholder = new CommonPlacholder(); // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.GetValue(placholder);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetPlaceholderList
        ///</summary>
        [TestMethod()]
        public void GetPlaceholderListTest()
        {
            Dictionary<string, string> expected = null; // TODO: Initialize to an appropriate value
            Dictionary<string, string> actual;
            actual = CommonPlaceholderHelper.GetPlaceholderList();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CommonPlaceholderHelper Constructor
        ///</summary>
        [TestMethod()]
        public void CommonPlaceholderHelperConstructorTest()
        {
            CommonPlaceholderHelper target = new CommonPlaceholderHelper();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
