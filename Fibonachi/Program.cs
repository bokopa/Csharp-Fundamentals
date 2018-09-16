using System;

namespace Fibonachi
{
    class Program
    {
        static void Main(string[] args)
        {

            int number = int.Parse(Console.ReadLine());
            Console.WriteLine(FibonacciNum(number));
        }
        static int FibonacciNum(int number)
        {
            int result = 0;

            if (0 == number || number == 1 )
            {
               result = 1;
               return result;
               
            }
            int previousNumber = 1;
            int previousPreviousNumber = 1;
            for (int i = 2; i <= number; i++)
            {
                result = previousNumber + previousPreviousNumber;
                previousPreviousNumber = previousNumber;
                previousNumber = result;
            }
            return result;
        }
    }
}
