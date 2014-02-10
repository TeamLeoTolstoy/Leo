using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempor
{
    public class GameField 
    {
        public char[,] Field { get; set; }
        public int Rows { get; set; }
        public int Cols { get; set; }

        public GameField(char symbol, Color color, int rows, int cols)
            : base(symbol, color)
        {
            this.Field = new cha[rows, cols];
        }


        public GameField(char symbol, Color color, char[,] field)
            : base(symbol, color)
        {
            this.Field = field;
        } 

        public override char Symbol
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public override Color Color
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }
    }
}
