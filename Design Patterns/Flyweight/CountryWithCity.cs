using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight
{
    public class CountryWithCity
    {
        public string City { get; set; } // may be shared.
        public string Country { get; set; } // may be shared.
    }
}
