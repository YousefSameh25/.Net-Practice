using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Employee : IOrganizationUnit
    {
        public string Name { get; set; }
        public int Salary { get; set; }

        public int CalculateSalary()
        {
            return Salary;
        }
    }
}
