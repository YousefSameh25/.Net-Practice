namespace Coding
{
    // Suppose that we can not modify this class
    class Point
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    class PointSort : IComparer<Point>
    {

        public int Compare(Point? P1, Point? P2)
        {
            // Sort X ascending, Y descending.
            if (P1.x != P2.x)
                return P1.x.CompareTo(P2.x);
            return -P1.y.CompareTo(P2.y);
        }

    }
    internal class Program
    {
        static void Main()
        {
            List<Point> points = new List<Point>
            {
                new Point{x = 1 , y = 3 },
                new Point{x = 1 , y = 2 },
                new Point{x = 2 , y = 5 },
                new Point{x = 1 , y = 4 },
            };

            points.Sort(new PointSort());

            points = points.OrderBy(p => p.x).ThenBy(p => -p.y).ToList();

            foreach (var P in points)
                Console.WriteLine($"({P.x}, {P.y})");
        }
    }
}
