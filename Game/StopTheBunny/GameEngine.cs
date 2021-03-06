﻿namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;

    public class GameEngine
    {
        public const int PointsFromBunny = 1;
        public const int NeededPointsToUpgrade = 2;

        private int gameTime;
        private int bunnyCounter;
        private List<Bunny> bunnies;
        private List<Tower> towers;
        private LogoOfGame logoOfTheGame;
        private Menu menu;
        private Base newBase;
        private Player player;
        private IUserInterface userInterface;

        public GameEngine(IUserInterface keyboard)
        {
            this.bunnies = new List<Bunny>();
            this.towers = new List<Tower>();
            this.logoOfTheGame = new LogoOfGame();
            this.menu = new Menu();
            this.newBase = new Base(new PositionOfElement(7, 61));
            this.player = new Player(new PositionOfElement(0, 0));
            this.userInterface = keyboard;
            this.gameTime = 0;
            this.bunnyCounter = 1;
        }

        public void StartGame()
        {
            this.logoOfTheGame.Print();
            this.logoOfTheGame.Name();
            Thread.Sleep(2000);
            Console.Clear();
            this.menu.ShowMenu();
            Path.Draw();
            this.newBase.Draw();

            while (true)
            {
                this.gameTime++;
                this.userInterface.ProcessInput();
                this.player.Draw();

                try
                {
                    this.HandleBunnies();
                }
                catch (IndexOutOfRangeException)
                {
                    this.bunnies.Clear();
                    this.towers.Clear();
                    this.gameTime = 0;
                    Console.Clear();
                    Console.SetCursorPosition(0, 0);
                    Console.WriteLine("Game over!");
                    Console.WriteLine("Your score is:{0}", this.player.ScoreOfPlayer.ScorePoints);
                    Thread.Sleep(1000);
                    break;
                }

                CheckForAttackTarget(this.towers, this.bunnies);
                this.RemoveDeadBunnies(this.bunnies);

                Thread.Sleep(100);
            }
        }

        public void UpgradeTower()
        {
            var currentTower = this.towers.Find(t => t.PositionOfElement.PositionRow == this.player.PositionOfElement.PositionRow + 1 && t.PositionOfElement.PositionCol == this.player.PositionOfElement.PositionCol);
            if (currentTower != null && this.player.ScoreOfPlayer.ScorePoints >= NeededPointsToUpgrade)
            {
                this.towers.Remove(currentTower);
                this.towers.Add(new AdvancedTurret(new PositionOfElement(this.player.PositionOfElement.PositionRow + 1, this.player.PositionOfElement.PositionCol)));
                this.towers.Last().Draw();
            }
        }

        public virtual void MovePlayerLeft()
        {
            this.ClearPlayerPosition();
            this.player.MoveLeft();
        }

        public virtual void MovePlayerRight()
        {
            this.ClearPlayerPosition();
            this.player.MoveRight();
        }

        public virtual void MovePlayerUp()
        {
            this.ClearPlayerPosition();
            this.player.MoveUp();
        }

        public virtual void MovePlayerDown()
        {
            this.ClearPlayerPosition();
            this.player.MoveDown();
        }

        public void ClearPlayerPosition()
        {
            Console.SetCursorPosition(this.player.PositionOfElement.PositionCol, this.player.PositionOfElement.PositionRow);
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Write(' ');
        }

        public void AddTower()
        {
            this.towers.Add(new Turret(new PositionOfElement(this.player.PositionOfElement.PositionRow + 1, this.player.PositionOfElement.PositionCol)));
            this.towers.Last().Draw();
        }

        private static void CheckForAttackTarget(List<Tower> towers, List<Bunny> bunnies)
        {
            foreach (var tower in towers)
            {
                foreach (var bunny in bunnies)
                {
                    if (IsInRange(tower, bunny))
                    {
                        if ((bunny.GetType() == typeof(CuteBunny) && tower.GetType() == typeof(Turret)) ||
                            (bunny.GetType() == typeof(AngoraBunny) || bunny.GetType() == typeof(FluffyBunny) &&
                             tower.GetType() == typeof(AdvancedTurret)))
                        {
                            bunny.CurrentHealth -= tower.Attack();
                            bunny.BackgroundColor = ConsoleColor.DarkYellow;
                        }
                        else
                        {
                        }
                    }
                    else
                    {
                        bunny.BackgroundColor = ConsoleColor.Green;
                    }
                }
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

        private void HandleBunnies()
        {
            if (this.gameTime % 7 == 0)
            {
                foreach (var bunny in this.bunnies)
                {
                    bunny.ClearPreviousPosition();

                    bunny.Move();
                    bunny.Draw();
                }
            }

            if (this.gameTime % 28 == 0)
            {
                if (this.bunnyCounter % 3 == 0)
                {
                    this.bunnies.Add(new FluffyBunny());
                }
                else if (this.bunnyCounter % 5 == 0)
                {
                    this.bunnies.Add(new AngoraBunny());
                }
                else
                {
                    this.bunnies.Add(new CuteBunny());
                }

                this.bunnyCounter++;
            }
        }

        private void RemoveDeadBunnies(List<Bunny> bunnies)
        {
            foreach (var bunny in bunnies)
            {
                if (!bunny.IsAlive)
                {
                    this.player.ScoreOfPlayer.AddPoints(PointsFromBunny);

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
    }
}