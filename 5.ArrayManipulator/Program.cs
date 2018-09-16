using System;
using System.Collections.Generic;
using System.Linq;




namespace _5.ArrayManipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                  .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                  .Select(int.Parse)
                  .ToList();
            string command = Console.ReadLine();

            while (command != "print")
            {
                string[] commandToArray = command.Split(' ').ToArray();

                if (commandToArray[0] == "add")
                {
                    int index = int.Parse(commandToArray[1]);
                    int element = int.Parse(commandToArray[2]);
                    numbersList.Insert(index, element);
                }
                else if (commandToArray[0] == "addMany")
                {
                    int index = int.Parse(commandToArray[1]);
                    List<int> elements = new List<int>();
                    for (int i = 2; i < commandToArray.Length; i++)
                    {
                       
                        elements.Add(int.Parse(commandToArray[i]));
                    }

                    numbersList.InsertRange(index, elements);
                }
                else if (commandToArray[0] == "remove")
                {
                    numbersList.RemoveAt(int.Parse(commandToArray[1]));
                }
                else if (commandToArray[0] == "shift")
                {
                    int rotations = int.Parse(commandToArray[1]);
                    for (int i = 0; i < rotations; i++)
                    {
                        int currentNumber = numbersList[0];
                        for (int j = 1; j < numbersList.Count; j++)
                        {
                            numbersList[j - 1] = numbersList[j];
                        }
                        numbersList[numbersList.Count - 1] = currentNumber;
                    }                  
                    }
                else if (commandToArray[0] == "sumPairs")
                {
                    for (int i = 0; i < numbersList.Count-1; i++)
                    {
                        numbersList[i] = numbersList[i] + numbersList[i+1];
                        numbersList.RemoveAt(i + 1);
                    }
                }
                else if (commandToArray[0] == "contains")
                {
                    //int number = int.Parse(commandToArray[1]);
                    Console.WriteLine(numbersList.IndexOf(int.Parse(commandToArray[1])));
                }




                command = Console.ReadLine();
            }
        Console.WriteLine($"[{String.Join(", ", numbersList)}]");
        }
    }
}
