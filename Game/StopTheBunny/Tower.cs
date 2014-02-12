using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public abstract class  Tower : GameObject
    {
        public abstract int Damage { get; set; }

        public abstract int Price { get; set; }

        public override char Sign { get; set; }

        public override Color Color { get; set; }

        public override int NumberOfCols { get; set; }

        public override int NumberOfRowss { get; set; }

        public virtual char[,] Fire()
        {

        }

    }
}
