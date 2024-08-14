using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class Beverage
    {
        public Beverage()
        {

        }
        public Beverage(DecoratorExtras DecoratorExtras)
        {
            this.DecoratorExtras = DecoratorExtras;
        }
        private int _cost = 10;
        public int Cost
        {
            get
            {
                return _cost + (DecoratorExtras is null ? 0 : DecoratorExtras.Cost);
            }
            set
            {
                _cost = value;
            }
        }

        protected DecoratorExtras DecoratorExtras;
        public abstract void Prepare();
    }
}
