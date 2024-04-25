using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Models
{
    public class Department
    {
        public int Id { get; set; }


        [Required(ErrorMessage = "Name is required")] [MaxLength(50)]
        public string Name { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        public DateTime DateOfCreation { get; set; }

        [InverseProperty("Department")]
        public ICollection <Employee> Employees { get; set; } = new List<Employee> ();
    }
}
