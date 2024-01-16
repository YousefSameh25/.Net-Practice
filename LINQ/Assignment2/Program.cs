namespace Assignment2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee(Id: 10, Name: "Yousef", Salary: 1000);

            emp.salary = 1000;
            emp.Salary = 1000;

        }
    }
}
