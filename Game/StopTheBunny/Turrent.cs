using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Turrent : Tower
    {
        private const int DAMAGE = 10;
        private const int PRICEOFTOWER = 50;

        public Turrent(PositionOfElement positionOfElement)
        {
            this.Sign = '@';
            this.SizeOfElement = new char[2, 2];
            this.PositionOfElement = positionOfElement;
            this.Color = Color.Blue;
            this.Damage = DAMAGE;
            this.PriceOfTower = PRICEOFTOWER;
        }
    }
}
