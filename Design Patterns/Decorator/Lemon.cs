using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    public class Lemon : DecoratorExtras
    {
        public Lemon()
        {

        }
        public Lemon(DecoratorExtras decoratorExtras) : base(decoratorExtras)
        {
        }

        public DecoratorExtras DecoratorExtras { get; set; }

        public override void Prepare()
        {
            Console.WriteLine("Add Lemon");
            decoratorExtras?.Prepare();
        }
    }
}
