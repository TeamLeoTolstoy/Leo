using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Airillery : GameObject, ITower
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

        public int Price
        {
            get { return this.price; }
        }

        public override UpperLeftPoint UpperLeftPoint { get; set; }

        public override char[,] SizeOfElement
        {
            get { throw new NotImplementedException(); }
        }

        public override char Sign
        {
            get { return this.sign; }
        }

        public override Color Color
        {
            get { return this.color; }
        }
    }
}
