using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem01
{
    class Program
    {
        static void Main(string[] args)
        {
            int siquenceLenght = int.Parse(Console.ReadLine());

            int startIndex = 0;
            int curentLenth = 1;
            int maxStart = 0;
            int maxLength = 1;
            int countSiquences = 0;
            int[] numbers = new int[siquenceLenght];
            int[] bestSiquence = new int[siquenceLenght];
            string command = Console.ReadLine();
            int rowSum = 0;
            int curSumOfElements = 0;
            int sumOfElements = 0;
            Dictionary<int, int[]> resourcesValue = new Dictionary<int, int[]>();

            while (command != "Clone them!")
            {
                
              numbers = command
            .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
            .ToArray();
                StringBuilder rows = new StringBuilder();
                foreach (var item in numbers)
                {
                    rows.Append(item);
                   
                   
                }
                int sum = numbers.Sum();
                if (curSumOfElements > rowSum)
                {
                    rowSum = curSumOfElements;
                }
             
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
                    countSiquences++;
                }
                foreach (var item in numbers)
                {
                   int sumOfElementsCur = numbers.Sum(s => s);

                    if (sumOfElementsCur > sumOfElements)
                    {
                        sumOfElements = sumOfElementsCur;
                    }
                    

                    }
                for (int i = 0; i < bestSiquence.Length - 1; i++)
                    bestSiquence[i] = numbers[i];
                {
                }
                foreach (var item in resourcesValue)
                {

                }
                //for (int j = maxStart; j < maxStart + maxLength; j++)
                //  {

                // Console.Write(numbers[j] + " ");

                //  }
                int[]result = new int[] {maxStart, maxLength };

            
                
                command = Console.ReadLine();
             
            }


            Console.WriteLine($"Best DNA sample {countSiquences} with sum: {sumOfElements}.");
            Console.WriteLine(string.Join(" ", numbers));
          
        }
    }
}
