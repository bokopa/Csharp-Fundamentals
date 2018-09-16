using System;
using System.Collections.Generic;
using System.Linq;

namespace _6.SumReversedNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> numbersList = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            int result = 0;
            for (int i = 0; i < numbersList.Count; i++)
            {
                string curentnumber = numbersList[i];
                string reversed = "";
                for (int j = curentnumber.Length-1; j>= 0; j--)
                {
                    reversed = reversed + curentnumber[j];
                }
                result = result + int.Parse(reversed);
            }
            Console.WriteLine(result);
        }
    }
}
