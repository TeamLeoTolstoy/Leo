namespace StopTheBunny
{
    using System;

    public class StopTheBunnyMain
    {
        public const int ConsoleWidthMax = 80;
        public const int ConsoleHeightMax = 30;

        public static void Main()
        { 
            ConsoleSetUp();
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