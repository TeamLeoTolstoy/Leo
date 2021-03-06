﻿namespace StopTheBunny
{
    public class MatrixCoords
    {
        public MatrixCoords(int positionY, int positionX)
        {
            this.PositionRow = positionY;
            this.PositionCol = positionX;
        }

        public int PositionRow { get; private set; }

        public int PositionCol { get; private set; }

        public static MatrixCoords operator +(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.PositionRow + b.PositionRow, a.PositionCol + b.PositionCol);
        }

        public static MatrixCoords operator -(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.PositionRow - b.PositionRow, a.PositionCol - b.PositionCol);
        }

        public override bool Equals(object obj)
        {
            MatrixCoords objAsMatrixCoords = obj as MatrixCoords;

            return objAsMatrixCoords.PositionRow == this.PositionRow && objAsMatrixCoords.PositionCol == this.PositionCol;
        }

        public override int GetHashCode()
        {
            return this.PositionRow.GetHashCode() * 7 + this.PositionCol;
        }
    }
}
