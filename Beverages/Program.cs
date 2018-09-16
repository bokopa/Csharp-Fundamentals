using System;

namespace Beverages
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 123;
            while (number > 0)
            {
                int currDigit = number % 10;
                if (currDigit 0)
                {
                    Console.WriteLine(true);
                }
                else
                {
                    Console.WriteLine(false);
                }

                number /= 10;
            }
            }

        }
    }


