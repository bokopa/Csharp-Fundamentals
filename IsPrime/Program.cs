using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace IsPrime
{
    public class Program
    {
        static void Main(string[] args)
        {
            long num = long.Parse(Console.ReadLine());
            Console.WriteLine(IsTrue(num));
        }

        public static bool IsTrue(long number)
        {
            
            if (number == 1 || number == 0)
            {
                return false;
            }
           // bool isPrime = false;
            for (long i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number%i == 0)
                {
                    return false;
                }
                            }
            return true;
        }
    }
}
