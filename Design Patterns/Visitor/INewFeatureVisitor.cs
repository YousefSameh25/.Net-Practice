using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    internal interface INewFeatureVisitor
    {
        public void visit(Employee Employee);
        public void visit(Manager Manager);
    }
}
