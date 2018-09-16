using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace DemonsBattleThird
{
    class Program
    {
        static void Main(string[] args)
        {
            var demons = Console.ReadLine().Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            SortedDictionary<string, int> demonHealts = new SortedDictionary<string, int>();
            SortedDictionary<string, double> demonsDamages = new SortedDictionary<string, double>();
            string patern = @"-?\d+\.?\d*";
           
            foreach (var demon in demons)
            {
                var healt = demon.Where(s => !char.IsDigit(s) &&
                    s != '+' && s != '-' && s != '*' && s != '/' && s != '.').Sum(s => s);
                demonHealts[demon] = healt;

                var matches = Regex.Matches(demon, patern);

                var damage = 0.0;

                foreach (Match item in matches)
                {
                    var result = double.Parse(item.Value);
                    damage += result;
                }

                foreach (var symbol in demon)
                {
                    if (symbol == '*')
                    {
                        damage *= 2;
                    }
                    if (symbol == '/')
                    {
                        damage /= 2;
                    }
                }
                demonsDamages[demon] = damage;
            }
            foreach (var demon in demonsDamages)
            {
                var demonName = demon.Key;
                var demonDamage = demon.Value;
                var demonHealt = demonHealts[demonName];
                Console.WriteLine($"{demonName} - {demonHealt} health, {demonDamage:F2} damage");
            }
        }
    }
}
