using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{

    public class Sugar : DecoratorExtras
    {
        public Sugar()
        {
        }
        public Sugar(DecoratorExtras decoratorExtras) : base(decoratorExtras)
        {
        }


        public override void Prepare()
        {
            Console.WriteLine("Add Sugar");
            decoratorExtras?.Prepare();
        }
    }

}
