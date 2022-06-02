namespace TP1.Models.IRepository
{
    public class EmployeeRepository : IRepository<Employee>

    {
        List<Employee> lemployees;
        public EmployeeRepository()
        {
            lemployees = new List<Employee>()
             {
             new Employee {Id=1,Name="Sofien ben ali", Departement= "comptabilité",Salary=1000},
             new Employee {Id=2,Name="Mourad triki", Departement= "HR",Salary=1500},
            new Employee {Id=3,Name="ali ben mohamed", Departement= "informatique",Salary=1700},
             new Employee {Id=4,Name="tarak aribi", Departement= "informatique",Salary=1100}
             };
        }

        public void Add(Employee e)
        {
            lemployees.Add(e);
        }

        public void Delete(int id)
        {
            var emp = FindByID(id);
            lemployees.Remove(emp);
        }

        public Employee FindByID(int id)
        {
            return lemployees.FirstOrDefault(x => x.Id == id);
        }

        public IList<Employee> GetAll()
        {
            return lemployees;
        }

        public double SalaryAverage()
        {
            return lemployees.Average(x => x.Salary);
        }
        public double MaxSalary()
        {
            return lemployees.Max(x => x.Salary);
        }
        public int HrEmployeesCount()
        {
            return lemployees.Where(x => x.Departement == "HR").Count();
        }

        public List<Employee> Search(string term)
        {
            if (!String.IsNullOrEmpty(term))
                return lemployees.Where(a => a.Name.Contains(term)).ToList();
            else
                return lemployees;
        }

        public void Update(int id, Employee NewEmploye)
        {
            var emp = FindByID(id);
            emp.Name = NewEmploye.Name;
            emp.Departement = NewEmploye.Departement;
            emp.Salary = NewEmploye.Salary;
        }
    }
}
