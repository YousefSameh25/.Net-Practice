using System.Collections.Immutable;
using System.Linq;
using LINQ_with_data;

namespace Built_in__Extension_Methods
{
    class Product
    {
        public int id { get; set; }
        public string name { get; set; }
        public int price { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 2, 3, 4 };

            #region Where
            IEnumerable<int> WhereRes = list.Where(x => x > 0);
            #endregion

            #region Select
            var SubData = Data.courses.Select(c => new { Name = c.Name, Hours = c.Hours });
            #endregion

            #region Aggregate
            // Look at the description

            int pro = list.Aggregate((x, y) => x * y);
            Console.WriteLine(pro);

            int sum = list.Aggregate((x, y) => x + y);
            Console.WriteLine(sum);

            int sub = list.Aggregate((x, y) => x - y);
            Console.WriteLine(sub);
            Console.WriteLine("=======================");
            #endregion

            #region Sum
            int summ = list.Sum(); // If it is list of number
            int suum = list.Sum(x => x); // Object and i want to some a specific attribute.
            #endregion

            #region All & Any
            bool AllPositive = list.All((x) => x > 0);
            Console.WriteLine(AllPositive ? "All numbers are positive." : "All numbers are not positive.");

            bool AnyPositive = list.Any((x) => x > 0);
            Console.WriteLine(AnyPositive ? "There is a positive number." : "All numbers are negative");

            bool HasElements = list.Any();
            Console.WriteLine(HasElements ? "The sequence is not empty." : "The sequence is empty.");
            #endregion

            #region Append
            list.Append(1); // We can use it with any collection implements IEnumerable.
            #endregion

            #region As ..
            List<int> list2 = new List<int> { 1, 3, 4 };

            IEnumerable<int> IList = list2.AsEnumerable();

            IQueryable<int> qlist = list.AsQueryable();

            #endregion

            #region Enable parallelization
            list.AsParallel();
            // Enable parallelization of a query
            #endregion

            #region Cast
            IEnumerable<long> listlong = list.Cast<long>();
            // Convert the given data type to another one.
            #endregion

            #region Chunk
            //    List of array != Array of List
            IEnumerable<int[]> chunks = list.Chunk(3); // 3 chunks

            foreach (int[] item in chunks)
            {
                for (int i = 0; i < item.Length; i++)
                {
                    Console.WriteLine(item[i]);
                }
                Console.WriteLine("-----------");
            }

            #endregion

            #region Concat
            List<int> list3 = new List<int> { 4, 3 };
            IEnumerable<int> result = list.Concat(list3);
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Contains
            bool Found = list.Contains(1);
            // O(list.Count())
            #endregion

            #region To...
            // Those functions make the query run using eager execution. 

            List<int> newList = list.ToList();

            int[] arr = list.ToArray();

            HashSet<int> st = list.ToHashSet();

            Dictionary<int, int> dic = list.ToDictionary((x) => x * 2);
            // Note that the lambda will be applied to the key and the given list will be the value.

            foreach (KeyValuePair<int, int> item in dic)
            {
                Console.WriteLine($"Key: {item.Key} \t Value: {item.Value}");
            }

            // Note that is doesn't convert to string.
            string s = list.ToString();

            Console.WriteLine($"Object type: {s}");

            // There are many ToImmutable......(HashSet, Dic, ect...)
            ImmutableArray<int> Iarr = list.ToImmutableArray();
            #endregion

            #region Count
            int cnt = list.Count(); // Can be used in all collections that implement IEnumerable.

            int cnt2 = list.Count(i => i > 0); // Get number of records that satisfy the condition.

            int cnt3 = list.Count; // Exists only in List.
            #endregion

            #region DefaultIfEmpty
            IEnumerable<int> list4 = list.DefaultIfEmpty(-1);
            // Return default value -1 if the sequence is empty otherwise return the sequence.
            #endregion

            #region Average

            double avg = list.Average();
            Console.WriteLine(avg);

            //=========================================

            double AvgOnNewList = list.Average((x) => x * x);
            Console.WriteLine(AvgOnNewList);
            #endregion

            #region Distinct

            IEnumerable<int> dis = list.Distinct(); // Using Hash Set.

            //=========================================

            list.DistinctBy(x => x * 2);
            // That means when x = 2 we will insert 4 into the hash set which calculate the ditinct elements.
            #endregion

            #region Equals
            List<int> l1 = new List<int> { 1 };
            List<int> l2 = new List<int> { 1 };
            bool equal = l1.Equals(l2); // It compare the objects not the values.
            Console.WriteLine($"Equality is {equal}"); // False
            #endregion

            #region Except
            List<int> l3 = new List<int> { 1, 3, 3 };
            List<int> l4 = new List<int> { 1 };
            IEnumerable<int> ret = l3.Except(l4);
            foreach (int item in ret)
            {
                Console.WriteLine(item); // Output: 3
            }


            IEnumerable<int> res = l1.ExceptBy(l2, (x) => x * 2);

            // HashSet will be created for l2 = {1}
            // iterate over every element on l1 then try to insert it into hashset if add function return
            // false that means the hash set already contains it otherwise return this element using yield.
            // when we use ExceptBy we will try to add x * 2 into the hash set.

            foreach (int item in res)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Intersect
            List<int> l5 = new List<int> { 1, 3, 3 };
            List<int> l6 = new List<int> { 1 };
            IEnumerable<int> ret2 = l5.Intersect(l6);
            foreach (int item in ret)
            {
                Console.WriteLine(item); // Output: 1
            }


            IEnumerable<int> res2 = l5.IntersectBy(l6, (x) => x * 2);

            // HashSet will be created for l6 = {1}
            // iterate over every element on l5 then try to remove the current element from hashset if remove function return
            // false that means the hash set doesn't contain it otherwise return this element using yield.
            // when we use IntersectBy we will try to remove x * 2 from the hash set.

            foreach (int item in res2)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region foreach for List

            List<int> l7 = new List<int> { 1, 2, 3, 4, 5 };

            l7.ForEach(i => Console.WriteLine(i));
            #endregion

            #region Take = Top in TSQL
            // Get the top 1 from the given sequence.
            IEnumerable<int> Res = list.Take(1);

            IEnumerable<int> Resss = list.TakeLast(1);

            // Takes from the begin all numbers until found an element doesn't satisfy the condition.
            IEnumerable<int> Ress = list.TakeWhile((i) => i > 0);

            #endregion

            #region Skip
            // Skips n rows then return the remaining ones.
            IEnumerable<int> Res2 = list.Skip(1);

            IEnumerable<int> Resss2 = list.SkipLast(1);

            // Skips from the begin all numbers that satisfy the condition and return the remaining.
            IEnumerable<int> Ress2 = list.SkipWhile((x) => x > 0);
            #endregion

            #region Max & Min

            // If there is no lambda given -> there must be one element that implement Icomparable.
            int mx = list.Max();

            // The given lambda will determine which attribute will be used to determine the max.
            int mx2 = list.Max(x => x);

            int mx3 = list.MaxBy(x => x);

            /*
                Max will directly return the maximum value itself.
                MaxBy will return the entire element associated with that maximum value.
            */
            // If there is no lambda given -> there must be one element that implement Icomparable.
            int mn = list.Min();

            int mn2 = list.Min(x => x);

            int mn3 = list.MinBy((x) => x);

            /*
                Min will directly return the minimum value itself.
                MinBy will return the entire element associated with that minimum value.
            */
            #endregion

            #region OrderBy & ThenBy
            IEnumerable<int> ress = list.OrderBy(x => x); // the given lambda determine what attribute will be used to sort.

            IEnumerable<int> ress2 = list.OrderByDescending(x => x);

            // If we want to order by name then age

            IEnumerable<int> ress3 = list.OrderBy(x => x).ThenBy(x => x);

            IEnumerable<int> ress4 = list.OrderByDescending(x => x).ThenByDescending(x => x);

            #endregion

            #region GroupBy

            List<Product> PL = new List<Product>();

            //                 <Key, Elements type>
            IEnumerable<IGrouping<int, Product>> groups = PL.GroupBy(P => P.price);

            // IGrouping is an list with key attribute.
            // Key attribute is used to store the attribute which we used in GroupBy.
            foreach (var group in groups)
            {
                Console.WriteLine($"Group: {group.Key}"); // Price

                foreach (var item in group)
                    Console.WriteLine(item.name);

                Console.WriteLine("-------------------");
            }
            #endregion


            // Any extension method from the following returns 1 object is (immediate excution).
            #region First
            List<object> objects = new List<object>();

            // If there is no result an exception will be thrown as the return value is nullable object
            var front = objects.First();

            // Will return the defualt value for the datatype of the sequence (here is null) with no exception.
            var front2 = objects.FirstOrDefault();

            // Handle if the list is empty.
            var front3 = objects.FirstOrDefault(-1);


            // Return the first element satisfies the condition or return default.
            int First = list.FirstOrDefault(x => x > 0);
            int First2 = list.First(x => x > 0);
            #endregion

            #region Last
            int back = list.Last();

            int back2 = list.LastOrDefault();

            int back3 = list.LastOrDefault(-1);


            // Return the last element satisfies the condition or return default.
            int Last = list.LastOrDefault(x => x < 0);
            int Last2 = list.Last(x => x > 0);
            Console.WriteLine($"Last = {Last}");
            #endregion

            #region ElementAt
            int value = list.ElementAt(0);

            int ValueOrDefualt = list.ElementAtOrDefault(10);
            // index is out of bounds -> return default value of the data type..
            #endregion

            #region Single

            // If the sequence has just 1 element (ok), otherwise throw an exception.
            var result10 = list.Single();

            // If the sequence has just 1 element match the condition (ok), otherwise throw an exception.
            result10 = list.Single(x => x % 2 == 0);


            // Find vs. Single
            // Find -> if there are many objects can be a result -> it will return the first object.
            // Single -> if there are many objects can be a result (or) no result -> it will throw an exception.
            #endregion

            // Other functions in Enumerable class but can be used only by calling the class.

            #region Range
            var result11 = Enumerable.Range(0, 5); // 0 1 2 3 4
            #endregion

            #region Repeat
            var result12 = Enumerable.Repeat(1, 3); // 1 1 1

            var result13 = Enumerable.Repeat(new object(), 5);
            #endregion

        }
    }
}
