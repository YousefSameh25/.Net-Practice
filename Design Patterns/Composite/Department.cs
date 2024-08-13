using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Composite
{
    public class Department : IOrganizationUnit
    {
        public List<IOrganizationUnit> OrganizationUnit { get; set; }

        public Department()
        {
            OrganizationUnit = new List<IOrganizationUnit>();
        }

        public void AddOrganizationUnit(IOrganizationUnit organizationUnit)
        {
            OrganizationUnit.Add(organizationUnit);
        }

        public int CalculateSalary()
        {
            int Total = 0;
            foreach (var organizationUnit in OrganizationUnit)
                Total += organizationUnit.CalculateSalary();

            return Total;
        }


    }
}
