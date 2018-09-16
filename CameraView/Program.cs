using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string text = Console.ReadLine();
            string patern = @"\|<(.*?)(?=\||$)";

            var matches = Regex.Matches(text, patern);
            List<string> camera = new List<string>();

            foreach (Match sentence in matches)
            {
                var input = sentence.Groups[1].ToString().Skip(elements[0]).Take(elements[1]).ToArray();
                var element = String.Concat(input);
                camera.Add(element);

            }
            Console.WriteLine(String.Join(", ", camera));
        }
    }
}
