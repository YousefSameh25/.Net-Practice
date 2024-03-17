using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    internal class Context : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Branch> Branches { get; set; }

        // We can deal with many providers (Oracle, sql server.....) so we need to configure some options.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // specify connection string.
            optionsBuilder.UseSqlServer(@"Data source = .; Initial catalog = DBCore; integrated security = true");

            // To log operations to console window.
            optionsBuilder.LogTo(log => Debug.WriteLine(log));

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Fluent API
            modelBuilder.Entity<Department>().ToTable("Department");
            modelBuilder.Entity<Department>().Property(d => d.Name).IsRequired();
            modelBuilder.Entity<Department>().HasKey(d => d.ID);

            // for composite key
            // modelBuilder.Entity<Department>().HasKey(d => new { d.ID, d.Name });

            base.OnModelCreating(modelBuilder);
        }
    }
}
