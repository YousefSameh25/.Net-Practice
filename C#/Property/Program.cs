using System.Threading.Tasks.Dataflow;

namespace Property
{
    class Human
    {
        // Auto implenemted property
        // Backing field , hidden private attribute.
        public string Name { get; set; }

        // Best practise when you do not have to login in seters and geters.
        // Full property
        public int id
        {
            get
            {
                return id;
            }
            private set
            {
                id = value;
            }
        }

        // Create shallow copy.
        public Human Clone()
        {
              // This function is at object class.
            return MemberwiseClone() as Human;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Human h1 = new Human();

            h1.Name = "hello";

            Human h2 = h1.Clone();

            Console.WriteLine(h2.Name);


            // Boxing => create object in heap and store value 10 in it.
            object obj = 10;
            Console.WriteLine(obj.ToString());

        }
    }
}
