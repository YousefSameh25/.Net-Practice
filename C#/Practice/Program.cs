
namespace Practice
{
    internal class Program
    {
        public static int Solve(out int x)
        {
            x = 10;
            return x;
        }
        static void Main()
        {
            int x;

            Console.WriteLine(Solve(out x));

        }
    }
}
