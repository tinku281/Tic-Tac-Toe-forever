//Singleton Board Class
using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ComputerGamesRUS.Game
{
    class Board
    {
        const int CellSize = 25;
        const int CoinCount = 5;
        static Board Instance=null;
        int Size;
        Symbol[,] SymbolLocation;
        /// <summary>
        /// Default Private constructor for Board Class.
        /// </summary>
        /// <param name="size"></param>
        Board(int size)
        {
            this.Size = size;
            Clear();
        }
        /// <summary>
        /// This method creates the instance of the Board Class.
        /// </summary>
        /// <param name="size"></param>
        /// <returns>Board object</returns>
       public static Board createInstance(int size)
       {
           if (Instance == null)
           {
               Instance = new Board(size);
               Instance.Size = size;

           }
           return Instance;

       }
        /// <summary>
        /// Getter and setter methods for SymbolLocation.
        /// </summary>
        public Symbol[,] SymbolStore
       {
           get
           {
               return SymbolLocation;
           }
           set
           {
               SymbolLocation = value;
           
           }
        }
        /// <summary>
        /// Overloaded method of Board with out BoardSize
        /// </summary>
        /// <returns>Board object</returns>
       public static Board createInstance()
       {

           return Instance;

       }


        /// <summary>
        /// Getter and Setter methods for Boardsize.
        /// </summary>
          
        public int BoardSize {
            get { 
            return Size; 
            }
            set
            {
                Size = value;
            }
        }
        /// <summary>
        /// This method places the symbol at a particular location
        /// </summary>
        /// <param name="Coin"></param>
        /// <param name="position"></param>

        public void PutSymbol(Symbol Coin, Point position) {
            if (IsOutofBounds(position.X, position.Y))
                MessageBox.Show("Out of Bounds");
            this.SymbolLocation[position.X, position.Y] = Coin;
        }

        /// <summary>
        /// This method returns the symbol at a particular location.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        public Symbol GetSymbol(Point position) {
            if (IsOutofBounds(position.X, position.Y))
                return Symbol.blank;
            return this.SymbolLocation[position.X, position.Y];

             }
        /// <summary>
        /// This method checks if the given coordinates are out of bounds of the board size.
        /// </summary>
        /// <param name="locX"></param>
        /// <param name="locY"></param>
        /// <returns>boolean</returns>

        public bool IsOutofBounds(int locX, int locY) {
            if (locX < 0 || (locX > (BoardSize - 1)) || locY < 0 || (locY > (BoardSize - 1)))
                return true;
            else
                return false;
        }

        /// <summary>
        /// This method creates a set of coordinates for the given boardsize.
        /// </summary>
        /// <returns>Point</returns>
         public IEnumerable<Point> CreatePoint() {
            for(int y = 0; y < BoardSize; y++) {
                for(int x = 0; x < BoardSize; x++) {
                   yield return new Point(x, y);
                }
            }
        }
        /// <summary>
        /// This method creates a new instance of the Symbol SymbolLocation to store the symbols.
        /// </summary>
        public void Clear() {
            this.SymbolLocation = new Symbol[Size, Size];
        }
        /// <summary>
        /// This methods draws the playing grid of given size.
        /// </summary>
        /// <param name="g"></param>
       public void DrawBoard(Graphics g)
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
  
            foreach (Point position in CreatePoint())
            {
                DrawCell(g, position);
                if (GetSymbol(position) == Symbol.Oval)
                    PaintSymbolO(g, position);
                if (GetSymbol(position) == Symbol.Cross)
                    PaintSymbolX(g, position);
            }

        }
        /// <summary>
        /// This method draws a single cell(rectangle) at a given poistion.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="position"></param>
        void DrawCell(Graphics g, Point position)
        {
            Rectangle rect = GetCellRectangle(position);
            g.FillRectangle(Brushes.GhostWhite, rect);
            g.DrawRectangle(Pens.Black, rect);

        }
        /// <summary>
        /// This method draws the symbol O at a given location.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="position"></param>
        void PaintSymbolO(Graphics g, Point position)
        {
            g.DrawString("O", new Font("calibri", 15), Brushes.Black, GetSymbolRectangle(position));
        }
        /// <summary>
        /// This method draws a symbol X at a given location.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="position"></param>
        void PaintSymbolX(Graphics g, Point position)
        {
            g.DrawString("X", new Font("calibri", 15), Brushes.Black, GetSymbolRectangle(position));
        }
        /// <summary>
        /// This method returns a rectangle for the given position.
        /// </summary>
        /// <param name="position"></param>
        /// <returns>Rectangle</returns>
        public Rectangle GetCellRectangle(Point position)
        {
            return new Rectangle(position.X * CellSize, position.Y * CellSize, CellSize, CellSize);
        }
        /// <summary>
        /// This method returns a rectangle to where the symbol needs to be placed.
        /// </summary>
        /// <param name="location"></param>
        /// <returns>Rectangle</returns>
        public Rectangle GetSymbolRectangle(Point location)
        {
            Rectangle result = GetCellRectangle(location);
            result.Inflate(-3, -3);
            return result;
        }
        /// <summary>
        /// Create a Memento object.
        /// </summary>
        /// <returns></returns>
        public Object CreateMemento()
        {
            return (Object)new Memento(SymbolLocation);
        }
        /// <summary>
        /// Set the current state of the memento object.
        /// </summary>
        /// <param name="temp"></param>
        /// <param name="m"></param>
        public void setMemento(Object m)
        {
            Memento mem = (Memento)m;
            Symbol[,] state = mem.GetState();
            SymbolLocation = state;
         }
        /// <summary>
        /// A private class for Memento.
        /// </summary>
        private class Memento
        {
            Symbol[,] csMemento;
            /// <summary>
            /// Stores the state of symbols in memento object.
            /// </summary>
            /// <param name="state"></param>
            public Memento(Symbol[,] state)
            {
                csMemento = state;
            }
            /// <summary>
            /// Gets the state of symbols in the memento object.
            /// </summary>
            /// <returns></returns>
            public Symbol[,] GetState()
            {
                return csMemento;
            }
            
           
        }
    }
        
   }
