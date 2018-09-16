using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace SnowflakeThirth
{
    class Program
    {
        static void Main(string[] args)
        {

            Regex surface = new Regex(@"^[^A-Za-z0-9\s]+$"); // w/o letters and digit
            Regex mantle = new Regex(@"^[0-9_]+$");  //digits and underscore
            Regex core = new Regex(@"[^A-Za-z0-9\s]+[0-9_]+([A-Za-z]+)[0-9_]+[^A-Za-z0-9\s]+"); // leters only

            int length = 0;

            for (int i = 1; i <= 5; i++)
            {
                string input = Console.ReadLine();

                if (i == 1 || i == 5)
                {
                    IsValid(surface, input);
                }
                else if (i == 2 || i == 4)
                {
                    IsValid(mantle, input);
                }
                else
                {
                    IsValid(core, input);
                    var match = core.Match(input);
                    length = match.Groups[1].Value.Length;
                   
                }
                
            }
            Console.WriteLine("Valid");
            Console.WriteLine(length);
        }

        private static void IsValid(Regex regex, string input)
        {
            if (!regex.IsMatch(input))
            {
                Console.WriteLine("Invalid");
                Environment.Exit(0);
            }
        }
    }
}
