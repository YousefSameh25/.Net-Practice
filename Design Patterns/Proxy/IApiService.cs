﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal interface IApiService
    {
        public Task<string> GetAllProducts();
    }
}
