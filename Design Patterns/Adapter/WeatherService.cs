using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public class WeatherService
    {
        public int GetTemptature(string City, string Country)
        {
            var random = new Random();

            return random.Next(27, 46);
        }
    }
}
