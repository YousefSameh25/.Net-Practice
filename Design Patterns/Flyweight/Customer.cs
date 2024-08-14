using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        //public string City { get; set; } // may be shared.
        //public string Country { get; set; } // may be shared.

        public CountryWithCity countryWithCity { get; set; }


        public Customer(int Id, string Name, CountryWithCity countryWithCity)
        {
            this.Id = Id;
            this.Name = Name;  
            this.countryWithCity = countryWithCity;
        }
    }
}
