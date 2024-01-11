using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_with_data
{
    public static class Data
    {
        public static List<Course> courses = new List<Course>
        {
            new Course { Name = "AI" , Hours = 40 , Department = "IS"},
            new Course { Name = "Algorithms" , Hours = 60 , Department = "CS"},
            new Course { Name = "DS" , Hours = 45 , Department = "CS"},
            new Course { Name = "OOP" , Hours = 30 , Department = "CS"},
        };

        public static List<Student> students = new List<Student>
        {
            new Student { Name = "Ali" , Level = 1 },
            new Student { Name = "Othman" , Level = 3 },
            new Student { Name = "Ahmed" , Level = 2 },
            new Student { Name = "Omar" , Level = 4 },
        };
    };
}
