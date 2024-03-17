using Microsoft.EntityFrameworkCore;

namespace EF_Core
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Context context = new Context();

            #region Eager Loading (Include)
            var Q = context.Departments
                .Where(d => d.ID > 3)
                .Select(d => d)
                .AsSplitQuery() // To solve the problem of performance of outer join (Do Cartesian product then filter)
                .Include(d => d.Employees)
                .ThenInclude(e => e.Dept) // e.anyCollection
                .ToList();
            #endregion

            #region Explicit Loading
            var Q2 = context.Departments.ToList();
            #endregion

            #region Select Loading
            var Q3 = context.Departments
                .Select(d =>
                new
                {
                    // Copy Department data
                    ID = d.ID,
                    Name = d.Name,
                    branchID = d.branchID,
                    branch = d.branch,
                    // copy the employess
                    Employees = d.Employees,
                });
            #endregion



            foreach (var Department in Q3)
            {
                Console.WriteLine(Department.Name);
                // Lazy loading here is disable by defualt for performance problems
                /*
                  lazy loading means we get the collection when we iterate on it.
                  Now the collection is null (يعني مجابش اصلا الكوليكشن في وقت ما جيت الف عليه)
                */

                #region Explicit Loading
                /*
                To load the collection of employees
                context.Entry(Department).Collection(d => d.Employees).Load();
                // To load the object of the branch
                context.Entry(Department).Reference(d => d.branch).Load();
                // What if I don't want all employees
                context.Entry(Department).Collection(d => d.Employees).Query().Where(e => e.ID > 2).Load();
                */
                #endregion

                foreach (var Employee in Department.Employees)
                    Console.WriteLine($"ID = {Employee.ID}, Name: {Employee.Name}");
                Console.WriteLine("-------------");
            }

            /*
             There are 4 options to get this collection
             1) using Include extented method (eager loading).
             - ThenInclude works on the last included collection.
            Problem of include is that when I write context.Departments.Include(d => d.employess) 
            {
                the result query will has an outer join which 
                will use Cartesian product (Time and memory complexity of outer join is T1Rows * T2Rows * ....)
                then filter.
            }
            */

        }
    }
}
