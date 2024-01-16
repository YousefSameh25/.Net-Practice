using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    internal class Employee
    {
        public int id;
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                // Validate the ID
                id = value;
            }
        }
        public string name;
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // Validate the Name
                name = value;
            }
        }
        public int salary;
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                // Validate the Name
                salary = value;
            }
        }

        //public int Id { get; set; }
        //public int Salary { get; set; }
        //public string Name { get; set; }

        public Employee(int Id, string Name, int Salary)
        {
            Console.WriteLine(1);
            this.Id = Id;
            Console.WriteLine(2);
            this.Name = Name;
            Console.WriteLine(3);
            this.Salary = Salary;
            Console.WriteLine(4);
        }

        public override string ToString()
        {
            return $"Person data:\n" +
                $"Id: {Id} \n" +
                $"Name: {Name}\n" +
                $"Salary: {Salary}\n" +
                $"---------------------------\n";
        }
    }
}
