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

        private static List<Bunny> bunnies = new List<Bunny>();

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
            if (gameCounter % 7 == 0)
            {
                foreach (var bunny in bunnies)
                {
                    bunny.ClearPreviousPosition();                    
                                    
                    bunny.Move();
                    bunny.Draw();    
                }
            }

            if (gameCounter % 28 == 0)
            {
                bunnies.Add(new CuteBunny());
            }
        }        

        public static void StartGame()
        { 

            Base newBase = new Base(new PositionOfElement(7, 61));
            //GameField field = new GameField(15, 20);
            Player player = new Player(new PositionOfElement(0, 0));
            Path.Draw();
            newBase.Draw();

            //List<Bunny> bunnies = new List<Bunny>();
            //IList<Bunny> tempBunnies = new List<Bunny>();
            //bunnies.Add(new CuteBunny());

            while (true)
            {
                gameTime++;
                
                player.Move();
                
                player.Draw();
                try
                {
                    HandleBunnies(bunnies, gameTime);
                }
                catch (IndexOutOfRangeException)
                {
                    bunnies.Clear();
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over!");
                    Thread.Sleep(1000);
                    break;
                }
                
                Thread.Sleep(100);
            }
        }
    }
}