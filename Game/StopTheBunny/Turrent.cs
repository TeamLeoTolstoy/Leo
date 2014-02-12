using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Turrent : Tower
    {
        private int damage=50;
        private int price = 100;
        private char sign = '#';

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
    }
}
