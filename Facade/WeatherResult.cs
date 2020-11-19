using Facade.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Facade
{
    public class WeatherResult
    {
        public City city { get; set; }
        public State state { get; set; }
        public int fahrenheit { get; set; }
        public int celcius { get; set; }
    }
}
