using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace WeatherFinder.ConsoleApp
{
    public class WeatherForecast
    {
        public WeatherForecast() { }
        [Key]
        public string Id { get; set; }
        public DateTime Date { get; internal set; }
        public string Summary { get; internal set; }
        public double TemperatureC { get; internal set; }
        public double Humidity { get; internal set; }
        public double Pressure { get; internal set; }
    }

}
