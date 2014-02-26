namespace StopTheBunny
{
    using System;

    public class AngryBunny : Bunny
    {
        private static readonly char[,] Image = new char[4, 4]
        {
            { '(', '\\', '/', ')' },
            { '(', '>', '<', ')' },
            { '(', '_', '_', ')' },
            { ' ', '*', '*', ' ' }
        };

        public AngryBunny() : base(ConsoleColor.DarkMagenta, Image, 120)
        {
        }
    }
}