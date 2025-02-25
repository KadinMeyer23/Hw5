using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Inheritance
{
    public class Engineer:Employee
    {

        private string specialization = "n/a";

        public string Specialization {  get { return specialization; } set { specialization = value; } }

        public Engineer(string Aname, int aSalary, string aSpecialization) : base(Aname, aSalary) 
        { Specialization = aSpecialization;  }

        public override string ToString()
        {
            string message = "Employee Name: " + Name + ", Salary:" + Salary + ", Specialization: " + Specialization;
            return message;
        }
    }
}
