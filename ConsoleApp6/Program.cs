using System;

namespace ReversedOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            Console.WriteLine(ReverseNumber(number));
        }
        static string ReverseNumber(string num)
        {
            string reverseNum = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                reverseNum += num[i];
            }
            return reverseNum;
        }
    }
}
