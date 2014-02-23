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
        static int gameTime = 0;

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

        static void HandleBunnies(List<Bunny> bunnies, int gameCounter)
        {
            if (gameCounter % 5 == 0)
            {
                foreach (var bunny in bunnies)
                {
                    bunny.ClearPreviousPosition();                    
                                    
                    bunny.Move();
                    bunny.Draw();    
                    
                }
            }

            if (gameCounter % 15 == 0)
            {
                bunnies.Add(new Bunny());
            }
        }

        static void Main(string[] args)
        {
            GameField field = new GameField(15, 20);
            Player player = new Player(new PositionOfElement(0, 0));
            Path.Draw();

            List<Bunny> bunnies = new List<Bunny>();
            //IList<Bunny> tempBunnies = new List<Bunny>();
            bunnies.Add(new Bunny());

            while (true)
            {
                gameTime++;
                player.Move();
                player.Draw();
                HandleBunnies(bunnies, gameTime);
                Thread.Sleep(100);
            }

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
    }
}
