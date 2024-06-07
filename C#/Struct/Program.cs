namespace Struct
{
    struct Complex
    {
        // Members by default is private.
        public int x;
        public int y = 10;

        // You cant create a constructor without parameters to C# 9.

        // When this constructed created you can not use the default one
        public Complex(int x, int y)
        {
            // Can not miss initializing one of the attributes
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"x = {x} , y = {y}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Complex C1;

            // Console.WriteLine(C1.x);  invalid as it does not have initial value.

            Complex C2 = new Complex(1, 2); // The right hand side calls the constructor only.

            Complex C3 = default; // Call default constructor.

            Complex C4 = C2; // Copping the values from C2 to C4.

            Console.WriteLine(C2); // Calls the ToString function.

        }
    }
}
