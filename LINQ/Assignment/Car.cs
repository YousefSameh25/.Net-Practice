using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class Car : IMovable
    {
        public int Speed { get; set; }

        public void Move()
        {
            Console.WriteLine("The car is moving");
        }

        public void Type()
        {
            Console.WriteLine("I am a movable car");
        }
    }
}
