using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;
namespace HornetComm
{
    class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();
            string messagePattern = @"^([\d]+) <-> ([A-Za-z0-9]+)$";
            string broadcastPattern = @"^([^\d]+) <-> ([A-Za-z0-9]+)$";
            List<string> messagesList = new List<string>();
            List<string> broadcastList = new List<string>();


            while (input!= "Hornet is Green")
            {
                if (Regex.IsMatch(input, messagePattern))
                {
                    MatchCollection messageMatches = Regex.Matches(input, messagePattern);
                    string num = messageMatches[0].Groups[1].ToString();
                    var numToReverse = Reverse(num);
                    string messageText = messageMatches[0].Groups[2].ToString();
                    
                    messagesList.Add(numToReverse+" -> "+messageText);
                }
                else if (Regex.IsMatch(input, broadcastPattern))
                {
                    MatchCollection broadcastMatches = Regex.Matches(input, broadcastPattern);
                    string num = broadcastMatches[0].Groups[2].ToString();                  
                    string broadcastText = broadcastMatches[0].Groups[1].ToString();
                    num = ToUpperLower(num);
                    string f = ToUpperLower(broadcastText);
                    broadcastList.Add(num + " -> " + broadcastText);
                }
               
                input = Console.ReadLine();
            }
            Console.WriteLine("Broadcasts:");
            if (broadcastList.Count > 0)
            {
               
                foreach (var item in broadcastList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
            Console.WriteLine("Messages:");
                if (messagesList.Count > 0)
                {
                    foreach (var item in messagesList)
                {
                    Console.WriteLine(item);
                }
            }
            else
            {
                Console.WriteLine("None");
            }
        }
        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
        public static string ToUpperLower(string s)
        {
            string result = "";
            char[] charArray = s.ToCharArray();
            for (int i = 0; i < charArray.Length; i++)
            {
                if (charArray[i] > 64 & charArray[i] < 91)
                {
                    result = result + charArray[i].ToString().ToLower();
                }
                else if (charArray[i] > 96 & charArray[i] < 123)
                {
                    result = result + charArray[i].ToString().ToUpper();
                }
                else
                {
                    result = result + charArray[i].ToString();
                }

            }
            return result;
        }
    }
}
