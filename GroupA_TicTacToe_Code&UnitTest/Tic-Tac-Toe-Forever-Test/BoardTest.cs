using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace Tic_Tac_Toe_Forever_Test
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
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void BoardConstructorTest()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(size);
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void ClearTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            target.Clear();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateMemento
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CreateMementoTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CreatePointTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            IEnumerable<Point> expected = null; // TODO: Initialize to an appropriate value
            IEnumerable<Point> actual;
            actual = target.CreatePoint();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for DrawBoard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void DrawBoardTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
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
            Point position = new Point(); // TODO: Initialize to an appropriate value
            target.DrawCell(g, position);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GetCellRectangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GetCellRectangleTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Point position = new Point(); // TODO: Initialize to an appropriate value
            Rectangle expected = new Rectangle(); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.GetCellRectangle(position);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSymbol
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GetSymbolTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Point position = new Point(); // TODO: Initialize to an appropriate value
            Symbol expected = new Symbol(); // TODO: Initialize to an appropriate value
            Symbol actual;
            actual = target.GetSymbol(position);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSymbolRectangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GetSymbolRectangleTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Point location = new Point(); // TODO: Initialize to an appropriate value
            Rectangle expected = new Rectangle(); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.GetSymbolRectangle(location);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOutofBounds
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void IsOutofBoundsTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int locX = 0; // TODO: Initialize to an appropriate value
            int locY = 0; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOutofBounds(locX, locY);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
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
            Point position = new Point(); // TODO: Initialize to an appropriate value
            target.PaintSymbolO(g, position);
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
            Point position = new Point(); // TODO: Initialize to an appropriate value
            target.PaintSymbolX(g, position);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for PutSymbol
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void PutSymbolTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Symbol Coin = new Symbol(); // TODO: Initialize to an appropriate value
            Point position = new Point(); // TODO: Initialize to an appropriate value
            target.PutSymbol(Coin, position);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for createInstance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void createInstanceTest()
        {
            Board_Accessor expected = null; // TODO: Initialize to an appropriate value
            Board_Accessor actual;
            actual = Board_Accessor.createInstance();
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for createInstance
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void createInstanceTest1()
        {
            int size = 0; // TODO: Initialize to an appropriate value
            Board_Accessor expected = null; // TODO: Initialize to an appropriate value
            Board_Accessor actual;
            actual = Board_Accessor.createInstance(size);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setMemento
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void setMementoTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Symbol[,] temp = null; // TODO: Initialize to an appropriate value
            object m = null; // TODO: Initialize to an appropriate value
            target.setMemento(temp, m);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoardSize
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void BoardSizeTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
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
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void SymbolStoreTest()
        {
            PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            Symbol[,] expected = null; // TODO: Initialize to an appropriate value
            Symbol[,] actual;
            target.SymbolStore = expected;
            actual = target.SymbolStore;
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
