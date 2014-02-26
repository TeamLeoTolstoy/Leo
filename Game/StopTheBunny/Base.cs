namespace StopTheBunny
{
    using System;

    public class Base : GameObject, IDrawable
    {
        public Base(PositionOfElement positionOfElement)
        {
            this.ElementImage = new char[3, 4]
            {
                { '#', '#', '#', '#' },
                { 'b', 'a', 's', 'e' },
                { '#', '#', '#', '#' },
            };
            this.PositionOfElement = positionOfElement;
            this.ForegroundColor = ConsoleColor.Gray;
            this.BackgroundColor = ConsoleColor.Black;
        }
    }
}