using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Cannon :GameObject
    {
         private readonly int damage;
         private readonly int priceOfTower;

        public Cannon(PositionOfElement positionOfElement)
        {
            this.Sign = '%';
            this.SizeOfElement = new char[2, 2];
            this.PositionOfElement = positionOfElement;
            this.Color = Color.Grey;
            this.damage = 20;
            this.priceOfTower = 60;
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
