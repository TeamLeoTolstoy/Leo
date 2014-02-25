namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Logo
    {
        protected const int SizeOfMatrix = 21;
        protected const int DefaultRow = 30;
        protected const int DefaultCol = 5;

        protected int positionCol;
        protected int positionRow;
        protected string[,] matrix;

        public Logo()
        {
            this.positionCol = DefaultCol;
            this.positionRow = DefaultRow;
            this.matrix = new string[SizeOfMatrix, SizeOfMatrix];
        }

        protected void ResetDefaultPosition()
        {
            this.positionRow = DefaultRow;
            this.positionCol = DefaultCol;
        }       
    }
}
