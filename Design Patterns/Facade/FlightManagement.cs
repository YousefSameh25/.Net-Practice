using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class FlightManagement
    {
        public int FlightClass { get; set; }

        public void ReserveFlight()
        {
            Console.WriteLine($"Reverse Flight in class {FlightClass}");
        }
    }
}
