namespace LinkedList
{
    class node
    {
        public int value { get; set; }
        public node? next { get; set; }
    }

    class LinkedList
    {
        private node? Head, End;
        public int Length { get; set; }

        public LinkedList()
        {
            Head = null;
            End = null;
            Length = 0;
        }
        public void AddFromBegin(int value)
        {
            //O(1)
            node n = new node();
            n.value = value;

            if (Head != null)
                n.next = Head;

            Head = n;

            if (End == null)
                End = n;

            Length++;
        }
        public void AddFromEnd(int value)
        {
            //O(1)
            node n = new node();
            n.value = value;

            if (End != null)
                End.next = n;

            End = n;

            if (Head == null)
                Head = n;

            Length++;
        }
        public void Print()
        {
            //O(Length)
            node? cur = Head;
            while (cur != null)
            {
                Console.Write($"{cur.value} ");
                cur = cur.next;
            }
            Console.WriteLine("");
        }
        public void GetByIndex(int index)
        {
            //O(Length)
            int tmp = 0;
            node? cur = Head;
            while (cur != null)
            {
                if (tmp == index)
                {
                    Console.WriteLine(cur.value);
                    break;
                }
                tmp++;
                cur = cur.next;
            }
        }
        public void RemoveByIndex(int index)
        {
            //O(Length)
            if (Length == 1)
            {
                Head = null;
                End = null;
                Length--;
                return;
            }

            if (index == 0)
            {
                Head = Head.next;
                Length--;
                return;
            }

            // Get the object which is before the target object.
            int tmp = 0;
            node? cur = Head, BeforeTarget = null, Target = null;
            while (cur != null)
            {
                if (tmp == index - 1)
                    BeforeTarget = cur;
                else if (tmp == index)
                    Target = cur;

                tmp++;
                cur = cur.next;
            }

            // Make this object points to the object that after the target node.
            if (Target.next != null)
                BeforeTarget.next = Target.next;
            else
            {
                End = BeforeTarget;
                BeforeTarget.next = null;
            }

            Length--;
        }
    }



    internal class Program
    {
        class point
        {
            public int x, y;


            public static explicit operator int(point x)
            {
                return x.x;
            }


            public static implicit operator point(int x)
            {
                return new point { x = x, y = x };
            }

        }
        static void Main(string[] args)
        {
            LinkedList list = new LinkedList();

            list.AddFromEnd(1);
            list.AddFromEnd(2);
            list.AddFromEnd(3);
            list.AddFromEnd(4);
            list.AddFromBegin(0);
            list.AddFromBegin(10);

            list.Print();

            list.RemoveByIndex(0);

            for (int i = 0; i < list.Length; i++)
                list.GetByIndex(i);

        }
    }
}
