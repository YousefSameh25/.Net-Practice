namespace Composite
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Composite: Allows us to compose objects into tree structures then work with these 
            // structures as if they were individual objects.

            Department main = new Department();

            Employee employee1 = new Employee();
            employee1.Salary = 10000;
            Employee employee2 = new Employee();
            employee2.Salary = 5000;

            main.AddOrganizationUnit(employee1);
            main.AddOrganizationUnit(employee2);

            Department Sub = new Department();

            Employee employee3 = new Employee();
            employee3.Salary = 6000;
            Employee employee4 = new Employee();
            employee4.Salary = 4000;

            Sub.AddOrganizationUnit(employee3);
            Sub.AddOrganizationUnit(employee4);

            main.AddOrganizationUnit(Sub);

            Console.WriteLine(main.CalculateSalary());
        }
    }
}
