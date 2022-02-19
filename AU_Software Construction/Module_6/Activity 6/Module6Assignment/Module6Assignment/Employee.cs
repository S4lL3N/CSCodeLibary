using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module6Assignment
{
    internal class Employee
    {
        private int _EmployeeNumber;
        private string _EmployeeName;
        public Employee(int employeeNumberIn, string emplyeeNameIn)
        {
            EmployeeNumber = employeeNumberIn;
            EmployeeName = emplyeeNameIn;
        }

        public string EmployeeName
        {
            get { return _EmployeeName; }
            set { _EmployeeName = value; }
        }

        public int EmployeeNumber
        {
            get { return _EmployeeNumber; }
            set { _EmployeeNumber = value; }
        }



    }
}
