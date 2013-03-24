using x_ian;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for ProgramTest and is intended
    ///to contain all ProgramTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ProgramTest
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
        ///A test for x_ian
        ///</summary>
        [TestMethod()]
        public void x_ianTest()
        {
            Program target = new Program(); // TODO: Initialize to an appropriate value
            string x = "eric"; // TODO: Initialize to an appropriate value
            string word = "algebraic"; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = "john"; // TODO: Initialize to an appropriate value
            word = "mahjong"; // TODO: Initialize to an appropriate value
            expected = false; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = "alvin"; // TODO: Initialize to an appropriate value
            word = "palavering"; // TODO: Initialize to an appropriate value
            expected = true; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = "sarina"; // TODO: Initialize to an appropriate value
            word = "czarina"; // TODO: Initialize to an appropriate value
            expected = false; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = ""; // TODO: Initialize to an appropriate value
            word = "test"; // TODO: Initialize to an appropriate value
            expected = true; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = "test"; // TODO: Initialize to an appropriate value
            word = ""; // TODO: Initialize to an appropriate value
            expected = false; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = ""; // TODO: Initialize to an appropriate value
            word = ""; // TODO: Initialize to an appropriate value
            expected = true; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = "test"; // TODO: Initialize to an appropriate value
            word = "test"; // TODO: Initialize to an appropriate value
            expected = true; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);

            x = "t"; // TODO: Initialize to an appropriate value
            word = "asdt"; // TODO: Initialize to an appropriate value
            expected = true; // TODO: Initialize to an appropriate value
            actual = target.x_ian(x, word);
            Assert.AreEqual(expected, actual);
        }
    }
}
