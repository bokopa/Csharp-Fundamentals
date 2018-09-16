using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bees
{
    class Program
    {
        static void Main(string[] args)

        {
            List<long> beesInHouse = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
             .Select(long.Parse).ToList();
            List<long> beesInHouseArr = new List<long>();

            List<long> hornets = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(long.Parse).ToList();

           long sumOfHPower = hornets.Sum();
           
            for (int i = 0; i < beesInHouse.Count; i++)
            {
                if (beesInHouse[i] < sumOfHPower)
                {
                    beesInHouse[i] = 0;
                }
                else
                {                
                    beesInHouse[i] -= sumOfHPower;
                    if (hornets.Count>0)
                    {
                        hornets.RemoveAt(0);
                    }
                    else
                    {
                        break;
                    }
                   
                }
                sumOfHPower = hornets.Sum();
            }
            for (int i = 0; i < beesInHouse.Count; i++)
            {
                if (beesInHouse[i] != 0)
                {
                    beesInHouseArr.Add(beesInHouse[i]);
                }
            }
            if (beesInHouse.Sum() > 0)
            {
                Console.WriteLine(String.Join(" ", beesInHouseArr));
            }
            else
            {
                Console.WriteLine(String.Join(" ", hornets));
            }
         
        }
    }
}
