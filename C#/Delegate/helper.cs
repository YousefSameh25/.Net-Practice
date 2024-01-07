using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    internal class helper
    {
        public static bool IsPositive(int num)
        {
            return num > 0;
        }

        public bool IsNegative(int num)
        {
            return num <= 0;
        }
    }
}
