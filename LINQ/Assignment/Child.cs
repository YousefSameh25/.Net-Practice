using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Child : Parent
    {
        public void TryAccessModifiers()
        {
            base.id = 1; // Was public at the Parent class.
            // base.name = "Yosuef"; Invalid as it was private at the Parent class.
            base.salary = 1000; // Was protected at the Parent class.
            base.sex = "Male"; // Was internal at the Parent class.
            base.na = "Na";
            base.job = "SWE";
        }

        public new void SayHello()
        {
            Console.WriteLine("Hello from child");
        }

        public override void SayHello2()
        {
            Console.WriteLine("Hello from child");
        }

    }
}
