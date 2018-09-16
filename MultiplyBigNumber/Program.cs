using System;
using System.Linq;
using System.Text;

namespace MultiplyBigNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            string num1 = Console.ReadLine();
           int num2 = int.Parse(Console.ReadLine());
            int num = 0;
            int reminder = 0;
            int multiplayer = 0;
            StringBuilder sb = new StringBuilder();
            if (num2==0)
            {
                Console.WriteLine("0");
                return;
            }

           
            for (int i = num1.Length - 1; i >= 0; i--)
            {
                multiplayer = (num1[i] - 48) * num2 + reminder;
                num = multiplayer % 10;
                if (multiplayer > 9)
                {
                    reminder = multiplayer/10;
                }
                else
                {
                    reminder = 0;
                }
                sb.Append(num);
            }
            if (reminder >0)
            {
                sb.Append(reminder);
            }
            Console.WriteLine(sb.ToString().TrimEnd('0').ToCharArray().Reverse().ToArray());
        }
    }
}
