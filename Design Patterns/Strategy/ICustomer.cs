using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal interface ICustomer
    {
        public double CalculateCheckOut(double TotalPrice);
    }
}
