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
        
        public abstract string[,] GetImage();

        public void RenderAll()
        {
            for (int i = 0; i < this.TopLeft.PositionY; i++)
            {
                for (int j = 0; j < this.TopLeft.PositionX; j++)
                {
                    Console.Write(this.GetImage()[i,j]);
                }
                Console.WriteLine();
            }
        }


        
    }
}
