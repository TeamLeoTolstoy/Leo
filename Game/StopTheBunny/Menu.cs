﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StopTheBunny
{
    public static class Menu
    {
        public static void ShowMenu()
        {
            int choise = 0;
            Menu.PrintMenu(choise);

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
                    Menu.PrintMenu(choise);
                }
            }
        }

        private static void MakeChoose(int choise)
        {
            Console.Clear();
            switch (choise)
            {
                case 0:
                    //StartGame();
                    break;
                case 1:
                    Menu.ReadGuide();
                    break;
                case 2:
                    Menu.ReadScores();
                    break;
                case 3:
                    Logo.Bye();

                    Environment.Exit(1);
                    break;
            }
        }

        public static void PrintMenu(int choose)
        {
            switch (choose)
            {
                case 0:
                    MenuIcons.StartSelected();
                    MenuIcons.Guide();
                    MenuIcons.Score();
                    MenuIcons.End();
                    break;
                case 1:
                    MenuIcons.Start();
                    MenuIcons.GuideSelected();
                    MenuIcons.Score();
                    MenuIcons.End();
                    break;
                case 2:
                    MenuIcons.Start();
                    MenuIcons.Guide();
                    MenuIcons.ScoreSelected();
                    MenuIcons.End();
                    break;
                case 3:
                    MenuIcons.Start();
                    MenuIcons.Guide();
                    MenuIcons.Score();
                    MenuIcons.EndSelected();
                    break;
            }
        }

        public static void ReadScores()
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
            Console.SetCursorPosition(32, 29);
            Console.Write("Press any key...");
            Console.ReadLine();
        }

        public static void ReadGuide()
        {
            Console.SetCursorPosition(0, 0);

            if (File.Exists(@"helpers.txt"))
            {
                Console.Clear();
                StreamReader reader = new StreamReader(@"helpers.txt");

                using (reader)
                {
                    string text = reader.ReadToEnd();
                    Console.WriteLine(text);
                }

                Console.SetCursorPosition(32, 29);
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
            else
            {
                Console.SetCursorPosition(19, 15);
                Console.WriteLine("File does not exist, ask from developer team");
                Console.SetCursorPosition(32, 29);
                Console.WriteLine("Press any key...");
                Console.ReadLine();
            }
        }
    }
}
