namespace StopTheBunny
{
    using System;
    using System.Collections.Generic;

    public static class Path
    {
        private static readonly List<PositionOfElement> PathOfPoints = new List<PositionOfElement>
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
            new PositionOfElement(6, 12),
            new PositionOfElement(7, 12),
            new PositionOfElement(8, 12),
            new PositionOfElement(9, 12),
            new PositionOfElement(10, 12),
            new PositionOfElement(11, 12),
            new PositionOfElement(12, 12),
            new PositionOfElement(13, 12),
            new PositionOfElement(14, 12),
            new PositionOfElement(15, 12),
            new PositionOfElement(16, 12),
            new PositionOfElement(17, 12),
            new PositionOfElement(18, 12),
            new PositionOfElement(19, 12),
            new PositionOfElement(20, 12),
            new PositionOfElement(20, 13),
            new PositionOfElement(20, 14),
            new PositionOfElement(20, 15),
            new PositionOfElement(20, 16),
            new PositionOfElement(20, 17),
            new PositionOfElement(20, 18),
            new PositionOfElement(20, 19),
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
            new PositionOfElement(19, 30),
            new PositionOfElement(18, 30),
            new PositionOfElement(17, 30),
            new PositionOfElement(16, 30),
            new PositionOfElement(15, 30),
            new PositionOfElement(14, 30),
            new PositionOfElement(13, 30),
            new PositionOfElement(12, 30),
            new PositionOfElement(11, 30),
            new PositionOfElement(10, 30),
            new PositionOfElement(9, 30),
            new PositionOfElement(8, 30),
            new PositionOfElement(7, 30),
            new PositionOfElement(6, 30),
            new PositionOfElement(5, 30),
            new PositionOfElement(5, 31),
            new PositionOfElement(5, 32),
            new PositionOfElement(5, 33),
            new PositionOfElement(5, 34),
            new PositionOfElement(5, 35),
            new PositionOfElement(5, 36),
            new PositionOfElement(5, 37),
            new PositionOfElement(5, 38),
            new PositionOfElement(5, 39),
            new PositionOfElement(5, 40),
            new PositionOfElement(5, 41),
            new PositionOfElement(5, 42),
            new PositionOfElement(5, 43),
            new PositionOfElement(6, 43),
            new PositionOfElement(7, 43),
            new PositionOfElement(8, 43),
            new PositionOfElement(9, 43),
            new PositionOfElement(10, 43),
            new PositionOfElement(11, 43),
            new PositionOfElement(12, 43),
            new PositionOfElement(13, 43),
            new PositionOfElement(14, 43),
            new PositionOfElement(15, 43),
            new PositionOfElement(16, 43),
            new PositionOfElement(17, 43),
            new PositionOfElement(18, 43),
            new PositionOfElement(19, 43),
            new PositionOfElement(20, 43),
            new PositionOfElement(20, 44),
            new PositionOfElement(20, 45),
            new PositionOfElement(20, 46),
            new PositionOfElement(20, 47),
            new PositionOfElement(20, 48),
            new PositionOfElement(20, 49),
            new PositionOfElement(20, 50),
            new PositionOfElement(20, 51),
            new PositionOfElement(20, 52),
            new PositionOfElement(20, 53),
            new PositionOfElement(20, 54),
            new PositionOfElement(20, 55),
            new PositionOfElement(20, 56),
            new PositionOfElement(20, 57),
            new PositionOfElement(20, 58),
            new PositionOfElement(20, 59),
            new PositionOfElement(20, 60),
            new PositionOfElement(20, 61),
            new PositionOfElement(19, 61),
            new PositionOfElement(18, 61),
            new PositionOfElement(17, 61),
            new PositionOfElement(16, 61),
            new PositionOfElement(15, 61),
            new PositionOfElement(14, 61),
            new PositionOfElement(13, 61),
            new PositionOfElement(12, 61),
            new PositionOfElement(11, 61),
            new PositionOfElement(10, 61),
        };

        public static void Draw()
        {
            Console.BackgroundColor = ConsoleColor.Green;
            foreach (var point in PathOfPoints)
            {               
                if (point.PositionCol == 12 || point.PositionCol == 21 || point.PositionCol == 30 || point.PositionCol == 43 || point.PositionCol == 61)
                {
                    if (point.PositionCol == 30 || point.PositionCol == 61)
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
            return PathOfPoints[0];
        }

        public static PositionOfElement GetNextPosition(PositionOfElement currentPosition)
        {
            int currentIndex = PathOfPoints.IndexOf(currentPosition);
            if (currentIndex + 1 < PathOfPoints.Count)
            {
                return PathOfPoints[currentIndex + 2];
            }
            else
            {
                throw new IndexOutOfRangeException("End of path!");
            }
        }
    }
}