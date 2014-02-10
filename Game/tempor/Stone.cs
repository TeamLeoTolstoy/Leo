using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempor
{
    public class Stone : GameObject, ICollectable
    {
        public Stone(char symbol, Color color)
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

        public int CollectablePoints
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
    }
}
