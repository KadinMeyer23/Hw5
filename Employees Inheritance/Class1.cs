using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Inheritance
{
    public class Employee
    {

        private string name = "n/a";
        private int salary = -10000;

        public string Name {get{ return this.name; }set { this.name = value; } }
        public int Salary {get{ return this.salary; }set {this.salary = value; } }

        public Employee(string Aname, int aSalary) {
        
            Name = Aname;
            Salary = aSalary;
        }

        public override string ToString()
        {
            string message = "Employee Name: " + Name + ", Salary:" + Salary;
            return message;
        }

    }
}
