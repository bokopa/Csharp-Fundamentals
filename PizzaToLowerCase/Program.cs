using System;

namespace PizzaToLowerCase
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int counterRow = int.Parse(Console.ReadLine());
            string ingredients = ""; 

            int calories = 0;

            int cheese = 500;
            int sauce = 150;
            int salami = 600;
            int pepper = 50;

            for (int i = 1; i <= counterRow; i++)
            {
                ingredients = Console.ReadLine();
              string a = ingredients.ToLower();
                if (a == "cheese")
                {
                    calories += cheese;
                }
                else if (a == "tomato sauce")
                {
                    calories += sauce;
                }
                else if (a == "salami")
                {
                    calories += salami;

                }
                else if (a == "pepper")
                {
                    calories += pepper;

                }

            }
                Console.WriteLine($"Total calories: {calories} ");
        }
    }
}
