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
    public class DepartmentRepository : EntityRepository<Department>, IDepartmentRepository
    {
        public DepartmentRepository(DBContext dbContext) : base(dbContext)
        {
        }


    }
}
