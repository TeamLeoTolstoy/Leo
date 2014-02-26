namespace StopTheBunny
{
    using System;

    public class Turret : Tower
    {
        private const int TurretDamage = 3;
        private const int TurretPrice = 50;
        private const int TurretRange = 6;
        private static readonly char[,] Image = new char[2, 2]
        {
            { '*', '*' },
            { '*', '*' }
        };

        public Turret(PositionOfElement position) : base(position, ConsoleColor.Blue, Image)
        {
            this.Damage = TurretDamage;
            this.PriceOfTower = TurretPrice;
            this.Range = TurretRange;
        }
    }
}