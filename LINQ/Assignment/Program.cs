using System.Text;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Part 1
            //EmployeeClass emp = new EmployeeClass(Id: 10, Name: "Yousef", Salary: 1000,
            //    MobileNumbers: new string[2] { "01097804067", "01080565320" });

            //Console.WriteLine(emp);

            //EmployeeStruct emp2 = new EmployeeStruct(Id: 20, Name: "Yousef", Salary: 1000,
            //    MobileNumbers: new string[1] { "01022512298" });

            //Console.WriteLine(emp2);
            #endregion

            #region Part 2
            //Employee[] EmpArr = new Employee[3] {
            //    new Employee { ID = 0, Name = "Yousef", Gender = Gender.M,
            //        HiringDate = new Date{Day = 25 , Month = 9 , Year = 2010 },
            //        Salary = 1000.0f , SecurityLevel = SecurityLevel.Developer },
            //    new Employee { ID = 1, Name = "Eman", Gender = Gender.M,
            //        HiringDate = new Date{Day = 7 , Month = 12 , Year = 2009 },
            //        Salary = 750.0f , SecurityLevel = SecurityLevel.Developer },
            //    new Employee { ID = 2, Name = "Hossam", Gender = Gender.M,
            //        HiringDate = new Date{Day = 16 , Month = 11 , Year = 2009 },
            //        Salary = 650.5f , SecurityLevel = SecurityLevel.SecurityOfficer },
            //};

            //Array.Sort(EmpArr); // Sort the employees in the older to newer hiring dates.

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.WriteLine($"Hiring date: {EmpArr[i].HiringDate.Day}/" +
            //        $"{EmpArr[i].HiringDate.Month}/{EmpArr[i].HiringDate.Year}");
            //    Console.WriteLine("========================");
            //}

            // I think there is no boxing and Unboxing has occurred when we sort using IComparable.
            #endregion
        }
    }
}
