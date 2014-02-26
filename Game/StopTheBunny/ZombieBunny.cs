using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class ZombieBunny : Bunny
    {
        private static readonly char[,] image = new char[4, 4]
                {
                    {'(', '\\', '/', ')'},
                    {'(', '*', '*', ')'},
                    {'(', '_', '_', ')'},
                    {' ', '*', '*', ' '}
                };

        public ZombieBunny() : base(ConsoleColor.DarkGray, image, 150)
        {
        }
    }
}
