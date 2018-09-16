using System;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger number = BigInteger.Parse(Console.ReadLine());
            // For Factorial only -Console.WriteLine(Factorial(number));
            Console.WriteLine(ZeroCounter(Factorial(number)));
        }
        static BigInteger Factorial(BigInteger number)
        {
            BigInteger factorialNumber = 1;
            for (int i = 1; i <= number; i++)
            {
                factorialNumber *= i;
            }
            return factorialNumber;
        }
        static int ZeroCounter(BigInteger factorialNumber)
        {
            int counter = 0;
            while (factorialNumber!=0)
            {
               BigInteger digit = factorialNumber % 10;
                factorialNumber /= 10;
                if (digit == 0)
                {
                    counter++;
                }
                else
                {
                    break;
                }
            }
            return counter;
        }
    }

}
