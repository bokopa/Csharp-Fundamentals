using System;
using System.Linq;
using System.Collections.Generic;

namespace _2._Change_List
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            string inputLine = Console.ReadLine();

            while (inputLine != "Even" && inputLine != "Odd")
            {
                string[] inputToArr = inputLine.Split(' ').ToArray();
                                               
                if (inputToArr[0] == "Delete")
                {
                    int number = int.Parse(inputToArr[1]);
                    for (int i = 0; i < numbersList.Count; i++)
                    {
                        numbersList.Remove(number);
                    }

                }
                else if (inputToArr[0] == "Insert")
                {
                    int element = int.Parse(inputToArr[1]);
                    int index = int.Parse(inputToArr[2]);
                    numbersList.Insert(index, element);

                }
                inputLine = Console.ReadLine();
            }
            if (inputLine == "Odd")
            {
                foreach (var item in numbersList)
                {
                    if (item % 2 != 0)
                    {
                        Console.Write(item + " ");
                    }

                }
                Console.WriteLine();
            }
            else if (inputLine == "Even")
            {
                foreach (var item in numbersList)
                {
                    if (item % 2 == 0)
                    {
                        Console.Write(item + " ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
