using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class CuteBunny : Bunny
    {
        public CuteBunny()
        {
            this.ForegroundColor = ConsoleColor.Red;
            this.BackgroundColor = ConsoleColor.Green;
            this.ElementImage = new char[4, 4]
                {
                    {'(', '\\', '/', ')'},
                    {'(', '.', '.', ')'},
                    {'(', '_', '_', ')'},
                    {' ', '*', '*', ' '}
                };
            this.CurrentHealth = initialHealth;
            this.PositionOfElement = Path.GetFirstPosition();
        }
    }
}
