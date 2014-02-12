using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Turrent : GameObject, ITower
    {
        private int damage = 50;
        private int price = 100;
        private char sign = '#';
        private char[,] sizeOfElement = new char[2, 2];
        private Color color = Color.Red;

        public override char[,] SizeOfElement
        {
            get
            {
                return this.sizeOfElement;
            }
        }

        public override UpperLeftPoint UpperLeftPoint { get; set; }

        public int Damage
        {
            get
            {
                return this.damage;
            }
        }

        public int Price
        {
            get
            {
                return this.price;
            }
        }

        public override char Sign
        {
            get
            {
                return this.sign;
            }
        }

        public override Color Color
        {
            get
            {
                return this.color;
            }
        }
    }
}
