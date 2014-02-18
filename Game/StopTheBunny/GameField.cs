using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class GameField 
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

        public char this[int row, int col]
        {
            get 
            {
                if (row<0 || row>this.GetRowsInField || col<0 || col>this.GetColsInField)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.field[row,col]; 
            }

            set
            {
                if (row < 0 || row > this.GetRowsInField || col < 0 || col > this.GetColsInField)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value==' ')
                {
                    throw new ArgumentException();
                }

                this.field[row, col] = value;
            }
        }

        public void AddTower(Tower tower)
        {
            if (tower.PositionOfElement.PositionRow < 0 || tower.PositionOfElement.PositionRow > this.GetRowsInField ||
                tower.PositionOfElement.PositionCol < 0 || tower.PositionOfElement.PositionCol > this.GetColsInField)
            {
                throw new IndexOutOfRangeException();
            }

            int sizeOfTowerInRows = tower.SizeOfElement.GetLength(0) + tower.PositionOfElement.PositionRow;
            int sizeOfTowerInCols = tower.SizeOfElement.GetLength(1) + tower.PositionOfElement.PositionCol;

            if (sizeOfTowerInRows<0 || sizeOfTowerInRows>this.GetRowsInField || 
                sizeOfTowerInCols<0 || sizeOfTowerInCols>this.GetColsInField)
            {
                throw new IndexOutOfRangeException();
            }

            int startRow = tower.PositionOfElement.PositionRow;
            int startCol = tower.PositionOfElement.PositionCol;

            for (int row =startRow ; row < sizeOfTowerInRows; row++)
            {
                for (int col = startCol; col < sizeOfTowerInCols; col++)
                {
                    this.field[row, col] = tower.Sign;
                }
            }
        }
    }
}
