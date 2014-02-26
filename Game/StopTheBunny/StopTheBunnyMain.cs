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

            keyboard.OnLeftPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerLeft();
            };

            keyboard.OnRightPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerRight();
            };

            keyboard.OnUpPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerUp();
            };

            keyboard.OnDownPressed += (sender, eventInfo) =>
            {
                gameEngine.MovePlayerDown();
            };

            keyboard.OnBuildPressed += (sender, eventInfo) =>
                {
                    gameEngine.AddTower();
                };

            keyboard.OnUpgradePressed += (sender, eventInfo) =>
            {
                gameEngine.UpgradeTower();
            };

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
