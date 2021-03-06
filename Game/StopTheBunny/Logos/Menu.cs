﻿namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class Menu
    {
        private List<Logo> logos;       
        
        public Menu()
        {
            this.logos = new List<Logo>();
            this.logos.Add(new StartIcon());
            this.logos.Add(new GuideIcon());
            this.logos.Add(new ScoreIcon());
            this.logos.Add(new EndIcon());
            this.logos.Add(new GoodByeLogo());          
        }
       
        public void ShowMenu()
        {
            int choise = 0;
            this.PrintMenu(choise);

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
                        string myChoise = this.MakeChoose(choise);
                        if (myChoise == "StartGame")
                        {
                            break;
                        }
                        else if (myChoise == "ReadGuide")
                        {
                            this.ReadGuide();
                        }
                        else if (myChoise == "ReadScores")
                        {
                            this.ReadScores();
                        }
                        else
                        {
                            this.logos.Last().Print();
                            Environment.Exit(1);
                        }
                    }

                    Console.Clear();
                    this.PrintMenu(choise);
                }
            }
        }

        public void PrintMenu(int choose)
        {
            switch (choose)
            {
                case 0:
                    this.logos[0].IsSelected = true;
                    break;
                case 1:
                    this.logos[1].IsSelected = true;
                    break;
                case 2:
                    this.logos[2].IsSelected = true;
                    break;
                case 3:
                    this.logos[3].IsSelected = true;
                    break;
            }

            for (int index = 0; index < this.logos.Count - 1; index++)
            {
                if (this.logos[index].IsSelected)
                {
                    this.logos[index].PrintSelected();
                    this.logos[index].IsSelected = false;
                }
                else
                {
                    this.logos[index].Print();
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

            this.ReturnToMainMenu();
        }

        public void ReadGuide()
        {
            Console.SetCursorPosition(0, 0);

            if (File.Exists(@"..\..\helpers.txt"))
            {
                Console.Clear();
                StreamReader reader = new StreamReader(@"..\..\helpers.txt");

                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    Console.SetCursorPosition(15, 3 + lineNumber);
                    Console.WriteLine(line);
                    line = reader.ReadLine();
                }

                this.ReturnToMainMenu();
            }
            else
            {
                Console.SetCursorPosition(19, 15);
                Console.WriteLine("File does not exist, ask from developer team");
                this.ReturnToMainMenu();
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

        private string MakeChoose(int choise)
        {
            Console.Clear();
            string result = null;

            switch (choise)
            {
                case 0:
                    result = "StartGame";
                    break;
                case 1:
                    result = "ReadGuide";
                    break;
                case 2:
                    result = "ReadScores";
                    break;
                case 3:
                    result = "GoodBye";
                    break;
            }

            return result;
        }
    }
}