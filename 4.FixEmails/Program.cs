using System;
using System.Collections.Generic;
using System.Linq;

namespace _4.FixEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> mailBook = new Dictionary<string, string>();
            string name = Console.ReadLine();
            string email = "";

            while (name!="stop")
            {
                email = Console.ReadLine();
                if (!mailBook.ContainsKey(name))
                {
                    mailBook.Add(name, email);
                }
                name = Console.ReadLine();
            }
            foreach (var pair in mailBook.Where(x => !x.Value.EndsWith("us") && !x.Value.EndsWith("uk")))
            {
                Console.WriteLine($"{pair.Key} -> {pair.Value}");
            }
        }
    }
}
