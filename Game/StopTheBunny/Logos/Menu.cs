using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny.Logos
{
    public static class Menu 
    {

        public static void MakeChoose(int choise)
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
                    new LogoBye().RenderAll();

                    Environment.Exit(1);
                    break;
            }
        }

        public static void PrintMenu(int choose)
        {
            var start = new MenuStart();
            var guide = new MenuGuide();
            var score = new MenuScore();
            var end = new MenuEnd();

            switch (choose)
            {
                case 0:
                    start.GetImageSelected();
                    guide.GetImage();
                    score.GetImage();
                    end.GetImage();
                    break;
                case 1:
                    start.GetImage();
                    guide.GetImageSelected();
                    score.GetImage();
                    end.GetImage();
                    break;
                case 2:
                   start.GetImage();
                   guide.GetImage();
                   score.GetImageSelected();
                   end.GetImage();
                    break;
                case 3:
                    start.GetImage();
                    guide.GetImage();
                    score.GetImage();
                    end.GetImageSelected();
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
