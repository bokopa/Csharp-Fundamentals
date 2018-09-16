using System;
using System.Collections.Generic;
using System.Linq;

namespace SearchforaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();

            int[] commandArr = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToArray();

            List<int> result = new List<int>();
            int numbersToTake = commandArr[0];
            int numbersToDelete = commandArr[1];
            int numberToFind = commandArr[2];

            for (int i = 0; i < numbersToTake; i++)
            {
                result.Add(numbersList[i]);
            }
            for (int i = 0; i < numbersToDelete; i++)
            {
                result.RemoveAt(0);
            }
            for (int i = 0; i < result.Count; i++)
            {
                if (numberToFind == result[i])
                {
                    Console.WriteLine("YES!");
                    return;
                }
            }
            Console.WriteLine("NO!");
        }
    }
}
