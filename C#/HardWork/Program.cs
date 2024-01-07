namespace HardWork
{
    [Flags] //Attribute! - to print the mix color to its representitive colors
    enum Color // Enhance the code readability
    {
        // Values must has single 1 in its binary representation.
        Red = 1, // (1)
        Green = 2, // (10)
        Blue = 4, // (100)
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Color color = Color.Red | Color.Blue;
            Console.WriteLine(color);
        }
    }
}
