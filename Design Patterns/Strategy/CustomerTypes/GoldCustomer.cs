using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.CustomerTypes
{
    internal class GoldCustomer : ICustomer
    {
        public double CalculateCheckOut(double TotalPrice)
        {
            return 0.9 * TotalPrice;
        }
    }
}
