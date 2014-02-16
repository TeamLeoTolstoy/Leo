using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public static class MenuIcons
    {

        private static int sizeCol = 7;
        private static int sizeRow = 10;

        public static void Start()
        {
            int positionX = 10;
            int positionY = 20;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (
                        (row == 1 && (col == 1 || col == 2)) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        //(row == 6 && col == 5) ||
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
                        //(row == 6 && col == 1) ||
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
                    else if (row == 6 && (col == 2 || col == 5))
                    {
                        Console.Write("T");
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.Write("A");
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.Write("R");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        public static void Guide()
        {
            int positionX = 10;
            int positionY = 30;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (
                        (row == 1 && (col == 1 || col == 2)) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        //(row == 6 && col == 5) ||
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
                        //(row == 6 && col == 1) ||
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
                        Console.Write("G");
                    }
                    else if (row == 6 && col == 2)
                    {
                        Console.Write("U");
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.Write("I");
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.Write("D");
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

        public static void Score()
        {
            int positionX = 10;
            int positionY = 40;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (
                        (row == 1 && (col == 1 || col == 2)) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        //(row == 6 && col == 5) ||
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
                        //(row == 6 && col == 1) ||
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

        public static void End()
        {
            int positionX = 10;
            int positionY = 50;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if (
                        (row == 1 && (col == 1 || col == 2)) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        (row == 6 && col == 5) ||
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
                        (row == 6 && col == 1) ||
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
                    else if (row == 6 && col == 2)
                    {
                        Console.Write("E");
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.Write("N");
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.Write("D");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        public static void StartSelected()
        {
            int positionX = 10;
            int positionY = 20;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 1 && col == 5) || (row == 2 && (col == 5 || col == 6)) ||
                        (row == 1 && col == 2) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        //(row == 6 && col == 5) ||
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
                        //(row == 6 && col == 1) ||
                        (row == 7 && col == 5) ||
                        (row == 8 && col == 4))
                    {
                        Console.Write("/");
                    }
                    else if (row == 4 && col == 3)
                    {
                        Console.Write("T");
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
                    else if (row == 6 && (col == 2 || col == 5))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("T");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("A");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("R");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
            }
        }

        public static void GuideSelected()
        {
            int positionX = 10;
            int positionY = 30;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 1 && col == 5) || (row == 2 && (col == 5 || col == 6)) ||
                         (row == 1 && col == 2) ||
                         (row == 2 && col == 2) ||
                         (row == 3 && col == 4) ||
                         (row == 4 && col == 2) ||
                         (row == 5 && col == 4) ||
                        //(row == 6 && col == 5) ||
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
                        //(row == 6 && col == 1) ||
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
                        Console.Write("G");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("U");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("I");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("D");
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

        public static void ScoreSelected()
        {
            int positionX = 10;
            int positionY = 40;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 1 && col == 5) || (row == 2 && (col == 5 || col == 6)) ||
                        (row == 1 && col == 2) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        //(row == 6 && col == 5) ||
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
                        //(row == 6 && col == 1) ||
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

        public static void EndSelected()
        {
            int positionX = 10;
            int positionY = 50;
            string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    if ((row == 1 && col == 5) || (row == 2 && (col == 5 || col == 6)) ||
                        (row == 1 && col == 2) ||
                        (row == 2 && col == 2) ||
                        (row == 3 && col == 4) ||
                        (row == 4 && col == 2) ||
                        (row == 5 && col == 4) ||
                        (row == 6 && col == 5) ||
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
                        (row == 6 && col == 1) ||
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
                    else if (row == 6 && col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("E");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("N");
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("D");
                        Console.ForegroundColor = ConsoleColor.White;
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
