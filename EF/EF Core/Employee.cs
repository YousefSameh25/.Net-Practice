using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Core
{
    internal class Employee
    {
        public int ID { get; set; }
        public string Name { get; set; }


        public int DepartmentID { get; set; }
        public Department Dept { get; set; }
    }
}
