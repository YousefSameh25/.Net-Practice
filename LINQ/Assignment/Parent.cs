using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Parent
    {
        public int id;
        private string name;
        protected int salary;

        internal string sex;
        internal protected string job;
        private protected string na;


        public void SayHello()
        {
            Console.WriteLine("Hello from parent");
        }

        public virtual void SayHello2()
        {
            Console.WriteLine("Hello from parent");
        }

    }
}
