﻿using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _2.Advertisement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            string[] Phrases = new string[] { "Excellent product.",
                "Such a great product.",
            "I always use that product.",
            "Best product of its category.",
            "Exceptional product.",
            "I can’t live without this product."};


            string[] Events = new string[] { "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!" };

            string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };

            string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

            Random message = new Random();
                                    
            for (int i = 0; i < number; i++)
            {

                int PhraseIndex = message.Next(0, Phrases.Length);
                int EventIndex = message.Next(0, Events.Length);
                int AuthorIndex = message.Next(0, Authors.Length);
                int CityIndex = message.Next(0, Cities.Length);


                Console.WriteLine(Phrases[PhraseIndex] + " " + Events[EventIndex] + " " + Authors[AuthorIndex] + " - " + Cities[CityIndex]);
            }
        }
    }
}
