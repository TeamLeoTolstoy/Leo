using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public class Menu
    {
        private Logo logo;
        private MenuIcons menuIcon;
        private GameEngine gameEngine;

        public Menu()
        {
            this.logo = new Logo();
            this.menuIcon = new MenuIcons();
            this.gameEngine = new GameEngine();
        }

        public Menu(Logo logo, MenuIcons menuIcon, GameEngine gameEngine)
        {
            this.logo = logo;
            this.menuIcon = menuIcon;
            this.gameEngine = gameEngine;
        }

        public void ShowMenu()
        {
            int choise = 0;
            PrintMenu(choise);

            ConsoleKeyInfo inputKey;

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    inputKey = Console.ReadKey();
                    if (inputKey.Key == ConsoleKey.LeftArrow)
                    {
                        choise--;
                        choise += 4;
                        choise %= 4;
                    }
                    else if (inputKey.Key == ConsoleKey.RightArrow)
                    {
                        choise++;
                        choise %= 4;
                    }
                    else if (inputKey.Key == ConsoleKey.Enter)
                    {
                        MakeChoose(choise);
                    }
                    Console.Clear();
                    PrintMenu(choise);
                }
            }
        }

        private void MakeChoose(int choise)
        {
            Console.Clear();
            switch (choise)
            {
                case 0:
                    this.gameEngine.StartGame();
                    break;
                case 1:
                    ReadGuide();
                    break;
                case 2:
                    ReadScores();
                    break;
                case 3:
                    logo.Bye();

                    Environment.Exit(1);
                    break;
            }
        }

        public void PrintMenu(int choose)
        {
            switch (choose)
            {
                case 0:
                    this.menuIcon.StartSelected();
                    this.menuIcon.Guide();
                    this.menuIcon.Score();
                    this.menuIcon.End();
                    break;
                case 1:
                    this.menuIcon.Start();
                    this.menuIcon.GuideSelected();
                    this.menuIcon.Score();
                    this.menuIcon.End();
                    break;
                case 2:
                    this.menuIcon.Start();
                    this.menuIcon.Guide();
                    this.menuIcon.ScoreSelected();
                    this.menuIcon.End();
                    break;
                case 3:
                    this.menuIcon.Start();
                    this.menuIcon.Guide();
                    this.menuIcon.Score();
                    this.menuIcon.EndSelected();
                    break;
            }
        }

        public void ReadScores()
        {
            int positionX = 10;
            int positionY = 20;

            if (File.Exists(@"score.txt"))
            {
                StreamReader reader = new StreamReader(@"score.txt");
                using (reader)
                {
                    string line = reader.ReadLine();
                    int count = 1;
                    while (line != null && count < 6)
                    {
                        var currLine = line.Split('-');
                        Console.SetCursorPosition(positionY, ++positionX);
                        Console.WriteLine(count++ + ". " + currLine[0] + " " + currLine[1]);
                        line = reader.ReadLine();
                        positionX++;
                    }
                }
            }
            else
            {
                Console.SetCursorPosition(32, 15);

                Console.WriteLine("NO HIGH SCORES ?");
            }
            ReturnToMainMenu();
        }

        public void ReadGuide()
        {
            Console.SetCursorPosition(0, 0);

            if (File.Exists(@"helpers.txt"))
            {
                Console.Clear();
                StreamReader reader = new StreamReader(@"helpers.txt");

                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.SetCursorPosition(23, 5 + lineNumber);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }
                ReturnToMainMenu();
            }
            else
            {
                Console.SetCursorPosition(19, 15);
                Console.WriteLine("File does not exist, ask from developer team");
                ReturnToMainMenu();
            }
        }

        public void ReturnToMainMenu()
        {
            Console.SetCursorPosition(26, 29);
            Console.WriteLine("Press [backspace] to return");
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo pressedKey = Console.ReadKey(true);
                    if (pressedKey.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        return;
                    }
                }
            }
        }
    }
}
