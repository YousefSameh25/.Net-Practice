using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Factory_Abstract
{
    public static class PaymentMethodFactory
    {
        public static PaymentMethod CreatePaymentMethod(PaymentType paymentType, string CarHolder, string CardNumber,
            string ExpiryDate, string CVV)
        {
            if (PaymentType.Visa == paymentType)
                return new Visa(CarHolder, CardNumber, ExpiryDate, CVV);
            else if (PaymentType.MasterCard == paymentType)
                return new MasterCard(CarHolder, CardNumber, ExpiryDate, CVV);
            else if (PaymentType.AmericanExpress == paymentType)
                return new AmericanExpress(CarHolder, CardNumber, ExpiryDate, CVV);

            return null;
        }
    }
}
