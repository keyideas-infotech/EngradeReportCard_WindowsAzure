using ERC.BusinessLogic.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for DocxReportCardParserTest and is intended
    ///to contain all DocxReportCardParserTest Unit Tests
    ///</summary>
    [TestClass()]
    public class DocxReportCardParserTest
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
        ///A test for Terms
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void TermsTest()
        {
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            IEnumerable<GradingTerm> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingTerm> actual;
            target.Terms = expected;
            actual = target.Terms;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for TemplateStream
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void TemplateStreamTest()
        {
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            target.TemplateStream = expected;
            actual = target.TemplateStream;
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
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> actual;
            target.Standards = expected;
            actual = target.Standards;
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
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            SchoolPeriod expected = null; // TODO: Initialize to an appropriate value
            SchoolPeriod actual;
            target.Period = expected;
            actual = target.Period;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReplacePlaceholder
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ReplacePlaceholderTest()
        {
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            int start = 0; // TODO: Initialize to an appropriate value
            int length = 0; // TODO: Initialize to an appropriate value
            string replacement = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReplacePlaceholder(text, start, length, replacement);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ReplacePlaceholder
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ReplacePlaceholderTest1()
        {
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Match match = null; // TODO: Initialize to an appropriate value
            string replacement = string.Empty; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ReplacePlaceholder(text, match, replacement);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for RemovePlaceholder
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void RemovePlaceholderTest()
        {
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            string text = string.Empty; // TODO: Initialize to an appropriate value
            Match match = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.RemovePlaceholder(text, match);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProcessText
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ProcessTextTest()
        {
            DocxReportCardParser_Accessor target = new DocxReportCardParser_Accessor(); // TODO: Initialize to an appropriate value
            string input = string.Empty; // TODO: Initialize to an appropriate value
            ClassEnrollment enrollment = null; // TODO: Initialize to an appropriate value
            IEnumerable<StudentGrade> grades = null; // TODO: Initialize to an appropriate value
            string expected = string.Empty; // TODO: Initialize to an appropriate value
            string actual;
            actual = target.ProcessText(input, enrollment, grades);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Process
        ///</summary>
        [TestMethod()]
        public void ProcessTest()
        {
            DocxReportCardParser target = new DocxReportCardParser(); // TODO: Initialize to an appropriate value
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
            DocxReportCardParser target = new DocxReportCardParser(); // TODO: Initialize to an appropriate value
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
            DocxReportCardParser target = new DocxReportCardParser(); // TODO: Initialize to an appropriate value
            SchoolPeriod schoolPeriod = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingTerm> gradingTerms = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> gradingStandards = null; // TODO: Initialize to an appropriate value
            byte[] templateData = null; // TODO: Initialize to an appropriate value
            target.Initialize(schoolPeriod, gradingTerms, gradingStandards, templateData);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DocxReportCardParser Constructor
        ///</summary>
        [TestMethod()]
        public void DocxReportCardParserConstructorTest()
        {
            DocxReportCardParser target = new DocxReportCardParser();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
