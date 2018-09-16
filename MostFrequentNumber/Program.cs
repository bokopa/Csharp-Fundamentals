using System;
using System.Linq;

namespace MostFrequentNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int totalOcuranceCount = 0;
            int result = 0;

            int[] numbers = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                 .ToArray();
            for (int i = 0; i < numbers.Length; i++)
            {
                int ocuranceCount = 0;
                int currentNumber = numbers[i];

                for (int j = i; j < numbers.Length; j++)
                {
                    if (currentNumber == numbers[j])
                    {
                        ocuranceCount++;
                        if (ocuranceCount > totalOcuranceCount)
                        {
                            totalOcuranceCount = ocuranceCount;
                            result = currentNumber;
                        }
                    }
                }
            }
            Console.WriteLine(result);
           
        }
    }
}
