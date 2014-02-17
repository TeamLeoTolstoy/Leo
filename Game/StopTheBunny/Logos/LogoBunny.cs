using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using StopTheBunny.Logo;

namespace StopTheBunny.Logos
{
    public class LogoBunny : Logo, IRenderable
    {
        private int positionCol = 5;
        private int positionRow = 30;
        private const int matrixSizeCol = 21;
        private const int matrixSizeRow = 21;

        public LogoBunny()
        {
            this.TopLeft = new MatrixCoords(positionRow, positionCol);
            this.LogoMatrix= new string[this.MatRow, this.MatCol];
        }

        public override int MatRow { get { return matrixSizeRow; } }
        public override int MatCol { get { return matrixSizeCol; } }

        public override string[,] GetImage()
        {
            //string[,] matrix = new string[this.matrixSizeY, matrixSizeX];
            Console.ForegroundColor = ConsoleColor.Red;
            //Console.WriteLine(Console.WindowHeight);
            //Console.WriteLine(Console.WindowWidth);

            for (int row = 0; row < this.LogoMatrix.GetLength(0); row++)
            {
                if (this.positionCol<Console.WindowWidth && this.positionRow<Console.WindowHeight)
                {
                    Console.SetCursorPosition(this.positionRow, this.positionCol);
                    this.positionCol++;
                }

                for (int col = 0; col < this.LogoMatrix.GetLength(1); col++)
                {
                    if (IsX(row,col))
                    {
                        this.LogoMatrix[row, col] = "X";
                    }
                    else if (row == 5 && col == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "V";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 10 && col == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "T";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if ((row == 12 || row == 18) && col == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "^";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (IsUnderscore(row,col))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "_";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 18 && col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "(";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 18 && col == 18)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = ")";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 18 && ((col >= 3 && col <= 8) || (col >= 12 && col <= 17)))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "_";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 15 && (col == 9 || col == 11))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "\"";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 10 && ((col == 6 || col == 5) || (col == 15 || col == 14)))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "=";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 8 && (col == 8 || col == 12))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = ".";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (IsLeftSlash(row,col))    
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "\\";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (IsRightSlash(row,col))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        this.LogoMatrix[row, col] = "/";
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        this.LogoMatrix[row, col] = " ";
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            return this.LogoMatrix;
        }

        private bool IsX(int row, int col)
        {
            if ((row == 0 || row == matrixSizeRow - 1) && (col >= 7 && col <= 13) ||
                        (col == 0 || col == matrixSizeCol - 1) && (row >= 7 && row <= 13) ||
                        (row == 1 || row == matrixSizeRow - 2) && (col == 6 || col == 14) ||
                        (col == 1 || col == matrixSizeCol - 2) && (row == 6 || row == 14) ||
                        (row == 2) && (col == 5 || col == 15) ||
                        (col == 2 || col == matrixSizeCol - 3) && (row == 5 || row == 15) ||
                        (row == 3) && (col == 4 || col == 16) ||
                        (col == 3 || col == matrixSizeRow - 4) && (row == 4 || row == 16) ||
                        (row == 17 && (col == 4 || col == 16)))
            {
                return true;
            }

            return false;
        }

        private bool IsUnderscore(int row, int col)
        {
            if ((row == 2 && ((col == 6 || col == 7) || (col == 13 || col == 14)) ||
                        row == 17 && ((col >= 3 && col <= 5) || (col >= 15 && col <= 17))))
            {
                return true;
            }

            return false;
        }

        private bool IsLeftSlash(int row, int col)
        {
            if ((row == 3 && (col == 6 || col == 8)) ||
                        (row == 4 && (col == 7 || col == 9) ||
                        (row == 5 && col == 8) ||
                        (row == 6 && col == 12) ||
                        (row == 7 && col == 13) ||
                        (row == 8 && col == 14) ||
                        (row == 9 && col == 6) ||
                        (row == 10 && col == 7) ||
                        (row == 11 && col == 13) ||
                        (row == 12 && (col == 7 || col == 14)) ||
                        (row == 13 && (col == 6 || col == 8 || col == 15)) ||
                        (row == 14 && (col == 7 || col == 16 || col == 9)) ||
                        (row == 15 && col == 4) ||
                        (row == 16 && col == 5) ||
                        (row == 17 && col == 6) ||
                        (row == 18 && col == 11)))
            {
                return true;
            }

            return false;
        }

        private bool IsRightSlash(int row, int col)
        {
            if ((row == 3 && (col == 12 || col == 14)) ||
                        (row == 4 && (col == 11 || col == 13) ||
                        (row == 5 && col == 12) ||
                        (row == 6 && col == 8) ||
                        (row == 7 && col == 7) ||
                        (row == 8 && col == 6) ||
                        (row == 9 && col == 14) ||
                        (row == 10 && col == 13) ||
                        (row == 11 && col == 7) ||
                        (row == 12 && (col == 6 || col == 13)) ||
                        (row == 13 && (col == 5 || col == 12 || col == 14)) ||
                        (row == 14 && (col == 4 || col == 13 || col == 11)) ||
                        (row == 15 && col == 16) ||
                        (row == 16 && col == 15) ||
                        (row == 17 && col == 14) ||
                        (row == 18 && col == 9)))
            {
                return true;
            }

            return false;
        }
    }
}
