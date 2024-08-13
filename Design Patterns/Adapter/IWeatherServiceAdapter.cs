using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter
{
    public interface IWeatherServiceAdapter
    {
        public int GetTemperature(double longitude, double latitude);
    }
}
