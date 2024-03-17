namespace Visitor
{
    internal class Program
    {
        static void Main()
        {
            Employee emp = new Employee();
            emp.Accept(new CreateReport()); // Here I can pass any feature that implement INewFeature interface

            // The same for configuring the settings for a table in EF Core.
        }
    }
}
