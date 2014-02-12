using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class GameField //: GameObject
    {
        private char[,] field;

        public GameField(int rows, int cols)
        {
            this.Field = new char[rows, cols];            
        }   
     
        public int GetRowsInField
        {
            get { return this.Field.GetLength(0); }
        }

        public int GetColsInField
        {
            get { return this.Field.GetLength(1); }
        }

        public char[,] Field
        {
            get { return this.field; }
            set
            {
                if (value.GetLength(0)<0 || value.GetLength(1)<0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.field = value;
            }

        }

        public void AddTower(Tower newTower)
        {
            int towerRow = newTower.UpperLeftPoint.PositionY;
            int towerCol = newTower.UpperLeftPoint.PositionX;

            for (int row = 0; row < newTower.SizeOfElement.GetLength(0); row++)
            {
                for (int col = 0; col < newTower.SizeOfElement.GetLength(1); col++)
                {
                    this.Field[towerRow + row, towerCol + col] = newTower.Sign;
                }
            }
        }
    }
}
