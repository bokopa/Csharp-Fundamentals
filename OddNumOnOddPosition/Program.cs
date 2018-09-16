using System; 

namespace OddNumOnOddPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] numsAsString = Console.ReadLine().Split(' ');
            int[] numbers = new int[numsAsString.Length];
            for (int i = 0; i < numsAsString.Length; i++)
            {
                numbers[i] = int.Parse(numsAsString[i]);
                if (i % 2 == 0 && Math.Abs(numbers[i]) % 2 != 0 )
                {
                    Console.WriteLine($"Number {numbers[i]} on position {i}");
                }
            }
        }
    }
}
