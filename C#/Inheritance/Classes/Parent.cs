using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes
{
    internal class Parent
    {


        // Use automatic prop when we do not want to validate.
        public int x { get; set; }
        public int y { get; set; }

        public Parent(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int Product()
        {
            return x * y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }

    }
}
