using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace NestedDictionary
{
    class Program
    {
        static void Main()
        {
            var result = new Dictionary<string, Dictionary<string, List<string>>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(' ').ToArray();
                string continent = input[0];
                string country = input[1];
                string city = input[2];
                if (!result.ContainsKey(continent))
                {
                    var nestDict = new Dictionary<string, List<string>>();
                    var tempList = new List<string>() { city };
                    nestDict.Add(country, tempList);
                    result.Add(continent, nestDict);
                }
                else
                {
                    if (!result[continent].ContainsKey(country))
                    {
                        result[continent].Add(country, new List<string>() { city });
                    }
                    else
                    {
                        result[continent][country].Add(city);
                    }
                }

            }
            foreach (var pair in result)
            {
                Console.WriteLine($"{pair.Key}");

                foreach (var nestedPair in pair.Value)
                {
                    Console.WriteLine($"{nestedPair.Key} -> {string.Join(" ", nestedPair.Value)}");
                }
            }

        }
    }
}