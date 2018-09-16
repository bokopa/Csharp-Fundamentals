using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        string input = Console.ReadLine();
        var result = new Dictionary<string, List<string>>();
        var toPrintDict = new Dictionary<string, string>();
         
        while (input != "Lumpawaroo")
        {
            string pattern = @"(.+?)( \| | -> )(.+)";
            MatchCollection extractedInput = Regex.Matches(input, pattern);

            string firstPart = extractedInput[0].Groups[1].ToString();
            string midlePart = extractedInput[0].Groups[2].ToString();
            string finalPart = extractedInput[0].Groups[3].ToString();
            if (midlePart.Contains(" | "))
            {
                string side = firstPart;
                string memberName = finalPart;
                if (!result.ContainsKey(side))
                {
                    var usersList = new List<string>() { memberName};
                    result.Add(side, usersList);
                }
                else
                {
                    if (!result[side].Contains(memberName))
                    {
                        result[side].Add(memberName);
                    }
                }                   
            }
            else
            {
                string side = finalPart;
                string memberName = firstPart;
                if (!result.ContainsKey(side))
                {
                    if (!result.Values.Any(x => x.Contains(memberName)))
                    {
                        var usersList = new List<string>() { memberName };
                        result.Add(side, usersList);
                        Console.WriteLine($"{memberName} joins the {side} side!");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            if (item.Value.Contains(memberName))
                            {
                                result[item.Key].Remove(memberName);
                            }
                        }
                    }
                }
                else
                {
                    // var usersList = new List<string>() { memberName };
                    result[side].Add(memberName);
                    // string toprint = ($"{memberName} joins the {side} side!");
                    toPrintDict.Add(memberName, side);
                }
            }
            input = Console.ReadLine();
        }
        foreach (var pair in toPrintDict)
        {
            Console.WriteLine($"{pair.Key} joins the {pair.Value} side!");
        }
        foreach (var pair in result.OrderByDescending(x=>x.Value.Count).ThenBy(x=> x.Key))
        {             
            Console.WriteLine($"Side: {pair.Key}, Members: {pair.Value.Count}");
            foreach (var item in pair.Value.OrderBy(x=>x))
            {
                Console.WriteLine($"! {item}");
            }
        }
    }
}

