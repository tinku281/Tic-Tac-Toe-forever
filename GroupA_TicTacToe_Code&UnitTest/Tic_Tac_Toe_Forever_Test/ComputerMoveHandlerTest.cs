using ComputerGamesRUS.Game;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Drawing;
using System.Collections.Generic;

namespace ComputerGamesRUS.Game.Test1
{
    
    
    /// <summary>
    ///This is a test class for ComputerMoveHandlerTest and is intended
    ///to contain all ComputerMoveHandlerTest Unit Tests
    ///</summary>
    [TestClass()]
    public class ComputerMoveHandlerTest
    {

        /// <summary>
        ///A test for CalculateStepOne
        ///Here a scenario is created such that one zero is placed at a position
        ///where the value is calculated for the nearby position we get the value as 2.
        ///As placing at that position we will have two continous coins
        ///</summary>
        [TestMethod()]
        public void CalculateStepOneTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(15, 15), Symbol.Oval);
            Point position = new Point(15,16); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Oval; // TODO: Initialize to an appropriate value
            int expected = 2; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CalculateStepOne(position, coin);
            Assert.AreEqual(expected, actual);
            target = null;
            board = null;
           
        }



        /// <summary>
        ///A test for CalculateStepOne
        ///we have made a scenario where four continous coins are placed together
        ///so in the next position it returns a Int.MaxValue as placing on that is the winning criteria
        ///</summary>
        [TestMethod()]
        public void CalculateStepOneTest1()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(5, 5), Symbol.Oval);
            target.MakeMove(new Point(5, 6), Symbol.Cross);
            target.MakeMove(new Point(5, 7), Symbol.Cross);
            target.MakeMove(new Point(5, 8), Symbol.Cross);
            target.MakeMove(new Point(5, 9), Symbol.Cross);
            Point position = new Point(5, 10); // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            int expected = int.MaxValue; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CalculateStepOne(position, coin);
            Assert.AreEqual(expected, actual);
            target = null;
            board = null;
        }

        /// <summary>
        ///A test for CalculateStepThree
        ///Given a point this returns a value which is based relative to the center of the grid
        ///The test case will return a value based on the existing formula
        ///</summary>
        [TestMethod()]
        public void CalculateStepThreeTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(1, 1), Symbol.Cross);
            IComparable actual;
            actual = target.CalculateStepThree(new Point(1,1), Symbol.Cross);
            target = null;
            board = null;
            Assert.Inconclusive("Value returned based on the formula");
        }

        /// <summary>
        ///A test for CalculateStepTwo
        ///This step calculates its chance of winning and the chance of Blocking. Based on both it calculates a value
        ///We have zero at 5,5 and an cross at 5,6. Now the suppose I pass a cross at 6,5. Then it will have a value 2 
        ///as there will be two cross continously and will block one zero, so the value is 2+1=3 which is returned.
        ///</summary>
        [TestMethod()]
        public void CalculateStepTwoTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(20, 5), Symbol.Oval);
            target.MakeMove(new Point(20, 6), Symbol.Cross);
           // target.MakeMove(new Point(6, 5), Symbol.Cross);
            Point position = new Point(21, 5);
             // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            int expected = 3; // TODO: Initialize to an appropriate value
            int actual;
            actual = target.CalculateStepTwo(position, coin);
            Assert.AreEqual(expected, actual);
            target = null;
            board = null;
           
        }

        /// <summary>
        ///A test for MakeMove
        ///This method does not return a vlaue so it cannot be unit tested. Also I cannot create two board
        ///objects to compare where specified points are set as Board is singleton and only one object can
        ///be created. This method is used in CalculateStepTwoTest,CalculateStepOneTest and CalculateStepThreeTest
        ///which have been tested already
        ///</summary>
        [TestMethod()]
        public void MakeMoveTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Point position = new Point(); // TODO: Initialize to an appropriate value
            Symbol coin = new Symbol(); // TODO: Initialize to an appropriate value
            target.MakeMove(position, coin);
            target = null;
            board = null;
        }

        /// <summary>
        ///A test for SelectBestMove
        ///I have created a scenario where we have 4 cross seperately are it now has to place in the fifth position
        ///This function calls each step of the algorithm which have already been tested
        ///</summary>
        [TestMethod()]
        public void SelectBestMoveTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler targetnew = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            targetnew.MakeMove(new Point(5, 5), Symbol.Oval);
            targetnew.MakeMove(new Point(5, 6), Symbol.Cross);
            targetnew.MakeMove(new Point(5, 7), Symbol.Cross);
            targetnew.MakeMove(new Point(5, 8), Symbol.Cross);
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            Point expected = new Point(5,9); // TODO: Initialize to an appropriate value
            Point actual;
            actual = targetnew.SelectBestMove(coin);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for StepOne
        ///Here that scenario is that we have three crosses placed simultaneously in this case it will return two 
        ///points one at the begining and one at the end. The subfunctions have already been tested
        ///</summary>
        [TestMethod()]
        public void StepOneTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            target.MakeMove(new Point(5, 5), Symbol.Cross);
            target.MakeMove(new Point(5, 6), Symbol.Cross);
            target.MakeMove(new Point(5, 7), Symbol.Cross);
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            List<Point> expected = new List<Point>(); // TODO: Initialize to an appropriate value
            expected.Add(new Point(5, 4));
            expected.Add(new Point(5, 8)); 
            List<Point> actual1;
            actual1 = target.StepOne(coin);
            List<Point> Actual = new List<Point>();
            foreach (Point ptr in actual1)
            {
                Actual.Add(ptr);
            }
           
            Assert.AreEqual(expected.ToString(), Actual.ToString());
           
            target = null;
            board = null;
        }

        /// <summary>
        ///A test for StepThree
        ///Returns the middle value
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void StepThreeTest()
        {
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler Step3Target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            List<Point> pos = new List<Point>(){new Point(0,0),new Point(0,1)}; // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            List<Point> expected = new List<Point>(){new Point(0,1)} ; // TODO: Initialize to an appropriate value
            List<Point> actual;
            actual = Step3Target.StepThree(pos, coin);
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Step3Target = null;
            board = null;
          
        }

        /// <summary>
        ///A test for StepTwo
        ///The scenario is tested where we have a position which moves towards winning and also blocking.
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]
        public void StepTwoTest()
        {
            
            Board board = Board.createInstance(25); // TODO: Initialize to an appropriate value
            int gameSize = 5; // TODO: Initialize to an appropriate value
            ComputerMoveHandler Step2Target = new ComputerMoveHandler(board, gameSize); // TODO: Initialize to an appropriate value
            Step2Target.MakeMove(new Point(5, 5), Symbol.Cross);
            Step2Target.MakeMove(new Point(5, 6), Symbol.Cross);
            Step2Target.MakeMove(new Point(5, 7), Symbol.Cross);
            Step2Target.MakeMove(new Point(6, 7), Symbol.Oval);
            List<Point> pos = new List<Point>() {new Point(5,8),new Point(5,4)}; // TODO: Initialize to an appropriate value
            Symbol coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            List<Point> expected = new List<Point>(){new Point(5,8)}; // TODO: Initialize to an appropriate value
            List<Point> actual;
            actual = Step2Target.StepTwo(pos, coin);
            Assert.AreEqual(expected.ToString(), actual.ToString());
            Step2Target = null;
            board = null;
        }
    }
}
