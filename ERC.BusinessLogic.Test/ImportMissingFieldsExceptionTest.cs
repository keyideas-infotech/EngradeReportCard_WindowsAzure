using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;
using System.Collections.Generic;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ImportMissingFieldsExceptionTest and is intended
    ///to contain all ImportMissingFieldsExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImportMissingFieldsExceptionTest
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
        ///A test for ImportMissingFieldsException Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ImportMissingFieldsExceptionConstructorTest()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            ImportMissingFieldsException_Accessor target = new ImportMissingFieldsException_Accessor(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportMissingFieldsException Constructor
        ///</summary>
        [TestMethod()]
        public void ImportMissingFieldsExceptionConstructorTest1()
        {
            List<string> missingFields = null; // TODO: Initialize to an appropriate value
            string message = string.Empty; // TODO: Initialize to an appropriate value
            ImportMissingFieldsException target = new ImportMissingFieldsException(missingFields, message);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportMissingFieldsException Constructor
        ///</summary>
        [TestMethod()]
        public void ImportMissingFieldsExceptionConstructorTest2()
        {
            List<string> missingFields = null; // TODO: Initialize to an appropriate value
            ImportMissingFieldsException target = new ImportMissingFieldsException(missingFields);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for MissingFields
        ///</summary>
        [TestMethod()]
        public void MissingFieldsTest()
        {
            List<string> missingFields = null; // TODO: Initialize to an appropriate value
            ImportMissingFieldsException target = new ImportMissingFieldsException(missingFields); // TODO: Initialize to an appropriate value
            List<string> expected = null; // TODO: Initialize to an appropriate value
            List<string> actual;
            target.MissingFields = expected;
            actual = target.MissingFields;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
