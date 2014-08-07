using ERC.BusinessLogic.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;
using System.Collections.Generic;
using System.IO;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for IReportCardParserTest and is intended
    ///to contain all IReportCardParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class IReportCardParserTest
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


        internal virtual IReportCardParser CreateIReportCardParser()
        {
            // TODO: Instantiate an appropriate concrete class.
            IReportCardParser target = null;
            return target;
        }

        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            IReportCardParser target = CreateIReportCardParser(); // TODO: Initialize to an appropriate value
            ClassEnrollment enrollment = null; // TODO: Initialize to an appropriate value
            IEnumerable<StudentGrade> grades = null; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = target.Process(enrollment, grades);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest1()
        {
            IReportCardParser target = CreateIReportCardParser(); // TODO: Initialize to an appropriate value
            IEnumerable<ClassEnrollment> enrollments = null; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = target.Process(enrollments);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            IReportCardParser target = CreateIReportCardParser(); // TODO: Initialize to an appropriate value
            SchoolPeriod schoolPeriod = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingTerm> gradingTerms = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> gradingStandards = null; // TODO: Initialize to an appropriate value
            byte[] templateData = null; // TODO: Initialize to an appropriate value
            target.Initialize(schoolPeriod, gradingTerms, gradingStandards, templateData);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
