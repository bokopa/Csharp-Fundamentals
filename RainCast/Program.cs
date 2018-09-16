using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace RainCast
{
    class Program
    {
        static void Main(string[] args)
        {
            var typePattern = @"^Type: ([(Normal|Danger|Warning]+$)";
            bool typeIsValid = false;
            var sourcePattern = @"^Source: ([A-Za-z0-9]+$)";
            bool sourceIsValid = false;
            var forecastPattern = @"^Forecast: ([^!.,?\n]+$)";
            bool forecastIsValid = false;
            var inputList = new List<string>();
            var resultList = new List<string>();
            var printList = new List<string>();
            int counter = 0;

            while (true)
            {
                var inputLine = Console.ReadLine();
                if (inputLine == "Davai Emo")
                {
                    break;
                }
                if (Regex.IsMatch(inputLine, typePattern) || Regex.IsMatch(inputLine, sourcePattern) || Regex.IsMatch(inputLine, forecastPattern))
                {
                    inputList.Add(inputLine);
                }
            }
            int i = 0;
            while (i < inputList.Count)
            {
                if (Regex.IsMatch(inputList[i], typePattern) && typeIsValid == false)
                {
                    resultList.Add(inputList[i]);
                    typeIsValid = true;
                }

                if (typeIsValid && Regex.IsMatch(inputList[i], sourcePattern) && sourceIsValid == false)
                {
                    resultList.Add(inputList[i]);

                    sourceIsValid = true;
                }
                if (typeIsValid && sourceIsValid && Regex.IsMatch(inputList[i], forecastPattern) && forecastIsValid == false)
                {
                    resultList.Add(inputList[i]);
                    forecastIsValid = true;
                }

                i++;
                if (typeIsValid && sourceIsValid && forecastIsValid)
                {
                    typeIsValid = false;
                    sourceIsValid = false;
                    forecastIsValid = false;
                
                var type = Regex.Match(resultList[counter++], typePattern).Groups[1].Value;
                var source = Regex.Match(resultList[counter++], sourcePattern).Groups[1].Value; ;
                var forecast = Regex.Match(resultList[counter++], forecastPattern).Groups[1].Value; ;
                string s = ($"({type}) {forecast} ~ {source}");
                    printList.Add(s);
            }
            }
            foreach (var item in printList)
            {
                Console.WriteLine(item);
            }
            
        }
    }

}
