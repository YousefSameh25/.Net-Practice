
using ClassLibrary;

namespace AccessModifiers
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Lets create object from TypeA class which is at another project (Class Library)

            // TypeA a = new TypeA(); (Invalid as it is internal)
        }
    }
}
