using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class GameField //: GameObject
    {
        private char[,] field;

        public GameField(int rows, int cols)
        {
            this.field = new char[rows, cols];

            Console.WindowWidth = this.SizeCols;
            Console.WindowHeight = this.SizeRows;
            Console.BufferHeight = this.SizeRows;
            Console.BufferWidth = this.SizeCols;
        }   
     
        public int RowsInField
        {
            get { return this.field.GetLength(0); }
        }

        public int ColsInField
        {
            get { return this.field.GetLength(1); }
        }

        public char[,] Field
        {

        }
    }
}
