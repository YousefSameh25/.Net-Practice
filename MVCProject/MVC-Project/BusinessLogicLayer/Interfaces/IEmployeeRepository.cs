using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IEmployeeRepository : IEntityRepository<Employee>
    {
        // Not logic to make it return Task<IQueryable> as the query will be applied on database
        IQueryable<Employee> GetEmployeesByAddress(string Address);
        IQueryable<Employee> GetEmployeesByName(string Name);
    }
}
