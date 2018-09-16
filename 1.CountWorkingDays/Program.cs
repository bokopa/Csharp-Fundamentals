using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _1.CountWorkingDays
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy",CultureInfo.InvariantCulture);
            DateTime endDate = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            int countWorkingDays = 0;
            List<DateTime> hollidays = new List<DateTime>();
            hollidays.Add(new DateTime(2016, 1, 1));
            hollidays.Add(new DateTime(2016, 3, 3));
            hollidays.Add(new DateTime(2016, 5, 1));
            hollidays.Add(new DateTime(2016, 5, 6));
            hollidays.Add(new DateTime(2016, 5, 24));
            hollidays.Add(new DateTime(2016, 9, 6));
            hollidays.Add(new DateTime(2016, 9, 22));
            hollidays.Add(new DateTime(2016, 11, 1));
            hollidays.Add(new DateTime(2016, 12, 24));
            hollidays.Add(new DateTime(2016, 12, 25));
            hollidays.Add(new DateTime(2016, 12, 26));


           
            for (var currentDate = startDate; currentDate <= endDate; currentDate = currentDate.AddDays(1))
            {
                if (!hollidays.Any(d => d.Day == currentDate.Day && d.Month == currentDate.Month)
                    && !currentDate.DayOfWeek.Equals(DayOfWeek.Saturday) &&
                    !currentDate.DayOfWeek.Equals(DayOfWeek.Sunday))
                {
                    countWorkingDays++;
                }
            }
            Console.WriteLine(countWorkingDays);
            
        }
    }
}
