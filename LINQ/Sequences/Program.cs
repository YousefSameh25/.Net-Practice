namespace Sequences
{
    internal class Program
    {
        // Deferred execution function vs Eager execution function.
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

            // built-in extension methods.

            List<int> list2 = new List<int> { 1, 2, -5 };

            bool AllPositive = list2.All((i) => i >= 0);
            Console.WriteLine(AllPositive);


            SortedSet<int> set = new SortedSet<int> { 3, 2 };

            Console.WriteLine(set.ElementAt(0));
        }
    }
}
