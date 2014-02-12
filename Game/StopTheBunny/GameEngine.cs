using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    class GameEngine
    {
        static void Main(string[] args)
        {
            //Field playField = new Field(30, 80);
            //Console.ReadLine();

            Turrent testTurrent = new Turrent();           
            Console.WriteLine(testTurrent.Sign);
            Console.WriteLine(testTurrent.Price);

            Console.WriteLine(testTurrent.Damage);
            Console.WriteLine(testTurrent.SizeOfElement.GetLength(0));
        }
    }
}
