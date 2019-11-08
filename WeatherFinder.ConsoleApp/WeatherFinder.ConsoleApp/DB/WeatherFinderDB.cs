using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherFinder.ConsoleAppDB
{
    public class WeatherFinderDB : DbContext
    {
	

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           
                optionsBuilder.UseSqlServer(@"Server=.\SQLExpress;Database=SchoolDB;Trusted_Connection=True;");
            }
        }
}
