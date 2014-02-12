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
            this.Field = new char[rows, cols];

            
        }   
     
        public int GetRowsInField
        {
            get { return this.Field.GetLength(0); }
        }

        public int GetColsInField
        {
            get { return this.Field.GetLength(1); }
        }

        public char[,] Field
        {
            get { return this.field; }
            set
            {
                if (value.GetLength(0)<0 || value.GetLength(1)<0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.field = value;
            }

        }
    }
}
