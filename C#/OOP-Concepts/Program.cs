namespace OOP_Concepts
{
    class creature
    {
        // Protected means visuable for children.
        protected int weight;
        protected int height;

        public creature() { }

        public creature(int weight, int height)
        {
            this.weight = weight;
            this.height = height;
        }

        public void Think()
        {
            Console.WriteLine("Creature is thinking");
        }
        // Virtual enables the overriding 
        public virtual void Move()
        {
            Console.WriteLine("Creature is moving");
        }

        public void Eating()
        {
            Console.WriteLine("Creature is eating");
        }
    }
    //=========================================================
    class Human : creature
    {
        public int id;
        public string name;

        public Human() { }

        // Base refernce -> refernces to the parent object.
        // This refernce -> refernces to the current object.
        public Human(int id, string name, int weight, int height) : base(weight, height) // can pass weight, height
        {
            // Will excute the parent constructor at first then this lines .
            this.id = id;
            this.name = name;

            // We can initialize them using parent constructor.
            //base.weight = weight;
            //base.height = height;
        }

        public void show()
        {
            Console.WriteLine(this.weight + " " + this.height);
        }

        public new void Think()
        {
            Console.WriteLine("Human is thinking");
        }

        public override void Move()
        {
            // base.Eating(); we can call any function (public - protected)
            // from the parent using base refernce. 
            Console.WriteLine("Human is moving");
        }
        //=========================================================
    }

    //=========================================================
    class Employee : Human
    {
        public int salary;

        public Employee() { }

        // If we removed this constructor we have to write a default constructor in the parent class.
        public Employee(int id, string name, int weight, int height, int salary) : base(id, name, weight, height)
        {
            this.salary = salary;
        }

        public new void Move()
        {
            // This function exists in parent and grand 
            // Here you will see your parent only
            base.Move();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Human h = new Human(50, "Ali", 50, 50);

            h.show(); // Will has the values 50 - 50

            h.Think();
            h.Move();

            h.Eating();

            // Note:
            // You will not able to call any inherited function using human object except by
            // using base reference in human class.

            // ================================================================================

            // The shared functions between (creature - Human) is running according to refernce type.
            creature c1 = new Human(); // I can only see function in creature class unless you use (virtual and override).

            // Ex)
            c1.Eating(); // Eating() is in creature class -> creature is eating
            c1.Move(); // Move() is in creature class and human class -> creature is moving

            // So in this case the overriding option is off to turn it on
            // We should make the function in creature class virtual and override in human class, why?
            // as you may want the function does not override the parent function (video day3.1 min 30)
            c1.Move();


            creature c2 = new Employee();
            c2.Move(); // Will call the last overrided function which is in human calss

            
        }
    }
}
