﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory_Method___Factory_Abstract
{
    public class Visa : PaymentMethod
    {
        public Visa(string CardHolder, string CardNumber, string ExpiryDate, string CVV)
            : base(CardHolder, CardNumber, ExpiryDate, CVV)
        {
        }
    }
}