using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Numerics;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> allFiles = new List<string>();
            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                string inp = Console.ReadLine();
                allFiles.Add(@inp);
            }
            string filter = Console.ReadLine();
            var filterTokens = Regex.Split(filter, " in ");
            var filterExt = '.' + filterTokens[0];
            var filterRoot = filterTokens[1]+'\\';
            var fileSize = new Dictionary<string, BigInteger>();

            foreach (var item in allFiles)
            {
                var tokens = item.Split(';');
                var path = tokens[0];
                var size = BigInteger.Parse(tokens[1]);
                if (path.StartsWith(filterRoot) && path.EndsWith(filterExt))
                {
                    var tokens1 = path.Split('\\');
                    var fileName = tokens1[tokens1.Length - 1];
                    fileSize[fileName] = size;

                }
            }
                if (fileSize.Count == 0)
                {
                    Console.WriteLine("null");
                    return;
                }
            foreach (var item in fileSize.OrderByDescending(s => s.Value).ThenBy (s => s.Key))
            {
                
                
                    Console.WriteLine(item.Key + " - " + item.Value + " KB");
                
            }
        }
       

    }
}
