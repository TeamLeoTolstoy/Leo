﻿namespace StopTheBunny
{
    using System;

    public class ScoreIcon : Logo
    {
        public ScoreIcon() : base(10, 7)
        {
        }

        public override void PrintSelected()
        {
            this.positionCol = 10;
            this.positionRow = 40;            


            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionRow, this.positionCol);
                this.positionCol++;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 1 && col == 5) || (row == 2 && (col == 5 || col == 6)) ||
                        (row == 1 && col == 2) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        (row == 7 && col == 1) ||
                        (row == 8 && col == 2))
                    {
                        Console.Write("\\");
                    }
                    else if ((row == 1 && col == 1) || (row == 2 && (col == 0 || col == 1)) ||
                             (row == 1 && col == 4) ||
                             (row == 2 && col == 4) ||
                             (row == 3 && col == 2) ||
                             (row == 4 && col == 4) ||
                             (row == 5 && col == 2) ||
                             (row == 7 && col == 5) ||
                             (row == 8 && col == 4))
                    {
                        Console.Write("/");
                    }
                    else if (row == 4 && col == 3)
                    {
                        Console.Write("T");
                    }
                    else if (row == 1 && (col == 1 || col == 5))
                    {
                        Console.Write("-");
                    }
                    else if (row == 9 && col == 3)
                    {
                        Console.Write("^");
                    }
                    else if (row == 4 && (col == 1 || col == 5))
                    {
                        Console.Write("=");
                    }
                    else if (row == 2 && col == 3)
                    {
                        Console.Write("V");
                    }
                    else if (row == 9 && col == 0)
                    {
                        Console.Write("(");
                    }
                    else if (row == 9 && col == 6)
                    {
                        Console.Write(")");
                    }
                    else if (row == 9 && (col == 1 || col == 2 || col == 4 || col == 5) || (row == 8 && (col == 1 || col == 5)))
                    {
                        Console.Write("_");
                    }
                    else if (row == 6 && col == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("S");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("C");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("O");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("R");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("E");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        public override void Print()
        {
            this.positionCol = 10;
            this.positionRow = 40;            

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionRow, this.positionCol);
                this.positionCol++;

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (
                        (row == 1 && (col == 1 || col == 2)) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        (row == 7 && col == 1) ||
                        (row == 8 && col == 2))
                    {
                        Console.Write("\\");
                    }
                    else if (
                             (row == 1 && (col == 4 || col == 5)) ||
                             (row == 2 && col == 4) ||
                             (row == 3 && col == 2) ||
                             (row == 4 && col == 4) ||
                             (row == 5 && col == 2) ||
                             (row == 7 && col == 5) ||
                             (row == 8 && col == 4))
                    {
                        Console.Write("/");
                    }
                    else if (row == 4 && col == 3)
                    {
                        Console.Write("T");
                    }
                    else if (row == 1 && (col == 1 || col == 5))
                    {
                        Console.Write("-");
                    }
                    else if (row == 9 && col == 3)
                    {
                        Console.Write("^");
                    }
                    else if (row == 4 && (col == 1 || col == 5))
                    {
                        Console.Write("=");
                    }
                    else if (row == 2 && col == 3)
                    {
                        Console.Write("V");
                    }
                    else if (row == 9 && col == 0)
                    {
                        Console.Write("(");
                    }
                    else if (row == 9 && col == 6)
                    {
                        Console.Write(")");
                    }
                    else if (row == 9 && (col == 1 || col == 2 || col == 4 || col == 5) || (row == 8 && (col == 1 || col == 5)) || (row == 0 && (col == 1 || col == 5)))
                    {
                        Console.Write("_");
                    }
                    else if (row == 6 && col == 1)
                    {
                        Console.Write("S");
                    }
                    else if (row == 6 && col == 2)
                    {
                        Console.Write("C");
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.Write("O");
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.Write("R");
                    }
                    else if (row == 6 && col == 5)
                    {
                        Console.Write("E");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }
    }
}