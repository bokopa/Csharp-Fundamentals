using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Problem02
{
    class Program
    {
        static void Main(string[] args)
        {
           
            double ammountIvanHas = double.Parse(Console.ReadLine());
            int countStudents =  int.Parse(Console.ReadLine());
            double lightsabersPrice =  double.Parse(Console.ReadLine());
            double robePrice = double.Parse(Console.ReadLine());
            double beltPrice = double.Parse(Console.ReadLine());


            //  . Also, every sixth belt is free.

            int freeBelts = countStudents / 6;

            double studentsLightSabers = Math.Ceiling(countStudents*1.10);
            var listToBuy = (lightsabersPrice * studentsLightSabers) +
                (robePrice * countStudents) + beltPrice * (countStudents - freeBelts);

            if (listToBuy <= ammountIvanHas)
            {
                Console.WriteLine($"The money is enough - it would cost {listToBuy:F2}lv.");
            }
            else
            {
          
                Console.WriteLine($"Ivan Cho will need {listToBuy - ammountIvanHas:F2}lv more.");
            }

       
        }
    }
}
