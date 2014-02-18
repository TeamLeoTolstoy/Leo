using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class Path:GameObject
    {
        private int fieldRows;
        private int fieldCols;
        public List<int> RowCoodrinates { get; set; }
        public List<int> ColCoordinates { get; set; }

        public Path(int fieldRows, int fieldCols)
        {
            this.FieldRows = fieldRows;
            this.FieldCols = fieldCols;
            this.RowCoodrinates = new List<int>();
            this.ColCoordinates = new List<int>();
            this.Sign = '=';          
        }

        public int FieldRows
        {
            get { return this.fieldRows; }
            set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }

                this.fieldRows = value;
            }
        }

        public int FieldCols
        {
            get { return this.fieldCols; }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.fieldCols = value;
            }
        }

        public void Initialize()
        {
           

        }

    }
}
