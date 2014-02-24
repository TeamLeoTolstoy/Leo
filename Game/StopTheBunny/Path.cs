using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StopTheBunny
{
    public static class Path
    {
        private static readonly List<PositionOfElement> pathPoints = new List<PositionOfElement>
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
            new PositionOfElement(10, 20),
            new PositionOfElement(11, 20),
            new PositionOfElement(12, 20),
            new PositionOfElement(13, 20),
            new PositionOfElement(14, 20),
            new PositionOfElement(15, 20),
            new PositionOfElement(16, 20),
            new PositionOfElement(17, 20),
            new PositionOfElement(18, 20),
            new PositionOfElement(19, 20),
            new PositionOfElement(20, 20),
            new PositionOfElement(20, 21),
            new PositionOfElement(20, 22),
            new PositionOfElement(20, 23),
            new PositionOfElement(20, 24),
            new PositionOfElement(20, 25),
            new PositionOfElement(20, 26),
            new PositionOfElement(20, 27),
            new PositionOfElement(20, 28),
            new PositionOfElement(20, 29),
            new PositionOfElement(20, 30),
            new PositionOfElement(20, 30),
            new PositionOfElement(20, 31),
            new PositionOfElement(20, 32),
            new PositionOfElement(20, 33),
            new PositionOfElement(20, 34),
            new PositionOfElement(20, 35),
            new PositionOfElement(20, 36),
            new PositionOfElement(20, 37),
            new PositionOfElement(20, 38),
            new PositionOfElement(20, 39),
            new PositionOfElement(20, 40),
            new PositionOfElement(19, 40),
            new PositionOfElement(18, 40),
            new PositionOfElement(17, 40),
            new PositionOfElement(16, 40),
            new PositionOfElement(15, 40),
            new PositionOfElement(14, 40),
            new PositionOfElement(13, 40),
            new PositionOfElement(12, 40),
            new PositionOfElement(11, 40),
            new PositionOfElement(10, 40),
            new PositionOfElement(10, 41),
            new PositionOfElement(10, 42),
            new PositionOfElement(10, 43),
            new PositionOfElement(10, 44),
            new PositionOfElement(10, 45),
            new PositionOfElement(10, 46),
            new PositionOfElement(10, 47),
            new PositionOfElement(10, 48),
            new PositionOfElement(10, 49),
            new PositionOfElement(10, 50),
            new PositionOfElement(10, 51),
            new PositionOfElement(10, 52),
            new PositionOfElement(10, 53),
            new PositionOfElement(10, 54),
            new PositionOfElement(10, 55),
            new PositionOfElement(10, 56),
            new PositionOfElement(10, 57),
            new PositionOfElement(10, 58),
            new PositionOfElement(10, 59),
            new PositionOfElement(10, 60),
            new PositionOfElement(11, 60),
            new PositionOfElement(12, 60),
            new PositionOfElement(13, 60),
            new PositionOfElement(14, 60),
            new PositionOfElement(15, 60),
        };

        public static void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            foreach (var point in pathPoints)
            {
                //if (point.PositionRow == 5 || point.PositionRow == 10 || point.PositionRow == 20)
                //{
                //    for (int i = 0; i < 4; i++)
                //    {
                //        Console.SetCursorPosition(point.PositionCol, point.PositionRow + i);
                //        Console.Write(' ');
                //    }
                //}
                if (point.PositionCol == 20 || point.PositionCol == 21 || point.PositionCol == 40 || point.PositionCol == 60)
                {
                    if (point.PositionCol == 40)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            for (int j = 0; j < 4; j++)
                            {
                                Console.SetCursorPosition(point.PositionCol + j, point.PositionRow + i);
                                Console.Write(' ');
                            }
                        }
                    }
                    for (int i = 0; i < 4; i++)
                    {
                        Console.SetCursorPosition(point.PositionCol + i, point.PositionRow);
                        Console.Write(' ');
                    }
                }

                for (int i = 0; i < 4; i++)
                {
                    Console.SetCursorPosition(point.PositionCol, point.PositionRow + i);
                    Console.Write(' ');
                }
            }
            Console.ResetColor();
        }

        public static PositionOfElement GetFirstPosition()
        {
            return pathPoints[0];
        }

        public static PositionOfElement GetNextPosition(PositionOfElement currentPosition)
        {
            int currentIndex = pathPoints.IndexOf(currentPosition);
            if (currentIndex + 1 < pathPoints.Count)
            {
                return pathPoints[currentIndex + 2];
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