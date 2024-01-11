namespace LINQ_with_data
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // This query will be executed when we start iterating on it.
            IEnumerable<Course> ret = Data.courses.Filter((c) => c.Hours > 30);

            foreach (var item in ret)
            {
                Console.WriteLine($"Name: {item.Name} , Hours: {item.Hours}");
            }
            // We filtered cources and the return is a full object of course, what if i want to 
            // select just few attributes? Creating extension method takes course and return name.

            Console.WriteLine("=======================================");

            IEnumerable<string> names = ret.ChooseName(c => c.Name);

            foreach (var item in names)
            {
                Console.WriteLine($"Name: {item}");
            }

            Console.WriteLine("=======================================");

            // Here i am returning a anonymous objects so i have to store them in var.
            // IEnumerable <??> NameAndDepartmentObj = (invalid XXX)
            //    ret.ChooseName(c => new { Name = c.Name, Department = c.Department });
            //                                       I can not replace this ann. function with normal one as i can not specify the return type.
            var NameAndDepartmentObj = ret.ChooseSub(c => new { Name = c.Name, Department = c.Department });

            foreach (var item in NameAndDepartmentObj)
            {
                Console.WriteLine($"Name: {item.Name} , Department: {item.Department}");
            }

            Console.WriteLine("----------------------------------------------------");

            // Most popular than query expression.
            var query = Data.courses.Where(c => c.Hours > 10)
                .Select(c => c.Name);


            // Query expression.
            var query2 =
                from crs in Data.courses
                where crs.Hours > 10
                select crs.Name;

            // Note: There are some functions can not be written using query expression.


            #region SubQuery

            string[] departments = { "CS", "IS" };

            var query3 =
                from dept in departments
                select new
                {
                    Name = dept,
                    Courses = from c in Data.courses
                              where c.Department == dept
                              select c
                };

            foreach (var department in query3)
            {
                Console.Write($"Dept.Name: {department.Name} , Total courses: {department.Courses.Count()} , ");
                Console.WriteLine($" Total hours: {department.Courses.Sum(c => c.Hours)}");

                foreach (var c in department.Courses)
                {
                    Console.WriteLine($"Name: {c.Name}, Hours: {c.Hours}");
                }
                Console.WriteLine("----------------------------------------------------");
            }

            #endregion
        }
    }
}
