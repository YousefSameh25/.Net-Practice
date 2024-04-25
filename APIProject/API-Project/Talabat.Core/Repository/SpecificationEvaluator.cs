using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Talabat.Core.Entites;
using Talabat.Core.Specifications;

namespace Talabat.Core.Repository
{
    public static class SpecificationEvaluator<T> where T : BaseEntity
    {
        public static IQueryable<T> BuildQuery(IQueryable<T> inputQuery, Ispecification<T> Spec)
        {
            var Query = inputQuery;

            if (Spec.Criteria is not null)
                Query = Query.Where(Spec.Criteria);

            //                              Base    Result, element          Result.Include(element).
            Query = Spec.Includes.Aggregate(Query, (CurQuery, CurInclude) => CurQuery.Include(CurInclude));

            return Query;
        }
    }
}
