using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MergeDivideStrings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> inputWords = Console.ReadLine().Split(' ').ToList();
            string[] command = Console.ReadLine().Split(' ').ToArray();
            while (command[0] != "3:1")
            {
                if (command[0] == "merge")
                {
                    int startIndex = int.Parse(command[1]);
                    int endIndex = int.Parse(command[2]);
                    if (startIndex < 0)
                    {
                        startIndex = 0;
                    }
                    if (endIndex >= inputWords.Count)
                    {
                        endIndex = inputWords.Count - 1;
                    }
                    for (int i = startIndex; i < endIndex; i++)
                    {
                        inputWords[startIndex] = inputWords[startIndex] + inputWords[startIndex+1];
                        inputWords.RemoveAt(startIndex + 1);
                    }
                }
                else if (command[0] == "divide")
                {
                    int indexToDevide = int.Parse(command[1]);
                    int partitions = int.Parse(command[2]);
                    string wordToPart = inputWords[indexToDevide];
                    int partitionsLenght = wordToPart.Length / partitions;

                    string[] wordOnParts = new string[partitions];
                    for (int i = 0; i < partitions; i++)
                    {
                        if (wordToPart.Length % partitions !=0 && i == partitions-1)
                        {
                            wordOnParts[i] = wordToPart.Substring(0);
                            break;
                        }
                        wordOnParts[i] = wordToPart.Substring(0, partitionsLenght);
                        wordToPart = wordToPart.Remove(0, partitionsLenght);
                    }
                    inputWords.RemoveAt(indexToDevide);
                    inputWords.InsertRange(indexToDevide, wordOnParts);
                }

                command = Console.ReadLine().Split(' ').ToArray();
            }
            Console.WriteLine(String.Join(" ", inputWords));
        }
    }
}
