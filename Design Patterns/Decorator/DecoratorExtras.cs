using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator
{
    public abstract class DecoratorExtras
    {
        public DecoratorExtras()
        {

        }
        public DecoratorExtras(DecoratorExtras decoratorExtras)
        {
            this.decoratorExtras = decoratorExtras;
        }

        private int _cost = 10;
        public int Cost
        {
            get
            {
                return _cost + (decoratorExtras is null ? 0 : decoratorExtras.Cost);
            }
            set
            {
                _cost = value;
            }
        }

        public DecoratorExtras decoratorExtras { get; set; }
        public abstract void Prepare();
    }
}
