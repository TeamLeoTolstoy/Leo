using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class MenuIcons
    {
        private int sizeCol;
        private int sizeRow;
        private int positionX;
        private int positionY;

        public MenuIcons()
        {
            this.sizeRow = 10;
            this.sizeCol = 7;
        }

        public void StartSelected()
        {
            this.positionX = 10;
            this.positionY = 20;
            string[,] matrix = new string[10, 7];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionY, this.positionX);
                this.positionX++;

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

        public void GuideSelected()
        {
            this.positionX = 10;
            this.positionY = 30;
            string[,] matrix = new string[10, 7];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionY, this.positionX);
                this.positionX++;

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

        public void ScoreSelected()
        {
            this.positionX = 10;
            this.positionY = 40;
            string[,] matrix = new string[10, 7];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionY, this.positionX);
                this.positionX++;

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

        public void EndSelected()
        {
            this.positionX = 10;
            this.positionY = 50;
            string[,] matrix = new string[10, 7];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(this.positionY, this.positionX);
                this.positionX++;

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
