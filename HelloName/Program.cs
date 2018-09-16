namespace Beverages
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            double volume = double.Parse(Console.ReadLine());

            double energyContent = double.Parse(Console.ReadLine());

            double shugarContent = double.Parse(Console.ReadLine());

            double energy = energyContent * volume / 100;
            double shugar = shugarContent * volume / 100;
            Console.WriteLine($"{volume}ml {name}:");
            Console.WriteLine($"{energy}kcal, {shugar}g sugars");
        }
    }
}
