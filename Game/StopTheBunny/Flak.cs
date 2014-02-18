using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Flak :GameObject, ITower
    {
        private readonly int damage;
        private readonly int priceOfElement;

        public Flak(PositionOfElement positionOfElement)
        {
            this.Sign = '$';
            this.SizeOfElement = new char[2, 2];
            this.PositionOfElement = positionOfElement;
            this.Color = Color.Green;

        }

        public int Damage
        {
            get { return this.damage; }            
        }

        public int PriceOfTower
        {
            get { return this.priceOfElement; }         
        }
    }
}
