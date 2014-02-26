namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// Base class for logos
    /// </summary>
    public class Logo
    {
        protected const int SizeOfMatrix = 21;
        protected const int DefaultRow = 30;
        protected const int DefaultCol = 5;

        protected int positionCol;
        protected int positionRow;
        protected string[,] matrix;

        public bool IsSelected { get; set; }

        public Logo()
        {
            this.positionCol = DefaultCol;
            this.positionRow = DefaultRow;
            this.matrix = new string[SizeOfMatrix, SizeOfMatrix];
        }

        public Logo(int matrixRows, int matrixCols)
            : this()
        {
            this.matrix = new string[matrixRows, matrixCols];
        }

        /// <summary>
        /// Reset default position of positionRow and positionCol
        /// </summary>
        protected void ResetDefaultPosition()
        {
            this.positionRow = DefaultRow;
            this.positionCol = DefaultCol;
        }

        public virtual void Print()
        {

        }

        public virtual void PrintSelected()
        {

        }
    }
}
