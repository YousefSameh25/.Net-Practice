
// Icomparer is like customize sort in C++.
namespace Icomparer
{
    class point
    {
        public int x { get; set; }
        public string p { get; set; }
    }

    class Mycomparer : IComparer
    {
        Comparison < point > comparison;

    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Array.Sort();
        }
    }
}
