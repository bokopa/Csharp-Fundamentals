using System;

namespace GameLives
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int curentHealt = int.Parse(Console.ReadLine());
            int maxHealt = int.Parse(Console.ReadLine());
            int curentEnergy = int.Parse(Console.ReadLine());
            int maxEnergy = int.Parse(Console.ReadLine());

            string healthAsText = new string('|',curentHealt);
            string healthMissing = new string('.', maxHealt - curentHealt);

            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Healt: |{healthAsText}|");
        }
    }
}
