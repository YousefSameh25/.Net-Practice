namespace AsyncAwait
{
    internal class Program
    {
        static void Main()
        {
            PrintOdd();

            for (int i = 0; i < 1000; i++)
                Console.Write('X');
        }

        static async Task PrintOdd()
        {
            int Result = await Task.Run(() => Solve()); // Run Solve in a thread and when it complete execute the remaining lines.
            Console.WriteLine("\n**************" + Result + "**************");
        }

        static int Solve()
        {
            return 100;
        }

    }
}
