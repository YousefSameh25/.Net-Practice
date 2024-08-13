using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    internal class PaymentProcessing
    {
        public double  Cost { get; set; }
        public void PaymentProcess ()
        {
            Console.WriteLine($"Process Payment = {Cost}");
        }
    }
}
