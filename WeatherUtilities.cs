using System;

namespace MyUtilities
{
    class WeatherUtilities
    {
        static public float FahrenheitToCelsius(float temperatureFahrenheit)
        {
            return (temperatureFahrenheit - 32 )/ 1.8f;
        }

        static float CelsiusToFahrenheit(float temperatureCelsius)
        {
            return (temperatureCelsius * 1.8f) + 32;
        }

        static float ComfortIndex(float temperatureFahrenheit, float humidityPercent)
        {
            return (temperatureFahrenheit + humidityPercent) / 4;
        }

        static public void Report(string location, float temperatureCelsius, float humidity)
        {
            var temperatureFahrenheit = CelsiusToFahrenheit(temperatureCelsius);
            Console.WriteLine($"Comfort Index for {location}: {ComfortIndex(temperatureFahrenheit, humidity)}");
        }
    }
}