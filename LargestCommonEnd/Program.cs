using System;
using System.Linq;

namespace LargestCommonEnd
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();
            string[] secondArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            int length = Math.Min(firstArray.Length, secondArray.Length);
            int firstCounter = 0;

            for (int i = 0; i < length; i++)
            {
                if (firstArray[i] == secondArray[i])
                {
                    firstCounter++;
                }
            }
                Array.Reverse(firstArray);
                secondArray = secondArray.Reverse().ToArray();

                int secondCounter = 0;

                for (int i = 0; i < length; i++)
                {
                    if (firstArray[i] == secondArray[i])
                    {
                        secondCounter++;
                    }
                }
            if (firstCounter > secondCounter)
            {
                Console.WriteLine(firstCounter);
            }
            else
            {
                Console.WriteLine(secondCounter);
            }
        }
    }
}
