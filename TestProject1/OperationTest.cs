using maxLength;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestProject1
{
    
    
    /// <summary>
    ///This is a test class for OperationTest and is intended
    ///to contain all OperationTest Unit Tests
    ///</summary>
    [TestClass()]
    public class OperationTest
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
        ///A test for getLength
        ///</summary>
        [TestMethod()]
        public void getLengthTest()
        {
            string strs1 = string.Empty; 
            int expected1 = 0; 
            int actual1;
            actual1 = Operation.getLength(strs1);
            Assert.AreEqual(expected1, actual1);

            string strs2 = "abcabcbb";
            int expected2 = 3;
            int actual2;
            actual2 = Operation.getLength(strs2);
            Assert.AreEqual(expected2, actual2);

            string strs3 = "aBcAbcBb";
            int expected3 = 3;
            int actual3;
            actual3 = Operation.getLength(strs3);
            Assert.AreEqual(expected3, actual3);

            string strs4 = "a";
            int expected4 = 1;
            int actual4;
            actual4 = Operation.getLength(strs4);
            Assert.AreEqual(expected4, actual4);

            string strs5 = "abcdefghijklmnopqrstuvwxyzzyxwvutsrqponmlkjihgiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiiii";
            int expected5 = 0;
            int actual5;
            actual5 = Operation.getLength(strs5);
            Assert.AreEqual(expected5, actual5);
        }
    }
}
