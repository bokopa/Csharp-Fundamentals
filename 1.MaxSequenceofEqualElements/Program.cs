using System;
using System.Collections.Generic;
using System.Linq;

namespace _1.MaxSequenceofEqualElements
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToList();

            int curentStart = 0;
            int curentLength = 1;
            int bestStart = 0;
            int bestLength = 1;

            for (int i = 1; i < numbersList.Count; i++)
            {
                if (numbersList[i] == numbersList[i-1])
                {
                    curentLength++;
                    if (bestLength<curentLength)
                    {
                        bestLength = curentLength;
                        bestStart = curentStart;
                    }
                }
                else
                {
                    curentStart = i;
                    curentLength = 1;
                }
            }
            for (int i = bestStart; i < bestStart+bestLength; i++)
            {
                Console.Write(numbersList[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
