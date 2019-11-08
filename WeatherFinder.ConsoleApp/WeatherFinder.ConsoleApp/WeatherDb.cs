using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherFinder.ConsoleApp
{
    class WeatherDb : DbContext
    {
        public DbSet<WeatherForecast> Forecasts { get; set; }

        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=.;Database=WeatherFinderDB;Integrated Security=True");
        }
    }
}

