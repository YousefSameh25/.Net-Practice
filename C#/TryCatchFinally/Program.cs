namespace TryCatchFinally
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0;
            try
            {
                Console.WriteLine(a / b);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Divided by zero");
            }
            finally // Will be executed however an exception has occurred or not.
            {
                // Disconnect the connection || deallocate || Free.
                Console.WriteLine("Close everything");
            }
        }
    }
}
