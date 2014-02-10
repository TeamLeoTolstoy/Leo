using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace tempor
{
    public abstract class GameObject
    {
        public abstract char Symbol { get; protected set; }
        public abstract Color Color { get; protected set; }

        public GameObject (char symbol, Color color)
        {
            this.Symbol = symbol;
            this.Color = color;
        }
    }
}
