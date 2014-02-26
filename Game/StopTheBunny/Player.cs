namespace StopTheBunny
{
    using System;

    public class Player : GameObject, IDrawable
    {
        public Player(PositionOfElement positionOfPlayer)
        {
            this.ElementImage = new char[1, 1] { { 'O' } };
            this.PositionOfElement = positionOfPlayer;
            this.ForegroundColor = ConsoleColor.Red;
            this.BackgroundColor = ConsoleColor.Black;
            this.ScoreOfPlayer = new Score();
        }

        public bool IsBuilding { get; set; }

        public Score ScoreOfPlayer { get; set; }

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