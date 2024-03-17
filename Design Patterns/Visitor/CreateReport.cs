using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor
{
    // Implement the algorithm (logic for every class type that will need it.)
    internal class CreateReport : INewFeatureVisitor
    {
        public void visit(Employee Employee)
        {
            Console.WriteLine("Employee is creating report...");
        }

        public void visit(Manager Manager)
        {
            Console.WriteLine("Manager is creating report...");
        }
    }
}
