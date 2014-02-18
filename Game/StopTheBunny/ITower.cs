using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
   public interface ITower
    {
       int Damage { get; }
       int PriceOfTower { get; }     
    }
}
