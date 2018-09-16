using System;

namespace ASCIItable
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end= int.Parse(Console.ReadLine());
            //  char start = Console.ReadLine(char start);

            for (int i = start; i <= end; i++)
            {
                if (i== end)
                {
                    Console.Write((char)i);
                }
                else
                {
                    Console.Write((char)i + " ");
                }
                
            }
            Console.WriteLine();
        }
    }
}
