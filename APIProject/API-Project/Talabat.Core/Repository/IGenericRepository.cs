using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entites;
using Talabat.Core.Specifications;

namespace Talabat.Core.Repository
{
    public interface IGenericRepository<T> where T : BaseEntity
    {
        #region Without Specifications
        public Task<IEnumerable<T>> GetAllAsync();
        public Task<T> GetByIdAsync(int Id);
        #endregion

        #region With Specifications

        Task<IEnumerable<T>> GetAllWithSpecAsync(Ispecification<T> Spec);

        Task<T> GetByIdWithSpecAsync(Ispecification<T> Spec);

        #endregion

    }
}
