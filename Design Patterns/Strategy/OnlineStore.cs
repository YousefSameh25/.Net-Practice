using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class OnlineStore
    {
        IPayment payment;
        ICustomer customer;

        public OnlineStore(IPayment Payment, ICustomer Customer)
        {
            payment = Payment;
            customer = Customer;
        }

        public void Pay(double TotalPrice)
        {
            payment.Pay(customer.CalculateCheckOut(TotalPrice));
        }
    }
}
