using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
  public  struct UpperLeftPoint
    {
        public int PositionX { get; set; }
        public int PositionY { get; set; }

        public UpperLeftPoint(int x, int y) : this()
        {
            this.PositionX = x;
            this.PositionY = y;
        }
    }
}
