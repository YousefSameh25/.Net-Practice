namespace Implicitly_typed_local_variable
{
    internal class Program
    {
        static int Test()
        {
            var x = 1;
            return x + 1;
        }


        static void Main(string[] args)
        {
            var x = 3; // x is int as 3 is an integer value.

            // x = "Hello"; (Invalid as x is integer.)
            // The compiler will detect the data type using the initialization.

            var y = x;

            // Using var here is better as the readability is the same but we write short statement.
            Dictionary<int, SortedSet<int>> dic = new Dictionary<int, SortedSet<int>>();
            var dic2 = new Dictionary<int, SortedSet<int>>();


            int[,] arr = new int[2, 2];
            var arr2 = new int[2, 2];


            List<int>[] Graph = new List<int>[2];
            var Graph2 = new List<int>[2];


            // We can not use var in functions (parameters type, return type).
            Console.WriteLine(Test());
        }
    }
}
