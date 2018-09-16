using System;

namespace MaxMetod
{
    class Program
    {
        static void Main(string[] args)
        {
            int firstNumber = int.Parse(Console.ReadLine());
            int secondNumber = int.Parse(Console.ReadLine());
            int thirdNumber = int.Parse(Console.ReadLine());
            int maxNumber = FindMax(firstNumber, FindMax(secondNumber, thirdNumber));
            Console.WriteLine(maxNumber);
        }
         static int FindMax(int firstNum, int secondNum)
        {
            if (firstNum > secondNum)
            {
                return firstNum;
            }
            else
            {
                return secondNum;
            }
            }
        
    }
}
