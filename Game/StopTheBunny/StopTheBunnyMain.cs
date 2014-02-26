using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StopTheBunny
{
    class StopTheBunnyMain
    {
        public const int ConsoleWidthMax = 80; // ******!!!JUST TO TEST THE GAME HEIGHT AND WIDTH!!!
        public const int ConsoleHeightMax = 30;// ******!!!JUST TO TEST THE GAME HEIGHT AND WIDTH!!!

        static void Main()
        {         
            ConsoleSetUp(); // *********!!!JUST TO TEST THE GAME HEIGHT AND WIDTH!!!
            IUserInterface keyboard = new KeyboardInterface();
            GameEngine gameEngine = new GameEngine(keyboard);
            gameEngine.StartGame();
            
        }

        // ******!!!METHOD JUST TO TEST THE GAME HEIGHT AND WIDTH!!!
        private static void ConsoleSetUp()
        {
            Console.WindowWidth = ConsoleWidthMax;
            Console.WindowHeight = ConsoleHeightMax;
            Console.BufferWidth = ConsoleWidthMax;
            Console.BufferHeight = ConsoleHeightMax;
        }


    }
}
