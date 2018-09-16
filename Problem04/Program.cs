using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem04
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();

            string[] commands = Console.ReadLine().Split(new char[] {'-', '|' },StringSplitOptions.RemoveEmptyEntries).ToArray();
            commands[1].TrimStart();
            commands[1].TrimStart();

            string side = "";
            string name = "";
            string separator = "";
            int countLigth = 0;
            int countDark = 0;

            while (commands[0] != "Lumpawaroo")
            {
                separator = commands[1];
                if (separator == "|")
                {
                    side = commands[0];
                    name = commands[2];
                }
                else
                {
                    side = commands[2];
                    name = commands[0];
                }
                
                

                if (!phonebook.ContainsKey(name))
                {
                    phonebook.Add(name, side);
                }
                if (side == "Light" || side == "Lighter")
                {
                    countLigth++;
                }
                else if (side == "Dark" || side == "Darker")
                {
                    countDark++;
                }

                //    if (!phonebook.ContainsKey(commands[1]))
                //    {
                //        Console.WriteLine($"Contact {commands[1]} does not exist.");
                //    }
                //    else
                //    {
                //        Console.WriteLine($"{commands[1]} -> {phonebook[commands[1]]}");
                //    }
                //}
                commands = Console.ReadLine().Split(new char[] { '-', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            }
                foreach (var pair in phonebook.OrderByDescending(x => x.Key))
                {
                    if (pair.Value == "Dark")
                    {
                        
                        Console.WriteLine($"Side: Dark, Members: {countDark}");
                        Console.WriteLine($"! {pair.Key}");
                    }
                    else if (pair.Value == "Light")
                    {
                        Console.WriteLine($"Side: Light, Members: {countLigth}");
                        Console.WriteLine($"! {pair.Key}");
                    }

                
                

            }
            
           

        }
     
    }
   
}
