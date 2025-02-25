using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees_Inheritance
{
    public class Manager:Employee
    {

        private int numofEmpMan = -1;

        public int NumOfEmpMan { get { return numofEmpMan; } set { numofEmpMan = value; } }

        public Manager(string Aname, int aSalary, int aNumOfEmpMan) : base(Aname, aSalary) 
        { NumOfEmpMan = aNumOfEmpMan; }

        public override string ToString()
        {
            string message = "Employee Name: " + Name + ", Salary:" + Salary + ", Number of Employees Managed: "+ NumOfEmpMan;
            return message;
        }


    }
}
