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
        private static List<Tower> towers = new List<Tower>();
    
        public static void AddTower(PositionOfElement position)
        {
            towers.Add(new Turret(position));
            towers[towers.Count - 1].Draw();
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

        private static bool IsInRange(Tower tower, Bunny bunny)
        {
            return ((bunny.PositionOfElement.PositionRow - tower.PositionOfElement.PositionRow + 1) *
                (bunny.PositionOfElement.PositionRow - tower.PositionOfElement.PositionRow + 1)) +
                ((bunny.PositionOfElement.PositionCol - tower.PositionOfElement.PositionCol + 1) *
                (bunny.PositionOfElement.PositionCol - tower.PositionOfElement.PositionCol + 1)) <
                (tower.Range * tower.Range);
        }

        static void CheckForAttackTarget(List<Tower> towers, List<Bunny> bunnies)
        {
            foreach (var tower in towers)
            {
                foreach (var bunny in bunnies)
                {
                    if (IsInRange(tower, bunny))
                    {
                        bunny.CurrentHealth -= tower.Attack();
                        bunny.BackgroundColor = ConsoleColor.DarkYellow;
                    }
                    else
                    {
                        bunny.BackgroundColor = ConsoleColor.Green;
                    }
                }
            }
        }

        private static void RemoveDeadBunnies(List<Bunny> bunnies)
        {
            foreach (var bunny in bunnies)
            {
                if (!bunny.IsAlive)
                {
                    for (int row = bunny.PositionOfElement.PositionRow; row < bunny.PositionOfElement.PositionRow + bunny.ElementImage.GetLength(0); row++)
                    {
                        for (int col = bunny.PositionOfElement.PositionCol; col < bunny.PositionOfElement.PositionCol + bunny.ElementImage.GetLength(1); col++)
                        {
                            Console.SetCursorPosition(col, row);
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.Write(' ');
                        }
                    }
                }
            }

            bunnies.RemoveAll(b => b.IsAlive == false);
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
                    towers.Clear();
                    gameTime = 0;
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over!");
                    Thread.Sleep(1000);
                    break;
                }
                CheckForAttackTarget(towers, bunnies);
                RemoveDeadBunnies(bunnies);
                
                Thread.Sleep(100);
            }
        }
    }
}