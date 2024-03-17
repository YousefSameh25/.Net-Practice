namespace Test
{
    static class Helper<T>
    {
        public static void Meow(T[] list)
        {
            if (list is not null)
                Swap(ref list[0], ref list[1]);
        }

        public static void Swap(ref T x, ref T y)
        {
            T z = x;
            x = y;
            y = z;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] list = { 1, 2 };
            Helper<int>.Meow(list);

            Console.WriteLine(list[0]);
        }
    }
}
