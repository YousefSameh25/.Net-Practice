using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class EmployeeRepository : EntityRepository<Employee>, IEmployeeRepository
    {
        public EmployeeRepository(DBContext dbContext) : base(dbContext)
        { }

        public IQueryable<Employee> GetEmployeesByAddress(string Address)
        {
            return dbContext.Employees.Where(E => E.Address == Address);
        }

        public IQueryable<Employee> GetEmployeesByName(string Name)
        {
            return dbContext.Employees.Where(E => E.Name.Contains(Name));
        }
    }
}
