using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WeatherServiceAdapter : IWeatherServiceAdapter
    {
        private readonly WeatherService _weatherService;

        public WeatherServiceAdapter(WeatherService WeatherService)
        {
            _weatherService = WeatherService;
        }

        public int GetTemperature(double longitude, double latitude)
        {
            return _weatherService.GetTemptature(GetCity(longitude, latitude), GetCountry(longitude, latitude));
        }

        public string GetCity(double longitude, double latitude)
        {
            return "Cairo";
        }
        public string GetCountry(double longitude, double latitude)
        {
            return "Egypt";
        }
    }
}
