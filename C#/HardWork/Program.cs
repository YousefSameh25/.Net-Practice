namespace HardWork
{
    [Flags] //Attribute! - to print the mix color to its representitive colors.
    // Enum enhances the code readability
    public enum Color : int // could be any numerical data type.
    {
        // Values must has single 1 in its binary representation.
        Red = 1, // (1)
        Green = 2, // (10)
        Blue = 4, // (100)

        // We can add more than one enum value with the same number
        blue = 2,
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Color color = Color.Red | Color.Blue;
            Console.WriteLine(color);

            color ^= Color.Blue; // remove blue color.

            Console.WriteLine(color);

            Color color2 = (Color)4; // Blue color.
            Console.WriteLine(color2);


            string input = Console.ReadLine();
            object x;
            bool flag = Enum.TryParse(typeof(Color), input, out x); // X will be Color type.
            if (flag)
                Console.WriteLine($"Color is {x}");

            // Note: In the database we will store the values not the lables.
        }
    }
}
