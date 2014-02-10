using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempor
{
    public class Player : GameObject
    {
         public Player(char symbol, Color color)
            : base(symbol, color)
        {

        }
        public override char Symbol
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }

        public override Color Color
        {
            get
            {
                throw new NotImplementedException();
            }
            protected set
            {
                throw new NotImplementedException();
            }
        }
    }
}
