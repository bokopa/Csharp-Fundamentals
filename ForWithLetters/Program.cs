﻿using System;

namespace ForWithLetters
{
    class Program
    {
        static void Main(string[] args)
        {
            char first = char.Parse(Console.ReadLine());
            char second = char.Parse(Console.ReadLine());
            char toAvoid = char.Parse(Console.ReadLine());
           
            int counter = 0;

            for (char i = first; i <= second; i++)
            {
                for (char j = first; j <= second; j++)
                {
                    for (char k = first; k <= second; k++)
                    {
                        if (i != toAvoid && j != toAvoid && k != toAvoid)
                        {
                            Console.Write($"{i}{j}{k} ");
                        }
                    }
                }
            }
           
        }
    }
}
