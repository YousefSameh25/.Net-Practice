using System.Threading.Tasks.Dataflow;

namespace Property
{
    class Human
    {
        // Auto implemented property
        // Backing field , hidden private attribute.
        public string Name { get; set; }

        // Best practice when you do not have to login in seters and geters.
        // Full property
        private int _id;
        public int id
        {
            get
            {
                return _id;
            }
            private set
            {
                _id = value;
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
