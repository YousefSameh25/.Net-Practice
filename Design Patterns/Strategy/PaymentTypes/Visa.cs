using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.PaymentTypes
{
    internal class Visa : IPayment
    {
        public void Pay(double TotalPrice)
        {
            Console.WriteLine($"Pay {TotalPrice} using Visa");
        }
    }
}
