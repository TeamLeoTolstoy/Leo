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

        //public void Draw()
        //{
        //    Console.SetCursorPosition(this.PositionOfElement.PositionCol, this.PositionOfElement.PositionRow);
        //    Console.ForegroundColor = this.Color;
        //    Console.BackgroundColor = ConsoleColor.White;
        //    for (int row = this.PositionOfElement.PositionRow; row < this.PositionOfElement.PositionRow + this.SizeOfElement.GetLength(0); row++)
        //    {
        //        for (int col = this.PositionOfElement.PositionCol; col < this.PositionOfElement.PositionCol + this.SizeOfElement.GetLength(1); col++)
        //        {
        //            Console.SetCursorPosition(col, row);
        //            Console.ForegroundColor = this.Color;
        //            Console.Write(this.Sign);
        //        }
        //    }
        //    Console.ResetColor();
        //}
    }
}
