using System;

namespace Hotel
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = Console.ReadLine();
            int nightsCount = int.Parse(Console.ReadLine());


            double studioPrice = 0;
            double doblePrice = 0;
            double suitPrice = 0;
            int nightsCountOctober = 0;

//•	For studio and more than 7 nights in September and October: one night is free


            if (month == "May" || month == "October")
            {
                studioPrice = 50;
                doblePrice = 65;
                suitPrice = 75;
                if (nightsCount > 7)
                {
                    studioPrice *= 0.95;
                    if (month == "October")
                    {
                        nightsCountOctober -= 1;
                    }
                        
                }

            }
            else if (month == "June" || month == "September")
            {
                studioPrice = 60;
                doblePrice = 72;
                suitPrice = 82;
                if (month == "September" || nightsCount > 7)
                {
                    nightsCountOctober -= 1; 
                }
                if (nightsCount > 14)
                {
                  
                    doblePrice *= 0.90;
                    
                }

            }
            else if (month == "July" || month == "August" || month == "December")
            {
                studioPrice = 68;
                doblePrice = 77;
                suitPrice = 89;
                if (nightsCount > 7)
                {
                    suitPrice *= 0.85;
                }

            }

            // •	For studio and more than 7 nights in May and October: 5 % discount
            //•	For double and more than 14 nights in June and September: 10 % discount
            //•	For suite and more than 14 nights in July, August and December: 15 % discount
            //•	For studio and more than 7 nights in September and October: one night is free

            Console.WriteLine($"Studio: {studioPrice * (nightsCount+nightsCountOctober):F2} lv.");
            Console.WriteLine($"Double: {doblePrice * nightsCount:F2} lv.");
            Console.WriteLine($"Suite: {suitPrice * nightsCount:F2} lv.");
        }
    }
}
