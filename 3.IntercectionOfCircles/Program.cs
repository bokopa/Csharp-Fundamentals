using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace IntercectionOfCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] firstCircleCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int[] secondCircleCoord = Console.ReadLine().Split().Select(int.Parse).ToArray();

            Point firstPoint = new Point(firstCircleCoord[0], firstCircleCoord[1]); 
            Point secondPoint = new Point(secondCircleCoord[0], secondCircleCoord[1]);

            Circle firstCircle = new Circle(firstPoint, firstCircleCoord[2]);
            Circle secondtCircle = new Circle(secondPoint, secondCircleCoord[2]);

            if (Circle.Intersec(firstCircle, secondtCircle))
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
