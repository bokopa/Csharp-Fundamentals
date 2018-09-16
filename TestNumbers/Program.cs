using System;

namespace TestNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int maxSum = int.Parse(Console.ReadLine());
            int sum = 0;
            int counter = 0;

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= m; j++)
                {
                    sum += i * j * 3;
                    counter++;
                    if (sum >=maxSum)
                    {
                        Console.WriteLine($"{counter} combinations\r\nSum: {sum} >= {maxSum}");
                        return;
                    }
                }
            }
            Console.WriteLine($"{counter} combinations\r\n Sum: {sum}");
            return;
        }
    }
}

