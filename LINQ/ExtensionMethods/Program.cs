namespace ExtensionMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List extension method
            List<int> list = new List<int> { 2, 3, 1 };

            //list.Sort(); // Sorting elements in ascending order.

            list.SortD(); // Sorts in descending order

            // list.Add(33333); // Will call the original not the extension

            string space = "";
            foreach (var item in list)
            {
                Console.Write($"{space}{item}");
                space = " ";
            }
            Console.WriteLine();
            #endregion


            #region String extension methods
            string s = "XwZyousefzWx";

            // Function chaining.
            // First remove z then w then x.
            s = s.RemoveZ().RemoveW().RemoveX();

            Console.WriteLine(s);
            #endregion

        }
    }
}
