using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_with_data
{
    internal static class Extensions
    {

        public static IEnumerable<T> Filter<T>(this IEnumerable<T> Source, Predicate<T> predicate)
        {
            foreach (T item in Source)
            {
                if (predicate(item))
                    yield return item;
            }
        }

        // This function takes for example List of courses and return List of courses names.
        // The given type is course type and the return is string type so Choose <TSource , TResult>
        // Important note at the first we setup the function as generics and if the passed parameter is not the return
        // we use TSource, TResult then setup the remaining things.
        // The logic here is to take course and return the name and remember that the logic can not be here
        // so we want a delegate to point at function takes TSource (course) and return TResult (name).
        //                                 Order here is not important.
        public static IEnumerable<TResult> ChooseName<TResult, TSource>(this IEnumerable<TSource> Source, Func<TSource, TResult> fun)
        {
            foreach (TSource item in Source)
            {
                yield return fun(item);
            }
        }

        // What if we want to get a course and return more than one attribute? Return anonymous objects.
        public static IEnumerable<TResult> ChooseSub<TResult, TSource>(this IEnumerable<TSource> Source, Func<TSource, TResult> fun)
        {
            foreach (TSource item in Source)
            {
                yield return fun(item);
            }
        }
    }
}
