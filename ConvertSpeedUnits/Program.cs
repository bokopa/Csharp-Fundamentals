using System;

namespace ConvertSpeedUnits
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 mile = 1609 meters.
            //•	On first line, you receive – distance in meters
            //•	On second – hours
            //•	On third – minutes
            //•	On fourth – seconds
            double meters = double.Parse(Console.ReadLine());
            double hours = double.Parse(Console.ReadLine());
            double minutes = double.Parse(Console.ReadLine());
            double seconds = double.Parse(Console.ReadLine());

            double metersPerSecond = meters / seconds;
        }
    }
}
