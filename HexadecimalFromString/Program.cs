using System;

namespace HexadecimalFromString
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            int number = Convert.ToInt32(inputNum, 16);
            Console.WriteLine(number);
        }
    }
}
