namespace StopTheBunny
{
    using System;

    public class EndIcon : Logo
    {
        public EndIcon() : base(10, 7)
        {
        }
      
        public override void Print()
        {
            this.positionCol = 10;
            this.positionRow = 50; 
         
            // Console.ForegroundColor = ConsoleColor.Red;
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

        public override void PrintSelected()
        {
            this.positionCol = 10;
            this.positionRow = 50;
           
            // Console.ForegroundColor = ConsoleColor.Red;
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