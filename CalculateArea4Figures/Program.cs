using System;

namespace CalculateArea4Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            string parameter = Console.ReadLine();
            double result = 0.0;

            if (parameter == "triangle")
            {
                double side = double.Parse(Console.ReadLine());
                double heigth= double.Parse(Console.ReadLine());
                result = calculateTriangleFace(side, heigth);
               
            }
            else if (parameter == "square")
                            {
                double side = double.Parse(Console.ReadLine());
                result = calculateSquareFace(side);
            }
            else if (parameter == "rectangle")
            {
                double width = double.Parse(Console.ReadLine());
                double heigth = double.Parse(Console.ReadLine());
                result = calculateRectangleFace(width, heigth);
            }
            else if (parameter == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                
                result = calculateCircleArea(radius);
            }
            Console.WriteLine($"{result:F2}");
        }


        static double calculateTriangleFace(double side, double heigth)
        {
            double triangleFace = (side*heigth)/2;
            return triangleFace;
        }
        static double calculateSquareFace(double side)
        {
            double squareFace = side*side;
            return squareFace;
        }
        static double calculateRectangleFace(double width, double heigth)
        {
            double rectangleFace = width*heigth;
            return rectangleFace;
        }
        static double calculateCircleArea(double radius)
        {
            double circleArea = Math.PI * radius * radius;
            return circleArea;
        }
    }
}

