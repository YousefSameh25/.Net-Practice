namespace Delegate
{
    // Delegate is a class and it can point to a function which takes a int parameter and
    // return a bool value.
    delegate bool delFilter(int num);

    internal class Program
    {
        static List<int> FilterNumbers(List<int> list, delFilter del)
        {
            List<int> result = new List<int>();

            for (int i = 0; i < list.Count; i++)
            {
                if (del(list[i]))
                    result.Add(list[i]);
            }
            return list;
        }

        static void Main(string[] args)
        {
            #region delegate points to static function
            delFilter filter = new delFilter(helper.IsPositive);
            bool Positive = filter(3); //filter.Invoke(3); 

            List<int> list = new List<int> { -2, 3, 5, -6, 7, 8, -4, 3 };

            // Different ways to pass the delegate.
            List<int> ret = FilterNumbers(list, filter);
            List<int> ret2 = FilterNumbers(list, helper.IsPositive); // create a delegate on the fly.
            #endregion

            #region delegate points to non-static function
            helper h = new helper(); // we must create an object first.
            List<int> ret3 = FilterNumbers(list, h.IsNegative);
            // What if there are many objects of class helper?
            // the delegate will call the function of h object and the data fields 
            // of the h object will be used on the function.
            #endregion

            #region Anonymous function
            List<int> list4 = FilterNumbers(list, delegate (int num)
            {
                return num > 0;
            });
            #endregion

            #region Lambda expression
            // Lambda operator (=>).
            List<int> list5 = FilterNumbers(list, num => num > 0);
            #endregion

            #region Delegate with lambda expression
            delFilter d = (i) => i > 0;
            #endregion

            #region Built-in delegates
            // Achieve the standardization.

            // Look at the defenition.
            Predicate<int> del = i => i > 0;

            // There are 17 Func delegate.
            Func<string> del2 = () => "yousef";

            // Use action when there is no return value.
            Action<int, string> del3 = (i, s) => Console.WriteLine("Hello");

            // No in parameters and no return type.
            Action del4 = () => Console.WriteLine("Non-generic action delegate.");
            #endregion

            #region Delegate points to many functions
            // Every delegate inherit from Multi cast delegate and this will allow us
            // to make the delegate points to many function

            filter += (i) => i > 0;
            bool flag = filter(3);
            // Flag will store the return value of the last function in the invokation list.
            // So it is useless when used with functions that return value.
            #endregion
        }
    }
}
