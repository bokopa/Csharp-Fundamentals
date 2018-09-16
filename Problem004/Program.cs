using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem004
{
    class Program
    {
        static void Main(string[] args)
        {
            string playerAndPositionPattern = @"(\w+) -> (\w+) -> (\d+)";
            string playerVsPlayerPattern = @"(\w+) vs (\w+)";
            var resultDictionary = new Dictionary<string, List<string>>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "Season end")
                {
                    break;
                }
                if (Regex.IsMatch(input, playerAndPositionPattern))
                {
                    var playerName = Regex.Match(input, playerAndPositionPattern).Groups[1].ToString();
                    var playerPosition = Regex.Match(input, playerAndPositionPattern).Groups[2].ToString();
                    var playerSkillstr = Regex.Match(input, playerAndPositionPattern).Groups[3].ToString();
                    int playerSkillInt = int.Parse(playerSkillstr);
                    
                    if (!resultDictionary.ContainsKey(playerName))
                    {
                        
                        var positionList = new List<string>() { playerPosition, playerSkillstr };
                        
                        resultDictionary.Add(playerName, positionList);
                    }
                    else
                    {
                        var positionList = new List<string>() { playerPosition, playerSkillstr };
                        resultDictionary[playerName].Add(playerPosition);
                       // var nestedDictionary = new Dictionary<List<string>, int>();
                      //  var positionList = new List<string>() { playerPosition };
                       // nestedDictionary.Add(positionList, playerSkillInt);
                       // resultDictionary[playerName] = nestedDictionary;
                                               
                    }

                }
                else if (Regex.IsMatch(input, playerVsPlayerPattern))
                {
                    var firstPlayerName = Regex.Match(input, playerAndPositionPattern).Groups[1].ToString();
                    var secondPlayerName = Regex.Match(input, playerAndPositionPattern).Groups[2].ToString();

                }

            }
            foreach (var pair in resultDictionary)
            {
                Console.Write(pair.Key);
                foreach (var item in resultDictionary[pair.Key])
                {
                    if (int.TryParse(item, out int p))
                    {

                    }
                    else
                    {
                        Console.Write($": {item} skill");
                    }
                   
                }
            }
        }
    }
}
