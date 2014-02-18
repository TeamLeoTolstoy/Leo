using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Turrent : GameObject, ITower
    {
        private readonly int damage;
        private readonly int priceOfTower;

        public Turrent(PositionOfElement positionOfElement)
        {
            this.Sign = '@';
            this.SizeOfElement = new char[2, 2];
            this.PositionOfElement = positionOfElement;
            this.Color = Color.Blue;
            this.damage = 10;
            this.priceOfTower = 50;
        }

        public int Damage
        {
            get { return this.damage; }
        }

        public int PriceOfTower
        {
            get { return this.priceOfTower; }           
        }
    }
}
