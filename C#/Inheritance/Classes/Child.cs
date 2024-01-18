using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Classes // When we create a new folder a new sub namespace will be created.
{
    internal class Child : Parent
    {
        public int z { get; set; }

        public Child(int x, int y, int z) : base(x, y)
        {
            // base.x or base.y are visible here.
            this.z = z;
        }

        // new here will hide the Product function which in Parent class.
        // new will not affect the the execution.
        public new int Product()
        {
            return x * y * z;
            // return base.Product(x , y) * z;
        }

        public override string ToString()
        {
            return $"({x}, {y}, {z})";
        }
    }
}
