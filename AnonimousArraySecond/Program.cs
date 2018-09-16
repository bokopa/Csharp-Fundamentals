using System;
using System.Collections.Generic;
using System.Linq;

namespace AnonimousArraySecond
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> elements = Console.ReadLine().Split().ToList();
            string input = Console.ReadLine();

            while (input != "3:1")
            {
                string[] splitedInput = input.Split();
                string command = splitedInput[0];
                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(splitedInput[1]);
                        int endIndex = int.Parse(splitedInput[2]);
                        startIndex = ValidateIndex(startIndex, elements.Count);
                        endIndex= ValidateIndex(endIndex, elements.Count);
                        string concatElements = "";
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            concatElements = concatElements + elements[i];
                        }
                        for (int i = startIndex; i <= endIndex; i++)
                        {
                            elements.RemoveAt(startIndex);
                        }
                        elements.Insert(startIndex, concatElements);
                        break;

                    case "devide":
                        int indexToDevide = int.Parse(splitedInput[1]);
                        int partitionsCount = int.Parse(splitedInput[2]);
                        List<string> partitions = SplitedEqualy(elements[indexToDevide], partitionsCount);
                        elements.RemoveAt(indexToDevide);
                        elements.InsertRange(indexToDevide, partitions);
                        break;
                }


                input = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", elements));
        }

        private static List<string> SplitedEqualy(string word, int partitionsCount)
        {
            List<string> result = new List<string>();
            int part = word.Length / partitionsCount;
            while (word.Length >= part)
            {
                result.Add(word.Substring(0, part));
                word = word.Substring(part);
            }
            if (word != "")
            {
                result.Add(word);
            }
            if (result.Count == partitionsCount)
            {
                return result;
            }
            else
            {
                string concatTwoElements = result[result.Count - 2] + result[result.Count - 1];
                result.RemoveRange(result.Count - 2, 2);
                result.Add(concatTwoElements);
                return result;
            }
        }

        private static int ValidateIndex(int index, int lenght)
        {
            if (index < 0)
            {
                index = 0;
            }
            if (index > lenght-1)
            {
                index = lenght - 1;
            }
            return index;
        }
    }
}
