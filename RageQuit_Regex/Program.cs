using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace RageQuit_Regex
{
class Program
{
    static void Main(string[] args)
    {
       
            string input = Console.ReadLine();
            StringBuilder result = new StringBuilder(); 

        foreach (Match m in Regex.Matches(input, @"([^0-9]+)(\d)"))
        {
                var word = m.Groups[1].Value.ToUpper();
                var count = int.Parse(m.Groups[2].Value);
                for (int i = 0; i < count; i++)
                {
                    result.Append(word);
                }
            }
            int uniqueNumber = result.ToString().Distinct().Count();
    }
}
}
