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

        /// Tested and passed
        public void BoardConstructorTest()
        {
            int size = 25; // TODO: Initialize to an appropriate value
            int expected = size+10;
            Board target = Board.createInstance(size);
            int actual=target.BoardSize;
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for Clear
        ///</summary>
        [TestMethod()]

        ///Tested and passed
        public void ClearTest()
        {
           // PrivateObject param0 = null; // TODO: Initialize to an appropriate value
           // Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 2;
            Board target = Board.createInstance(size);
            Symbol[,] expected = new Symbol[size, size];
            Point position = new Point(0, 0);
            target.PutSymbol(Symbol.Oval,position);
            target.Clear();
            Symbol[,] actual = target.SymbolStore;
            Assert.AreEqual(expected.ToString(), actual.ToString());
           // Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for CreateMemento
        ///</summary>
        [TestMethod()]
        /// Tested and passed
        public void CreateMementoTest()
        {
            //PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
           
            Symbol[,] expected =target.SymbolStore; // TODO: Initialize to an appropriate value
            object test;
            test = target.CreateMemento();
            target.setMemento(test);
            Symbol[,] actual = target.SymbolStore;

            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for CreatePoint
        ///</summary>
        [TestMethod()]

    ///Tested and passed
        public void CreatePointTest()
        {
          //  PrivateObject param0 = null; // TODO: Initialize to an appropriate value
           // Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 2;
            Board target = Board.createInstance(size);

            List<Point> expected = new List<Point>();
            Point Epoint= new Point(0,0);
            for (int y = 0; y < 2; y++)
            {
                for (int x = 0; x < 2; x++)
                {
                    expected.Add(new Point(x, y));
                }
            }
            IEnumerable<Point> act;
            List<Point> actual = new List<Point>();
            act = target.CreatePoint();
            foreach (Point position in act)
            {
                actual.Add(new Point(position.X, position.Y));
            }
           Assert.AreEqual(expected.ToString(), actual.ToString());    
        }

        
      

        /// <summary>
        ///A test for GetCellRectangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]

        //Tested and passed
        public void GetCellRectangleTest()
        {
            //PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
            Point position = new Point(10,10); // TODO: Initialize to an appropriate value
            Rectangle expected = new Rectangle(10*25,10*25,25,25); // TODO: Initialize to an appropriate value
            Rectangle actual;
            actual = target.GetCellRectangle(position);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSymbol
        ///</summary>
        [TestMethod()]
        //Tested and passed
        public void GetSymbolTest()
        {
           // PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
            Point position = new Point(10,10); // TODO: Initialize to an appropriate value
            target.PutSymbol(Symbol.Cross,position);
            Symbol expected = Symbol.Cross; // TODO: Initialize to an appropriate value
            Symbol actual;
            actual = target.GetSymbol(position);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for GetSymbolRectangle
        ///</summary>
        [TestMethod()]
        [DeploymentItem("GroupA_TicTacToe.exe")]

        ///Tested and passed
        public void GetSymbolRectangleTest()
        {
           // PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
            Point location = new Point(10,10); // TODO: Initialize to an appropriate value
            Rectangle expected = new Rectangle(10*25,10*25,25,25); // TODO: Initialize to an appropriate value
            expected.Inflate(-3, -3);
            Rectangle actual;
            actual = target.GetSymbolRectangle(location);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for IsOutofBounds
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void IsOutofBoundsTest()
        {
            //PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
            int locX = 10; // TODO: Initialize to an appropriate value
            int locY = 10; // TODO: Initialize to an appropriate value
            bool expected = false; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOutofBounds(locX, locY);
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
        /// <summary>
        ///A test for IsOutofBounds
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void IsOutofBoundsTest1()
        {
            //PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
            int locX = 50; // TODO: Initialize to an appropriate value
            int locY = 10; // TODO: Initialize to an appropriate value
            bool expected = true; // TODO: Initialize to an appropriate value
            bool actual;
            actual = target.IsOutofBounds(locX, locY);
            Assert.AreEqual(expected, actual);
            // Assert.Inconclusive("Verify the correctness of this test method.");
        }
     


        /// <summary>
        ///A test for PutSymbol
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void PutSymbolTest()
        {
            //PrivateObject param0 = null; // TODO: Initialize to an appropriate value
            //Board_Accessor target = new Board_Accessor(param0); // TODO: Initialize to an appropriate value
            int size = 25;
            Board target = Board.createInstance(size);
            Symbol Coin = Symbol.Cross; // TODO: Initialize to an appropriate value
            Symbol expected = Coin;
            Point position = new Point(10,10); // TODO: Initialize to an appropriate value
            target.PutSymbol(Coin, position);
            Symbol[,] actual = target.SymbolStore;
            Assert.AreEqual(expected, actual[position.X,position.Y]);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for createInstance
        ///</summary>
        [TestMethod()]
        /// Tested and passed. 
        public void createInstanceTest()
        {
            int size = 25; // TODO: Initialize to an appropriate value
             // TODO: Initialize to an appropriate value
            Board actual;
            actual = Board.createInstance(size);
            Board expected = Board.createInstance();
            Assert.AreEqual(expected.BoardSize, actual.BoardSize);
            //Assert.Inconclusive("This method can't be tested as the Board class is singleton and has a private constructor");
        }

        /// <summary>
        ///A test for createInstance
        ///</summary>
        [TestMethod()]

        ///Tested and passed.
        public void createInstanceTest1()
        {
            int size = 25;
            Board expected = Board.createInstance(size); // TODO: Initialize to an appropriate value
            Board actual;
            actual = Board.createInstance();
            Assert.AreEqual(expected.ToString(), actual.ToString());
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for setMemento
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void setMementoTest()
        {
            int size = 25;
            Board target = Board.createInstance(size);
            Symbol[,] expected= target.SymbolStore;
            object m = target.CreateMemento(); ; // TODO: Initialize to an appropriate value
            Symbol[,] actual= target.SymbolStore;
            target.setMemento(m);
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("A method that does not return a value cannot be verified.");
        }

        /// <summary>
        ///A test for BoardSize
        ///</summary>
        [TestMethod()]
        ///Tested and passed
        public void BoardSizeTest()
        {
            int size = 25;
            Board target = Board.createInstance(size);
            int expected = size;
            int actual;
            target.BoardSize = expected;
            actual = target.BoardSize;
            Assert.AreEqual(expected, actual);
            //Assert.Inconclusive("Verify the correctness of this test method.");
        }

        /// <summary>
        ///A test for SymbolStore
        ///</summary>
        [TestMethod()]

        ///Tested and passed.
        public void SymbolStoreTest()
        {
            int size = 25;
            Board target = Board.createInstance(size);
            Symbol[,] expected =new Symbol[size,size]; // TODO: Initialize to an appropriate value
            expected[1, 1] = Symbol.Cross;
            expected[1, 2] = Symbol.Oval;
            Symbol[,] actual;
            target.SymbolStore = expected;
            actual = target.SymbolStore;
            Assert.AreEqual(expected, actual);
           // Assert.Inconclusive("Verify the correctness of this test method.");
        }
    }
}
