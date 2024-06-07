namespace IReadOnlyCollection
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = new List<int> { 1, 5, 29 };

            IReadOnlyCollection<int> list2 = list;

            // Valid for read only.
            foreach (var item in list2)
                Console.WriteLine(item);
              
            // Not valid to modify:
            // list2.Add(39);
            // list2[0] = 4;

            // General informations:

            /*
                What does it mean by this line 'Animal a = new Dog();' ?
                It means that i am caring of members(data fields, functions) of the Animal class,
                (Very Important) But i may use a function of data field of dog at the runtime.

                When using this Animal a = new Animal() => i am sure that i want Animal members only.
                When using this Dog d = new Dog() => i am sure that i want Dog members only.

                Summary:
                Super s = new Child() => the reference s is responsible for what members do you want.
                when you want members of the child you have to cast:
                (Child)s.ChildMember.

                Same things with interface.

                For the combinations of a function exists in parent and not in child
                and bla bla bla 
                try to get the answer by thinking :).
            */

            /*
                 After this general information 
                 when we use IReadOnlyCollection<int> list2 = list;
                 that means i am only caring about interface members and definition
            */

            /*
                The reason you can't use modification methods on a List when 
                it's declared as IReadOnlyCollection<T> 
                is because the actual type of the object matters 
                when it comes to method availability. 
                While a List<T> implements the IReadOnlyCollection<T> interface, 
                it also has additional methods that are specific to List<T> 
                and not part of the IReadOnlyCollection<T> interface.

                When you declare a variable as IReadOnlyCollection<T> 
                and assign a List<T> to it, 
                you are stating that you intend to treat 
                the object as an immutable, read-only collection.
                The compiler enforces this contract by only 
                allowing you to use methods declared in the IReadOnlyCollection<T> interface,
                which does not include modification methods.

                If i want methods in List class i have to perform casting operation.
            */

        }
    }
}
