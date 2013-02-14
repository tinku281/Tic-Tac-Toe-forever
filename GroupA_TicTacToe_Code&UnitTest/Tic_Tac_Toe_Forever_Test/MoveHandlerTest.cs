using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;

namespace ComputerGamesRUS.Game.Test1
{
    
    
    /// <summary>
    ///This is a test class for MoveHandlerTest and is intended
    ///to contain all MoveHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class MoveHandlerTest
    {

        /// <summary>
        ///A test for CheckResult
        ///</summary>
        [TestMethod()]
        public void CheckResultTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board,gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(5, 1), Symbol.Cross);
            target.MakeMove(new Point(5, 2), Symbol.Cross);
            target.MakeMove(new Point(5, 3), Symbol.Cross);
            target.MakeMove(new Point(5, 4), Symbol.Cross);
            target.MakeMove(new Point(5, 5), Symbol.Cross);
            
            Point position = new Point(5,5); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.CheckResult(position, coin);
            Assert.AreEqual(expected, actual);
            target = null;
            board = null;
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }

        public void CheckResultTest1()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler TargetTest = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            TargetTest.MakeMove(new Point(5, 5), Symbol.Cross);
            TargetTest.MakeMove(new Point(5, 6), Symbol.Cross);
            TargetTest.MakeMove(new Point(5, 7), Symbol.Cross);
            TargetTest.MakeMove(new Point(5, 8), Symbol.Cross);
            

            Point position = new Point(5, 8); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = TargetTest.CheckResult(position, coin);
            Assert.AreEqual(expected, actual);
            TargetTest = null;
            board = null;
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }

      

        /// <summary>
        ///A test for CountCoin
        ///Tessted CountCoin and CountCoins
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void CountCoinTest()
        {

            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(5, 5), Symbol.Cross);
            target.MakeMove(new Point(5, 6), Symbol.Cross);
            target.MakeMove(new Point(5, 7), Symbol.Cross);
            target.MakeMove(new Point(5, 8), Symbol.Cross);
            Point position = new Point(5,9); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            int expected = 4; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CountCoin(position, coin);
            Assert.AreEqual(expected, actual);
            target = null;
            board = null;
        }

       

        /// <summary>
        ///A test for GetUserSymbol
        ///</summary>
        [TestMethod()]
        public void GetUserSymbolTest()
        {

            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            Symbol expected = Symbol.Oval; // TODO: Initialize to an appropriate value
            Symbol actual;
            actual = target.GetUserSymbol(coin);
            Assert.AreEqual(expected, actual);
            board = null;
            target = null;
           
        }

    }
}
