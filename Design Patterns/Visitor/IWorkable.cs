using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface IWorkable
    {
        public void Work();
        public void Accept(INewFeatureVisitor NewFeature);
    }
}
