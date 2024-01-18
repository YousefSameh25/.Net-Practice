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

            #region Intro

            // MyCompanyEntities class has a generic DbSet class as a property
            // DbSet implements IEnumerable so we can iterate on it.
            MyCompanyEntities context = new MyCompanyEntities();

            foreach (var dept2 in context.Departments)
            {
                Console.WriteLine(dept2.Dname);
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
                Console.WriteLine(row.Dname);


            Department dept = context.Departments.Find(10); // Find the department by PK.
            Department dept2 = context.Departments.Single((d) => d.Dnum == 10);

            /*
                Find() Vs. Single() 
                
             */

            Console.WriteLine($"Find: {dept.Dname}");
            #endregion

            #region Update & Track data

            dept.Dname = "New Name";

            // When context gets objects from DB it tracks them and this will affect the performance
            // as the context create new entry object for every object it got from DB.

            // Get this entry object and update the state (Not recommended).
            context.Entry(dept).State = System.Data.Entity.EntityState.Modified;

            context.SaveChanges();

            // How to disable tracking?
            // Department dept3 = context.Departments.AsNoTracking().Find(10); (Can't use find directly after AsNoTracking())
            // we should use LINQ query instead of Find()
            Department dept3 = context.Departments.AsNoTracking().ToList().Find((d => d.Dnum == 10));

            // How to Enable tracking?
            context.Departments.Attach(dept3); // After this line the context will be aware about dept3 object.


             /*
                 What if i want to update a property of many employees?

                 - I have to load all data and track them and update then save changes (Bad performance).

                 Solutions:
                  1) Stored procedure and calling it from EF.
                  2) Bulk updates or inserts (Not exist in EF6).
             */

            
            #endregion



        }
    }
}
