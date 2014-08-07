using ERC.BusinessLogic.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;
using System.Collections.Generic;
using System.IO;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for PdfReportCardParserTest and is intended
    ///to contain all PdfReportCardParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PdfReportCardParserTest
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
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            PdfReportCardParser target = new PdfReportCardParser(); // TODO: Initialize to an appropriate value
            IEnumerable<ClassEnrollment> enrollments = null; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = target.Process(enrollments);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest1()
        {
            PdfReportCardParser target = new PdfReportCardParser(); // TODO: Initialize to an appropriate value
            ClassEnrollment enrollment = null; // TODO: Initialize to an appropriate value
            IEnumerable<StudentGrade> grades = null; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = target.Process(enrollment, grades);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Period
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void PeriodTest()
        {
            PdfReportCardParser_Accessor target = new PdfReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            SchoolPeriod expected = null; // TODO: Initialize to an appropriate value
            SchoolPeriod actual;
            target.Period = expected;
            actual = target.Period;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Standards
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void StandardsTest()
        {
            PdfReportCardParser_Accessor target = new PdfReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            List<GradingStandard> expected = null; // TODO: Initialize to an appropriate value
            List<GradingStandard> actual;
            target.Standards = expected;
            actual = target.Standards;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Template
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void TemplateTest()
        {
            PdfReportCardParser_Accessor target = new PdfReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            byte[] expected = null; // TODO: Initialize to an appropriate value
            byte[] actual;
            target.Template = expected;
            actual = target.Template;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Terms
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void TermsTest()
        {
            PdfReportCardParser_Accessor target = new PdfReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            List<GradingTerm> expected = null; // TODO: Initialize to an appropriate value
            List<GradingTerm> actual;
            target.Terms = expected;
            actual = target.Terms;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Initialize
        ///</summary>
        [TestMethod()]
        public void InitializeTest()
        {
            PdfReportCardParser target = new PdfReportCardParser(); // TODO: Initialize to an appropriate value
            SchoolPeriod schoolPeriod = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingTerm> gradingTerms = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> gradingStandards = null; // TODO: Initialize to an appropriate value
            byte[] templateData = null; // TODO: Initialize to an appropriate value
            target.Initialize(schoolPeriod, gradingTerms, gradingStandards, templateData);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PdfReportCardParser Constructor
        ///</summary>
        [TestMethod()]
        public void PdfReportCardParserConstructorTest()
        {
            PdfReportCardParser target = new PdfReportCardParser();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
