using System;
using System.Text;
using System.Text.RegularExpressions;

namespace RegexMon
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "!.!asd-asd---??!chuuuu!!!asd-dsa";//Console.ReadLine();
           var bojomonPatern = @"[A-Za-z]+\-[A-Za-z]+";
            var didiMonPatern = @"[^A-Za-z-]+";
            string founByBojo = "";
            int round = 1;

            while (true)
            {
                if (round %2 == 1)
                {
                    if (Regex.IsMatch(input, didiMonPatern))
                    {
                        var didiMatch = Regex.Match(input, didiMonPatern);
                        input = input.Substring(didiMatch.Index + didiMatch.Length);
                        Console.WriteLine(didiMatch.ToString());
                    }
                    else
                    {
                        return;
                    }
                }
                else
                {
                    if (Regex.IsMatch(input, bojomonPatern))
                    {
                        var bojoMatch = Regex.Match(input, bojomonPatern);
                        input = input.Substring(bojoMatch.Index + bojoMatch.Length);
                        Console.WriteLine(bojoMatch.ToString());
                    }
                    else
                    {
                        return;
                    }
                }
                round++;
            }
            
        }
    }
}
