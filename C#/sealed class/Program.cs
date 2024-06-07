namespace sealed_class
{
    class parent
    {
        // If i don't want this function to be overridden just remove virtual
        // (as i can't use sealed class here)
        public virtual void print()
        {
            Console.WriteLine("Hello from parent");
        }
    }
    class child : parent
    {
        // Any class inherits from child can not override this sealed method
        // can be overridden, but if we want to disable the override to the next generation just use
        // public sealed override void print() 
        public override void print() 
        {
            Console.WriteLine("Hello from child");
        }
    }
    // grandchild class can not be inherited.
    sealed class greandchild : child
    {
        // We can use new keyword (Hide the implementation of the base class (child))
        public new void print()
        {
            Console.WriteLine("Hello from grandchild");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
