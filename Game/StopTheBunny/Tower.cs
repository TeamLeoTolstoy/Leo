using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public abstract class Tower:GameObject, IDrawable
    {
        private int damage;
        private int priceOfTower;

        public int Range { get; protected set; }

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

        public virtual int Attack()
        {
            return this.Damage;
        }     
    }
}
