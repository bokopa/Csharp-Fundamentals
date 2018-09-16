using System;

namespace MasterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int lastNumber = int.Parse(Console.ReadLine());

            for (int i = 1; i <=lastNumber; i++)
            {
                if (IsSymetric(i) && SumOfDigits(i) % 7 == 0 && isHoldEven(i))
                {
                    Console.WriteLine(i);
                }
                
            }
        }
        static bool IsSymetric(int number)
        { 
            string numberString = number.ToString();
            int counter = numberString.Length - 1;
            for (int i = 0; i < numberString.Length-1; i++)
            {
                if (numberString[i] != numberString[counter])
                {
                    return false;
                }
                counter--;
            }
            return true;
        }
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number>0)
            {
               int currDigit = number % 10;
                sum += currDigit;
                number /= 10;
            }
           
            return sum;
        }
        static bool isHoldEven(int number)
        {
            
            while (number > 0)
            {
                int currDigit = number % 10;
                if (currDigit%2==0)
                {
                    return true;
                }
               
                number /= 10;
            }

            return false;
        }
    }
}
