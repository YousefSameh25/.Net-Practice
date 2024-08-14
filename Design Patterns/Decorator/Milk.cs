using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public class Milk : DecoratorExtras
    {
        public Milk()
        {

        }
        public Milk(DecoratorExtras decoratorExtras) : base(decoratorExtras)
        {
        }


        public override void Prepare()
        {
            Console.WriteLine("Add Milk");
            decoratorExtras?.Prepare();
        }
    }
}
