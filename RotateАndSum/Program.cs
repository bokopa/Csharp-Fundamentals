using System;
using System.Linq;

namespace RotateАndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
               .ToArray();
            int[] result = new int[numbers.Length];
            int rotationNumber = int.Parse(Console.ReadLine());

            for (int i = 0; i < rotationNumber; i++)
            {
                int lastDigit = numbers[numbers.Length - 1];

                for (int y = numbers.Length-1; y > 0; y--)
                {
                    numbers[y] = numbers[y - 1];
                    result[y] += numbers[y];
                }
                numbers[0] = lastDigit;
                result[0] += numbers[0];
            }
            for (int j = 0; j < result.Length; j++)
            {
                Console.Write(result[j] + " ");
            }
            Console.WriteLine();
        }
    }
}
