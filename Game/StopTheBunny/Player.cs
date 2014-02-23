using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Player: GameObject
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
    }
}
