using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    interface ITower
    {
        int Damage { get; }
        int Price { get; }
        UpperLeftPoint UpperLeftPoint { get; set; }
        char[,] SizeOfElement { get; set; }
        char Sign { get; }
         Color Color { get;}
    }
}
