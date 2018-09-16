using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;

class Program
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
        while (true)
        {
            var commands = Console.ReadLine();
            if (commands == "end")
            {
                break;
            }
            ProcessCommand(input, commands);
        }
        Console.WriteLine($"[{string.Join(", ", input)}]");
    }

    private static void ProcessCommand(List<string> input, string commands)
    {
        var commandsToArray = commands.Split(' ');
        var commandName = commandsToArray[0];
        switch (commandName)
        {
            case "reverse":
                Reverse(input, commandsToArray);
                break;
            case "sort":
                Sort(input, commandsToArray);
                break;
            case "rollLeft":
                RollLeft(input, commandsToArray);
                break;
            case "rollRight":
                RollRight(input, commandsToArray);
                break;
            default:
                Console.WriteLine("Invalid command");
                break;
        }       
    }

  static bool isValid(List<string> input, int startIndex, int count)
    {
        if (startIndex<0)
        {
            return false;
        }
        if (count < 0)
        {
            return false;
        }
        if (startIndex + count >= input.Count+1)
        {
            return false;
        }
        return true;
    }
    static bool isValidRoll(List<string> input, int count)
    {
        
        if (count < 0)
        {
            return false;
        }
       
        return true;
    }

    static void Reverse(List<string> input, string[] commandsToArray)
    {
        var startIndex = int.Parse(commandsToArray[2]);
        var count = int.Parse(commandsToArray[4]);
        if (isValid(input, startIndex, count))
        {
            input.Reverse(startIndex, count);
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }

    }

    static void Sort(List<string> input, string[] commandsToArray)
    {
        var startIndex = int.Parse(commandsToArray[2]);
        var count = int.Parse(commandsToArray[4]);
        if (isValid(input, startIndex, count))
        {
            var firstElements = input.Take(startIndex).ToList();
            var midleElements = input.Skip(startIndex).Take(count).ToList();
            var lastElements = input.Skip(startIndex + count).ToList();
            
            midleElements.Sort();
            input.RemoveRange(startIndex, count);
            input.InsertRange(startIndex, midleElements);
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }
    static void RollLeft(List<string> input, string[] commandsToArray)
    {
        var countToRoll = int.Parse(commandsToArray[1]);
        countToRoll = countToRoll % input.Count;
        if (isValidRoll(input, countToRoll))
        {
            for (int i = 0; i < countToRoll; i++)
            {
                string oldValue = input[0];
                for (int j = 0; j < input.Count - 1; j++)
                {

                    input[j] = input[j + 1];
                }
                input[input.Count - 1] = oldValue;
            }
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
             
    }
    static void RollRight(List<string> input, string[] commandsToArray)
    {
        var countToRoll = int.Parse(commandsToArray[1]);
        countToRoll = countToRoll % input.Count;

        if (isValidRoll(input, countToRoll))
        {
            for (int i = 0; i < countToRoll; i++)
            {
                string oldValue = input[input.Count-1];
                for (int j = input.Count - 1; j > 0 ; j--)
                {
                    input[j] = input[j - 1];
                }
                input[0] = oldValue;
            }
        }
        else
        {
            Console.WriteLine("Invalid input parameters.");
        }
    }
}

