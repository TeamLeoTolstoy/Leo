using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public struct PathPoint
    {
        public int PositionRow { get; set; }
        public int PositionCol { get; set; }

        public PathPoint(int row, int col)
            : this()
        {
            this.PositionRow = row;
            this.PositionCol = col;
        }
    }
}
