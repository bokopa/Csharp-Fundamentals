using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Problem0003
{
    class Program
    {
        static void Main(string[] args)
        {
            var gamesList = Regex.Split(Console.ReadLine(), @"\s+").ToList();

            while (true)
            {
                var command = Console.ReadLine();
                if (command == "Play!")
                {
                    break;
                }
                var commandsToList = command.Split(' ').ToList();
                var commandName = commandsToList[0];
                var gameName = commandsToList[1];
                switch (commandName)
                {
                    case "Install":
                        Install(gamesList, gameName);
                        break;
                    case "Uninstall":
                        Uninnstall(gamesList, gameName);
                        break;
                    case "Update":
                        Update(gamesList, gameName);
                        break;
                    case "Expansion":
                        AddExpansion(gamesList, gameName);
                        break;
                    default:
                        Console.WriteLine("Invalid command");
                        break;
                }
            }
            Console.WriteLine(String.Join(" ", gamesList));
        }

        private static void AddExpansion(List<string> gamesList, string gameName)
        {
            var gameNameToArr = Regex.Split(gameName, @"-");
            gameName = gameNameToArr[0];
            var extension = gameNameToArr[1];
            if (gamesList.Contains(gameName))
            {
                string nameAndExt = $"{gameName}:{extension}";
               int indexToReplace = gamesList.IndexOf(gameName);
                gamesList.RemoveAt(indexToReplace);
                gamesList.Insert(indexToReplace, nameAndExt);
                gamesList.Insert(indexToReplace, gameName);

            }
        }

        private static void Update(List<string> gamesList, string gameName)
        {
            if (gamesList.Contains(gameName))
            {
                gamesList.Remove(gameName);
                gamesList.Add(gameName);

            }
        }

        private static void Uninnstall(List<string> gamesList, string gameName)
        {
            if (gamesList.Contains(gameName))
            {
                gamesList.Remove(gameName);
            }
            else
            {
                return;
            }
        }

        private static void Install(List<string> gamesList, string gameName)
        {
            if (!gamesList.Contains(gameName))
            {
                gamesList.Add(gameName);
            }
            else
            {
                return;
            }
        }
    }
}
