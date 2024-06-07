using System.Security.AccessControl;

namespace ClassLibrary
{
    // Class library is a project with no entry point.
    internal class TypeA
    {
        // Default here is private.
        public int i6; // Accessible within any project.

        private int i1; // Accessible within the class only.

        protected int i3; // Accessible by any child anywhere.

        internal int i4; // Accessible within the same project only.

        internal protected int i5; // Children + Not children in same assembly.

        private protected int i2; // Children in the same assembly.

        // Look at https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
    }
    /*
        Note: Protected not allowed in Structs as the Structs do not allow inheritance.
    */

    public class TypeB
    {

    }
}
