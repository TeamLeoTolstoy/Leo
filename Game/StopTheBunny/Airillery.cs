using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Airillery //: GameObject, ITower
    {
        private int damage = 60;
        private int price = 90;
        private char sign = '/';
        private char[,] sizeOfElement = new char[2, 2];
        private Color color = Color.Red;

        public int Damage
        {
            get { return this.damage; }
        }

        public int PriceOfTower
        {
            get { return this.price; }
        }

        public  PositionOfElement UpperLeftPoint { get; set; }

        public  char[,] SizeOfElement
        {
            get { throw new NotImplementedException(); }
        }

        public  char Sign
        {
            get { return this.sign; }
        }

        public  Color Color
        {
            get { return this.color; }
        }
    }
}
