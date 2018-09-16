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
        string pattern = @"^(<\[[\W_]*[\]]\.)(\.\[[^\W_]*\]\.)*$";
 
        string input = Console.ReadLine();
        List<string> loko = new List<string>();
  
        while (input != "Traincode!")
        {
            var trainMatch = Regex.Matches(input, pattern);
            StringBuilder sb = new StringBuilder();
            if (Regex.IsMatch(input, pattern))
            {
                foreach (Match item in trainMatch)
                {
                    sb.Append(item);         
                }
                loko.Add(sb.ToString());
            }

            sb.Clear();
            input = Console.ReadLine();
        }
        foreach (var item in loko)
        {
            Console.WriteLine(item);
        }
    }
    }

