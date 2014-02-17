using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class MatrixCoords
    {
        public int PositionY { get; private set; }
        public int PositionX { get; private  set; }

        public MatrixCoords(int positionY, int positionX)
        {
            this.PositionY = positionY;
            this.PositionX = positionX;
        }

        public static MatrixCoords operator + (MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.PositionY + b.PositionY, a.PositionX + b.PositionX);
        }

        public static MatrixCoords operator -(MatrixCoords a, MatrixCoords b)
        {
            return new MatrixCoords(a.PositionY - b.PositionY, a.PositionX - b.PositionX);
        }

        public override bool Equals(object obj)
        {
            MatrixCoords objAsMatrixCoords = obj as MatrixCoords;

            return objAsMatrixCoords.PositionY == this.PositionY && objAsMatrixCoords.PositionX == this.PositionX;
        }

        public override int GetHashCode()
        {
            return this.PositionY.GetHashCode() * 7 + this.PositionX;
        }
    }
}
