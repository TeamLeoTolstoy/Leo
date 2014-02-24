using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Turret : Tower
    {
        private const int DAMAGE = 3;
        private const int PRICEOFTOWER = 50;

        public Turret(PositionOfElement positionOfElement)
        {
            this.ElementImage = new char[2, 2]
                {
                    {'*', '*'},
                    {'*', '*'}
                };
            this.PositionOfElement = positionOfElement;
            this.ForegroundColor = ConsoleColor.Blue;
            this.BackgroundColor = ConsoleColor.Black;
            this.Damage = DAMAGE;
            this.PriceOfTower = PRICEOFTOWER;
            this.Range = 6;
        }
    }
}
