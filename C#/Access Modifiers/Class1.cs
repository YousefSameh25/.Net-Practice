using System.Security.AccessControl;

namespace ClassLibrary
{
    // Class library is a project with no entry point.
    internal class TypeA
    {
        // Default here is private.
        private int i1; // Accessible within the class only.
        private protected int i2; // This access modifier allows a member to be accessible within the same assembly and only to derived classes within that assembly.
        protected int i3; // Members with the protected access modifier are accessible within the same class, as well as in derived classes.They are not accessible from outside the class hierarchy.
        internal int i4; // Accessible within this project only.
        internal protected int i5; // Allows access to members from within the same assembly or from derived classes, even if they are in a different assembly.
        public int i6; // Accessible within any project.
    }
    /*
        Note: Protected not allowed in structs as the structs do not allow inheritance.
    */

    public class TypeB
    {

    }
}
