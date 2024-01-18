namespace Interface
{
    interface IReadable
    {
        public int value { get; set; }

        public void Write1()
        {
            Console.WriteLine($"Write1 {value}");
        }

        public void Write2();
    }
    class Book : IReadable
    {
        int v;
        public int value
        {
            get
            {
                return v;
            }
            set
            {
                v = value;
            }
        }

        // No need to implement Write1().
        public void Write2()
        {
            Console.WriteLine($"Write2 {value}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            IReadable read = new Book();
            read.value = 1;
            read.Write1();
            read.Write2(); // Accept this line as interface has Write2()
            // ===========================

            Book b = new Book();
            b.value = 2;
            b.Write2();
            // b.Write1(); not valid as refernce book hasn't got Write1()
        }
    }
}
