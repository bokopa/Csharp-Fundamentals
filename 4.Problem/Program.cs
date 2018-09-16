using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _4Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var secondsExtracted = 0;
            var hoursExtracted = 0;
            string namePattern = @"\[([^\- ][A-Za-z \-]+)]";
            string lyricsPattern = @"""([A-Za-z ]+)""|""\b([A-Za-z ]+)""";
            string minutesPattern = @"([\d{1|2}]+\:\d{2})m|\b([\d{1|2}]+\:\d{2})m";
            string secondsPattern = @"(\d+)s|(\d+)s";
            List<string> result = new List<string>();
            //string pattern = @"^(<\[[\W_]*[\]]\.)(\.\[[^\W_]*\]\.)*$";

            string input = Console.ReadLine();
            List<string> loko = new List<string>();

            while (input != "Rock on!")
            {
                var lyrics = Regex.Match(input, lyricsPattern).Groups[1].Value.ToString();
                // StringBuilder sb = new StringBuilder();
                var name = Regex.Match(input, namePattern).Groups[1].Value.ToString();
              
                var minutes = Regex.Match(input, minutesPattern).Groups[1].Value.ToString();
                if (Regex.IsMatch(input, minutesPattern))
                {
                    if (int.Parse(minutes) > 60)
                    {
                        continue;
                    }
                }
                if (Regex.IsMatch(input, secondsPattern))
                {
                    var seconds = Regex.Match(input, secondsPattern).Groups[1].Value.ToString();
                    if (int.Parse(seconds)>3600 && int.Parse(seconds) <1)
                    {
                        continue;
                    }
                     secondsExtracted = int.Parse(seconds) % 60;
                     hoursExtracted = (int.Parse(seconds) - secondsExtracted) / 60;
                }
                
          

                if (Regex.IsMatch(input,namePattern) && Regex.IsMatch(input, lyricsPattern))
                {

                    if (Regex.IsMatch(input, minutesPattern))
                    {
                        string s = $"{name} -> {minutes} => {lyrics}";
                        result.Add(s);
                    }
                    else if (Regex.IsMatch(input, secondsPattern))
                    {
                        
                        string s = $"{name} -> {hoursExtracted:D2}:{secondsExtracted:D2} => {lyrics}";
                        result.Add(s);
                    }
                }
                input = Console.ReadLine();
            }
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }
    }
}