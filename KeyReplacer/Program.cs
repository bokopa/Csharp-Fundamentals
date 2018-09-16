using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"([A-Za-z]+)[|<\\](.*?)[|<\\]([A-Za-z]+)";

            string key = Console.ReadLine();
            string text = Console.ReadLine();

            var match = Regex.Match(key, patern);

            var startkey = match.Groups[1].ToString();
            var endkey = match.Groups[3].ToString();

            string textPatern = $"{startkey}(.*?){endkey}";

            var matches = Regex.Matches(text, textPatern);

            StringBuilder sb = new StringBuilder();

            foreach (Match item in matches)
            {
                sb.Append(item.Groups[1].ToString());
            }

            var result = sb.Length != 0 ? sb.ToString() : "Empty result";
            Console.WriteLine(result);
        }
    }
}
