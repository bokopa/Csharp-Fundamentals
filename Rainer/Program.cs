using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rainer
{
    class Program
    {
        static void Main(string[] args)
        {
            var inputSiquence = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            var currentIndex = inputSiquence.Last();
            var initialInputSiquence = inputSiquence.Take(inputSiquence.Length - 1).ToArray();
            var currentInputSiquence = initialInputSiquence.ToArray();
            int count = 0;


            while (true)
            {
                DecreaseByOne(currentInputSiquence);
                if (currentInputSiquence[currentIndex] == 0)
                {
                    Console.WriteLine(string.Join(" ", currentInputSiquence));
                    Console.WriteLine(count);
                    return;
                }
                else
                {
                    for (int i = 0; i < currentInputSiquence.Length; i++)
                    {
                        if (currentInputSiquence[i] == 0)
                        {
                            currentInputSiquence[i] = initialInputSiquence[i];
                        }
                    }
                    currentIndex = int.Parse(Console.ReadLine());
                    count++;
                }
            }

        }

        private static void DecreaseByOne(int[] inputSiquence)
        {
            for (int i = 0; i < inputSiquence.Length; i++)
            {
                inputSiquence[i] -= 1;
            }
        }
    }

}