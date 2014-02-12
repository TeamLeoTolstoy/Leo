using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Turrent : GameObject, ITower
    {
        private int damage=50;
        private int price = 100;
        private char sign = '#';
        private char[,] sizeOfElement = new char[2, 2];
        private Color color = Color.Red;

        public char[,] SizeOfElement
        {
            get
            {
                return this.sizeOfElement;
            }
        }
        public override int Damage
        {
            get
            {
                return this.damage;
            }
        }

        public override int Price
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

        public UpperLeftPoint UpperLeftPoint { get; set; }
   
        public Color Color
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }
    }
}
