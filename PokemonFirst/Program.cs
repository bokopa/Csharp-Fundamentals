using System;

namespace PokemonFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            var pokePower = int.Parse(Console.ReadLine());
            var targetsDistance = int.Parse(Console.ReadLine());
            var exhaustionFactor = int.Parse(Console.ReadLine());
            var pokePowerHalf = 0;

            if (pokePower % 2 == 0)
            {
                pokePowerHalf = pokePower / 2;
            }
            int count = 0;

            while (pokePower >= targetsDistance)
            {
                if (pokePower == pokePowerHalf && exhaustionFactor !=0)
                {

                    pokePower /= exhaustionFactor;

                }
                else
                {
                    pokePower = pokePower - targetsDistance;
                    count++;
                }

            }
            Console.WriteLine($"{pokePower}");
            Console.WriteLine($"{count}");
        }
    }
}
