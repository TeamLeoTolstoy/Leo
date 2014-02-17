using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny.Logos
{
   public  class MenuScore : Logo, ISelectable, IRenderable, IRenderer
    {
       private const int matrixSizeX = 7;
        private const int matrixSizeY = 10;

        private int positionX = 10;
        private int positionY = 70;

        public MenuScore()
            : base()
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
        //        return new string[sizeRow, sizeCol];
        //    }           
        //}

        public override int MatRow { get { return matrixSizeY; } }
        public override int MatCol { get { return matrixSizeX; } }

         public  override string[,]  GetImage()
        {
            //string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < this.LogoMatrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < this.LogoMatrix.GetLength(1); col++)
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
                        this.LogoMatrix[row, col] = "\\";
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
                        this.LogoMatrix[row, col] = "/";
                    }
                    else if (row == 4 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "T";
                    }
                    else if (row == 1 && (col == 1 || col == 5))
                    {
                        this.LogoMatrix[row, col] = "-";
                    }
                    else if (row == 9 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "^";
                    }
                    else if (row == 4 && (col == 1 || col == 5))
                    {
                        this.LogoMatrix[row, col] = "=";
                    }
                    else if (row == 2 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "V";
                    }
                    else if (row == 9 && col == 0)
                    {
                        this.LogoMatrix[row, col] = "(";
                    }
                    else if (row == 9 && col == 6)
                    {
                        this.LogoMatrix[row, col] = ")";
                    }
                    else if (row == 9 && (col == 1 || col == 2 || col == 4 || col == 5) || (row == 8 && (col == 1 || col == 5)) || (row == 0 && (col == 1 || col == 5)))
                    {
                        this.LogoMatrix[row, col] = "_";
                    }
                    else if (row == 6 && col == 1)
                    {
                        this.LogoMatrix[row, col] = "S";
                    }
                    else if (row == 6 && col == 2)
                    {
                        this.LogoMatrix[row, col] = "C";
                    }
                    else if (row == 6 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "O";
                    }
                    else if (row == 6 && col == 4)
                    {
                        this.LogoMatrix[row, col] = "R";
                    }
                    else if (row == 6 && col == 5)
                    {
                        this.LogoMatrix[row, col] = "E";
                    }
                    else
                    {
                        this.LogoMatrix[row, col] = " ";
                    }
                }
            }
            return this.LogoMatrix;
        }

         public string[,] GetImageSelected()
        {
            //string[,] matrix = new string[sizeRow, sizeCol];
            //Console.ForegroundColor = ConsoleColor.Red;

            for (int row = 0; row < this.LogoMatrix.GetLength(0); row++)
            {
                Console.SetCursorPosition(positionY, positionX++);

                for (int col = 0; col < this.LogoMatrix.GetLength(1); col++)
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
                        this.LogoMatrix[row, col] = "\\";
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
                        this.LogoMatrix[row, col] = "/";
                    }
                    else if (row == 4 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "T";
                    }
                    else if (row == 1 && (col == 1 || col == 5))
                    {
                        this.LogoMatrix[row, col] = "-";
                    }
                    else if (row == 9 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "^";
                    }
                    else if (row == 4 && (col == 1 || col == 5))
                    {
                        this.LogoMatrix[row, col] = "=";
                    }
                    else if (row == 2 && col == 3)
                    {
                        this.LogoMatrix[row, col] = "V";
                    }
                    else if (row == 9 && col == 0)
                    {
                        this.LogoMatrix[row, col] = "(";
                    }
                    else if (row == 9 && col == 6)
                    {
                        this.LogoMatrix[row, col] = ")";
                    }
                    else if (row == 9 && (col == 1 || col == 2 || col == 4 || col == 5) || (row == 8 && (col == 1 || col == 5)))
                    {
                        this.LogoMatrix[row, col] = "_";
                    }
                    else if (row == 6 && col == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.LogoMatrix[row, col] = "S";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 2)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.LogoMatrix[row, col] = "C";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 3)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.LogoMatrix[row, col] = "O";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 4)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.LogoMatrix[row, col] = "R";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else if (row == 6 && col == 5)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        this.LogoMatrix[row, col] = "E";
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        this.LogoMatrix[row, col] = " ";
                    }
                }
            
            }
            return this.LogoMatrix;
        }
    }
}
