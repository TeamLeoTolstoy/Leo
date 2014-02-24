using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StopTheBunny
{
    public class Base:GameObject, IDrawable
    {
        public Base(PositionOfElement positionOfElement)
        {
            this.Sign = '#';
            this.SizeOfElement = new char[4, 5];
            this.PositionOfElement = positionOfElement;
            this.ForegroundColor = ConsoleColor.Gray;
            this.BackgroundColor = ConsoleColor.Black;
        }

        //public void Draw()
        //{
        //    Console.SetCursorPosition(this.PositionOfElement.PositionCol, this.PositionOfElement.PositionRow);
        //    Console.ForegroundColor = this.Color;
        //    for (int row = this.PositionOfElement.PositionRow; row < this.PositionOfElement.PositionRow + this.SizeOfElement.GetLength(0); row++)
        //    {
        //        for (int col = this.PositionOfElement.PositionCol; col < this.PositionOfElement.PositionCol + this.SizeOfElement.GetLength(1); col++)
        //        {
        //            Console.SetCursorPosition(col, row);
        //            Console.ForegroundColor = this.Color;
        //            Console.Write(this.Sign);
        //        }   
        //    }
        //    Console.ResetColor();
        //}
    }
}
