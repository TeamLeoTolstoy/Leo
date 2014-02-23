using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class Bunny : GameObject, IMovable, IDrawable
    {
        private static int initialHealth;
        private int currentHealth;

        public Bunny()
        {
            this.Color = ConsoleColor.Red;
            this.Sign = '@';
            this.SizeOfElement = new char[1,1];
            this.CurrentHealth = initialHealth;
            this.PositionOfElement = Path.GetFirstPosition();
        }

        public int CurrentHealth
        {
            get
            {
                return currentHealth;
            }
            set
            {
                currentHealth = value;
            }
        }

        public void ClearPreviousPosition()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            for (int row = 0; row < this.SizeOfElement.GetLength(0); row++)
            {
                for (int col = 0; col < this.SizeOfElement.GetLength(1); col++)
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

        public void Draw()
        {
            Console.ForegroundColor = this.Color;
            Console.BackgroundColor = ConsoleColor.Green;
            for (int row = 0; row < this.SizeOfElement.GetLength(0); row++)
            {
                for (int col = 0; col < this.SizeOfElement.GetLength(1); col++)
                {
                    Console.SetCursorPosition(this.PositionOfElement.PositionCol + col, this.PositionOfElement.PositionRow + row);
                    Console.Write(this.Sign);
                }
            }            
        }
    }
}
