using System;

namespace IntegerToHexAndBinary
{
    class Program
    {
        static void Main(string[] args) 
        {
            int number = int.Parse(Console.ReadLine());

            string s = Convert.ToString(number,16).ToUpper();
            string s2 = Convert.ToString(number, 2);

            Console.WriteLine(s);
            Console.WriteLine(s2);

        }
    }
}
