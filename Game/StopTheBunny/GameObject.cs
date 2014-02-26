namespace StopTheBunny
{
    using System;

    public abstract class GameObject : IDrawable
    {
        private PositionOfElement positionOfElement;
        private char[,] elementImage;
        private ConsoleColor foregroundColor;
        private ConsoleColor backgroundColor;       

        public PositionOfElement PositionOfElement
        {
            get 
            { 
                return this.positionOfElement; 
            }

            set
            {
                // TODO: Proverka dali e v poleto
                this.positionOfElement = value;
            }
        }

        public char[,] ElementImage
        {
            get 
            { 
                return this.elementImage; 
            }

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

                // TODO:Proverka dali ne e po golqmo ot poleto
                this.elementImage = value;
            }
        }

        public ConsoleColor ForegroundColor
        {
            get
            {
                return this.foregroundColor;
            }

            set
            {
                this.foregroundColor = value;
            }
        }

        public ConsoleColor BackgroundColor
        {
            get
            {
                return this.backgroundColor;
            }

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
            for (int row = 0; row < this.ElementImage.GetLength(0); row++)
            {
                for (int col = 0; col < this.ElementImage.GetLength(1); col++)
                {
                    Console.SetCursorPosition(col + this.PositionOfElement.PositionCol, row + this.PositionOfElement.PositionRow);
                    Console.ForegroundColor = this.ForegroundColor;
                    Console.Write(this.ElementImage[row, col]);
                }
            }

            // Console.ResetColor();
        }
    }
}