using BusinessLogicLayer.Interfaces;
using DataAccessLayer.Contexts;
using DataAccessLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Repositories
{
    public class EntityRepository<T> : IEntityRepository<T> where T : class
    {
        protected readonly DBContext dbContext;
        public EntityRepository(DBContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async Task AddAsync(T Entry)
        {
            await dbContext.AddAsync(Entry);
        }
        public void Update(T Entry)
        {
            dbContext.Update(Entry);
        }
        public void Delete(T Entry)
        {
            dbContext.Remove(Entry);
        }
        public async Task<IEnumerable<T>> GetAllAsync()
        {
            if (typeof(T) == typeof(Employee))
                return (IEnumerable<T>)await dbContext.Employees.Include(E => E.Department).ToListAsync();

            return await dbContext.Set<T>().ToListAsync();
        }
        public async Task<T> GetByEntryIdAsync(int EntryId)
        {
            return await dbContext.Set<T>().FindAsync(EntryId);
        }
    }
}
