using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopTheBunny
{
    class StopTheBunnyMain
    {
        public const int ConsoleWidthMax = 80; // ******!!!JUST TO TEST THE GAME HEIGHT AND WIDTH!!!
        public const int ConsoleHeightMax = 30;// ******!!!JUST TO TEST THE GAME HEIGHT AND WIDTH!!!

        static void Main()
        {         
            ConsoleSetUp(); // *********!!!JUST TO TEST THE GAME HEIGHT AND WIDTH!!!

           // Logo.SignBunny();
            Logo logo = new Logo();
            logo.ShowBunnyLogo();
            logo.Name();
            Thread.Sleep(2000);

            Console.Clear();

            Menu.ShowMenu();

            GameEngine.StartGame();
            //Thread movingBunnies = new Thread(() =>
            //{
            //    while (true)
            //    {
            //        foreach (var currentBunny in bunnies)
            //        {
            //            currentBunny.Move();
            //            currentBunny.Draw();
            //            Thread.Sleep(500);
            //            currentBunny.ClearPreviousPosition();
            //        }                    
            //    }
            //});
            //movingBunnies.Start();
            //Thread addingBunnies = new Thread(() => 
            //{
            //    for (int i = 0; i < 10; i++)
            //    {
            //        tempBunnies.Add(new Bunny());
            //        Thread.Sleep(2000);
            //    }
            //});
            //addingBunnies.Start();
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

        // ******!!!METHOD JUST TO TEST THE GAME HEIGHT AND WIDTH!!!
        private static void ConsoleSetUp()
        {
            Console.WindowWidth = ConsoleWidthMax;
            Console.WindowHeight = ConsoleHeightMax;
            Console.BufferWidth = ConsoleWidthMax;
            Console.BufferHeight = ConsoleHeightMax;
        }


    }
}
