namespace StopTheBunny
{
    using System;

    public class AdvancedTurret : Tower
    {
        private const int AdvTurretDamage = 6;
        private const int AdvTurretPrice = 120;
        private const int AdvTurretRange = 8;

        private static readonly char[,] Image = new char[2, 2]
        {
            { '$', '$' },
            { '$', '$' }
        };

        public AdvancedTurret(PositionOfElement position) : base(position, ConsoleColor.Yellow, Image)
        {
            this.Damage = AdvTurretDamage;
            this.PriceOfTower = AdvTurretPrice;
            this.Range = AdvTurretRange; 
        }
    }
}