using ERC.BusinessLogic.Export;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using ERC.DataModel;
using ERC.DataAccess;
using System.IO;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ReportCardExporterTest and is intended
    ///to contain all ReportCardExporterTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ReportCardExporterTest
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
        ///A test for GetParser
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void GetParserTest()
        {
            ReportCardTemplateFileType fileType = new ReportCardTemplateFileType(); // TODO: Initialize to an appropriate value
            IReportCardParser expected = null; // TODO: Initialize to an appropriate value
            IReportCardParser actual;
            actual = ReportCardExporter_Accessor.GetParser(fileType);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetReportCard
        ///</summary>
        [TestMethod()]
        public void GetReportCardTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            int studentID = 0; // TODO: Initialize to an appropriate value
            int schoolPeriodID = 0; // TODO: Initialize to an appropriate value
            int templateID = 0; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = ReportCardExporter.GetReportCard(repo, studentID, schoolPeriodID, templateID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetReportCards
        ///</summary>
        [TestMethod()]
        public void GetReportCardsTest()
        {
            IDataRepo repo = null; // TODO: Initialize to an appropriate value
            List<int> studentIds = null; // TODO: Initialize to an appropriate value
            int schoolPeriodID = 0; // TODO: Initialize to an appropriate value
            int templateID = 0; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = ReportCardExporter.GetReportCards(repo, studentIds, schoolPeriodID, templateID);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProcessReportCard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ProcessReportCardTest()
        {
            SchoolPeriod schoolPeriod = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> gradingStandards = null; // TODO: Initialize to an appropriate value
            ReportCardTemplate template = null; // TODO: Initialize to an appropriate value
            IEnumerable<ClassEnrollment> enrollments = null; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = ReportCardExporter_Accessor.ProcessReportCard(schoolPeriod, gradingStandards, template, enrollments);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ProcessReportCard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ProcessReportCardTest1()
        {
            SchoolPeriod schoolPeriod = null; // TODO: Initialize to an appropriate value
            IEnumerable<GradingStandard> gradingStandards = null; // TODO: Initialize to an appropriate value
            ReportCardTemplate template = null; // TODO: Initialize to an appropriate value
            ClassEnrollment enrollment = null; // TODO: Initialize to an appropriate value
            MemoryStream expected = null; // TODO: Initialize to an appropriate value
            MemoryStream actual;
            actual = ReportCardExporter_Accessor.ProcessReportCard(schoolPeriod, gradingStandards, template, enrollment);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
