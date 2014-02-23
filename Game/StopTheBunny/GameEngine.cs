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
            GameField field = new GameField(15, 20);
            Player player = new Player(new PositionOfElement(0, 0));
            Path.Draw();

            Bunny testBunny = new Bunny(ConsoleColor.Red, '@', new char[1, 1]);

            Thread parallelThread = new Thread(() =>
            {
                while (true)
                {
                    testBunny.Move();
                    testBunny.Draw();
                    Thread.Sleep(500);
                    testBunny.ClearPreviousPosition();
                }
            });
            parallelThread.Start();

            while (true)
            {
                player.Move();
                player.Draw();
                Thread.Sleep(100);
            }

            

            //while (true)
            //{
            //    testBunny.Move();
            //    testBunny.Draw();                 
            //    Thread.Sleep(300);
            //    testBunny.ClearPreviousPosition();
                
            //}
            
            //Airillery testTower = new Airillery();
            //GameField field = new GameField(15, 20);
            //for (int row = 0; row < field.GetRowsInField; row++)
            //{
            //    for (int col = 0; col < field.GetColsInField; col++)
            //    {
            //        field[row, col] = '*';
            //    }
            //}
            

            //Turrent tower = new Turrent(new PositionOfElement(13, 18));
            //field.AddElement(tower);
            //Base newBase = new Base(new PositionOfElement(0,0));
            //field.AddElement(newBase);
            //Print(field);

            //Dictionary<int, int> coordinates = new Dictionary<int, int>();
            //coordinates.Add(3, 2);
            //Console.WriteLine(coordinates.Keys.First());
            //Console.WriteLine(coordinates[3]);
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
