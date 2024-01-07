

namespace CustomizeListToBusinessLogic
{

    /*
    - Problem:
     Suppose in my business logic i can not add a negative number to the list.
    - Solution: 
     I can create new class which will Inherit from Class List (has all features)
     then create new function called Add to write my own logic.
     when i want to add i will use the Add function which in the base class.
     */

    class CustomizedList : List<int> // CustomizedList has all features of List
    {
        public new void Add(int num)
        {
            if (num < 0)
                throw new Exception();
            base.Add(num);
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            CustomizedList list = new CustomizedList();
            list.Add(-1); // Will throw an exception.
            list.Add(1);
        }
    }
}
