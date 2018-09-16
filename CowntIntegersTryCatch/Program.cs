using System;

namespace CowntIntegersTryCatch
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            try
            {
                while (true)
                {
                    int a = int.Parse(Console.ReadLine());
                    count++;
                }
            }
            catch (Exception)
            {

                Console.WriteLine(count);
            }
           
        }
    }
}
