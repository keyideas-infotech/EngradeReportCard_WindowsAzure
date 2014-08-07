using ERC.BusinessLogic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for PdfCreatorTest and is intended
    ///to contain all PdfCreatorTest Unit Tests
    ///</summary>
    [TestClass()]
    public class PdfCreatorTest
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
        ///A test for CreateFromURL
        ///</summary>
        [TestMethod()]
        public void CreateFromURLTest()
        {
            string url = string.Empty; // TODO: Initialize to an appropriate value
            string outputFilePath = string.Empty; // TODO: Initialize to an appropriate value
            bool hideBackground = false; // TODO: Initialize to an appropriate value
            int margin = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = PdfCreator.CreateFromURL(url, outputFilePath, hideBackground, margin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PdfCreator Constructor
        ///</summary>
        [TestMethod()]
        public void PdfCreatorConstructorTest()
        {
            PdfCreator target = new PdfCreator();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
