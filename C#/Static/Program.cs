namespace Static
{
    static class Test
    {
        public static int x { get; set; }
        public const int c = 10;

        // Is called automatic when we access the class.
        static Test()
        {
            x = 1;
        }

        public static void Method()
        {
            // In static method we can access static and const only.
            Console.WriteLine(c * 1);
            Console.WriteLine(x * 1);
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
