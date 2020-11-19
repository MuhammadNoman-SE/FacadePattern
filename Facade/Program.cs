using System;
using Facade.Entities;
using Facade.Services;

namespace Facade
{
    public static class Program
    {
        static void Main(string[] args)
        {
            const string zipCode = "98074";

            IWeather w = new Weather();
            WeatherResult wr = w.GetWeather(zipCode);
            // bring the result of all service calls together
            Console.WriteLine("The current temperature is {0} F / {1} C in {2}, {3}",
                                wr.fahrenheit,
                                wr.celcius,
                                wr.city.Name,
                                wr.state.Name);
            Console.ReadLine();

        }
    }
}