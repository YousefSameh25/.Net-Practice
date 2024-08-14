using System.Text;

namespace Prototype
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Post p1 = new Post("Hello form post 1", "basic", "dark-blue");

            Post p2 = (p1.Clone() as Post)!; // Null forgiving operator means I am sure that the expression is not null.

            // Prototype pros:
            // 1- Clone created complex objects with the desired state to increase performance.
            // 2- Can produce a template with the common attributes then customize it.
        }
    }
}
