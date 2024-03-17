using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Code_first
{
    [Table(name: "Employees", Schema = "HR")]
    internal class Employee
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        // [DatabaseGenerated(DatabaseGeneratedOption.None)] // disable identity
        public int ID { get; set; }

        [Column(name: "FullName"), MaxLength(100)] // We can add many attributes on 1 line.
        public string Name { get; set; }

        [Required] // Disable allowing null 3la mostawa el application not DB
        public double Salary { get; set; }

        public int? Age { get; set; } // Nullable

        [Column(TypeName = "Date")] // At data base the type will be Date but here will be DateTime (hours,min,seco = 0)
        public DateTime BirthDate { get; set; }

        // [ForeignKey(name: "dept")] // name = name of navigation property.
        public int DepartmentId { get; set; }

        [ForeignKey(name: "DepartmentId")]
        public virtual Department Dept { get; set; } // Navigation property.
        // Virtual => To allow lazy loading 
        // (when we get the data of employess the department data will be loaded when needed).

        public int SupervisedDepartmentId { get; set; }

        [ForeignKey(name: "SupervisedDepartmentId")]
        public virtual Department SuperviedDept { get; set; } // Navigation property.

    }
}
