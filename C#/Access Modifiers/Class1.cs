namespace ClassLibrary
{
    // Class library is a project with no entry point.
    internal class TypeA
    {
        // Default here is private.
        private int i1; // Accessible within the class only.
        private protected int i2;
        protected int i3;
        internal int i4; // Accessible within this project only.
        internal protected int i5;
        public int i6; // Accessible within any project.
    }
    /*
        Note: Protected not allowed in structs as the structs do not allow inheritance.
    */

    public class TypeB
    {

    }
}
