using Strategy.CustomerTypes;
using Strategy.PaymentTypes;

namespace Strategy
{
    internal class Program
    {
        static void Main()
        {
            OnlineStore onlineStore = new OnlineStore(new Visa(), new GoldCustomer());
            onlineStore.Pay(100);

            onlineStore = new OnlineStore(new PayPal(), new RegularCustomer());
            onlineStore.Pay(100);
        }
    }
}