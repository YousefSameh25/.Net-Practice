namespace AnonymousObjects
{
    internal class Program 
    {
        static void Main(string[] args)
        {
            // Compiler will implement anonymous class with the given attributes.
            var v = new { ID = 1, Name = "Yousef" };

            // The compiler will not create another anonynous class.
            var v2 = new { ID = 1, Name = "Yousef" };

            Console.WriteLine(v.Name);

            // This line is valid but useless.
            Object obj = new { ID = 1, Name = "Yousef" };

            // Console.WriteLine(obj.Name); Invalid as we need casting but we can not cast as the class is anonymous.

            // Next. we will know about how to create a list of anonymous objects.
        }
    }
}
