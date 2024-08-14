using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
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

            foreach (var dept4 in context.Departments)
            {
                Console.WriteLine(dept4.Dname);
            }
            Console.WriteLine("====================");

            // We can apply any extension methods of IEnumberable interface.
            IQueryable<Department> query = context.Departments.Where(d => d.Dnum > 0);

            /* 
             Why Where return IQueryable? 
            As here we are dealing with DB not data in memory so we need a one more layer to
            convert lambda expression to SQL query and then execute this query 
            that's the responsibility of Expression class which encapsulates many lambda expressions on it
            then convert it to SQL query then execute this query and retrieve the result in deferred execution.

            - The function will be executed using differed execution.
            - The where will be applied on the server side (DB)
             */


            IEnumerable<Department> query2 = context.Departments.ToList().Where(d => d.Dnum > 0);
            /*
            - Important note
            - Here the where is from Enumerable class not Queryable.
            - The function will be executed using eager execution.
            - The where will be applied on the client side (Application)
            */


            // how to see the generated SQL query?
            context.Database.Log = log => Console.WriteLine(log);

            foreach (var row in query)
                Console.WriteLine(row.Dname);


            Department dept = context.Departments.Find(10); // Find the department by PK.
            Department dept2 = context.Departments.Single((d) => d.Dnum == 10);

            /*
                Find() Vs. Single() 

                Single() => will throw an exception when the query return 0 or more than one object.

                Performance:
                When the context gets some data from DB it caches them so when you use Find()
                it will get the object from context's cache not from DB.

                Single() => will get the object directly from DB.

                Conclusion:

                - Object at context's cache => use Find()

                - Object is not at context's cache => use Single() because the Find() will check the cache 
                then gets the object from DB but Single() will get the object directly from DB.


                Note that cache data may be different from DB at this case i should use Single() when i want 
                the DB's data.
             */

            Console.WriteLine($"Find: {dept.Dname}");
            #endregion

            #region Update & Track data

            dept.Dname = "New Name";

            // When context gets objects from DB it tracks them and this will affect the performance
            // as the context create new entry object for every object it got from DB.

            // Get this entry object and update the state (Not recommended).
            context.Entry(dept).State = System.Data.Entity.EntityState.Modified;

            // Untrack this object.
            context.Entry(dept).State = System.Data.Entity.EntityState.Detached;

            context.SaveChanges(); // Will check the state of each attached object and delete, update or insert into DB.

            // How to disable tracking?
            // Department dept3 = context.Departments.AsNoTracking().Find(10); (Can't use find directly after AsNoTracking())
            // we should use LINQ query instead of Find()
            Department dept3 = context.Departments.AsNoTracking().ToList().Find((d => d.Dnum == 10));

            // How to Enable tracking?
            context.Departments.Attach(dept3); // After this line the context will be aware about dept3 object.


            /*
                What if i want to update a property of many employees (Bulk update)?

                - I have to load all data and track them and update then save changes (Bad performance).

                Solutions:
                 1) Stored procedure and calling it from EF.
                 2) Bulk updates or inserts (Not exist in EF6).
            */


            #endregion

            #region Insert Parent & Child

            Department newdept = new Department { Dname = "YousefDept", Dnum = 259 };

            newdept.Employees = new List<Employee>
            {
                new Employee { Fname = "Yousef", Lname = "Sameh", SSN = 2345, Sex = "M", Address = "Ain shams"},
                new Employee { Fname = "Moumen", Lname = "Sameh", SSN = 2346, Sex = "M", Address = "Ain shams"},
                new Employee { Fname = "Meow", Lname = "Sameh", SSN = 2347, Sex = "M", Address = "Ain shams"},
            };

            /*
               At all we don't care about any FK when we add a new record thanks to navigation property.
            */

            Employee emp = new Employee
            {
                Fname = "Eman",
                Lname = "Shehta",
                SSN = 2222,
                Address = "Khanka",
                Sex = "F",
                Department = newdept,
                // Dno = 259, we can use FK or navigation property.
            };

            context.Employees.Add(emp);
            // When we use navigation property an exception will be thrown as it create a new department and
            // the department is already exist so we can use FK (Dno) instead of navigation property.

            context.Departments.Add(newdept);

            context.SaveChanges();
            #endregion

            /* 
              Save changes works as transaction 
              execute all operation or non of them.
            */

            #region Delete
            //Employee emp2 = context.Employees.Find(2222);

            //context.Employees.Remove(emp2); // The object must be tracked by context.

            //context.SaveChanges();

            #endregion

            #region Using SP & Function

            //                                 Is auto implemented using designer.
            IQueryable<string> query4 = context.GetEmployees(300); // 300 is the project id.

            foreach (string fullname in query4)
                Console.WriteLine(fullname);

            #endregion

            #region Concurrency Mode
            MyCompanyEntities computer1 = new MyCompanyEntities();
            MyCompanyEntities computer2 = new MyCompanyEntities();

            Employee emp1 = computer1.Employees.First(e => e.Salary != null);
            Employee emp2 = computer2.Employees.First(e => e.Salary != null);

            emp1.Salary -= 10;

            computer1.SaveChanges();

            emp2.Salary -= 20;

            bool successed = true;
            do
            {
                try
                {
                    computer2.SaveChanges(); // Will throw an exception as the old salary.
                }
                catch (DbUpdateConcurrencyException ex)
                {
                    successed = false;
                    // Entries has a IEnumerable of all objects that contribute in this exception.
                    // Then get the entity (each object has an entity) of this object to reload its data from DB again.
                    var emp3 = ex.Entries.First().Entity as Employee;

                    computer2.Entry(emp3).Reload();

                    // emp1.Salary += 10;

                    // computer2.SaveChanges(); // Also may throw an exception :(
                    // We need to add try catch block inside a do while loop => try until the operation successed.
                }
            } while (!successed);

            // When we enable Concurrency Mode that will affect the performance in terms of memory
            // because each object we will retrieve from DB will be stored 2 times at the memory
            // Old version which will be useful when SaveChanges() comes to DB and
            // check if this old version is the same in the DB or not.
            // if yes so save the changes
            // else throw an exception.

            // This bad performance can be improved by select which attributes we want to track not the whole object.
            #endregion
        }
    }
}
