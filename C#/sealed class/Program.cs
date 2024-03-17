namespace sealed_class
{
    class parent
    {
        // If i don't want this function to be overrided just remove virtual
        // (as i can't use sealed class here)
        public virtual void print()
        {
            Console.WriteLine("Hello from parent");
        }
    }
    class child : parent
    {
        // we class inherit from child can not override this sealed method
        public sealed override void print()
        {
            Console.WriteLine("Hello from child");
        }
    }
    // greandchild class can not be inherited.
    sealed class greandchild : child
    {
        // We can use new keyword (Hide the implementation of the base class (child))
        public new void print()
        {
            Console.WriteLine("Hello from greandchild");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
