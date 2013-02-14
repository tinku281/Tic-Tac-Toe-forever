using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace ComputerGamesRUS.Game.Test
{
    
    
    /// <summary>
    ///This is a test class for BoardTest and is intended
    ///to contain all BoardTest Unit Tests
    ///</summary>
    [TestClass()]
    public class BoardTest
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
        ///A test for Board Constructor
        ///</summary>
        [TestMethod()]
        public void BoardConstructorTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        [TestMethod()]
        public void ClearTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateCellRect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CreateCellRectTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Rectangle expected = new Rectangle(); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.CreateCellRect(location);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateMemento
        ///</summary>
        [TestMethod()]
        public void CreateMementoTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            object expected = null; // TODO: Initialize to an appropriate value
            object actual;
            actual = target.CreateMemento();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreatePoint
        ///</summary>
        [TestMethod()]
        public void CreatePointTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            IEnumerable<Point> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Point> actual;
            actual = target.CreatePoint();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreateStoneRect
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CreateStoneRectTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Rectangle expected = new Rectangle(); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.CreateStoneRect(location);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DrawBoard
        ///</summary>
        [TestMethod()]
        public void DrawBoardTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            Graphics g = null; // TODO: Initialize to an appropriate value
            target.DrawBoard(g);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for DrawCell
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void DrawCellTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Graphics g = null; // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            target.DrawCell(g, location);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetSymbol
        ///</summary>
        [TestMethod()]
        public void GetSymbolTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Symbol expected = new Symbol(); // TODO: Initialize to an appropriate value
            Symbol actual;
            actual = target.GetSymbol(location);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOutofBounds
        ///</summary>
        [TestMethod()]
        public void IsOutofBoundsTest()
        {
            int size = 25; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            int locX = 24; // TODO: Initialize to an appropriate value
            int locY = 22; // TODO: Initialize to an appropriate value
            bool expected = true; ; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOutofBounds(locX, locY);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for PaintSymbolO
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void PaintSymbolOTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Graphics g = null; // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            target.PaintSymbolO(g, location);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PaintSymbolX
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void PaintSymbolXTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Graphics g = null; // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            target.PaintSymbolX(g, location);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PutSymbol
        ///</summary>
        [TestMethod()]
        public void PutSymbolTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            Symbol Coin = new Symbol(); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            target.PutSymbol(Coin, location);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for createInstance
        ///</summary>
        [TestMethod()]
        public void createInstanceTest()
        {
            Board expected = null; // TODO: Initialize to an appropriate value
            Board actual;
            actual = Board.createInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for createInstance
        ///</summary>
        [TestMethod()]
        public void createInstanceTest1()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board expected = null; // TODO: Initialize to an appropriate value
            Board actual;
            actual = Board.createInstance(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setMemento
        ///</summary>
        [TestMethod()]
        public void setMementoTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            Symbol[,] temp = null; // TODO: Initialize to an appropriate value
            object m = null; // TODO: Initialize to an appropriate value
            target.setMemento(temp, m);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoardSize
        ///</summary>
        [TestMethod()]
        public void BoardSizeTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            target.BoardSize = expected;
            actual = target.BoardSize;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SymbolStore
        ///</summary>
        [TestMethod()]
        public void SymbolStoreTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board target = new Board(size); // TODO: Initialize to an appropriate value
            Symbol[,] expected = null; // TODO: Initialize to an appropriate value
            Symbol[,] actual;
            target.SymbolStore = expected;
            actual = target.SymbolStore;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
