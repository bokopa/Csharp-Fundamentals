using System;

namespace _3restaurantDiscount
{
    class Program
    {
        static void Main(string[] args)
        {
            int groupSize = int.Parse(Console.ReadLine());
            string package = Console.ReadLine();
            int packpackagePrice = 0;
            string hallName = "";
            int hallPrice = 0;
            double discount = 0;

            double pricePerPerson = 0.0;

            if (0 <= groupSize && groupSize <= 50)
            {
                hallName = "Small Hall";
                hallPrice = 2500;
            }
            else if (51 <= groupSize && groupSize <= 100)
            {
                hallName = "Terrace";
                hallPrice = 5000;
            }
            else if (101 <= groupSize && groupSize <= 120)
            {
                hallName = "Great Hall";
                hallPrice = 7500;
            }
            else
            {
                Console.WriteLine(" We do not have an appropriate hall.");
                return;
            }
            //         Normal  Gold  Platinum
            //Discount    5 %   10 %  15 %
            //Price   500$	750$	1000$

            switch (package)
            {
                case "Normal":
                    packpackagePrice = 500;
                    discount = 0.95;
                    break;
                case "Gold":
                    packpackagePrice = 750;
                    discount = 0.9;
                    break;
                case "Platinum":
                    packpackagePrice = 1000;
                    discount = 0.85;
                    break;
                default:
                    break;
            }
            double totalPrice = (hallPrice + packpackagePrice) * discount;
            pricePerPerson = totalPrice / groupSize;

            Console.WriteLine($"We can offer you the { hallName}");
            Console.WriteLine($"The price per person is {pricePerPerson:f2}$");
        }
    }
}
