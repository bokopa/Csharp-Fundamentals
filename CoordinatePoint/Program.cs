using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace CoordinatePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            PrintCloserPointToZero(x1, y1, x2, y2);
        }
        static void PrintCloserPointToZero(double x1, double y1, double x2, double y2)
        {
            
           double firstPoint = Math.Sqrt(x1 * x1 + y1 * y1);
           double secondPoint = Math.Sqrt(x2 * x2 + y2 * y2);
            if (firstPoint<=secondPoint)
            {
                Console.WriteLine($"({x1}, {y1})");
            }
            else
            {
                Console.WriteLine($"({x2}, {y2})");
            }
        }
    }
}
