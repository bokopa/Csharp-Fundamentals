using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
namespace Vox
{
    class Program
    {
        static void Main(string[] args)
        {
            string placeholder = Console.ReadLine();
            string placeholderPattern = @"([A-Za-z]+)(.+)(\1)";
            string value = Console.ReadLine();
            string valuePattern = @"{(.*?)}";
            MatchCollection placeholdersMatches = Regex.Matches(placeholder, placeholderPattern);
            MatchCollection valueMatches = Regex.Matches(value, valuePattern);
            for (int i = 0; i < Math.Min(placeholdersMatches.Count, valueMatches.Count); i++)
            {
                string toChange = placeholdersMatches[i].Groups[2].ToString();
                string toPut = valueMatches[i].Groups[1].ToString();
                int index = placeholder.IndexOf(toChange);
                placeholder = placeholder.Replace(toChange, toPut);
            }
            Console.WriteLine(placeholder);
        }
    }
}

