using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _3.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> resourcesValue = new Dictionary<string, int>();

            string resourcesString = Console.ReadLine();
          
           

            while (resourcesString!= "stop")
            {
               
                int quantity = int.Parse(Console.ReadLine());

                if (!resourcesValue.ContainsKey(resourcesString))
                {
                    resourcesValue.Add(resourcesString, quantity);
 
                }
                else
                {
                    resourcesValue[resourcesString] += quantity;
                }

                resourcesString = Console.ReadLine();
            }
            foreach (var resource in resourcesValue)
            {
                Console.WriteLine($"{resource.Key} -> {resource.Value}");
            }
        }
    }
}
