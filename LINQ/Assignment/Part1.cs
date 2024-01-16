using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal class EmployeeClass
    {
        #region Attributes
        int id;
        string name;
        int salary;
        string[] mobilenumbers;
        #endregion

        #region Full properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                // Validate the ID
                if (value >= 0)
                    id = value;
                else
                    Console.WriteLine("Invalid id\n");
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // Validate the Name
                if (value is not null)
                    name = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }
        public string[] MobileNumbers
        {
            set
            {
                // We can use value[index] here.
                if (value is not null)
                {
                    mobilenumbers = new string[value.Length];

                    for (int i = 0; i < value.Length; i++)
                        mobilenumbers[i] = value[i];
                }
                else
                    Console.WriteLine("Invalid given list of phone numbers\n");
            }
            get
            {
                return mobilenumbers;
            }
        }
        #endregion

        #region Constructors
        public EmployeeClass()
        {
            Id = 0;
            Name = "";
            Salary = 0;
            MobileNumbers = new string[3];
        }

        public EmployeeClass(int Id, string Name, int Salary)
        {
            this.Id = Id;
            this.Name = Name;
            this.Salary = Salary;
        }

        public EmployeeClass(int Id, string Name, int Salary, string[] MobileNumbers) : this(Id, Name, Salary)
        {
            this.MobileNumbers = MobileNumbers;
        }
        #endregion

        #region Indexer
        // Each employee has at most 3 mobile numbers.
        public string this[int index]
        {
            get
            {
                if (index < MobileNumbers.Length && index >= 0)
                    return MobileNumbers[index];
                return "Invalid index\n";
            }
            set
            {
                if (index < MobileNumbers.Length && index >= 0)
                    MobileNumbers[index] = value;
                else
                    Console.WriteLine("Invalid index\n");
            }
        }


        #endregion

        #region Functions
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Person data:\n" +
                $"Id: {Id} \n" +
                $"Name: {Name}\n" +
                $"Salary: {Salary}\n");

            for (int i = 0; i < MobileNumbers?.Length; i++)
                sb.Append($"Phone Number {i + 1}: {MobileNumbers[i]}\n");

            sb.Append("---------------------------------\n");

            return sb.ToString();

        }
        #endregion
    }
    internal struct EmployeeStruct
    {
        #region Attributes
        int id;
        string name;
        int salary;
        string[] mobilenumbers;
        #endregion

        #region Full properties
        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                // Validate the ID
                if (value >= 0)
                    id = value;
                else
                    Console.WriteLine("Invalid id\n");
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                // Validate the Name
                if (value is not null)
                    name = value;
            }
        }
        public int Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value >= 0)
                    salary = value;
            }
        }
        #endregion

        #region Constructors
        public EmployeeStruct(int Id, string Name, int Salary, string[] MobileNumbers)
        {
            // Set of the properties is not visiable here.
            id = Id;
            name = Name;
            salary = Salary;
            mobilenumbers = new string[MobileNumbers.Length];
            for (int i = 0; i < MobileNumbers.Length; i++)
                mobilenumbers[i] = MobileNumbers[i];
        }
        #endregion

        #region Indexer
        // Each employee has at most 3 mobile numbers.
        public string this[int index]
        {
            get
            {
                if (index < mobilenumbers.Length && index >= 0)
                    return mobilenumbers[index];
                return "Invalid index\n";
            }
            set
            {
                if (index < mobilenumbers.Length && index >= 0)
                    mobilenumbers[index] = value;
                else
                    Console.WriteLine("Invalid index\n");
            }
        }


        #endregion

        #region Functions
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Person data:\n" +
                $"Id: {Id} \n" +
                $"Name: {Name}\n" +
                $"Salary: {Salary}\n");

            for (int i = 0; i < mobilenumbers?.Length; i++)
                sb.Append($"Phone Number {i + 1}: {mobilenumbers[i]}\n");

            sb.Append("---------------------------------\n");

            return sb.ToString();

        }
        #endregion
    }
}
