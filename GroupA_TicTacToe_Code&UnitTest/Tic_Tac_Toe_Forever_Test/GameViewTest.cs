using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tic_Tac_Toe_Forever_Test
{
    
    
    /// <summary>
    ///This is a test class for GameViewTest and is intended
    ///to contain all GameViewTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GameViewTest
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
        ///A test for GameView Constructor
        ///</summary>
        [TestMethod()]
        public void GameViewConstructorTest()
        {
            GameView target = new GameView();
          //Assert.Inconclusive("TODO: Implement code to verify target");
        }

       

        /// <summary>
        ///A test for ShowInstruction
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void ShowInstructionTest()
        {
            GameView target = new GameView(); // TODO: Initialize to an appropriate value
            Label expected = new Label(); ;
            expected.Text= "1. Your Symbol is " + "O." + "\r\n" + "2. Computer's Symbol is " + "X." + "\r\n" + "3. Place your symbol during your turn." + "\r\n" + "4. You win by placing five of your coins either horizontally, vertically" + "\r\n" + "    or diagonally." + "\r\n"+ "5. Enjoy the game!!"; // TODO: Initialize to an appropriate value
            Label actual;
            actual = target.ShowInstruction();
            Assert.AreEqual(expected.Text, actual.Text);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for ShowResult
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void ShowResultTest()
        {
            GameView target = new GameView(); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            target.ShowResult(coin);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for ShowResult
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void ShowResultTest1()
        {
            GameView target = new GameView(); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Oval; // TODO: Initialize to an appropriate value
            target.ShowResult(coin);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

    }

}
