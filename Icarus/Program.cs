using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


class Program
{
    static void Main()
    {
        List<int> inputNumbesList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse).ToList();
        int startIndex = int.Parse(Console.ReadLine());
        int currentIndex = startIndex;
        int decrIndex = 1;
        string[] command = Console.ReadLine().Split(' ').ToArray();

        while (command[0] != "Supernova")
        {
            int step = int.Parse(command[1]);
            if (command[0] == "left")
            {
                for (int i = 0; i < step; i++)
                {   
                        if (currentIndex == 0)
                        {
                        decrIndex++;
                        currentIndex = inputNumbesList.Count-1;
                    }
                    else
                    {                       
                        currentIndex--;
                    }
                    inputNumbesList[currentIndex] =
                   inputNumbesList[currentIndex] - decrIndex;
                }
            }
            else if (command[0] == "right")

            {
                for (int i = 0; i < step; i++)
                {                                    
                        if (currentIndex == inputNumbesList.Count-1)
                        {
                        currentIndex = 0;
                        decrIndex++;
                        }
                    else
                    {
                      
                        currentIndex++;
                    }
                    inputNumbesList[currentIndex] =
                 inputNumbesList[currentIndex] - decrIndex;
                }
                }
            
            command = Console.ReadLine().Split(' ').ToArray();
            }
        Console.WriteLine(String.Join(" ", inputNumbesList));
        }
    }

