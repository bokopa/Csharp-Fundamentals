using System;
using System.Text.RegularExpressions;

namespace ValidEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            var patern = new Regex(@"^| [a-zA-Z0-9][a-zA-Z0-9.\-_]*@[a-z-]+(\.[A-Za-z]+)+");
            var matches = patern.Matches(input);

            foreach (Match item in matches)
            {
                Console.WriteLine(item.Value.Trim());
            }
        }
    }
}
