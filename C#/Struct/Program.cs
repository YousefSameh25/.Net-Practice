namespace Struct
{
    internal class Program
    {
        struct Complex
        {
            // Members by default is public
             int x; 
             int y;

            // You cant create a constructor without parameters

            // When this constructed created you can not use the default one
            public Complex(int x , int y) 
            {
                // Can not miss initializing one of the attriutes
                this.x = x;
                this.y = y; 
            }
        }
        static void Main(string[] args)
        {
            Complex C1;
            //Console.WriteLine(c1.x);  invalid as it does not have initial value.

            Complex C2 = new Complex(); // Call defulat constructor.

            Complex C3 = default; // Call defulat constructor.

            Complex C4 = C2; // Copping the values from C2 to C4.
        }
    }
}
