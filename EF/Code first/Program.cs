using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_first
{
    internal class Program
    {
        public static readonly int x;
        public static readonly int y;

        static void Main(string[] args)
        {
            Context context = new Context();

            context.Departments.Add(new Department
            {
                ID = 1,
                Name = "Test"
            });

            context.SaveChanges();


            // If we change any class structure and run a query we will get an exception?
            // as the current class structure is not the same as the stucture in snapshot at 
            // migrationHistory table.



        }
    }
}
