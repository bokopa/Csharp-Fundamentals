using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Problem002
{
    class Program
    {
        static void Main(string[] args)
        {
            string d = "";
            var inputStrArr = new List<string>();
            var inputBuilder = new StringBuilder();
            var extractedNumbers = new List<int>();
            var namesList = new List<string>();
            while (true)
            {
                var inputLine = Console.ReadLine();
                d = inputBuilder.AppendJ(' ', inputLine).ToString();

                var e = Regex.Split(d, @"\s+").ToList();

                if (inputStrArr[0] == "Visual")
                {
                    break;
                }

            }
                    for (int i = 0; i < inputStrArr.Count; i++)
                    {
                        if (inputStrArr[i] == "32656" && inputStrArr[i + 1] == "19759" && inputStrArr[i + 2] == "32763")
                        {
                            int magicNumber = 0;
                            if (int.TryParse(inputStrArr[i + 4],out magicNumber))
                            {
                                 magicNumber = int.Parse(inputStrArr[i + 4]);
                            }
                            else
                            {
                                continue;
                            }
                                                    
                            extractedNumbers = inputStrArr.Skip(i + 6).Take(magicNumber).Select(int.Parse).ToList();
                            var concatChars = new StringBuilder(); ;
                            for (int y = 0; y < extractedNumbers.Count; y++)
                            {
                                var a = extractedNumbers[y];
                                char c = Convert.ToChar(a);
                                concatChars.Append(c);
                            }
                            namesList.Add(concatChars.ToString());

                        }
                        else
                        {
                            continue;
                        }

                    }
                }

            
            foreach (var item in namesList)
            {
                Console.WriteLine(item);
            }
        }
    }
}