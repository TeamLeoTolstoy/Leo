using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Player : GameObject, IMovable, IDrawable
    {
        public bool IsBuilding { get; set; }

        public Player(PositionOfElement positionOfPlayer)
        {
            this.ElementImage = new char[1, 1] { { 'O' } };
            this.PositionOfElement = positionOfPlayer;
            this.ForegroundColor = ConsoleColor.Red;
            this.BackgroundColor = ConsoleColor.Black;
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
    }
}