using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class PositionOfElement
    {
        private int positionRow;
        private int positionCol;

        public PositionOfElement(int positionRow, int postionCol)
        {
            this.PositionRow = positionRow;
            this.PositionCol = postionCol;
        }

        public int PositionRow
        {
            get { return this.positionRow; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of positionRow cannot be negative number");
                }

                this.positionRow = value;
            }
        }

        public int PositionCol
        {
            get { return this.positionCol; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The value of positionCol cannot be negative number");
                }

                this.positionCol = value;
            }
        }
    }
}
