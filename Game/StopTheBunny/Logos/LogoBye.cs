using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny.Logos
{
    public class LogoBye : Logo, IRenderable
    {

        private int positionX = 5;
        private int positionY = 30;
        private const int matrixSizeX = 21;
        private const int matrixSizeY = 21;

        //public LogoBye(MatrixCoords topLeft, string[,] logoMatrix)
        //    : base(topLeft, logoMatrix)
        //{

        //}
        public LogoBye():base()
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
        //        return new string[matrixSizeY, matrixSizeX];
        //    }
        //}

        public override int MatRow { get { return matrixSizeY; } }
        public override int MatCol { get { return matrixSizeX; } }


        public override string[,] GetImage()
        {
            //string[,] matrix = new string[this.MatrixSizeY, this.MatrixSizeX];
            Console.ForegroundColor = ConsoleColor.White;

            for (int row = 0; row < this.LogoMatrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionY, this.positionX++);

                for (int col = 0; col < this.LogoMatrix.GetLength(1); col++)
                {
                    if (row == 5 && col == 10)
                    {
                        this.LogoMatrix[row, col] = "V";
                    }
                    else if (row == 10 && col == 10)
                    {
                        this.LogoMatrix[row, col] = "T";
                    }
                    else if ((row == 12 || row == 18) && col == 10)
                    {
                        this.LogoMatrix[row, col] = "^";
                    }
                    else if ((row == 2 && ((col == 6 || col == 7) || (col == 13 || col == 14)) ||
                        row == 17 && ((col >= 3 && col <= 4) || (col >= 16 && col <= 17))))
                    {
                        this.LogoMatrix[row, col] = "_";
                    }
                    else if (row == 18 && col == 2)
                    {
                        this.LogoMatrix[row, col] = "(";
                    }
                    else if (row == 18 && col == 18)
                    {
                        this.LogoMatrix[row, col] = ")";
                    }
                    else if (row == 18 && ((col >= 3 && col <= 8) || (col >= 12 && col <= 17)))
                    {
                        this.LogoMatrix[row, col] = "_";
                    }
                    else if (row == 15 && (col == 9 || col == 11))
                    {
                         this.LogoMatrix[row, col] = "\"";
                    }
                    else if (row == 10 && ((col == 6 || col == 5) || (col == 15 || col == 14)))
                    {
                         this.LogoMatrix[row, col] = "=";
                    }
                    else if (row == 8 && (col == 8 || col == 12))
                    {
                        this.LogoMatrix[row, col] = ".";
                    }
                    else if (
                        (row == 3 && (col == 6 || col == 8)) ||
                        (row == 4 && (col == 7 || col == 9) ||
                        (row == 5 && col == 8) ||
                        (row == 6 && col == 12) ||
                        (row == 7 && col == 13) ||
                        (row == 8 && col == 14) ||
                        (row == 9 && col == 6) ||
                        (row == 10 && col == 7) ||
                        (row == 11 && col == 13) ||
                        (row == 12 && (col == 7 || col == 14)) ||
                        (row == 13 && col == 8) ||
                        (row == 14 && col == 16) ||
                        (row == 15 && col == 4) ||
                        //(row == 16 && col == 5) ||
                        //(row == 17 && col == 6) ||
                        (row == 18 && col == 11)))
                    {
                         this.LogoMatrix[row, col] = "\\";
                    }
                    else if (
                        (row == 3 && (col == 12 || col == 14)) ||
                        (row == 4 && (col == 11 || col == 13) ||
                        (row == 5 && col == 12) ||
                        (row == 6 && col == 8) ||
                        (row == 7 && col == 7) ||
                        (row == 8 && col == 6) ||
                        (row == 9 && col == 14) ||
                        (row == 10 && col == 13) ||
                        (row == 11 && col == 7) ||
                        (row == 12 && (col == 6 || col == 13)) ||
                        (row == 13 && col == 12) ||
                        (row == 14 && (col == 4 || col == 13)) ||
                        (row == 15 && col == 16) ||
                        (row == 16 && col == 15) ||
                        //(row == 17 && col == 14) ||
                        (row == 18 && col == 9)))
                    {
                         this.LogoMatrix[row, col] = "/";
                    }
                    else if ((row == 13 && (col == 5 || col == 6 || col == 9 || col == 11 || (col >= 13 && col <= 15)) ||
                        (row == 14 && (col == 5 || col == 7 || col == 9 || col == 11)) ||
                        ((row == 15 || row == 17) && (col == 5 || col == 6 || col == 10 || (col >= 13 && col <= 15))) ||
                        (row == 16 && (col == 5 || col == 7 || col == 10))))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                         this.LogoMatrix[row, col] = "X";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                         this.LogoMatrix[row, col] = " ";
                    }
                }
            }
            Console.SetCursorPosition(32, 29);
            return this.LogoMatrix;
        }
    }
}
