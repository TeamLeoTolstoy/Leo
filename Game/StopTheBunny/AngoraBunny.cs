namespace StopTheBunny
{
    using System;
    
    public class AngoraBunny : Bunny
    {
        private static readonly char[,] Image = new char[4, 4]
        {
            { '(', '\\', '/', ')' },
            { '(', '*', '*', ')' },
            { '(', '_', '_', ')' },
            { ' ', '*', '*', ' ' }
        };

        public AngoraBunny() : base(ConsoleColor.DarkGray, Image, 150)
        {
        }
    }
}