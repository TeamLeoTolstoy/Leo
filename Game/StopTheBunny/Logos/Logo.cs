namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public abstract class Logo : IRenderable, IRenderer
    {
        //private int posX;
        //private int posY;

        private MatrixCoords topLeft;
        private string[,] logoMatrix;

        public abstract int MatRow { get; }
        public abstract int MatCol { get; }
        public abstract string[,] GetImage();

        //public Logo()
        //{
        //    this.TopLeft = topLeft;
        //    this.LogoMatrix = new string[this.MatRow, this.MatCol];
        //}

        //public Logo(MatrixCoords topLeft, string[,] logoMatrix):this()
        //{
        //    //this.TopLeft = topLeft;
        //    //this.LogoMatrix = logoMatrix;
        //}

        public  MatrixCoords TopLeft
        {
            get
            {
                return this.topLeft;//new MatrixCoords(this.posY, this.posX);
            }
            set
            {
                this.topLeft = value;
            }
        } 

        public string[,] LogoMatrix 
        { 
            get
            {
                return this.logoMatrix;
            }
            set
            {
                this.logoMatrix = value;
            }
        }

        public void RenderAll()
        {
            for (int row = 0; row < this.TopLeft.PositionY; row++)
            {
                for (int col = 0; col < this.TopLeft.PositionX; col++)
                {
                    Console.Write(this.GetImage()[row,col]);
                }
                Console.WriteLine();
            }
        }       
    }
}
