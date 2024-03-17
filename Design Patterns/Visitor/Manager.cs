using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Manager : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Manager is working...");
        }
        public void Accept(INewFeatureVisitor NewFeature)
        {
            NewFeature.visit(this);
        }
    }
}
