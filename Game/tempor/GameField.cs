using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempor
{
    public class GameField : GameObject
    {
         public GameField(char symbol, Color color)
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
