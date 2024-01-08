namespace Sequences
{
    internal class Program
    {

        static IEnumerable<int> Sequence()
        {
            //List<int> seq = new List<int> { 1, 2, 3 };
            //return seq;

            yield return 1;
            yield return 2;
            yield return 3;
        }

        static void Main(string[] args)
        {
            IEnumerable<int> list = Sequence();

            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
    }
}
