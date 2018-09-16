using System;

namespace _3.UnicodeCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            foreach (var item in input)
            {
                Console.Write("\\u{0:x4}", (int)item);
            }
        }
    }
}
