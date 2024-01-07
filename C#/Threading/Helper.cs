using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threading
{
    internal class Helper
    {
        bool Finished = false;
        object Locker = new object();
        public void SayHi()
        {
            lock (Locker) // Safe threading 
            {// This scope can not be accessed by more than one thread at the same time.
                if (!Finished)
                {
                    Console.WriteLine("Hi");
                    Finished = true;
                }
            }
        }
    }
}
