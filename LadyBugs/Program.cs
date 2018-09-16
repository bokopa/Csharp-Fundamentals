using System;
using System.Linq;

namespace LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var field = new int[size];

            var bugIndexes = Console.ReadLine()
               .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
               .Select(int.Parse)
               .Where(i => i >= 0 || i < size)
               .ToList();

            foreach (var index in bugIndexes)
            {
                field[index] = 1; // bug here
            }

            var comands = Console.ReadLine();

            while (comands != "end")
            {
                var comandParts = comands.Split(' ');

                var bugLocation = int.Parse(comandParts[0]);
                var bugDirection = comandParts[1];
                var flyLength = int.Parse(comandParts[2]);
                if (bugDirection == "left")
                {
                    flyLength = flyLength * -1;
                }
                if (bugLocation < 0 || bugLocation >= size) //outside of the field
                {
                    continue;
                }
                if (field[bugLocation] == 0) // there is no bug
                {
                    continue;
                }
                field[bugLocation] = 0;
                var nextIndexToLand = bugLocation;
                while (true)
                {
                    nextIndexToLand += flyLength;
                    if (nextIndexToLand < 0 || nextIndexToLand >= size)
                    {
                        break;
                    }
                    if (field[nextIndexToLand] == 1)
                    {
                        continue;
                    }
                    field[nextIndexToLand] = 1;
                    break; //just landed
                }

                comands = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", field));


        }
    }
}
