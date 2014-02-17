using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StopTheBunny.Logos;

namespace StopTheBunny
{
    public class Keyboard : IUserInterface
    {
        public event EventHandler OnLeftArrow;

        public event EventHandler OnRightArrow;

        public event EventHandler OnActionPressed;

        public void ProcessInput()
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
                        Menu.MakeChoose(choise);
                    }
                    Console.Clear();
                    Menu.PrintMenu(choise);
                }
            }
        }
    }
}
