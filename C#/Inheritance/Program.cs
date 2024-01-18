using Inheritance.Classes;
namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Parent p = new Parent(2, 3);

            Console.WriteLine(p); // Will call ToString()

            Console.WriteLine(p.Product());

            // =====================================

            Child c = new Child(2, 3, 4);

            Console.WriteLine(c);

            Console.WriteLine(c.Product());
        }
    }
}
