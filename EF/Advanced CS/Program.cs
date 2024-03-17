namespace Advanced_CS
{
    internal class Program
    {
        public static void SWAP<T>(ref T x, ref T y)
        {
            T temp = x;
            x = y;
            y = temp;
        }

        static void Main(string[] args)
        {

        }
    }
}
