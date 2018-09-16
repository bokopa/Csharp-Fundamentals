using System;

namespace ChoosADrink2
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            var quantities = int.Parse(Console.ReadLine());
           double totalPrice = 0.0;

            switch (profesion)
            {
                case "Athlete":
                    totalPrice = quantities * 0.70;
                    Console.WriteLine($"The {profesion} has to pay {totalPrice:F2}.");
                    break;
                case "Businessman":
                case "Businesswoman":
                    totalPrice = quantities * 1.0;
                    Console.WriteLine($"The {profesion} has to pay {totalPrice:F2}.");
                    break;
                case "SoftUni Student":
                    totalPrice = quantities * 1.7;
                    Console.WriteLine($"The {profesion} has to pay {totalPrice:F2}.");
                    break;
                default:
                    totalPrice = quantities * 1.2;
                    Console.WriteLine($"The {profesion} has to pay {totalPrice:F2}.");
                    break;
            }
            }
    }
}
