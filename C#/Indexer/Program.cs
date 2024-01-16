namespace Indexer
{
    class EmployeesData
    {
        public string[] Name;
        public int[] salary;

        // Indexer is a property but without name.
        // May be [string arg1, int arg2, .....]
        // Indexer to get the salary by employee's name.
        public int this[string name] // This means what data type will use this indexer.
        {
            get
            {
                for (int i = 0; i < Name?.Length; i++)
                    if (Name[i] == name)
                        return salary[i];
                return -1;
            }
            set
            {
                for (int i = 0; i < Name?.Length; i++)
                    if (Name[i] == name)
                        salary[i] = value;
            }
        }

        // We can create many indexer but no 2 indexer have the same parameters types.

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeesData ED = new EmployeesData();
            ED.Name = new string[] { "Yousef", "ali", "hossam" };
            ED.salary = new int[] { 20000, 25000, 45000 };

            Console.WriteLine(ED["Yousef"]);
        }
    }
}
