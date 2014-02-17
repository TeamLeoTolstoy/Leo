using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny.Logos
{
    public class LogoName:Logo, IRenderable
    {

        private int positionX = 5;
        private int positionY = 30;
        private const int matrixSizeX = 21;
        private const int matrixSizeY = 21;

        //public LogoName(MatrixCoords topLeft, string[,] logoMatrix)
        //    : base(topLeft, logoMatrix)
        //{

        //}

        public LogoName():base()
        {

        }


        //public override MatrixCoords TopLeft
        //{
        //    get
        //    {
        //        return new MatrixCoords(this.positionY, this.positionX);
        //    }
        //    set
        //    {
        //        // WHAT????????????????????????????
        //    }
        //}

        //public override string[,] LogoMatrix
        //{
        //    get
        //    {
        //        return new string[matrixSizeY,matrixSizeX];
        //    }           
        //}

        public override int MatRow { get { return matrixSizeY; } }
        public override int MatCol { get { return matrixSizeX; } }

        public override string[,] GetImage()
        {
            //string[,] matrix = new string[this.MatrixSizeY, this.MatrixSizeX];
            Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < this.LogoMatrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionY++, this.positionX++);

                for (int col = 0; col < this.LogoMatrix.GetLength(1); col++)
                {
                    if ((row == 5 && col == 5) || (row == 11 && col == 11))
                    {
                         this.LogoMatrix[row, col] = "L";
                    }
                    else if (row == 6 && col == 6)
                    {
                         this.LogoMatrix[row, col] = "E";
                    }
                    else if ((row == 7 && col == 7) || (row == 10 && col == 10) || (row == 14 && col == 14))
                    {
                         this.LogoMatrix[row, col] = "O";
                    }
                    else if ((row == 9 && col == 9) || (row == 13 && col == 13))
                    {
                         this.LogoMatrix[row, col] = "T";
                    }
                    else if (row == 12 && col == 12)
                    {
                         this.LogoMatrix[row, col] = "S";
                    }
                    else if (row == 15 && col == 15)
                    {
                         this.LogoMatrix[row, col] = "Y";
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            return this.LogoMatrix;
        }
    }
}