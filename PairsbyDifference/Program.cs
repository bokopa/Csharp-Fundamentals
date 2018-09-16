using System;
using System.Linq;

namespace PairsbyDifference
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
               .ToArray();
            int difference = int.Parse(Console.ReadLine());
            int result = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                int curentDigit = numbers[i];
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (numbers[j] - curentDigit == difference)
                    {
                        result++;

                    }
                }
            }
            Console.WriteLine(result);
        }
    }
}
