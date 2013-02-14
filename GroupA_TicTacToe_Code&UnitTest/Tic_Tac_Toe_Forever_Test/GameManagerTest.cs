using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Forever_Test
{
    
    
    /// <summary>
    ///This is a test class for GameManagerTest and is intended
    ///to contain all GameManagerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameManagerTest
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
        ///A test for CheckResizeRequired
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void CheckResizeRequiredTest()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            Point cellCoords = new Point(24,24); // TODO: Initialize to an appropriate value
            int expected = 1; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CheckResizeRequired(cellCoords);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CheckResizeRequired
        ///</summary>
        [TestMethod()]
        ///Tested and passed

        public void CheckResizeRequiredTest1()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            Point cellCoords = new Point(0, 0); // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CheckResizeRequired(cellCoords);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }


        /// <summary>
        ///A test for CheckResizeRequired
        ///</summary>
        [TestMethod()]
        ///Tested and passed

        public void CheckResizeRequiredTest2()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            Point cellCoords = new Point(100,100); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CheckResizeRequired(cellCoords);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }
        
        /// <summary>
        ///A test for ResizeBoard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        //Tested and passed
        public void ResizeBoardTest()
        {
            int size = 25;
            Board expectedBoard = Board.createInstance(size);
            int expectedSize = expectedBoard.BoardSize;
            Symbol[,] expectedSymbol = new Symbol[expectedSize, expectedSize];
            
             GameManager gv = new GameManager();
               gv.ResizeBoard();
            Board actualBoard = Board.createInstance(size);
            int actualSize = actualBoard.BoardSize;
            Symbol[,] actualSymbol = actualBoard.SymbolStore;
            Assert.AreEqual(expectedSymbol.ToString(), actualSymbol.ToString());

         }
        /// <summary>
        ///A test for ResizeBoard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        //Tested and passed
        public void ResizeBoardTest1()
        {
            int size = 25;
            Board expectedBoard = Board.createInstance(size);
            int expectedSize = expectedBoard.BoardSize + 10;
            Symbol[,] expectedSymbol = new Symbol[expectedSize, expectedSize];

            GameManager gv = new GameManager();
            gv.TopLeft = true;
            gv.ResizeBoard();
            Board actualBoard = Board.createInstance();
            int actualSize = actualBoard.BoardSize;
            Symbol[,] actualSymbol = actualBoard.SymbolStore;
            Assert.AreEqual(expectedSize, actualSize);
            Assert.AreEqual(expectedSymbol.ToString(), actualSymbol.ToString());

        }

    }
}
