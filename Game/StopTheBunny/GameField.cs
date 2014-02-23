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
                if (value.GetLength(0) < 0 || value.GetLength(1) < 0)
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
                if (row < 0 || row > this.GetRowsInField || col < 0 || col > this.GetColsInField)
                {
                    throw new IndexOutOfRangeException();
                }

                return this.field[row, col];
            }

            set
            {
                if (row < 0 || row > this.GetRowsInField || col < 0 || col > this.GetColsInField)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value == ' ')
                {
                    throw new ArgumentException();
                }

                this.field[row, col] = value;
            }
        }
        
        public void AddElement(GameObject newElement)
        {
            if (CheckSizeOfElement(newElement) == false)
            {
                throw new IndexOutOfRangeException();
            }

            int startRow = newElement.PositionOfElement.PositionRow;
            int startCol = newElement.PositionOfElement.PositionCol;
            int sizeOfTowerInRows = newElement.SizeOfElement.GetLength(0) + newElement.PositionOfElement.PositionRow;
            int sizeOfTowerInCols = newElement.SizeOfElement.GetLength(1) + newElement.PositionOfElement.PositionCol;

            for (int row = startRow; row < sizeOfTowerInRows; row++)
            {
                for (int col = startCol; col < sizeOfTowerInCols; col++)
                {
                    this.field[row, col] = newElement.Sign;
                }
            }
        }

        private bool CheckSizeOfElement(GameObject element)
        {
            if (element.PositionOfElement.PositionRow < 0 || element.PositionOfElement.PositionRow > this.GetRowsInField ||
                element.PositionOfElement.PositionCol < 0 || element.PositionOfElement.PositionCol > this.GetColsInField)
            {
                return false;
            }
            else
            {
                int sizeOfTowerInRows = element.SizeOfElement.GetLength(0) + element.PositionOfElement.PositionRow;
                int sizeOfTowerInCols = element.SizeOfElement.GetLength(1) + element.PositionOfElement.PositionCol;

                if (sizeOfTowerInRows < 0 || sizeOfTowerInRows > this.GetRowsInField ||
                    sizeOfTowerInCols < 0 || sizeOfTowerInCols > this.GetColsInField)
                {
                    return false;
                }

                return true;
            }
        }
    }
}
