using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGamesRUS.Game.Test
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
        ///A test for GameManager Constructor
        ///</summary>
        [TestMethod()]
        public void GameManagerConstructorTest()
        {
            GameManager target = new GameManager();
            Assert.Inconclusive("TODO: Implement code to verify target");
        }

        /// <summary>
        ///A test for CheckResizeRequired
        ///</summary>
        [TestMethod()]
        public void CheckResizeRequiredTest()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            Point cellCoords = new Point(); // TODO: Initialize to an appropriate value
            int expected = 0; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CheckResizeRequired(cellCoords);
            Assert.AreEqual(expected, actual);
            Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for Dispose
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void DisposeTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            bool disposing = false; // TODO: Initialize to an appropriate value
            target.Dispose(disposing);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GameManager_Load
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GameManager_LoadTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.GameManager_Load(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GameManager_MouseUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GameManager_MouseUpTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GameManager_MouseUp(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GameManager_Resize
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GameManager_ResizeTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.GameManager_Resize(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GameManager_Scroll
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void GameManager_ScrollTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            ScrollEventArgs e = null; // TODO: Initialize to an appropriate value
            target.GameManager_Scroll(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GameRestart
        ///</summary>
        [TestMethod()]
        public void GameRestartTest()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            target.GameRestart();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for GameStart
        ///</summary>
        [TestMethod()]
        public void GameStartTest()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            target.GameStart();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for InitializeComponent
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void InitializeComponentTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            target.InitializeComponent();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnMouseClick
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void OnMouseClickTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnMouseClick(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnPaint
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void OnPaintTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            PaintEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnPaint(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for OnUserClick
        ///</summary>
        [TestMethod()]
        public void OnUserClickTest()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.OnUserClick(e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ResizeBoard
        ///</summary>
        [TestMethod()]
        public void ResizeBoardTest()
        {
            GameManager target = new GameManager(); // TODO: Initialize to an appropriate value
            Point p = new Point(); // TODO: Initialize to an appropriate value
            target.ResizeBoard(p);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ResizeBoard
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void ResizeBoardTest1()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            target.ResizeBoard();
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for button1_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void button1_ClickTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.button1_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for button1_MouseMove
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void button1_MouseMoveTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.button1_MouseMove(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for button2_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void button2_ClickTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.button2_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for button3_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void button3_ClickTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.button3_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for button4_Click
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void button4_ClickTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            EventArgs e = null; // TODO: Initialize to an appropriate value
            target.button4_Click(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for label6_MouseUp
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void label6_MouseUpTest()
        {
            GameManager_Accessor target = new GameManager_Accessor(); // TODO: Initialize to an appropriate value
            object sender = null; // TODO: Initialize to an appropriate value
            MouseEventArgs e = null; // TODO: Initialize to an appropriate value
            target.label6_MouseUp(sender, e);
            Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }
    }
}
