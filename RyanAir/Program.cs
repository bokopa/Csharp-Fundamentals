using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace RyanAir
{
    class Program
    {
        static void Main(string[] args)
        {

            var result = new Dictionary<string, List<int>>();

            while (true)
            {
                var input = Console.ReadLine();
                if (input == "I believe I can fly!")
                {
                    break;
                }
                var inputToList = input.Split(' ').ToList();
                if (inputToList[1] != @"=")
                {
                    string name = inputToList[0];
                    if (name.Contains(" ") && name.Contains(@"="))
                    {
                        continue;
                    }
                    inputToList.RemoveAt(0);
                    List<int> flightNumbers = inputToList.Select(int.Parse).ToList();
                    if (result.ContainsKey(name))
                    {

                        (result[name]).AddRange(flightNumbers);
                    }
                    else
                    {
                        result.Add(name, flightNumbers);
                    }
                }
                else
                {
                    var name1 = inputToList[0];
                    var name2 = inputToList[2];
                   
                    if (result.ContainsKey(name1))
                    {
                        result[name1] = result[name2].ToList();
                    }
                }
            }
            foreach (var pair in result.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                Console.WriteLine($"#{pair.Key} ::: {string.Join(", ", pair.Value.OrderBy(x => x))}");
            }
        }
    }
}