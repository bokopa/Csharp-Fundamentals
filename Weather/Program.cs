using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string patern = @"([A-Z]{2})(\d+\.\d+)([A-Za-z]+)\|";
            string input = Console.ReadLine();
            Dictionary<string, WeatherClass> forecastDict= new Dictionary<string, WeatherClass>();

            while (!input.Equals("end"))
            {
                var match = Regex.Match(input, patern);
                if (Regex.IsMatch(input, patern))
                {
                string cityName = match.Groups[1].ToString();
                double averageTemp = double.Parse(match.Groups[2].ToString());
                string weatherType = match.Groups[3].ToString();

                    WeatherClass weather = new WeatherClass(averageTemp, weatherType);
                    if (!forecastDict.ContainsKey(cityName))
                    {
                        forecastDict.Add(cityName, weather);
                    }
                    else
                    {
                        forecastDict[cityName] = weather;
                    }
                    
                      }

                input = Console.ReadLine();
            }
            foreach (var item in forecastDict.OrderBy(e => e.Value.AverageTemp))
            {
                Console.WriteLine($"{item.Key} => {item.Value.AverageTemp:F2} => {item.Value.WeatherType}");
            }
        }
    }
    public class WeatherClass
    {
        public double AverageTemp{ get; set; }
        public string WeatherType{ get; set; }

        public WeatherClass(double averageTemperatureConstr, string weatherTypeConstr)
        {
            AverageTemp = averageTemperatureConstr;
            WeatherType = weatherTypeConstr;
        }

    }
}
