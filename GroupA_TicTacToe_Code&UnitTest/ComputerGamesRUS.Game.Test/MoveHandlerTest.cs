using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace ComputerGamesRUS.Game.Test
{
    
    
    /// <summary>
    ///This is a test class for MoveHandlerTest and is intended
    ///to contain all MoveHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MoveHandlerTest
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


        internal virtual MoveHandler CreateMoveHandler()
        {
            // TODO: Instantiate an appropriate concrete class.
            MoveHandler target = null;
            return target;
        }

        /// <summary>
        ///A test for CheckResult
        ///</summary>
        [TestMethod()]
        public void CheckResultTest()
        {
            MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CheckResult(location, color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        internal virtual MoveHandler_Accessor CreateMoveHandler_Accessor()
        {
            // TODO: Instantiate an appropriate concrete class.
            MoveHandler_Accessor target = null;
            return target;
        }

        /// <summary>
        ///A test for CountCoins
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CountCoinsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            MoveHandler_Accessor target = new MoveHandler_Accessor(param0); // TODO: Initialize to an appropriate value
            Point startPos = new Point(); // TODO: Initialize to an appropriate value
            int xIncrement = 0; // TODO: Initialize to an appropriate value
            int yIncrement = 0; // TODO: Initialize to an appropriate value
            Symbol coin = new Symbol(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CountCoins(startPos, xIncrement, yIncrement, coin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CountScore
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CountScoreTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            MoveHandler_Accessor target = new MoveHandler_Accessor(param0); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol coin = new Symbol(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CountScore(location, coin);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetOpponentColor
        ///</summary>
        [TestMethod()]
        public void GetOpponentColorTest()
        {
            MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
            Symbol myColor = new Symbol(); // TODO: Initialize to an appropriate value
            Symbol expected = new Symbol(); // TODO: Initialize to an appropriate value
            Symbol actual;
            actual = target.GetUserSymbol(myColor);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for HaveVictoryAt
        ///</summary>
        //[TestMethod()]
        //public void HaveVictoryAtTest()
        //{
        //    MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
        //    int x = 0; // TODO: Initialize to an appropriate value
        //    int y = 0; // TODO: Initialize to an appropriate value
        //    Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
        //    bool expected = false; // TODO: Initialize to an appropriate value
        //    bool actual;
        //    actual = target.HaveVictoryAt(x, y, color);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        /// <summary>
        ///A test for HaveVictoryAt
        ///</summary>
        //[TestMethod()]
        //public void HaveVictoryAtTest()
        //{
        //    MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
        //    Point location = new Point(); // TODO: Initialize to an appropriate value
        //    Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
        //    bool expected = false; // TODO: Initialize to an appropriate value
        //    bool actual;
        //    actual = target.HaveVictoryAt(location, color);
        //    Assert.AreEqual(expected, actual);
        //    Assert.Inconclusive("Verify the correctness of this test method.");
        //}

        /// <summary>
        ///A test for SelectBestMove
        ///</summary>
        [TestMethod()]
        public void SelectBestMoveTest()
        {
            MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
            Symbol color = new Symbol(); // TODO: Initialize to an appropriate value
            Point expected = new Point(); // TODO: Initialize to an appropriate value
            Point actual;
            actual = target.SelectBestMove(color);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Board
        ///</summary>
        [TestMethod()]
        public void BoardTest()
        {
            MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
            Board actual;
            actual = target.Board;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GameSize
        ///</summary>
        [TestMethod()]
        public void GameSizeTest()
        {
            MoveHandler target = CreateMoveHandler(); // TODO: Initialize to an appropriate value
            int actual;
            actual = target.GameSize;
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
