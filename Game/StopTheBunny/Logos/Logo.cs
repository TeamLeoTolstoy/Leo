namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Logo
    {
        private const int SizeMatrix = 21;

        private int positionCol; //= 5;
        private int positionRow;// = 30;
        private string[,] matrix;// = new string[SizeMatrix, SizeMatrix];

        public Logo()
        {
            this.positionCol = 5;
            this.positionRow = 30;
            this.matrix = new string[SizeMatrix, SizeMatrix];
        }

        public void ShowBunnyLogo()
        {
            ResetDefaultPosition();

            Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < this.matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionRow, this.positionCol);
                this.positionCol++;

                for (int col = 0; col < this.matrix.GetLength(1); col++)
                {
                    if (IsX(row, col))
                    {
                        Console.Write("X");
                    }
                    else if (row == 5 && col == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("V");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 10 && col == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("T");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if ((row == 12 || row == 18) && col == 10)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("^");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (IsUnderscore(row, col))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("_");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 18 && col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("(");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 18 && col == 18)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(")");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 18 && ((col >= 3 && col <= 8) || (col >= 12 && col <= 17)))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("_");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 15 && (col == 9 || col == 11))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\"");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 10 && ((col == 6 || col == 5) || (col == 15 || col == 14)))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("=");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (row == 8 && (col == 8 || col == 12))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write(".");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (IsLeftSlash(row, col))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("\\");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else if (IsRightSlash(row, col))
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.Write("/");
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
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

        private bool IsUnderscore(int row, int col)
        {
            if ((row == 2 && ((col == 6 || col == 7) || (col == 13 || col == 14)) ||
                                    row == 17 && ((col >= 3 && col <= 5) || (col >= 15 && col <= 17))))
            {
                return true;
            }

            return false;
        }

        private bool IsX(int row, int col)
        {
            if ((row == 0 || row == SizeMatrix - 1) && (col >= 7 && col <= 13) ||
                                    (col == 0 || col == SizeMatrix - 1) && (row >= 7 && row <= 13) ||
                                    (row == 1 || row == SizeMatrix - 2) && (col == 6 || col == 14) ||
                                    (col == 1 || col == SizeMatrix - 2) && (row == 6 || row == 14) ||
                                    (row == 2) && (col == 5 || col == 15) ||
                                    (col == 2 || col == SizeMatrix - 3) && (row == 5 || row == 15) ||
                                    (row == 3) && (col == 4 || col == 16) ||
                                    (col == 3 || col == SizeMatrix - 4) && (row == 4 || row == 16) ||
                                    (row == 17 && (col == 4 || col == 16)))
            {
                return true;
            }
            return false;
        }

        private void ResetDefaultPosition()
        {
            this.positionRow = 30;
            this.positionCol = 5;
        }

        public void Name()
        {
            ResetDefaultPosition();
            Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionRow, this.positionCol);
                this.positionRow++;
                this.positionCol++;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 5 && col == 5) || (row == 11 && col == 11))
                    {
                        Console.Write("L");
                    }
                    else if (row == 6 && col == 6)
                    {
                        Console.Write("E");
                    }
                    else if ((row == 7 && col == 7) || (row == 10 && col == 10) || (row == 14 && col == 14))
                    {
                        Console.Write("O");
                    }
                    else if ((row == 9 && col == 9) || (row == 13 && col == 13))
                    {
                        Console.Write("T");
                    }
                    else if (row == 12 && col == 12)
                    {
                        Console.Write("S");
                    }
                    else if (row == 15 && col == 15)
                    {
                        Console.Write("Y");
                    }

                }
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();

        }

        public void Bye()
        {
            Console.ForegroundColor = ConsoleColor.White;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionRow, this.positionCol);
                this.positionCol++;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (row == 5 && col == 10)
                    {
                        Console.Write("V");
                    }
                    else if (row == 10 && col == 10)
                    {
                        Console.Write("T");
                    }
                    else if ((row == 12 || row == 18) && col == 10)
                    {
                        Console.Write("^");
                    }
                    else if ((row == 2 && ((col == 6 || col == 7) || (col == 13 || col == 14)) ||
                        row == 17 && ((col >= 3 && col <= 4) || (col >= 16 && col <= 17))))
                    {
                        Console.Write("_");
                    }
                    else if (row == 18 && col == 2)
                    {
                        Console.Write("(");
                    }
                    else if (row == 18 && col == 18)
                    {
                        Console.Write(")");
                    }
                    else if (row == 18 && ((col >= 3 && col <= 8) || (col >= 12 && col <= 17)))
                    {
                        Console.Write("_");
                    }
                    else if (row == 15 && (col == 9 || col == 11))
                    {
                        Console.Write("\"");
                    }
                    else if (row == 10 && ((col == 6 || col == 5) || (col == 15 || col == 14)))
                    {
                        Console.Write("=");
                    }
                    else if (row == 8 && (col == 8 || col == 12))
                    {
                        Console.Write(".");
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
                        (row == 18 && col == 11)))
                    {
                        Console.Write("\\");
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
                        Console.Write("/");
                    }
                    else if ((row == 13 && (col == 5 || col == 6 || col == 9 || col == 11 || (col >= 13 && col <= 15)) ||
                        (row == 14 && (col == 5 || col == 7 || col == 9 || col == 11)) ||
                        ((row == 15 || row == 17) && (col == 5 || col == 6 || col == 10 || (col >= 13 && col <= 15))) ||
                        (row == 16 && (col == 5 || col == 7 || col == 10))))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("X");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
            Console.SetCursorPosition(32, 29);
            Console.WriteLine();
        }
    }
}
