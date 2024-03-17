using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public int branchID { get; set; }

        public Branch branch { get; set; }

        public virtual ICollection<Employee> Employees { get; set; }
    }
}
