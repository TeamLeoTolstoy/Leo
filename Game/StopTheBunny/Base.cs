using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Base:GameObject
    {
        public Base(PositionOfElement positionOfElement)
        {
            this.Sign = '#';
            this.SizeOfElement = new char[3, 2];
            this.PositionOfElement = positionOfElement;
            this.Color = ConsoleColor.Gray;
        }
    }
}
