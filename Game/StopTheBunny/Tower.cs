using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public abstract class  Tower : GameObject
    {
        public abstract int Damage { get; }

        public abstract int Price { get; }        
        
        public override UpperLeftPoint UpperLeftPoint
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public override char[,] SizeOfElement { get; set; }


        public override char Sign 
        {
            get { throw new NotImplementedException(); }
        }


        public override Color Color { get; set; }

    }
}
