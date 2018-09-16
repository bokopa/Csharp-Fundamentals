using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string ingredients = Console.ReadLine(); ;
            int counter = 0;

            while (ingredients != "Bake!")
            {
                Console.WriteLine($"Adding ingredient {ingredients}.");
                ingredients = Console.ReadLine();
                counter += 1;
              
                
            }
           
            Console.WriteLine($"Preparing cake with {counter} ingredients.");
        }
    }
}
