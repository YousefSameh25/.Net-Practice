using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Factory_Abstract
{
    public class PaymentMethod
    {
        public string CardHolder { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }

        public PaymentMethod(string CardHolder, string CardNumber, string ExpiryDate, string CVV)
        {
            this.CardHolder = CardHolder;
            this.CardNumber = CardNumber;
            this.ExpiryDate = ExpiryDate;
            this.CVV = CVV;
        }

        public bool IsAuthorized()
        {
            // Logic
            return true;
        }
        public void MoneyTransfer()
        {
            // Logic
        }
        public int CalculatePaymentFee()
        {
            // Logic
            return 1;
        }

    }
}
