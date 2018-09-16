﻿using System;
using System.Linq;

namespace CompareCharArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] firstArray = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
               .ToArray();
            char[] secondArray = Console.ReadLine()
              .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(char.Parse)
              .ToArray();
            int length = Math.Min(firstArray.Length, secondArray.Length);
            bool isFirst = false;
            for (int i = 0; i < length; i++)
            {
                
                    if (firstArray[i] < secondArray[i])
                    {
                        isFirst = true;
                        break;
                    }
                    else
                    {
                       // isFirst = false;
                        break;
                    
                }
            }
            if (isFirst || firstArray.Length < secondArray.Length)
            {
                Console.WriteLine(string.Join("",firstArray));
                Console.WriteLine(string.Join("", secondArray));
            }
            else
            {
                Console.WriteLine(string.Join("", secondArray));
                Console.WriteLine(string.Join("", firstArray));
            }
        }
    }
}
