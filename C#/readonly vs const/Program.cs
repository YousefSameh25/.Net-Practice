namespace readonly_vs_const
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player p = new Player(10);

            Console.WriteLine(p.ReadOnlyNumber); // 10
            Console.WriteLine(Player.ConstNumber); // 5
            // When we try to acccess a const number
            // we can call it using name of the class like static variable.
        }
    }
}
