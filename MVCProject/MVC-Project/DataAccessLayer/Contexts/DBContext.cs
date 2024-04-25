using DataAccessLayer.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PresentationLayer.Models;

namespace DataAccessLayer.Contexts
{
    public class DBContext : IdentityDbContext<ApplicationUser> // Already has the required DbSets
    {
        public DBContext(DbContextOptions<DBContext> options) : base(options)
        {

        }


        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
