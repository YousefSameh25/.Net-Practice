
using System.Collections;

namespace iEnumerable
{

    class List : IEnumerable // To complete standardization why? 
    {              //To let me know in the main that the class List has a function called GetEnumerator()
        int[] arr;
        int LastIndex;

        public List()
        {
            arr = new int[3];
            LastIndex = -1; // Will points to the last used index.
        }

        public void Add(int value)
        {
            // You have used the total capacity
            if (LastIndex == arr.Length - 1)
                extend();

            arr[++LastIndex] = value;
        }

        private void extend()
        {
            int[] temp = new int[LastIndex * 2];
            Array.Copy(arr, temp, LastIndex + 1);
            arr = temp;
        }

        public IEnumerator GetEnumerator()
        {
            return new Iterator(this);
        }

        class Iterator : IEnumerator // Standardize, why? To allow me create object in main                              
        {                       // as the inner class is not visible except in the outer calss.
            List a;
            int Cur;

            public Iterator(List arr)
            {
                Cur = -1;
                a = arr;
            }
            public bool MoveNext()
            {
                // a.LastIndex can not be accessed without using inner class.
                return ++Cur < a.LastIndex;
            }
            public object Current
            {
                // a.arr[] can not be accessed without using inner class.
                get { return a.arr[Cur]; }
            }

            public void Reset()
            {
                Cur = -1;
            }
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            List list = new List();
            list.Add(1);
            list.Add(2);
            list.Add(3);
            list.Add(4);
            list.Add(5);

            IEnumerator iter = list.GetEnumerator();

            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }

            Console.WriteLine("========");
            iter.Reset();

            while (iter.MoveNext())
            {
                Console.WriteLine(iter.Current);
            }

        }
    }
}
