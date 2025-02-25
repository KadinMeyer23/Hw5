namespace Employees_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Employee aEmployee1 = new Employee("Bob",1000);
            Manager aEmployee2 = new Manager("Joe", 2000, 50);
            Engineer aEmplyee3 = new Engineer("Hank", 2500, "Software");

            List<Employee> ListOfEmployees = new List<Employee>();
            ListOfEmployees.Add(aEmployee1);
            ListOfEmployees.Add(aEmployee2);
            ListOfEmployees.Add(aEmplyee3);

            foreach (Employee employee in ListOfEmployees) {Console.WriteLine(employee.ToString()); }
        }
    }
}
