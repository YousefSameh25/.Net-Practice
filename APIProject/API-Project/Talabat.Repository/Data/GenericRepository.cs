using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entites;
using Talabat.Core.Specifications;
using Talabat.Repository.Data;

namespace Talabat.Core.Repository
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly StoreContext StoreContext;
        public GenericRepository(StoreContext storeContext)
        {
            StoreContext = storeContext;
        }


        public async Task<IEnumerable<T>> GetAllAsync()
        {
            return await StoreContext.Set<T>().ToListAsync();
        }

        public async Task<T> GetByIdAsync(int Id)
        {
            return await StoreContext.Set<T>().FindAsync(Id);
        }


        public async Task<IEnumerable<T>> GetAllWithSpecAsync(Ispecification<T> Spec)
        {
            return await SpecificationEvaluator<T>.BuildQuery(StoreContext.Set<T>(), Spec).ToListAsync();
        }

        public async Task<T> GetByIdWithSpecAsync(Ispecification<T> Spec)
        {
            return await SpecificationEvaluator<T>.BuildQuery(StoreContext.Set<T>(), Spec).FirstOrDefaultAsync();
        }
    }
}
