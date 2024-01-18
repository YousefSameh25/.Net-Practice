using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal interface IMovable
    {
        public int Speed { get; set; }

        public void Move();

        // When the class has a function with the same name it will hide this implementation.
        public void Type()
        {
            Console.WriteLine("I am a movable thing");
        }
    }
}
