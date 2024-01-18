using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Human : IMovable
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("The human is moving");
        }
        public void Type()
        {
            Console.WriteLine("I am a movable human");
        }
    }
}
