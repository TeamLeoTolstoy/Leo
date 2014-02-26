namespace StopTheBunny
{
    using System;
    
    public abstract class Tower : GameObject, IDrawable
    {
        private int damage;
        private int priceOfTower;

        public Tower(PositionOfElement positionOfElement, ConsoleColor fColor, char[,] image)
        {
            this.PositionOfElement = positionOfElement;
            this.ElementImage = image;            
            this.ForegroundColor = fColor;
            this.BackgroundColor = ConsoleColor.Black;
        }

        public int Range { get; protected set; }

        public int Damage
        {
            get
            {
                return this.damage;
            }

            protected set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.damage = value;
            }
        }

        public int PriceOfTower
        {
            get
            {
                return this.priceOfTower;
            }

            protected set
            {
                if (value < 0)
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