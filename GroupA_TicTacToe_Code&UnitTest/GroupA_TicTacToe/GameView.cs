using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;

namespace ComputerGamesRUS.Game
{
    class GameView
    {
        string Instruction;
        string ComputerResult,UserResult;
        Board GvBoard; 
        /// <summary>
        /// Default Constructor for the GameView Class.
        /// </summary>
        public GameView()
        {
            Instruction = "1. Your Symbol is " + "O." + "\r\n" + "2. Computer's Symbol is " + "X." + "\r\n" + "3. Place your symbol during your turn." + "\r\n" + "4. You win by placing five of your coins either horizontally, vertically" + "\r\n" + "    or diagonally." + "\r\n"
           + "5. Enjoy the game!!";
            ComputerResult = "Computer" + " wins!!";
            UserResult = "You" + " won!!";
        }

        
        /// <summary>
        /// Displays the Grid to the user.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="boardsize"></param>
        public void ShowGrid(Graphics g,int boardsize)
        {
           GvBoard=Board.createInstance(boardsize);
            GvBoard.DrawBoard(g);
        }
        /// <summary>
        /// Displays the set of instructions to the user.
        /// </summary>
        /// <returns></returns>
        public Label ShowInstruction()
        {
            Label InstructionLabel = new Label();
            InstructionLabel.Text = Instruction;
            return InstructionLabel;
        }
        /// <summary>
        /// Displays the Gameresult to the user.
        /// </summary>
        /// <param name="coin"></param>
        public void ShowResult(Symbol coin)
        {
            if(coin==Symbol.Cross)
                MessageBox.Show(ComputerResult);
               
            else 
                MessageBox.Show(UserResult);
        }

    }
}
