namespace Generics
{
    // may be <T1, T2, ....>
    class MyList<T> where T : class // Add restriction, to check the entered item is not null.
    {             // class may be for ex employee and that means we can add employee and any child of it.
        T[] arr;  // T : new() => allow me to return new T() for ex in GetByIndex function
        public int Length { get; set; }

        public MyList()
        {
            Length = 0;
            arr = new T[3];
        }
        public void Add(T item)
        {
            if (item == null)
                return;

            if (Length > arr.Length - 1)
                extend();
            arr[Length++] = item;
        }
        private void extend()
        {
            T[] arr2 = new T[Length * 2];
            for (int i = 0; i < Length; i++)
                arr2[i] = arr[i];

            arr = arr2;
        }
        public T GetByIndex(int index)
        {
            return arr[index];

            //return new T();
        }
    }


    internal class Program
    {

        // generic function.
        static T GetLast<T>(T[] arr)
        {
            return arr[arr.Length - 1];
        }


        static void Main(string[] args)
        {

            //MyList<int> list = new MyList<int>(); wrong

            MyList<string> list2 = new MyList<string>();

            list2.Add("hi");
            list2.Add("hi");
            list2.Add("hi");

            for (int i = 0; i < list2.Length; i++)
                Console.WriteLine(list2.GetByIndex(i));


            int[] arr = { 1, 3, 6 };

            int ret = GetLast(arr);

            Console.WriteLine(ret);
        }
    }
}
