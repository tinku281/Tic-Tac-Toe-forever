using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGamesRUS.Game
{
    class ComputerMoveHandler:MoveHandler
    {

        Board cmhBoard;
        Random RandValue=new Random();
        
        
        /// <summary>
        ///To get the singleton object of Board and initialise base class fields 
        /// </summary>
        /// <param name="board"></param>
        /// <param name="gameSize"></param>
        public ComputerMoveHandler(Board board, int gameSize) : base(board, gameSize) 
         {
                cmhBoard = Board.createInstance();
          
        }

        /// <summary>
        /// Places the coin at the specified position
        /// </summary>
        /// <param name="position"></param>
        /// <param name="coin"></param>
      public  void MakeMove(Point position, Symbol coin)
        {

            cmhBoard.PutSymbol(coin, position);
            
        }

        /// <summary>
        /// The main algorithm used to select the best position in the grid. 
        /// This algorithm is modularized in three steps.
        /// </summary>
        /// <param name="coin"></param>
        /// <returns>Point</returns>
        public override Point SelectBestMove(Symbol coin) {


            List<Point> StepOneResult = StepOne(coin);
            List<Point> StepTwoResult = StepTwo(StepOneResult, coin);
            //List<Point> PossiblePosition = StepThree(Step2Result, coin);
            List<Point> StepThreeResult = StepThree(StepTwoResult,coin);

            if(StepThreeResult.Count == 1)
                return StepThreeResult[0];

            int index = RandValue.Next(0, StepThreeResult.Count - 1);
            return StepThreeResult[index];
        }



        /// <summary>
        /// Assigns a value to the position passed based on the the coins placed nearby
        /// </summary>
        /// <param name="position"></param>
        /// <param name="coin"></param>
        /// <returns>int</returns>
        public int CalculateStepOne(Point position, Symbol coin)
        {
            int ComputerValue = 1 + CountCoin(position, coin);
            int UserValue = 1 + CountCoin(position, GetUserSymbol(coin));
            if (ComputerValue >= GameSize)
                ComputerValue = int.MaxValue;

            return Math.Max(ComputerValue, UserValue);
        }

       /// <summary>
       /// For each position in the grid assigns a value based on symbols placed nearby 
       /// and returns a set of points having the maximum value
       /// </summary>
       /// <param name="coin"></param>
       /// <returns><Point>List</Point></returns>
        public List<Point> StepOne(Symbol coin) {

            IEnumerable<Point> Coordinate = Board.CreatePoint();
            List<Point> PossiblePosition = new List<Point>();
            int MaxValue = 0;

            foreach (Point position in Coordinate)
            {
                if (Board.GetSymbol(position) != Symbol.blank)
                    continue;
                int CurrentValue = CalculateStepOne(position, coin);

                int compareResult = CurrentValue.CompareTo(MaxValue);
                if (compareResult < 0)
                    continue;
                if (compareResult > 0)
                {
                    PossiblePosition.Clear();
                    MaxValue = CurrentValue;
                }
                PossiblePosition.Add(position);
            }

            return PossiblePosition;

           }


        /// <summary>
        /// For each of the position returned by step one, it calculated a 
        /// value considering the immediate neighbours of the point and returns
        /// a set of points having the maximum value
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="coin"></param>
        /// <returns><point>List</point></returns>
        public List<Point> StepTwo(List<Point> pos,Symbol coin) {

            IEnumerable<Point> Coordinate = pos;
            List<Point> PossiblePosition = new List<Point>();
            int MaxValue = 0;

            foreach (Point position in Coordinate)
            {
                if (Board.GetSymbol(position) != Symbol.blank)
                    continue;
                int CurrentValue = CalculateStepTwo(position, coin);

                int compareResult = CurrentValue.CompareTo(MaxValue);
                if (compareResult < 0)
                    continue;
                if (compareResult > 0)
                {
                    PossiblePosition.Clear();
                    MaxValue = CurrentValue;
                }
                PossiblePosition.Add(position);
            }

            return PossiblePosition;
        }


        /// <summary>
        /// Takes a set of points from step two and returns a single point which is 
        /// oriented towards the center of the board relative to other input points
        /// </summary>
        /// <param name="pos"></param>
        /// <param name="coin"></param>
        /// <returns><point>List</point></returns>
        public List<Point> StepThree(List<Point> pos, Symbol coin) {

            IEnumerable<Point> Coordinate = pos;
            List<Point> PossiblePosition = new List<Point>();
            IComparable MaxValue = null;

            foreach (Point position in Coordinate)
            {
                if (Board.GetSymbol(position) != Symbol.blank)
                    continue;
               IComparable CurrentValue = CalculateStepThree(position, coin);

                int compareResult = CurrentValue.CompareTo(MaxValue);
                if (compareResult < 0)
                    continue;
                if (compareResult > 0)
                {
                    PossiblePosition.Clear();
                    MaxValue = CurrentValue;
                }
                PossiblePosition.Add(position);
            }

            return PossiblePosition;
            
        }


        /// <summary>
        /// For each point calculates a value based on the immediate neighbours
        /// By doing this we assign a weight for blocking the opponent and our chance of winning
        /// </summary>
        /// <param name="position"></param>
        /// <param name="coin"></param>
        /// <returns>int</returns>
        public int CalculateStepTwo(Point position, Symbol coin)
        {
            Point TempPoint;
            int TempX=position.X;
            int TempY=position.Y;

            int ComputerValue = 0;
            int UserValue = 0;

            for(int x = TempX - 1; x <= TempX + 1; x++) {
                for(int y = TempY - 1; y <= TempY + 1; y++) {
                    TempPoint = new Point(x, y);
                    if(Board.GetSymbol(TempPoint) == coin)
                        ComputerValue++;
                    if(Board.GetSymbol(TempPoint) == GetUserSymbol(coin))
                        UserValue++;
                }
            }

            return 2 * ComputerValue + UserValue;
        }

       /// <summary>
       /// Calculate the position of the point to the center of the board
       /// </summary>
       /// <param name="position"></param>
       /// <param name="coin"></param>
       /// <returns>IComparable</returns>
      
        public IComparable CalculateStepThree(Point position, Symbol coin) {
            var TempX = position.X - Board.BoardSize / 2;
            var TempY = position.Y - Board.BoardSize / 2;
            return -Math.Sqrt(TempX * TempX + TempY * TempY);
        }

        
    }


    }

