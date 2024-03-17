using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first
{
    internal class Department
    {
        public int ID { get; set; }
        public string Name { get; set; }

        [InverseProperty("Dept")]
        public virtual ICollection<Employee> Employees { get; set; }

        [InverseProperty("SuperviedDept")]
        public virtual ICollection<Employee> Supervisors { get; set; }
    }
}
