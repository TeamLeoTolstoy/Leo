using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public static class Path
    {
        private static List<PositionOfElement> pathPoints = new List<PositionOfElement>
        {
            new PositionOfElement(5, 0),
            new PositionOfElement(5, 1),
            new PositionOfElement(5, 2),
            new PositionOfElement(5, 3),
            new PositionOfElement(5, 4),
            new PositionOfElement(5, 5),
            new PositionOfElement(5, 6),
            new PositionOfElement(5, 7),
            new PositionOfElement(5, 8),
            new PositionOfElement(5, 9),
            new PositionOfElement(5, 10),
            new PositionOfElement(5, 11),
            new PositionOfElement(5, 12),
            new PositionOfElement(5, 13),
            new PositionOfElement(5, 14),
            new PositionOfElement(5, 15),
            new PositionOfElement(5, 16),
            new PositionOfElement(5, 17),
            new PositionOfElement(5, 18),
            new PositionOfElement(5, 19),
            new PositionOfElement(5, 20),
            new PositionOfElement(6, 20),
            new PositionOfElement(7, 20),
            new PositionOfElement(8, 20),
            new PositionOfElement(9, 20),
        };

        public static void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            foreach (var point in pathPoints)
            {
                Console.SetCursorPosition(point.PositionCol, point.PositionRow - 1);
                Console.Write('-');
                Console.SetCursorPosition(point.PositionCol, point.PositionRow);
                Console.Write(' ');
                Console.SetCursorPosition(point.PositionCol, point.PositionRow + 1);
                Console.Write('-');
            }
            Console.ResetColor();
        }

        public static PositionOfElement GetNextPosition(PositionOfElement currentPosition)
        {
            if (currentPosition == null)
            {
                return pathPoints[0];
            }
            int currentIndex = pathPoints.IndexOf(currentPosition);
            if (currentIndex + 1 < pathPoints.Count)
            {
                return pathPoints[currentIndex + 1];
            }
            else
            {
                throw new IndexOutOfRangeException("End of path!");
            }
        }
    }
    //public class Path:GameObject
    //{
    //    private int fieldRows;
    //    private int fieldCols;
    //    public List<int> RowCoodrinates { get; set; }
    //    public List<int> ColCoordinates { get; set; }

    //    public Path(int fieldRows, int fieldCols)
    //    {
    //        this.FieldRows = fieldRows;
    //        this.FieldCols = fieldCols;
    //        this.RowCoodrinates = new List<int>();
    //        this.ColCoordinates = new List<int>();
    //        this.Sign = '=';          
    //    }

    //    public int FieldRows
    //    {
    //        get { return this.fieldRows; }
    //        set
    //        {
    //            if (value<0)
    //            {
    //                throw new ArgumentException();
    //            }

    //            this.fieldRows = value;
    //        }
    //    }

    //    public int FieldCols
    //    {
    //        get { return this.fieldCols; }
    //        set
    //        {
    //            if (value < 0)
    //            {
    //                throw new ArgumentException();
    //            }

    //            this.fieldCols = value;
    //        }
    //    }

    //    public void Initialize()
    //    {
           

    //    }

    //}
}
