using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment
{
    internal enum Gender
    {
        M,
        F
    }
    internal enum SecurityLevel
    {
        Guest = 1,
        Developer = 2,
        Secretary = 4,
        DBA = 8,
        SecurityOfficer = 15 // Summition of all the previous roles.
    }
    internal class Date
    {
        public int Day { get; set; }
        public int Month { get; set; }
        public int Year { get; set; }
    }
    internal class Employee : IComparable<Employee>
    {
        #region Attributes
        int id;
        string name;
        float salary;
        Gender gender;
        Date hiringDate;
        SecurityLevel securityLevel;
        #endregion

        #region Properties
        public int ID
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }
        public string Name
        {
            get { return name; }
            set
            {
                if (value is not null)
                    name = value;
            }
        }
        public float Salary
        {
            get { return salary; }
            set
            {
                if (value > 0.0)
                    salary = value;
            }
        }
        public Gender Gender
        {
            get { return gender; }
            set
            {
                object G;
                if (Enum.TryParse(typeof(Gender), value.ToString(), true, out G))
                    gender = (Gender)G;
            }
        }
        public Date HiringDate
        {
            get { return hiringDate; }
            set
            {
                if (value.Day > 0 && value.Day < 32 && value.Month > 0 && value.Month < 13)
                    hiringDate = value;
            }
        }

        public SecurityLevel SecurityLevel
        {
            get { return securityLevel; }
            set
            {
                object SL;
                if (Enum.TryParse(typeof(SecurityLevel), value.ToString(), true, out SL))
                    securityLevel = (SecurityLevel)SL;
            }
        }

        #endregion

        #region Constructors
        // I have used object initializer instead of it.
        #endregion

        #region Functions
        public override string ToString()
        {
            return string.Format("Salary = {0:C4}$", Salary);
        }

        public int CompareTo(Employee? other)
        {
            // Sort the employees in the older to newer hiring dates.
            int Ycompare = HiringDate.Year.CompareTo(other.HiringDate.Year);
            if (Ycompare != 0)
                return Ycompare;
            else
            {
                int Mcompare = HiringDate.Month.CompareTo(other.HiringDate.Month);
                if (Mcompare != 0)
                    return Mcompare;
                else
                {
                    int Dcompare = HiringDate.Day.CompareTo(other.HiringDate.Day);
                    if (Dcompare != 0)
                        return Dcompare;
                    else
                        return 0;
                }
            }
        }
        #endregion
    }
}
