using System;
using System.Numerics;
using System.Linq;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main()
    {
        var input = Console.ReadLine();
        
        var privateKey = ToSingleIntArr(input);
        var pattern = @"TO: ([A-Z]+); [A-Z]+: (.+);";
        var resultDict = new Dictionary< string, string >();

        while (true)
        {           

            var row = Console.ReadLine();
            if (row == "END")
            {
                break;
            }
            if (Regex.IsMatch(row, pattern))
            {
                var message = Regex.Match(row, pattern).ToString().ToCharArray();

                var rowReady = ChangeStrMetod(privateKey, message);
                var nameSender = Regex.Match(row, pattern).Groups[1].ToString();

                resultDict.Add(nameSender,rowReady);
            }           
        }
        foreach (var item in resultDict.OrderBy(x=>x.Key))
        {
            Console.WriteLine(item.Value);
        }
           
    }

    private static int[] ToSingleIntArr(string input)
    {
        var toSingleChar = input.ToCharArray();
        int[] arr = new int[toSingleChar.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = int.Parse(toSingleChar[i].ToString());
        }
        return arr;
    }

    private static String ChangeStrMetod(int[] privateKey, char[] message)
    {
        int counter = 0;
        StringBuilder uncriptedRow = new StringBuilder();
        for (int i = 0; i < message.Length; i++)
        {
            if (counter == privateKey.Length)
            {
                counter = 0;
            }
            var currentKey = privateKey[counter];
            var currLetterToChange = message[i];
          var sumInts = currLetterToChange + currentKey;
            char c = (char)currentKey;
            var changedLetter = Convert.ToChar(sumInts);
            message[i] = changedLetter;
           
            uncriptedRow.Append(changedLetter);
            counter++;           
        }
        return uncriptedRow.ToString();
    }
}

