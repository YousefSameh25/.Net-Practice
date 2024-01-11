using System.Text;

namespace Assignment
{
    public enum WeekDays : byte
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }

    public enum Season : byte
    {
        Spring,
        Summer,
        Autumn,
        Winter
    }

    public enum Permissions : int
    {
        // Must be 2 to the power of i.
        Read = 1,
        Write = 2,
        Delete = 4,
        Execute = 8
    }

    public enum Colors : int
    {
        // Must be 2 to the power of i.
        Red = 1,
        Green = 2,
        Blue = 4,
    }

    public struct Person
    {
        public string name;
        public int age;
    }

    public struct Point
    {
        public int X;
        public int Y;
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            #region (1)
            //for (int d = 0; d < 7; d++)
            //    Console.WriteLine((WeekDays)d);
            #endregion

            #region (2)
            //Person[] persons = {
            //    new Person { name = "Yousef" , age = 22},
            //    new Person { name = "Ali" , age = 16},
            //    new Person { name = "Omar" , age = 25},
            //};

            //for (int i = 0; i < persons.Length; i++)
            //    Console.WriteLine($"Name: {persons[i].name}, age: {persons[i].age}");
            #endregion

            #region (3)
            //string[] months = { "January", "February", "March", "April", "May", "June", "July",
            //    "August", "September", "October", "November", "December" };

            //var range = new Dictionary<Season, KeyValuePair<int, int>>
            //{
            //   { Season.Spring, KeyValuePair.Create (2 , 4) },
            //   { Season.Summer , KeyValuePair.Create (5 , 7) },
            //   { Season.Autumn , KeyValuePair.Create (8 , 10) },
            //   { Season.Winter , KeyValuePair.Create (11 , 1) },
            //};

            //Console.Write("Enter the Season: ");

            //Object input = Enum.Parse(typeof(Season), Console.ReadLine(), true);

            //Season season = (Season)input;

            //int start = range[season].Key;
            //int MonthsCnt = ((range[season].Value - range[season].Key + 1) + 12) % 12;

            //while (MonthsCnt-- > 0)
            //    Console.WriteLine(months[start++ % 12]);
            #endregion

            #region (4)
            //Permissions permissions = Permissions.Read;

            //// Adding a permission.
            //permissions |= Permissions.Write;

            //// Remove a permission.
            //permissions ^= Permissions.Write;

            //if ((permissions & Permissions.Read) > 0)
            //    Console.WriteLine("Read permission is exist.");
            #endregion

            #region (5)
            //string color = Console.ReadLine();

            //object ColorObj;
            //bool primary = Enum.TryParse(typeof(Colors), color, true, out ColorObj);

            //if (primary)
            //    Console.WriteLine("The color is a primary color");
            //else
            //    Console.WriteLine("The color isn't a primary color");
            #endregion

            #region (6)
            //Point p1, p2;
            //Console.Write("Enter x for point 1: ");
            //p1.X = int.Parse(Console.ReadLine());
            //Console.Write("Enter y for point 1: ");
            //p1.Y = int.Parse(Console.ReadLine());

            //Console.Write("Enter x for point 2: ");
            //p2.X = int.Parse(Console.ReadLine());
            //Console.Write("Enter y for point 2: ");
            //p2.Y = int.Parse(Console.ReadLine());

            //double dis = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
            //Console.WriteLine($"Distance = {dis}");
            #endregion

            #region (7)
            //Person[] persons = new Person[3];

            //Person Oldest = new Person();

            //for (int i = 0; i < 3; i++)
            //{
            //    Console.Write("Enter name: ");
            //    string name = Console.ReadLine();

            //    Console.Write("Enter age: ");
            //    int age = int.Parse(Console.ReadLine());

            //    persons[i].name = name;
            //    persons[i].age = age;

            //    if (age > Oldest.age)
            //        Oldest = persons[i];
            //}

            //Console.WriteLine($"Name : {Oldest.name} , Age : {Oldest.age}");
            #endregion
        }
    }
}
