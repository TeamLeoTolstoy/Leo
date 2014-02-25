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
        private List<Logo> logos;       
        private GameEngine gameEngine;

        public Menu()
        {
            this.logos = new List<Logo>();
            this.logos.Add(new StartIcon());
            this.logos.Add(new GuideIcon());
            this.logos.Add(new ScoreIcon());
            this.logos.Add(new EndIcon());           
            this.gameEngine = new GameEngine();
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
                    //logos.Bye();

                    Environment.Exit(1);
                    break;
            }
        }

        public void PrintMenu(int choose)
        {
            switch (choose)
            {
                case 0:
                    logos[0].IsSelected = true;
                    break;
                case 1:
                    logos[1].IsSelected = true;
                    break;
                case 2:
                    logos[2].IsSelected = true;
                    break;
                case 3:
                    logos[3].IsSelected = true;
                    break;
            }

            foreach (var item in logos)
            {
                if (item.IsSelected)
                {
                    item.PrintSelected();
                    item.IsSelected = false;
                }
                else
                {
                    item.Print();
                }
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
