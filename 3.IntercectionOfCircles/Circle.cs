using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntercectionOfCircles
{
    class Circle
    {
        public Point Center { get; set; }
        public int Radius { get; set; }
    
    public Circle(Point center, int radius)
    {
        Center = center;
            Radius = radius;
    }
        public static bool Intersec(Circle c1, Circle c2)
        {
            int d = Point.calculateDistanceBetweenTwoPoints(c1.Center, c2.Center);
                if (d<=c1.Radius+c2.Radius)
                {
                    return true;
                }
                return false;
            }
        }
}

