using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2Problem
{
    class Program
    {
        static void Main(string[] args)
        {
            var moneyToSpend = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .ToList();
            var drumsQualitiListInitial = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            List<int> drumsQualitiListCurrent = new List<int>();
            for (int i = 0; i < drumsQualitiListInitial.Count; i++)
            {
                drumsQualitiListCurrent.Add(drumsQualitiListInitial[i]);
            }
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Hit it again, Gabsy!")
                {
                    break;
                }
                else
                {
                    var hitPower = int.Parse(input);


                    DrumPowerDecrease(drumsQualitiListCurrent, hitPower);
                    DrumReplacement(drumsQualitiListCurrent, drumsQualitiListInitial, moneyToSpend);
                }
            }

            foreach (var item in drumsQualitiListCurrent)
            {
                Console.Write($"{ item} ");
            }
            Console.WriteLine();
            double e = moneyToSpend[0];
            Console.WriteLine($"Gabsy has {e:F2}lv.");
        }

        private static void DrumReplacement(List<int> drumsQualitiListCurrent, List<int> drumsQualitiListInitial,List<double> moneyToSpend)
        {
           
            for (int i = 0; i < drumsQualitiListCurrent.Count; i++)
            {
               
                if (drumsQualitiListCurrent[i] <= 0)
                {
                    if (moneyToSpend[0] >= drumsQualitiListInitial[i]*3)
                    {
                        moneyToSpend[0] = moneyToSpend[0] - (drumsQualitiListInitial[i] * 3);
                        drumsQualitiListCurrent[i] = drumsQualitiListInitial[i];
                    }
                    else
                    {
                        drumsQualitiListCurrent.RemoveAt(i);
                        drumsQualitiListInitial.RemoveAt(i);
                        i--;
                    }
                }
            }
        }

        private static void DrumPowerDecrease(List<int> drumsQualitiListCurrent, int hitPower)
        {
            for (int i = 0; i < drumsQualitiListCurrent.Count; i++)
            {
                drumsQualitiListCurrent[i] = drumsQualitiListCurrent[i] - hitPower;

            }
        }
    }
        }
    
