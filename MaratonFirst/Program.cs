using System;

namespace MaratonFirst
{
    class Program
    {
        static void Main(string[] args)
        {
         
                var days = int.Parse(Console.ReadLine());
                var numberOfRunners = long.Parse(Console.ReadLine());
                var averageLapsPerRunner = int.Parse(Console.ReadLine());
                var trackLenght = long.Parse(Console.ReadLine());
                var trackCapacityPerDay = int.Parse(Console.ReadLine());
                var moneyPerKm = decimal.Parse(Console.ReadLine());

            int maximumRunners = trackCapacityPerDay * days;

            if (numberOfRunners > maximumRunners)
            {
                numberOfRunners = maximumRunners;
            }
          

            long totalMeters = numberOfRunners * averageLapsPerRunner * trackLenght;
           long totalKm = totalMeters / 1000;
            decimal moneyRaised = totalKm * moneyPerKm;
            Console.WriteLine($"Money raised: {moneyRaised:F2}");
        }
    }
}
