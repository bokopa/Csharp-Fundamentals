using System;

namespace _1ChooseADrink
{
    class Program
    {
        static void Main(string[] args)
        {
            string profesion = Console.ReadLine();
            switch (profesion)
            {
                case "Athlete":
                    Console.WriteLine("Water");
                    break;
                case "Businessman":
                    Console.WriteLine("Coffee");
                    break;
                case "SoftUni Student":
                    Console.WriteLine("Beer");
                    break;
                default:
                        Console.WriteLine("Tea");
                        break;
                    }
           
        }
    }
}
