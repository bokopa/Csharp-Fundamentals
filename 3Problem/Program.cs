using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _3Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            string namePattern = @"^\[([A-Za-z\s\-]+)]";
            string lyricsPattern = @"^""([A-Za-z ]+)""";
            //string pattern = @"^(<\[[\W_]*[\]]\.)(\.\[[^\W_]*\]\.)*$";

            string input = Console.ReadLine();
            List<string> loko = new List<string>();

            while (input != "Traincode!")
            {
                var lyrics = Regex.Match(input, lyricsPattern).Groups[1].ToString().TrimStart().TrimEnd();
               // StringBuilder sb = new StringBuilder();
                var name = Regex.Match(input, namePattern).Groups[1].ToString().TrimStart().TrimEnd();
                if (true)
                {

                }
                input = Console.ReadLine();
            }
            foreach (var item in loko)
            {
                Console.WriteLine(item);
            }
        }
    }
}
