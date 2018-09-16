using System;
using System.Linq;

namespace MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
               .ToArray();

            int startIndex = 0;
            int curentLenth= 1;
            int maxStart = 0;
            int maxLength = 1;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] == numbers[i - 1])
                {
                    curentLenth++;
                    if (curentLenth > maxLength)
                    {
                        maxLength = curentLenth;
                        maxStart = startIndex;

                    }
                }
                else
                {
                   curentLenth = 1;
                    startIndex = i;

                }
            }
                for (int j = maxStart; j < maxStart+maxLength; j++)
                {
                    Console.Write(numbers[j] + " ");
                }
            
            Console.WriteLine();
        }
    }
}
