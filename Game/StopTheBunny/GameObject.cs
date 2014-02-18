using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public abstract class GameObject
    {
        private char sign;
        private Color color;
        private char[,] sizeOfElement;
        private PositionOfElement positionOfElement;

        public PositionOfElement PositionOfElement
        {
            get { return this.positionOfElement; }
            set
            {
                //TODO: Proverka dali e v poleto
                this.positionOfElement = value;
            }
        }

        public char[,] SizeOfElement
        {
            get { return this.sizeOfElement; }
             set
            {
                if (value == null)
                {
                    throw new ArgumentException("The value of sizeOfElement cannot be null");
                }
                if (value.GetLength(0) == 0 || value.GetLength(1) == 0)
                {
                    throw new ArgumentException("The dimensions of sizeOfElement cannot be 0");
                }
                //TODO:Proverka dali ne e po golqmo ot poleto

                this.sizeOfElement = value;
            }
        }

        public char Sign
        {
            get { return this.sign; }
             set
            {
                if (value==null)
                {
                    throw new  ArgumentNullException("The sign of element cannot be null");
                }
                if (value==' ')
                {
                    throw new ArgumentException("The sign of element cannot be whitespace");
                }

                this.sign = value;
            }
        }

        public Color Color
        {
            get { return this.color; }
            set
            {
                if (value==null)
                {
                    throw new ArgumentNullException("The color cannot be null");
                }

                this.color = value;
            }
        }

    }
}
