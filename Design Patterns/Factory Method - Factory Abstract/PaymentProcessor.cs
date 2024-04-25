using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Factory_Abstract
{
    public class PaymentProcessor
    {
        public void PaymentProcess(PaymentType paymentType, string CardHolder, string CardNumber, string ExpiryDate, string CVV)
        {
            PaymentMethod paymentMethod = PaymentMethodFactory.CreatePaymentMethod(paymentType, CardHolder, CardNumber, ExpiryDate, CVV);

            paymentMethod.IsAuthorized();
            paymentMethod.MoneyTransfer();
            paymentMethod.CalculatePaymentFee();

            Console.WriteLine("Processing is succeeded");
        }

    }
}
