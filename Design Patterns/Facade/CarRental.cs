using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class CarRental
    {
        public int CarId { get; set; }
        public void RentCar()
        {
            Console.WriteLine($"Renting car {CarId}");
        }
    }
}
