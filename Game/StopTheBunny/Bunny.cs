namespace StopTheBunny
{
    using System;

    public class Bunny : GameObject, IMovable, IDrawable
    {
        private int currentHealth;

        public Bunny(ConsoleColor fColor, char[,] image, int initialHealth)
        {
            this.ForegroundColor = fColor;
            this.CurrentHealth = initialHealth;
            this.ElementImage = image;
            this.BackgroundColor = ConsoleColor.Green;
            this.PositionOfElement = Path.GetFirstPosition();
            this.IsAlive = true;
        }

        public bool IsAlive { get; protected set; }

        public int CurrentHealth
        {
            get
            {
                return this.currentHealth;
            }

            set
            {
                if (this.currentHealth + value < 0)
                {
                    this.IsAlive = false;
                }

                this.currentHealth = value;
            }
        }

        public void ClearPreviousPosition()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            for (int row = 0; row < this.ElementImage.GetLength(0); row++)
            {
                for (int col = 0; col < this.ElementImage.GetLength(1); col++)
                {
                    Console.SetCursorPosition(this.PositionOfElement.PositionCol + col, this.PositionOfElement.PositionRow + row);
                    Console.Write(' ');
                }
            }

            Console.ResetColor();
        }

        public void Move()
        {
            this.PositionOfElement = Path.GetNextPosition(this.PositionOfElement);
        }

        public override void Draw()
        {
            Console.ForegroundColor = this.ForegroundColor;
            Console.BackgroundColor = this.BackgroundColor;
            for (int row = 0; row < this.ElementImage.GetLength(0); row++)
            {
                for (int col = 0; col < this.ElementImage.GetLength(1); col++)
                {
                    Console.SetCursorPosition(this.PositionOfElement.PositionCol + col, this.PositionOfElement.PositionRow + row);
                    Console.Write(this.ElementImage[row, col]);
                }
            }
        }
    }
}