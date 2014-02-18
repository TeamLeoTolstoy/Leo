using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Bunker// :GameObject, ITower
    {
        private int damage = 40;
        private int price = 60;
        private char sign = '%';
        private char[,] sizeOfElement = new char[2, 2];
        private Color color = Color.Yellow;

        public  PositionOfElement UpperLeftPoint { get; set; }

        public  char[,] SizeOfElement
        {
            get { return this.sizeOfElement; }
        }

        public  char Sign
        {
            get { return this.sign; }
        }

        public  Color Color
        {
            get { return this.color; }
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public int PriceOfTower
        {
            get { return this.price; }
        }
    }
}
