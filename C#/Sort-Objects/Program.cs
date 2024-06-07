namespace Sort_Objects
{
    // We can specify the type IComparable <point>
    class point : IComparable<point>
    {
        public int x { get; set; }
        public string p { get; set; }


        public int CompareTo(point? other)
        {
            // Can handle the logic by myself:

            //if (obj is point p2)
            //{
            //    if (x < p2.x)
            //        return -1;
            //    else if (x > p2.x)
            //        return 1;
            //    return 0;
            //}

            // Or use CompareTo function which is in all data types.

            return p.CompareTo(other.p);
            // P < other.p => -1
            // P > other.p => 1
            // P = other.p => 0
            // Internal logic => when return value is 1 that means do swap.
        }

        public override string ToString()
        {
            return $"{x} , {p}";
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            point[] arr = {
                new point { x = 1,p = "point1" },
                new point { x = 3, p = "point2" },
                new point { x = 2, p = "point3" }
            };

            Array.Sort(arr);

            foreach (var item in arr)
            {
                // Here printing the item will call ToString() function from the object.
                Console.WriteLine(item.ToString());
            }

            Console.WriteLine("===========================");
            // Can be used instead of > , < operators.
            string a = "ali";
            string b = "yousef";

            Console.WriteLine(a.Equals(b));
        }
    }
}
