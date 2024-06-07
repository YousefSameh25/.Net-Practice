using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace readonly_vs_const
{
    internal class Player
    {
        public const int ConstNumber = 5;

        public readonly int ReadOnlyNumber; // Can be initialized here. same as final


        public Player(int ReadOnlyValue)
        {
            // The readonly can be accessed only in the constructor only.
            // can be initialized at runtime.
            ReadOnlyNumber = ReadOnlyValue;
        }
    }
}
