using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem01try
{
    class Program
    {
        static void Main(string[] args)
        {
            int startIndex = 0;
            int curentLenth = 1;
            int maxStart = 0;
            int maxLength = 1;
            int siquenceLenght = int.Parse(Console.ReadLine());           
            List<string> rowsAsStringFirst = new List<string>();
            List<string> rowsAsString = new List<string>();
            List<string> rowsAsStringSec = new List<string>();
            int[] resultArr = new int[4] {0,0,0,0 };
            int rowsCounter = 1;
            string command = Console.ReadLine();

            while (command != "Clone them!")
            {
                rowsAsStringFirst.Add(command);               
                var splitedRowArray = command.Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse)
                .ToArray();
                if (splitedRowArray.Length>siquenceLenght )
                {
                    return;
                }
                rowsAsStringSec = rowsAsStringFirst.Select(x => x.Replace("!", "")).ToList();
                // rowsAsStringSec.Select(y => y.Replace(String.Empty, " "));
                // rowsAsString = rowsAsStringSec.Select(c => c.Split(new string[] { "" }, StringSplitOptions.RemoveEmptyEntries).ToList());
                StringBuilder sb = new StringBuilder();

                foreach (var item in splitedRowArray.Select(d => d.ToString()))
                {
                    sb.Append(item);
                    sb.Append(" ");

                }
                rowsAsString.Add(sb.ToString());
                for (int i = 1; i < splitedRowArray.Length; i++)
                    {
                    if (splitedRowArray[i] == 0)
                    {

                        continue;
                    }
                        if (splitedRowArray[i] == splitedRowArray[i - 1])
                        {
                            curentLenth++;
                            if (curentLenth > maxLength)
                            {
                               maxLength = curentLenth;
                                maxStart = startIndex;
                            }
                        }
                        else
                        {
                            curentLenth = 1;
                            startIndex = i;

                        }
   
                    }
                int subsiquence = maxLength;
                int currIndex = maxStart;
                int sumForCurrRow = splitedRowArray.Sum();
                int[] resultArrCurr = new int[4];
                resultArrCurr[0] = rowsCounter;
                resultArrCurr[1] = subsiquence;
                resultArrCurr[2] = currIndex;
                resultArrCurr[3] = sumForCurrRow;

                if (resultArrCurr[1] > resultArr[1])
                    {
                    resultArr = resultArrCurr;
                  }
                else if (resultArrCurr[1] == resultArr[1])
                {
                    if (resultArrCurr[2] < resultArr[2])
                    {
                        resultArr = resultArrCurr;
                    }
                    else if (resultArrCurr[2] == resultArr[2])
                    {
                        if (resultArrCurr[3] > resultArr[3])
                        {
                            resultArr = resultArrCurr;
                        }
                    }
                }
                command = Console.ReadLine();
                maxLength = 0; ;
                rowsCounter++;
            }

            Console.WriteLine($"Best DNA sample {resultArr[0]} with sum: {resultArr[3]}.");
            Console.WriteLine(String.Join(" ", rowsAsString[resultArr[0] - 1]));
            }
    }
}
