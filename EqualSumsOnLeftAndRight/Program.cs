using System;
using System.Linq;

namespace EqualSumsOnLeftAndRight
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
               .ToArray();
            bool ifThereIs = false;
            for (int i = 0; i < numbers.Length; i++)
            {
                int[] firstArr = numbers.Take(i).ToArray();
                int[] secondArr = numbers.Skip(i + 1).ToArray();
                if (firstArr.Sum() == secondArr.Sum())
                {
                    Console.WriteLine(i);
                    ifThereIs = true;
                }

            }
              if (!ifThereIs)
            {
                Console.WriteLine("no");
            }
            
        }
    }
}
