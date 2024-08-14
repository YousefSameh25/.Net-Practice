namespace Classes
{
    internal class point
    {
        // Members will be private by default
        public int x, y;

        // Must be exist if we want it
        public point()
        { }
        public point(int x)
        {
            // We can miss any member.
            // Why? as by default all members will be initialized by the default value.
            this.x = x;
        }

        public point(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    internal class Program
    {
        // string[] args => is used to accept command-line
        // arguments when you run a console application.
        static void Main(string[] args)
        {
            point P; // reference
            P = null;
            P = default; // Null
            P = new point(); // Stored in heap

            P = new point { x = 5, y = 10 }; // Object initializer.
            point P2 = new point(5, 10) { x = 5, y = 10 };
            // execution order will be 1 then 2.
        }
    }
}