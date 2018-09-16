using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntercectionOfCircles
{
    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point(int x, int y) { 

            X = x;
            Y = y;
            }
        public static int calculateDistanceBetweenTwoPoints (Point p1, Point p2)
        {
            return (int)Math.Sqrt(Math.Pow(p2.X - p1.X, 2) + Math.Pow(p2.Y - p1.Y, 2));
        }
       
    }
}
