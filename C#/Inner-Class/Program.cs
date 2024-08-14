namespace Inner_Class
{
    class X
    {
        int x;
        class Y
        {
            X o;
            public Y()
            {
                o = new X();
                o.x = 1; // we can access the private members of class X but not vice versa.
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
