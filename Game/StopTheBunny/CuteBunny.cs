namespace StopTheBunny
{
    using System;

    public class CuteBunny : Bunny
    {
        private static readonly char[,] Image = new char[4, 4]
        {
            { '(', '\\', '/', ')' },
            { '(', '.', '.', ')' },
            { '(', '_', '_', ')' },
            { ' ', '*', '*', ' ' }
        };

        public CuteBunny() : base(ConsoleColor.Red, Image, 100)
        {
        }
    }
}
