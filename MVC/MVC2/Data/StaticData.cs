namespace MVC2.Data
{
    public class StaticData
    {
        public List<Department> Departments { get; set; }
        public List<Employee> Employees { get; set; }

        public StaticData()
        {
            Departments = new List<Department>();
            Employees = new List<Employee>();
            LoadData();
        }

        private void LoadData()
        {
            Departments.Add(new Department { Id = 1, Name = "HR" });
            Departments.Add(new Department { Id = 2, Name = "SW" });
            Departments.Add(new Department { Id = 3, Name = "Marketing" });
            Departments.Add(new Department { Id = 4, Name = "Sales" });
            Departments.Add(new Department { Id = 5, Name = "IT" });

            Employees.Add(new Employee { Id = 1, FullName = "Samir Ali" });
            Employees.Add(new Employee { Id = 2, FullName = "Ahmed Mohamed" });
            Employees.Add(new Employee { Id = 3, FullName = "Mona Galal" });
            Employees.Add(new Employee { Id = 4, FullName = "Reem Mostafa" });
            Employees.Add(new Employee { Id = 5, FullName = "Said Hussein" });
            Employees.Add(new Employee { Id = 6, FullName = "Ahmed Metwally" });
            Employees.Add(new Employee { Id = 7, FullName = "Nader Mohamed" });
            Employees.Add(new Employee { Id = 8, FullName = "Mahmoud Saleh" });
            Employees.Add(new Employee { Id = 9, FullName = "Maha Ahmed" });
            Employees.Add(new Employee { Id = 10, FullName = "Amir Shalaby" });

            for (int i = 0, j = 0; i < Departments.Count; i++, j += 2)
            {
                Departments[i].Employees.Add(Employees[j]);
                Departments[i].Employees.Add(Employees[j + 1]);

                Employees[j].Department = Departments[i];
                Employees[j + 1].Department = Departments[i];
            }
        }
    }
}
