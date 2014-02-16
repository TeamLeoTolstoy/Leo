using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
            Airillery testTower = new Airillery();
            GameField field = new GameField(30, 80);

            Console.WindowWidth = field.GetColsInField;
            Console.WindowHeight = field.GetRowsInField;
            Console.BufferHeight = field.GetRowsInField;
            Console.BufferWidth = field.GetColsInField;

            Logo.SignBunny();
            Logo.Name();
            Thread.Sleep(2000);

            Console.Clear();

            Menu.ShowMenu();

        }
    }
}
