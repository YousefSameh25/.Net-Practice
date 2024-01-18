using System.Text;

namespace Assignment
{
    internal class Program
    {
        public static int Sum(int int1, int int2)
        {
            return int1 + int2;
        }

        public static double Sum(int int1, double doub1)
        {
            return int1 + doub1;
        }

        static void Main(string[] args)
        {
            #region new keyword
            Console.WriteLine("Trying new keyword");
            Console.WriteLine("---------------------------------");
            Parent p = new Parent();
            p.SayHello(); // Hello from parent.

            Child c = new Child();
            c.SayHello(); // Hello from child.

            Parent p2 = new Child(); // Static binding => Call based on refernce type.
            p2.SayHello(); // Hello from parent.
            Console.WriteLine("------------------------------------------------------");
            #endregion

            #region Override keyword
            Console.WriteLine("Trying polymerphism (Override)");
            Console.WriteLine("---------------------------------");
            Parent p3 = new Parent();
            p.SayHello(); // Hello from parent.

            Child c2 = new Child();
            c.SayHello(); // Hello from child.

            Parent p4 = new Child(); // Dynamic binding => Call based on object type.
            p2.SayHello2(); // Hello from child.
            Console.WriteLine("------------------------------------------------------");
            #endregion

            #region Overloading
            Console.WriteLine("Trying polymerphism (overloading)");
            Console.WriteLine("---------------------------------");
            int IntResult = Sum(5, 5);
            Console.WriteLine(IntResult);
            double DoubleResult = Sum(5, 5.5);
            Console.WriteLine(DoubleResult);
            Console.WriteLine("------------------------------------------------------");
            #endregion

            #region Interface
            Console.WriteLine("Trying interface");
            Console.WriteLine("---------------------------------");
            IMovable car = new Car();
            car.Move(); // The car is moving.

            IMovable human = new Human();
            human.Move(); // The human is moving.

            Car car2 = new Car();
            car2.Type(); // I am a movable car.

            Human human2 = new Human();
            human2.Type(); // I am a movable human.

            IMovable car3 = new Car();
            car3.Type(); // I am a movable car.

            IMovable human3 = new Human();
            human3.Type();  // I am a movable human.
            Console.WriteLine("------------------------------------------------------");
            #endregion
        }
    }
}
