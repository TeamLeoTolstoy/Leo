namespace StopTheBunny
{
    using System;

    public class FluffyBunny : Bunny
    {
        private static readonly char[,] Image = new char[4, 4]
        {
            { '(', '\\', '/', ')' },
            { '(', '^', '^', ')' },
            { '(', '_', '_', ')' },
            { ' ', '*', '*', ' ' }
        };

        public FluffyBunny() : base(ConsoleColor.DarkMagenta, Image, 120)
        {
        }
    }
}