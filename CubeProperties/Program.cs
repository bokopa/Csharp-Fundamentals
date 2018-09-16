using System;

namespace CubeProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();
            if (parameter == "face")
            {
                Console.WriteLine($"{ calculateFaceDiagonals(side):F2}");
            }
            else if (parameter == "space")
            {
                Console.WriteLine($"{ calculateSpaceDiagonals(side):F2}");
            }
            else if (parameter == "volume")
            {
                Console.WriteLine($"{ calculateVolume(side):F2}");
            }
            else if (parameter == "area")
            {
                Console.WriteLine($"{ calculateArea(side):F2}");
            }
        }


        static double calculateFaceDiagonals(double side)
        {
            double faceDiagonals = Math.Sqrt(2 * Math.Pow(side, 2));
            return faceDiagonals;
        }
        static double calculateSpaceDiagonals(double side)
        {
            double spaceDiagonals = Math.Sqrt(3 * Math.Pow(side, 2));
            return spaceDiagonals;
        }
        static double calculateVolume(double side)
        {
            double volume = Math.Pow( side, 3);
            return volume;
        }
        static double calculateArea(double side)
        {
            double area = 6*Math.Pow(side, 2);
            return area;
        }
    }
}
