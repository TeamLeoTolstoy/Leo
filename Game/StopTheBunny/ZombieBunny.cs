namespace StopTheBunny
{
    using System;
    
    public class ZombieBunny : Bunny
    {
        private static readonly char[,] Image = new char[4, 4]
        {
            { '(', '\\', '/', ')' },
            { '(', '*', '*', ')' },
            { '(', '_', '_', ')' },
            { ' ', '*', '*', ' ' }
        };

        public ZombieBunny() : base(ConsoleColor.DarkGray, Image, 150)
        {
        }
    }
}