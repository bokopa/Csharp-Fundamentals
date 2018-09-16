using System;

namespace Greeting
{
    class Program
    {
        static void Main(string[] args)
        {
            string name1 = Console.ReadLine();
            GreetByName(name1);
        }
        public static void GreetByName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
    }
}
