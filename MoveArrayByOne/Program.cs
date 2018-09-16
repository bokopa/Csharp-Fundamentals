using System;

namespace MoveArrayByOne
{
    class Program
    {
        static void Main()
        {
            string[] words = Console.ReadLine().Split(' ');
            var res =ReverseArrayByOneEl(words);
            Console.WriteLine(String.Join(" ", res));
        }
        public static string[] ReverseArrayByOneEl(string[] tockens)
        {
            string[] result = new string[tockens.Length];
            string lastElement = tockens[tockens.Length - 1];
            

            for (int i = 1; i < tockens.Length; i++)
            {
                result[i] = tockens[i - 1];

            }
            result[0] = lastElement;
            return result;
        }
    }
}
