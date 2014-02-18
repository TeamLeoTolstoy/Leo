using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public abstract class Tower:GameObject
    {
        private int damage;
        private int priceOfTower;

        public int Damage
        {
            get { return this.damage; }
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }

                this.damage = value;
            }
        }

        public int PriceOfTower
        {
            get { return this.priceOfTower; }
            protected set
            {
                if (value<0)
                {
                    throw new ArgumentException();
                }

                this.priceOfTower = value;
            }
        }
    }
}
