using System.Collections;

namespace Icollection
{
    /*
     Interface : Interface => Inherit.
     Class : Interface => Implement.
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            #region List = vector
            //List<int> list = new List<int>(); // Implements ICollection

            //list.Clear();

            //list.Add(1);

            //bool found = list.Contains(1);

            //int index = list.BinarySearch(1); // index of the item or -1.

            //list.AddRange(new List<int> { 1, 2, 4, 5 });

            //list.Insert(2, 1); // Insert 2 in index 1.

            //list.Reverse();

            //Console.WriteLine(list.Count);

            //bool HasRemoved = list.Remove(1); // Remove the first occurrence of the given value.

            //list.RemoveRange(0, 1); // Remove 0 elements starting from index 0.

            //list.RemoveAt(0); // Removes element at the given index.

            //List<int> list3 = list.GetRange(0, 1); // Gets element at the given index.

            //list.IndexOf(1); // Gets index of the first occurrence of the given value.

            //list.Sort();

            ////list.CopyTo();

            //int[] res = list.ToArray(); // list -> int[] res

            //Console.WriteLine(list.ToString()); // Gets type.
            #endregion

            #region Dictionary = Unordered Map (Hash table)
            //Dictionary<int, int> dic = new Dictionary<int, int>();
            //dic.Add(1, 2);
            //dic.Add(2, 3); 

            //Console.WriteLine(dic.Count);

            //foreach (KeyValuePair<int, int> it in dic)
            //{
            //    Console.WriteLine(it.Key);
            //    Console.WriteLine(it.Value);
            //}

            //bool CanAdd = dic.TryAdd(1, 2);

            //bool FoundKey = dic.ContainsKey(1);

            //bool FoundValue = dic.ContainsValue(2);

            //int value;
            //bool FoundValueOfKey = dic.TryGetValue(1, out value);

            //dic.Clear
            #endregion

            #region SortedDictionary = Map (BST)
            //SortedDictionary<int, int> mp = new SortedDictionary<int, int>();
            // Same functions as Dictionary.
            #endregion

            #region HashSet = Unorderedset (Hash table)
            //HashSet<int> st = new HashSet<int> { 1, 3, 2 };

            //int[] nums = new int [st.Count];
            //st.CopyTo(nums);

            //for (int i = 0; i < nums.Length; i++)
            //    Console.WriteLine(nums[i]);
            #endregion

            #region SortedSet = Set (BST)
            //SortedSet<int> st = new SortedSet<int> { 1, 2, 2 };
            #endregion

            #region Multi Set
            // There is no built in multiset in c# but we can implement it using dictionary or sorted dictionary.
            #endregion

            #region Multi Map
            // Not exists but we can can use dictionary of list '<int, List <int>>' 
            #endregion
        }
    }
}
