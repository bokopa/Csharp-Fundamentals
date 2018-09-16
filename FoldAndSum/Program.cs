using System;
using System.Linq;

namespace FoldAndSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
               .ToArray();
            int k = numbers.Length / 4;

            int[] leftPart = numbers.Take(k).ToArray();
            int[] midlePart = numbers.Skip(k).Take(2 * k).ToArray();
            int[] rightPart = numbers.Skip(3*k).Take(k).ToArray();

            Array.Reverse(leftPart);
            Array.Reverse(rightPart);

            int[] result = new int[2*k];

            for (int i = 0; i < k; i++)
            {
                result[i] = leftPart[i] + midlePart[i];
                result[i+k] = rightPart[i] + midlePart[i+k];
                
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }

           // Console.WriteLine(string.Join(" ", result));
        }
    }
}
