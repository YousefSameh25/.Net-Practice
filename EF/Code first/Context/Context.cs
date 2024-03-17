using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first
{
    internal class Context : DbContext
    {


        public Context() : base("Data Source=YOUSEF;Initial Catalog=CodeFirstDB;Integrated Security=True")
        {

        }

        // Each DbSet here will be created as a table in DB
        // and any navigation property will be create as a table.
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }

    }
}
