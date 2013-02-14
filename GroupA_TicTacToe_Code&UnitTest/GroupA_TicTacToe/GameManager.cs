using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;


namespace ComputerGamesRUS.Game
{
    public partial class GameManager : Form
    {
        enum Screens {game, exit,welcome }
        Screens ScreenFlag=Screens.welcome; 
        object ObjMemento;
        bool IsTopLeft = false;
        Symbol[,] SymbolTemp;
        const Symbol UserSymbol = Symbol.Oval;
        const Symbol ComputerSymbol = Symbol.Cross;
        int BoardSize = 25;
        const int CellSize = 25;
        const int CoinCount = 5;
        Object GmMemento;
        GameView GView;
        Board GmBoard;
        ComputerMoveHandler Logic;
        /// <summary>
        /// Default Constructor for GameManager Class
        /// </summary>
        public GameManager()
         
        {
            InitializeComponent();
            GmBoard = Board.createInstance(BoardSize);
            Logic = new ComputerMoveHandler(GmBoard, CoinCount);
            GView = new GameView();
            
        }
        /// <summary>
        /// This method Resizes the playing board by a size of 10 when clicked 
        /// at cornors of the  board
        /// </summary>
        public void ResizeBoard()
        {
            int ExtensionSize = 10;
            BoardSize = BoardSize + ExtensionSize;
            this.AutoScrollMinSize = new System.Drawing.Size(CellSize * BoardSize, CellSize * BoardSize);
            Object objMemento = GmBoard.CreateMemento();
            GmBoard.SymbolStore = null;
            GmBoard.SymbolStore = new Symbol[BoardSize, BoardSize];
            GmBoard.BoardSize = BoardSize;
            SymbolTemp = new Symbol[BoardSize, BoardSize];
            GmBoard.setMemento(objMemento);
            for (int i = 0; i < (BoardSize - ExtensionSize); i++)
                for (int j = 0; j < (BoardSize - ExtensionSize); j++)
                    SymbolTemp[i, j] = GmBoard.SymbolStore[i, j];
            GmBoard.SymbolStore = SymbolTemp;
           
            if (IsTopLeft == true)
            {
                SymbolTemp = null;
                SymbolTemp = new Symbol[BoardSize, BoardSize];
                for (int i = 0; i < (BoardSize - ExtensionSize); i++)
                {
                    for (int j = 0; j < (BoardSize - ExtensionSize); j++)
                    {
                        SymbolTemp[i + ExtensionSize, j + ExtensionSize] = GmBoard.SymbolStore[i, j];

                    }
                }
                GmBoard.SymbolStore = SymbolTemp;
                }
        }
        /// <summary>
        /// This event will be generated when the user clicks on the playing grid,
        /// and checks if resize is required, places the user move, selects the best
        /// move for the computer and places the computer move.
        /// </summary>
        /// <param name="e"></param>
        protected override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
            int CoordX = 0;
            int CoordY = 0;

            if (e.Button == MouseButtons.Left)
            {

                int ScrollX = (AutoScrollPosition.X % CellSize);
                int ScrollY = (AutoScrollPosition.Y % CellSize);
                AutoScrollPosition.Offset(ScrollX, ScrollY);
                CoordX = (int)Math.Round(((-(decimal)AutoScrollPosition.X) / (decimal)CellSize), 0);
                CoordY = (int)Math.Round(((-(decimal)AutoScrollPosition.Y) / (decimal)CellSize), 0);
                Point CellCoord = new Point((e.X / CellSize) + CoordX, (e.Y / CellSize) + CoordY);
                if (GmBoard.GetSymbol(CellCoord) == Symbol.blank)
                {
                    Logic.MakeMove(CellCoord, UserSymbol);
                    Refresh();
                    if (Logic.CheckResult(CellCoord, UserSymbol))
                    {
                        GView.ShowResult(UserSymbol);
                        GmBoard.Clear();
                        ScreenFlag = Screens.exit;
                     }


                    if (CheckResizeRequired(CellCoord) == 1)
                    {
                        ResizeBoard();
                        Refresh();
                    }
                    else if (CheckResizeRequired(CellCoord) == 2)
                    {
                        IsTopLeft = true;
                        ResizeBoard();
                        Refresh();
                    }
                    Point ComputerPosition = Logic.SelectBestMove(ComputerSymbol);
                    Logic.MakeMove(ComputerPosition, ComputerSymbol);
                    Refresh();
                    if (Logic.CheckResult(ComputerPosition, ComputerSymbol))
                    {
                        GView.ShowResult(ComputerSymbol);
                        GmBoard.Clear();
                        ScreenFlag = Screens.exit;
                    }

                    Refresh();
                 

                }
              else
               {
                MessageBox.Show("Please make a valid move");
               }
            
            }

         else
         {
          MessageBox.Show("Right Click not allowed");
         }
        
        }

        /// <summary>
        /// This method returns a integer 1 or 2 depending on the resize direction
        /// whenever resize is required or returns 
        /// zero if resize if not required
        /// </summary>
        /// <param name="cellCoords"></param>
        /// <returns>integer</returns>
        public int CheckResizeRequired(Point cellCoords)
        {
            int Check;
            if (((cellCoords.X > -1 && cellCoords.X < (BoardSize)) && (cellCoords.Y == (BoardSize - 1))) ||
                    ((cellCoords.Y > -1 && cellCoords.Y < (BoardSize)) && cellCoords.X == (BoardSize - 1)))
                    {
                        Check = 1; 
                        return Check;
                       
                    }
            else if (((cellCoords.X > -1 && cellCoords.X < (BoardSize)) && (cellCoords.Y == (0))) ||
              ((cellCoords.Y > -1 && cellCoords.Y < (BoardSize)) && cellCoords.X == (0)))
            {
                Check = 2;
                return Check;

            }
            else
            {
                Check = 0;
                return Check; ;
            }
        
        }
        /// <summary>
        /// This method paints the board as well the symbols.
        /// </summary>
        /// <param name="e"></param>

        protected override void OnPaint(PaintEventArgs e)
        {
           
           
            if (IsTopLeft == true)
            {
                IsTopLeft = false;
                this.AutoScrollPosition = new Point(225, 225);
            }
            
            int dx = (AutoScrollPosition.X % CellSize);
            int dy = (AutoScrollPosition.Y % CellSize);
            AutoScrollPosition.Offset(AutoScrollPosition.X + dx, AutoScrollPosition.Y + dy);
            base.OnPaint(e);
            Matrix mx = new Matrix(1, 0, 0, 1, AutoScrollPosition.X, AutoScrollPosition.Y);
            e.Graphics.Transform = mx;
            if (ScreenFlag == Screens.game)
            {
                this.AutoScroll = true;
                this.HScroll = true;
                this.AutoScrollMinSize = new System.Drawing.Size(CellSize * BoardSize, CellSize * BoardSize);
                this.VScroll = true;
                GView.ShowGrid(e.Graphics, BoardSize);
            }
            else if (ScreenFlag == Screens.exit)
            {
               this.AutoScrollPosition = new Point(0, 0);
                GoodBye.Visible = true;
                this.AutoScroll=false;
                Exit.Visible = true;
                GameRestart.Visible = true;
                GameHeading.Location = new Point(160, 10);
                GameHeading.Visible = true;
            }
      }
        /// <summary>
        /// This event triggers whenever the Board gets resized.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameManager_Resize(object sender, EventArgs e)
        {
            this.Width=25*25;
            this.Height=25*25;
        }
        /// <summary>
        /// This event triggers when the user clicks start button to start the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Start_Click(object sender, EventArgs e)
        {
            Start.Visible = false;
            Instructions.Visible = false;
            GameHeading.Visible = false;
            WelcomeGame.Visible = false;
            InstructionsH.Visible = false;
            Instruction.Visible= false;
            ScreenFlag = Screens.game;
           this.Refresh();
            
        }
        /// <summary>
        /// This event occurs when the user clicks on the Instructions button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Instructions_Click(object sender, EventArgs e)
        {
            Label Instr = GView.ShowInstruction();
            Instruction.Text = Instr.Text;
            WelcomeGame.Visible = false;
            Instructions.Visible = false;
            InstructionsH.Visible = true;
            Instruction.Visible = true;
        }
        /// <summary>
        /// This event triggers as soon as the GameManager gets loaded.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameManager_Load(object sender, EventArgs e)
        {
            InstructionsH.Visible = false;
            Instruction.Visible = false;
            GoodBye.Visible = false;
            Exit.Visible = false;
            GameRestart.Visible = false;
        }
        /// <summary>
        /// This event triggers when ever the user clicks on the restart button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GameRestart_Click(object sender, EventArgs e)
        {
            GoodBye.Visible = false;
            Exit.Visible = false;
            GameRestart.Visible = false;
            GameHeading.Visible = false;
            this.BoardSize = 25;
            GmBoard = null;
            GmBoard = Board.createInstance(BoardSize);
            ScreenFlag = Screens.game;
            this.Refresh();
        }
        /// <summary>
        /// This event triggers when ever the users clicks on the exit button.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Top Left property
        /// </summary>
        public bool TopLeft
        {
            get
            {
                return IsTopLeft;
            }
            set
            {
                IsTopLeft = value;

            }
        }
        
    }
}
