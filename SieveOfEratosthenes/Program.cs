using System;
using System.Collections.Generic;

namespace SieveOfEratosthenes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            bool[] prime = new bool[number + 1];

            for (int i = 2; i < prime.Length; i++)
            {
                prime[i] = true;
            }
            //           Let A be an array of Boolean values, indexed by integers 2 to n,
            //initially all set to true.
            //for i = 2, 3, 4, ..., not exceeding √n:
            //  if A[i] is true:
            //    for j = i2, i2 + i, i2 + 2i, i2 + 3i, ..., not exceeding n:
            //      A[j] := false.

            //Output: all i such that A[i] is true.

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (prime[i])
                {
                    for (int j =i*i; j <=number; j+=i)
                    {
                        prime[j] = false;
                    }
                }
            }
            List<int> result = new List<int>();
            for (int k = 0; k < prime.Length; k++)
            {
                if (prime[k])
                {
                    result.Add(k);
                }
                
            }
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
