using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PockemonDontGo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> inputNumbesList = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
              .Select(int.Parse).ToList();
            int consoleIndex = int.Parse(Console.ReadLine());
           
            int sum = 0;
            int indexToRemove = 0;

         

            while (inputNumbesList.Count > 0)
            {
                if (consoleIndex > inputNumbesList.Count - 1)
                {
                    indexToRemove = inputNumbesList[inputNumbesList.Count - 1];
                    inputNumbesList[inputNumbesList.Count - 1] = inputNumbesList[0];
                    
                }
                else if (consoleIndex < 0)
                {
                    indexToRemove = inputNumbesList[0];
                    inputNumbesList[0] = inputNumbesList[inputNumbesList.Count - 1];
                  
                }
                else
                {
                    indexToRemove = inputNumbesList[consoleIndex];
                    inputNumbesList.RemoveAt(consoleIndex);
                
                    
                }
                sum += indexToRemove;
                    for (int i = 0; i < inputNumbesList.Count; i++)
                    {
                    if (inputNumbesList[i]<= indexToRemove)
                    {
                        inputNumbesList[i] += indexToRemove;
                    }
                    else
                    {
                        inputNumbesList[i] -= indexToRemove;
                    }
                    }
                if (inputNumbesList.Count>0)
                {
                    consoleIndex = int.Parse(Console.ReadLine());
                }
                

            }
            Console.WriteLine(sum);
        }
    }
}
