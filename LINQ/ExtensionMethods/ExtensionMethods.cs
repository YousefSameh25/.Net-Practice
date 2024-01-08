using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethods
{
    // static means all members is static
    internal static class ExtensionMethods
    {
        // The first parameter must be the class which we want to add extension to.
        // 'This' refers to that the object which will call this function is object of type List.
        public static void SortD(this List<int> list)
        {
            list.Sort();
            list.Reverse();
        }

        // public static void Add(this IEnumerable <T> list, T element)
        // this function will be for any class implement IEnumerable
        // also it it generic function.
        public static void Add(this List<int> list, int element)
        {
            if (element < 3000)
                list.Add(element);
        }

        public static string RemoveZ(this string str)
        {
            // My logic is to remove any 'z' char
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToLower(str[i]) != 'z')
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public static string RemoveW(this string str)
        {
            // My logic is to remove any 'w' char
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToLower(str[i]) != 'w')
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }

        public static string RemoveX(this string str)
        {
            // My logic is to remove any 'x' char
            var sb = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                if (char.ToLower(str[i]) != 'x')
                    sb.Append(str[i]);
            }
            return sb.ToString();
        }
    }
}
