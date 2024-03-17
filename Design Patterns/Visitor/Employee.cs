using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal class Employee : IWorkable
    {
        public void Work()
        {
            Console.WriteLine("Employee is working..");
        }
        public void Accept(INewFeatureVisitor NewFeature)
        {
            NewFeature.visit(this);
        }
    }
}
