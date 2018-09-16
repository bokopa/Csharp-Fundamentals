using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace AnonimousRegExMisho
{
    class Program
    {
        static void Main(string[] args)
        {
            string encodedText = Console.ReadLine();

            string[] placeholders = Console.ReadLine().Split("{}".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            string patern= @"([a-zA-Z]+)(.+)(\1)";

           var matches = Regex.Matches(encodedText, patern);
            int count = 0;
            string decodedMessage = "";
            foreach (Match item in matches)
            {

                decodedMessage = item.Groups[1] + placeholders[count++] + item.Groups[3];
                encodedText = encodedText.Replace(item.Value, decodedMessage);

            }
            Console.WriteLine(encodedText);
        }
    }
}
