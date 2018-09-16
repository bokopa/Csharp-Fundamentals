using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
           
            Dictionary<string, List<int>> result = new Dictionary<string, List<int>>();

            for (int i = 0; i < n; i++)
            {
                string nameInput = Console.ReadLine();
                int gradeInput = int.Parse(Console.ReadLine());
                List<int> grades = new List<int>();

                if (!result.ContainsKey(nameInput))
                {
                    grades.Add(gradeInput);
                    result.Add(nameInput, grades);
                }
                else
                {

                    result[nameInput].Add(gradeInput);
                }

            }


            Dictionary<string, int> wordCounts = new Dictionary<string, int>();

            foreach (var word in siquence)
            {
                if (!wordCounts.ContainsKey(word))
                {
                    wordCounts.Add(word, 1);
                }
                else
                {
                    wordCounts[word]++;
                }
            }
     
        }
    }
}
