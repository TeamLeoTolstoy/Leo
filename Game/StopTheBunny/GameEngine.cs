using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    class GameEngine
    {
        static void Print(GameField field)
        {
            for (int i = 0; i < field.GetRowsInField; i++)
            {
                for (int j = 0; j < field.GetColsInField; j++)
                {
                    Console.Write(field.Field[i,j]);
                }

                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            GameField field = new GameField(20, 60);
            Turrent newTower = new Turrent();
            field.AddTower(newTower);
            Print(field);
            Console.WindowWidth = field.GetColsInField;
            Console.WindowHeight = field.GetRowsInField;
            Console.BufferHeight = field.GetRowsInField;
            Console.BufferWidth = field.GetColsInField;           

            
        }
    }
}
