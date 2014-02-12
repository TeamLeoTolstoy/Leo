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
            GameField field = new GameField(30, 80);
            Console.WindowWidth = field.GetColsInField;
            Console.WindowHeight = field.GetRowsInField;
            Console.BufferHeight = field.GetRowsInField;
            Console.BufferWidth = field.GetColsInField;

            
        }
    }
}
