using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public abstract class GameObject : IDrawable
    {
        private PositionOfElement positionOfElement;
        private char[,] sizeOfElement;
        private char sign;
        private ConsoleColor foregroundColor;
        private ConsoleColor backgroundColor;       

        public PositionOfElement PositionOfElement
        {
            get { return this.positionOfElement; }
            set
            {
                //TODO: Proverka dali e v poleto
                this.positionOfElement = value;
            }
        }

        public char[,] SizeOfElement
        {
            get { return this.sizeOfElement; }
             set
            {
                if (value == null)
                {
                    throw new ArgumentException("The value of sizeOfElement cannot be null");
                }
                if (value.GetLength(0) == 0 || value.GetLength(1) == 0)
                {
                    throw new ArgumentException("The dimensions of sizeOfElement cannot be 0");
                }
                //TODO:Proverka dali ne e po golqmo ot poleto

                this.sizeOfElement = value;
            }
        }

        public char Sign
        {
            get { return this.sign; }
             set
            {
                this.sign = value;
            }
        }

        public ConsoleColor ForegroundColor
        {
            get { return this.foregroundColor; }
            set
            {
                this.foregroundColor = value;
            }
        }

        public ConsoleColor BackgroundColor
        {
            get { return this.backgroundColor; }
            set
            {
                this.backgroundColor = value;
            }
        }

        public virtual void Draw()
        {
            Console.SetCursorPosition(this.PositionOfElement.PositionCol, this.PositionOfElement.PositionRow);
            Console.ForegroundColor = this.ForegroundColor;
            Console.BackgroundColor = this.backgroundColor;
            for (int row = this.PositionOfElement.PositionRow; row < this.PositionOfElement.PositionRow + this.SizeOfElement.GetLength(0); row++)
            {
                for (int col = this.PositionOfElement.PositionCol; col < this.PositionOfElement.PositionCol + this.SizeOfElement.GetLength(1); col++)
                {
                    Console.SetCursorPosition(col, row);
                    Console.ForegroundColor = this.ForegroundColor;
                    Console.Write(this.Sign);
                }
            }
            //Console.ResetColor();
        }
    }
}
