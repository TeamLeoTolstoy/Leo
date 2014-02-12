using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Field //: GameObject
    {
        public readonly int SizeRows;
        public readonly int SizeCols;

        public Field(int rows, int cols)
        {
            this.SizeRows = rows;
            this.SizeCols = cols;
            Console.WindowWidth = this.SizeCols;
            Console.WindowHeight = this.SizeRows;
            Console.BufferHeight = this.SizeRows;
            Console.BufferWidth = this.SizeCols;
        }        
    }
}
