using System;
using System.Text.RegularExpressions;

namespace ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            string keyWord = Console.ReadLine();
            string text = Console.ReadLine();

            string[] sentences = text.Split(".!?".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var sentence in sentences)
            {
                var words = Regex.Split(sentence, @"[^A-Za-z0-9]+");

                foreach (var word in words)
                {
                    if (word == keyWord)
                    {
                        Console.WriteLine(sentence.Trim());
                        break;
                    }
                }
            }
        }
    }
}
