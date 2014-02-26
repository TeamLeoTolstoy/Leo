namespace StopTheBunny
{
    using System;

    public class KeyboardInterface : IUserInterface
    {
        public event EventHandler OnLeftPressed;

        public event EventHandler OnRightPressed;

        public event EventHandler OnUpPressed;

        public event EventHandler OnDownPressed;

        public event EventHandler OnBuildPressed;

        public event EventHandler OnUpgradePressed;

        public void ProcessInput()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo keyPressed = Console.ReadKey();
                while (Console.KeyAvailable)
                {
                    Console.ReadKey();
                }

                if (keyPressed.Key == ConsoleKey.LeftArrow)
                {
                    if (this.OnLeftPressed != null)
                    {
                        this.OnLeftPressed(this, new EventArgs());
                    }
                }

                if (keyPressed.Key == ConsoleKey.RightArrow)
                {
                    if (this.OnRightPressed != null)
                    {
                        this.OnRightPressed(this, new EventArgs());
                    }
                }

                if (keyPressed.Key == ConsoleKey.UpArrow)
                {
                    if (this.OnUpPressed != null)
                    {
                        this.OnUpPressed(this, new EventArgs());
                    }
                }

                if (keyPressed.Key == ConsoleKey.DownArrow)
                {
                    if (this.OnDownPressed != null)
                    {
                        this.OnDownPressed(this, new EventArgs());
                    }
                }

                if (keyPressed.Key == ConsoleKey.Spacebar)
                {
                    if (this.OnBuildPressed != null)
                    {
                        this.OnBuildPressed(this, new EventArgs());
                    }
                }

                if (keyPressed.Key == ConsoleKey.U)
                {
                    if (this.OnUpgradePressed != null)
                    {
                        this.OnUpgradePressed(this, new EventArgs());
                    }
                }
            }
        }        
    }
}
