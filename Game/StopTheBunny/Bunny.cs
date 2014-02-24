using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public abstract class Bunny : GameObject, IMovable, IDrawable
    {
        protected int initialHealth;
        protected int currentHealth;

        public bool IsAlive { get; protected set; }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                if (this.currentHealth + value < 0)
                {
                    this.IsAlive = false;
                }
                currentHealth = value;
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

        //public void Draw()
        //{
        //    Console.ForegroundColor = this.Color;
        //    Console.BackgroundColor = ConsoleColor.Green;
        //    for (int row = 0; row < this.SizeOfElement.GetLength(0); row++)
        //    {
        //        for (int col = 0; col < this.SizeOfElement.GetLength(1); col++)
        //        {
        //            Console.SetCursorPosition(this.PositionOfElement.PositionCol + col, this.PositionOfElement.PositionRow + row);
        //            Console.Write(this.Sign);
        //        }
        //    }            
        //}
    }
}
