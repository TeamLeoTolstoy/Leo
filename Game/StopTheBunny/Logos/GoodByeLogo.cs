using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    class GoodByeLogo:Logo
    {
        public GoodByeLogo():base()
        {
            
        }

        public void PrintBye()
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
