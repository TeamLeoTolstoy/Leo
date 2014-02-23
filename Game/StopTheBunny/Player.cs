using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Player : GameObject, IMovable, IDrawable
    {
        public Player(PositionOfElement positionOfPlayer)
        {
            this.Sign = '&';
            this.SizeOfElement = new char[1, 1];
            this.PositionOfElement = positionOfPlayer;
            this.Color = ConsoleColor.Red;
        }

        public void MoveRight()
        {
            this.PositionOfElement.PositionCol++;
        }

        public void MoveLeft()
        {
            this.PositionOfElement.PositionCol--;
        }
        
        public void MoveDown()
        {
            this.PositionOfElement.PositionRow++;
        }

        public void MoveUp()
        {
            this.PositionOfElement.PositionRow--;
        }

        public void Draw()
        {
            Console.SetCursorPosition(this.PositionOfElement.PositionCol, this.PositionOfElement.PositionRow);
            Console.ForegroundColor = this.Color;
            Console.Write(this.Sign);
        }

        public void Move()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }
                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    this.MoveLeft();
                }
                if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    this.MoveRight();
                }
                if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    this.MoveUp();
                }
                if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    this.MoveDown();
                }
                if (keyPressed.Key == ConsoleKey.D)
                {
                    Turrent tur = new Turrent(new PositionOfElement(this.PositionOfElement.PositionRow, this.PositionOfElement.PositionCol));
                    
                }
            }
        }
    }
}