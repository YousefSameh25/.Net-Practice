using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DBContext dbContext;

        public IEmployeeRepository EmployeeRepository { get; set; }
        public IDepartmentRepository DepartmentRepository { get; set; }


        public UnitOfWork(DBContext dbContext)
        {
            // I need dbContext here as I want to save changes in the 'Complete' function.
            // I should create object by myself to pass dbContext object because 
            // If I let it to dependency injection the EmployeeRepository, DepartmentRepository will create a dbContext using DI inside them
            // and I will create a different dbContext here so now we will have 2 objects (1 for modifications and 1 for save changes) ans
            // this is totally wrong.
            this.dbContext = dbContext;
            EmployeeRepository = new EmployeeRepository(dbContext);
            DepartmentRepository = new DepartmentRepository(dbContext);
        }

        public async Task CompleteAsync()
        {
            await dbContext.SaveChangesAsync();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}