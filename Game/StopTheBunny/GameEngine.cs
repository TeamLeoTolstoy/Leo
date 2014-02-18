using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//using StopTheBunny.Logos;

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
                    Console.Write(field[i, j]);
                }

                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            Airillery testTower = new Airillery();
            GameField field = new GameField(15, 20);
            for (int row = 0; row < field.GetRowsInField; row++)
            {
                for (int col = 0; col < field.GetColsInField; col++)
                {
                    field[row, col] = '*';
                }
            }
            

            Turrent tower = new Turrent(new PositionOfElement(13, 18));
            field.AddTower(tower);
            Print(field);

            //Console.WindowWidth = field.GetColsInField;
            //Console.WindowHeight = field.GetRowsInField;
            //Console.BufferHeight = field.GetRowsInField;
            //Console.BufferWidth = field.GetColsInField;

            //Logo.SignBunny();
            //Logo.Name();
            //Thread.Sleep(2000);

            //Console.Clear();

            //Menu.ShowMenu();

        }
    }
}
