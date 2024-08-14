using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    internal class Coffee : Beverage
    {
        public Coffee()
        {

        }
        public Coffee(DecoratorExtras DecoratorExtras) : base(DecoratorExtras)
        {
        }


        public override void Prepare()
        {
            Console.WriteLine("Add coffee");
            DecoratorExtras?.Prepare();
        }
    }
}
