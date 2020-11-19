using Facade.Entities;
using Facade.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public interface IWeather
    {
        WeatherResult GetWeather(string zipCode);
    }
    public class Weather : IWeather
    {
        private readonly GeoLookupService _geoLookupService ;
        private readonly WeatherService _weatherService ;
        private readonly ConverterService _metricConverter ;

        public Weather(GeoLookupService geoLookupService,
            WeatherService weatherService,
             ConverterService metricConverter) {
            _geoLookupService = geoLookupService;
            _weatherService = weatherService;
            _metricConverter = metricConverter;
        }

        public Weather() : this(geoLookupService:new GeoLookupService(),
            weatherService:new WeatherService(),
            metricConverter:new ConverterService()
            ) 
        {
        }
        public WeatherResult GetWeather(string zipCode)
        {
            // call to service 1
            City city = _geoLookupService.GetCityForZipCode(zipCode);
            State state = _geoLookupService.GetStateForZipCode(zipCode);

            // call to service 2
            int fahrenheit = _weatherService.GetTempFahrenheit(city, state);

            // call to service 3
            int celcius = _metricConverter.ConvertFahrenheitToCelcious(fahrenheit);

            // bring the result of all service calls together
            return new WeatherResult
            {
                fahrenheit = fahrenheit,
                celcius = celcius,
                city = city,
                state = state
            };
        }
    }
}
