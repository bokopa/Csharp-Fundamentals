using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;

namespace StarEnigma
{
    class Program
    {
        static void Main(string[] args)
        {
           string planetName = "";
            string population = "";
            string typeOfPlanet = "";
            string soldiersNumber = "";
            string planetPattern = @"@([A-Za-z]+)";
            string populationPattern = @"\:([\d]+)";
            string typePattern = @"!(A|D)";
            string soldierCountPattern = @"[->]([\d]+)";
            string input = "";
            string editedInput = "";
            int lettersCount = 0;
            int attacedCount = 0;
            int destroyedCount = 0;
            string attacedPlanet = "";
            string destroyedPlanet = "";
            List<Match> attakedList = new List<Match>();
            List<Match> destroyedList = new List<Match>();

            int inputNumber = int.Parse(Console.ReadLine());
            for (int i = 0; i < inputNumber; i++)
            {
                input = Console.ReadLine();
                lettersCount = CountMetod(input);
                editedInput = DecreaseMetod(input, lettersCount);
                try
                {

                }
                catch (Exception)
                {

                    throw;
                }
                    Match planetNameMatch = Regex.Match(editedInput, planetPattern);
                if (planetNameMatch.Value)
                {
 
                    planetName = planetNameMatch[0].Groups[1].Value;
                }
                    MatchCollection populationMatch = Regex.Matches(editedInput, populationPattern);               
                if (populationMatch.Count > 0)
                {

                  population = populationMatch[0].Groups[1].Value;
                }
                    MatchCollection typeMatch = Regex.Matches(editedInput, typePattern);
                if (typeMatch.Count > 0)
                {

                    typeOfPlanet = typeMatch[0].Groups[1].Value;
                }
                    MatchCollection soldiers = Regex.Matches(editedInput, soldierCountPattern);
                if (soldiers.Count>0)
                {

                   soldiersNumber = soldiers[0].Groups[1].Value;
                }
                    
                if (planetNameMatch.Count > 0 & populationMatch.Count > 0 & typeMatch.Count > 0 & soldiers.Count > 0)
                {
                    if (typeOfPlanet == "A")
                    {
                        attacedCount++;
                        attakedList.Add(planetName);
                    }
                    else if (typeOfPlanet == "D")
                    {
                        destroyedCount++;
                        destroyedList.Add(planetName);
                    }
                }
                
         
            }

            Console.WriteLine($"Attacked planets: {attacedCount}");
            foreach (var item in attakedList)
            {
                Console.WriteLine(@"-> " + item);
            }
            Console.WriteLine($"Destroyed planets: {destroyedCount}");

            foreach (var item in destroyedList.OrderBy(s => s))
            {
                Console.WriteLine(@"-> " + item);
            }
        }

        private static int CountMetod(string s)
        {
            char[] charArray = s.ToCharArray();
            int count = 0;
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] == 115 || charArray[i] == 116 || charArray[i] == 97 || charArray[i] == 114 ||
                    charArray[i] == 83 || charArray[i] == 84 || charArray[i] == 65 || charArray[i] == 82)
                {
                    count++;
                }                              
            }
            return count;
        }
        private static string DecreaseMetod(string s, int n)
        {
            string result = "";
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                    var decrChar = charArray[i] - n;
                var toChar = Convert.ToChar(decrChar);
                    result = result + toChar.ToString();                   
            }
            return result;
        }
    }
}
