namespace Params
{
    internal class Program
    {
        // Params must be at the end and only one.
        static int sum(int count, params int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < count; i++)
            {
                sum += arr[i];
            }
            return sum;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(sum(3, 1, 2, 5));
        }
    }
}
