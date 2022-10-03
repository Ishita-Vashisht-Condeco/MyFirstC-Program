using System;
//using WeatherUtilities = MyUtilities.WeatherUtilities;
using MyUtilities;


namespace MyFirstProgram
{

    class CheckComfort
    {
        static void Main(string[] args)
        {
            Console.WriteLine("where should we go in may");
            WeatherUtilities.Report("san francisco", WeatherUtilities.FahrenheitToCelsius(65),73);
            WeatherUtilities.Report("denver", WeatherUtilities.FahrenheitToCelsius(77), 55);
            WeatherUtilities.Report("bologna", 23, 65);
        }
    }
}