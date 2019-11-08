using System;
using System.Collections.Generic;

namespace WeatherFinder.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var forecasts = GetWeatherForecastData();

            using var dbContext = new WeatherDb();
            {
                for (int i = 0; i < forecasts.Count; i++)
                {

                    dbContext.Forecasts.Add(forecasts[1]);
                }
                dbContext.SaveChanges();

            }

            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"{"WEATHER-FINDER",50}");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine($"{"City",-20}| {"Date",-30}| {"Temperature "}| {"Summary",-20}|\n");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (int i = 0; i < forecasts.Count; i++)
            {
                //var city = i == 0 ? cities[i].Name : "";
                Console.WriteLine(
                    //$"{city,-20}| " +
                    $"{forecasts[i].Date.ToLongDateString(),-30}| " +
                    $"{forecasts[i].TemperatureC,-12:N2}| " +
                    $"{forecasts[i].Summary,-20}|"
                );
            }
            Console.WriteLine("----------------------------------------------------------------------------------------");
        }

        private static List<WeatherForecast> GetWeatherForecastData()
        {
            var weeklyForecast = new List<WeatherForecast>();
            var rng = new Random();
            string[] Summaries =
                new[]
                {
                    "Freezing",
                    "Bracing",
                    "Chilly",
                    "Cool",
                    "Mild",
                    "Warm",
                    "Balmy",
                    "Hot",
                    "Sweltering",
                    "Scorching"
                };

            for (int i = 0; i < 7; i++)
            {
                string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
                var newId = 
                new string(Enumerable.Repeat(chars, length)
                  .Select(s => s[random.Next(s.Length)]).ToArray());

                var forecast = new WeatherForecast
                {
                    Date = DateTime.Now.AddDays(i),
                    TemperatureC = rng.Next(-20, 55),
                    //Humidity = RandomGeneratorUtils.NextDouble(rng, 0, 100),
                    //Pressure = RandomGeneratorUtils.NextDouble(rng, 0, 100),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                };

                weeklyForecast.Add(forecast);
            };

            return weeklyForecast;
        }

    }
}
