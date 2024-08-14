using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Tea : Beverage
    {
        public Tea()
        {

        }
        public Tea(DecoratorExtras DecoratorExtras) : base(DecoratorExtras)
        {
        }


        public override void Prepare()
        {
            Console.WriteLine("Add tea");
            DecoratorExtras?.Prepare();
        }
    }
}
