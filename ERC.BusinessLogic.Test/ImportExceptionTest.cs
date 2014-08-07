﻿using ERC.BusinessLogic.Import;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Runtime.Serialization;

namespace ERC.BusinessLogic.Test
{
    
    
    /// <summary>
    ///This is a test class for ImportExceptionTest and is intended
    ///to contain all ImportExceptionTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ImportExceptionTest
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
        ///A test for ImportException Constructor
        ///</summary>
        [TestMethod()]
        public void ImportExceptionConstructorTest()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            Exception inner = null; // TODO: Initialize to an appropriate value
            ImportException target = new ImportException(message, inner);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportException Constructor
        ///</summary>
        [TestMethod()]
        [DeploymentItem("ERC.BusinessLogic.dll")]
        public void ImportExceptionConstructorTest1()
        {
            SerializationInfo info = null; // TODO: Initialize to an appropriate value
            StreamingContext context = new StreamingContext(); // TODO: Initialize to an appropriate value
            ImportException_Accessor target = new ImportException_Accessor(info, context);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportException Constructor
        ///</summary>
        [TestMethod()]
        public void ImportExceptionConstructorTest2()
        {
            ImportException target = new ImportException();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for ImportException Constructor
        ///</summary>
        [TestMethod()]
        public void ImportExceptionConstructorTest3()
        {
            string message = string.Empty; // TODO: Initialize to an appropriate value
            ImportException target = new ImportException(message);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }
    }
}
