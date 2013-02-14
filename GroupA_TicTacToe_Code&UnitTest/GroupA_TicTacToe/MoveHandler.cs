using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGamesRUS.Game
{
  abstract class MoveHandler
    {
       Board MhBoard;
       int Size;
     
      /// <summary>
      /// Constructor for move handler
      /// </summary>
       public MoveHandler()
       {
           MhBoard = Board.createInstance();
           Size = 0;
       }
       
      /// <summary>
      /// Checks whether the user or the computer have won the game
      /// </summary>
      /// <param name="position"></param>
      /// <param name="coin"></param>
      /// <returns>bool</returns>
        public bool CheckResult(Point position, Symbol coin)
        {
            if (IsWon(position, coin))
            {

                return true;
            }
            else
                return false;

        }


      /// <summary>
      /// Constructor to initialize board and gamesize
      /// </summary>
      /// <param name="board"></param>
      /// <param name="gameSize"></param>
        public MoveHandler(Board board, int gameSize)
        {
            if (board == null)
                MessageBox.Show("Board object not initialized");
            if (gameSize != 5)
                MessageBox.Show("Game size should be equal to 5");
            this.MhBoard = board;
            this.Size = gameSize;            
        }

      
        public Board Board {
            get { return MhBoard; }
        }

        public int GameSize {
            get { return Size; }
        }

      /// <summary>
      /// Checks whether the the passed symbol has won 
      /// </summary>
      /// <param name="position"></param>
      /// <param name="coin"></param>
      /// <returns>bool</returns>
        public bool IsWon(Point position, Symbol coin) {
            return Board.GetSymbol(position) == coin && CountCoin(position, coin) >= GameSize - 1;
        }


      /// <summary>
      /// abstract method implemented in Child class - ComputerMoveHandler
      /// </summary>
      /// <param name="coin"></param>
      /// <returns>Point</returns>
        public abstract Point SelectBestMove(Symbol coin);
       

        
      /// <summary>
      /// returns the symbol of the user
      /// </summary>
      /// <param name="coin"></param>
      /// <returns>Symbol</returns>
        public Symbol GetUserSymbol(Symbol coin) {
            if(coin == Symbol.Cross)
                return Symbol.Oval;
            if(coin == Symbol.Oval)
                return Symbol.Cross;
            MessageBox.Show("Error close the game and reopen it");
            return 0;
        }
     
      /// <summary>
      /// Counts the coins placed in the direction given by xIncrement and yIncrement
      /// </summary>
      /// <param name="startPos"></param>
      /// <param name="xIncrement"></param>
      /// <param name="yIncrement"></param>
      /// <param name="coin"></param>
      /// <returns>int</returns>
        int CountCoins(Point startPos, int xIncrement, int yIncrement, Symbol coin) {
            int score = 0;

            for(int i = 1; i < GameSize; i++) {
                Point current = startPos + new Size(i * xIncrement, i * yIncrement);
                if(Board.GetSymbol(current) != coin)
                    break;
                score++;
            }

            return score;
        }


      /// <summary>
      /// Count a type of coin(symbol) vertically, horizontally and diagonally
      /// and returns the maximum value
      /// </summary>
      /// <param name="position"></param>
      /// <param name="coin"></param>
      /// <returns>int</returns>
        public int CountCoin(Point position, Symbol coin) {
          
            int Diagonal1 = CountCoins(position, -1, -1, coin) + CountCoins(position, 1, 1, coin);
            int Diagonal2= CountCoins(position, -1, 1, coin) + CountCoins(position, 1, -1, coin);
            int XDirection=  CountCoins(position, -1, 0, coin) + CountCoins(position, 1, 0, coin);
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                
            int YDirection= CountCoins(position, 0, -1, coin) + CountCoins(position, 0, 1, coin);
                
            System.Collections.ArrayList Values = new System.Collections.ArrayList();
            Values.Add(Diagonal1);
            Values.Add(Diagonal2);
            Values.Add(XDirection);
            Values.Add(YDirection);
            int MaxValue = 0;
            for(int i = 0; i < Values.Count; i++) {
                MaxValue = Math.Max(MaxValue,(int) Values[i]);
            }
            return MaxValue;
        }
    }

    
}
