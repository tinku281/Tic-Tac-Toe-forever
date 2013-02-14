using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace ComputerGamesRUS.Game.Test
{
    
    
    /// <summary>
    ///This is a test class for ComputerMoveHandlerTest and is intended
    ///to contain all ComputerMoveHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ComputerMoveHandlerTest
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
        ///A test for ComputerMoveHandler Constructor
        ///</summary>
        [TestMethod()]
        public void ComputerMoveHandlerConstructorTest()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for EstimateForStageOne
        ///</summary>
        [TestMethod()]
        public void EstimateForStageOneTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            int x =0; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Oval;// TODO: Initialize to an appropriate value
            IComparable expected = 1; // TODO: Initialize to an appropriate value
            IComparable actual;
            actual = target.EstimateForStageOne(x, y, coin);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EstimateForStageOne
        ///</summary>
        [TestMethod()]
        public void EstimateForStageOneTest1()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            IComparable expected = null; // TODO: Initialize to an appropriate value
            IComparable actual;
            actual = target.EstimateForStageOne(location, color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EstimateForStageThree
        ///</summary>
        [TestMethod()]
        public void EstimateForStageThreeTest()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            int x = 0; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            IComparable expected = null; // TODO: Initialize to an appropriate value
            IComparable actual;
            actual = target.EstimateForStageThree(x, y, color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EstimateForStageThree
        ///</summary>
        [TestMethod()]
        public void EstimateForStageThreeTest1()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            IComparable expected = null; // TODO: Initialize to an appropriate value
            IComparable actual;
            actual = target.EstimateForStageThree(location, color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EstimateForStageTwo
        ///</summary>
        [TestMethod()]
        public void EstimateForStageTwoTest()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            IComparable expected = null; // TODO: Initialize to an appropriate value
            IComparable actual;
            actual = target.EstimateForStageTwo(location, color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for EstimateForStageTwo
        ///</summary>
        [TestMethod()]
        public void EstimateForStageTwoTest1()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            int x = 0; // TODO: Initialize to an appropriate value
            int y = 0; // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            IComparable expected = null; // TODO: Initialize to an appropriate value
            IComparable actual;
            actual = target.EstimateForStageTwo(x, y, color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for MakeMove
        ///</summary>
        [TestMethod()]
        public void MakeMoveTest()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            target.MakeMove(location, color);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for SelectBestMove
        ///</summary>
        [TestMethod()]
        public void SelectBestMoveTest()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.SelectBestMove(color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SelectBestMove
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void SelectBestMoveTest1()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ComputerMoveHandler_Accessor target = new ComputerMoveHandler_Accessor(param0); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.SelectBestMove();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StepOne
        ///</summary>
        [TestMethod()]
        public void StepOneTest()
        {
            Board board = null; // TODO: Initialize to an appropriate value
            int gameSize = 0; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            List<Point> expected = null; // TODO: Initialize to an appropriate value
            List<Point> actual;
            actual = target.StepOne(color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StepThree
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void StepThreeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ComputerMoveHandler_Accessor target = new ComputerMoveHandler_Accessor(param0); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            List<Point> expected = null; // TODO: Initialize to an appropriate value
            List<Point> actual;
            actual = target.StepThree(color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for StepTwo
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void StepTwoTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            ComputerMoveHandler_Accessor target = new ComputerMoveHandler_Accessor(param0); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            List<Point> expected = null; // TODO: Initialize to an appropriate value
            List<Point> actual;
            actual = target.StepTwo(color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
