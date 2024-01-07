namespace Nullable_Type
{
    internal class Program
    {
        static void Fun1(ref string a)
        {
            // The given refernce type will be changed as the string is immutable.
            a = "meow";
        }
        static void Main(string[] args)
        {
            /*
            Note: String is immutable so when you pass it by value or reference and you change it
            the returned string will be in different reference.
            the ref key just affects the value.
            */
            //string s = "Yousef";
            //Console.WriteLine(s.GetHashCode());
            //Fun1(ref s);
            //Console.WriteLine(s.GetHashCode());

            //==================================================

            // Nullable type

            // int x = null; (x) as int is non-nullable data type.

            int? x = null;

            int? a = null; // Can hold null or integer value

            // Some properties of nullable data type.
            if (a.HasValue)
                Console.WriteLine(a);

            a = a.GetValueOrDefault(0); // the same as '??'
            Console.WriteLine(a);

            // Coalescing operator '??'
            int v = a ?? 10; // that means is a not null assign its value otherwise assign 10 to v.

            // Null-Forgiving Operator '!'
            // From C#8 
            int y = 10;

            int z = y!; // That means i tell the compiler that um sure that y is not null.

            Nullable<int> nu = new Nullable<int>();
            // Nullable type is a struct which has 2 variables one is the value and the other is a flag which tell me wheather the value is null or not.
            // In case os null the value will be 0 but the flag (HasValue) will be true.

        }
    }
}
