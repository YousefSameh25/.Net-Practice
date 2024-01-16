using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Framework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // MyCompanyEntities class has a geniric DbSet class as a property
            // DbSet implements IEnumerable so we can iterate on it.
            MyCompanyEntities context = new MyCompanyEntities();

            foreach (var dept in context.Departments)
            {
                Console.WriteLine(dept.Dname);
            }
            Console.WriteLine("====================");

            // We can apply any extension methods of IEnumberable interface.
            IQueryable<Department> query = context.Departments.Where(d => d.Dnum > 0);

            /* 
             Why Where return IQueryable? 
            As here we are deal with DB not data in memory so we need a one more layer to
            convert lambda expression to SQL query and then execute this query 
            that's the responsibility of Expression class which encapsulates many lambda expressions on it
            then convert it to SQL query then execute this query and retrieve the result in deferred execution.

            - The function will be executed using deffered execution.
            - The where will be applied on the server side (DB)
             */


            IEnumerable<Department> query2 = context.Departments.ToList().Where(d => d.Dnum > 0);
            /*
            - Important note
            - Here the where is from Enumerable class not Queryable.
            - The function will be executed using eager execution.
            - The where will be applied on the cilent side (Application)
            */


            // how to see the generated SQL query?
            context.Database.Log = log => Console.WriteLine(log);

            foreach (var row in query)
            {
                Console.WriteLine(row.Dname);
            }
        }
    }
}
