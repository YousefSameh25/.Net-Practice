using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogicLayer.Interfaces
{
    public interface IEntityRepository<T>
    {
        public Task AddAsync(T Entry);
        public void Update(T Entry);
        public void Delete(T Entry);
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByEntryIdAsync(int EntryId);
    }
}
