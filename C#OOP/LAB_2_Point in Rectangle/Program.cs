using System;
using System.Linq;

namespace LAB_2_Point_in_Rectangle
{
    class Program
    {
        static void Main(string[] args)
        {

            //"{topLeftX} {topLeftY} {bottomRightX} {bottomRightY}".

            int[] coord = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            MyRectangle rect = new MyRectangle(coord[0], coord[1], coord[2], coord[3]);
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int[] aPointCoord = Console.ReadLine()
    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
    .Select(int.Parse)
    .ToArray();

                Point myPoint = new Point(aPointCoord[0], aPointCoord[1]);

                rect.Contains(myPoint);

            }



        }

        class Point
        {
            public int x { get; set; }
            public int y { get; set; }

            Point(int x, int y)
            {
                this.x = x;
                this.y =
            }
        }
        class MyRectangle
        {
            public Point TopLeft { get; set; }
            public Point LowerRight { get; set; }

            public MyRectangle(int topLX, int topLY, int lowRX, int lowRY)
            {
                Point TopLeft = new Point();
                Point LowerRight = new Point();

                TopLeft.x = topLX;
                TopLeft.y = topLY;
                LowerRight.x = lowRX;
                LowerRight.y = lowRY;


            }

            public bool Contains(Point aPoint)
            {
                if (aPoint.x >= TopLeft.x && aPoint.x <= LowerRight.x && aPoint.y >= LowerRight.y && aPoint.y <= TopLeft.y)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }



    }
}
