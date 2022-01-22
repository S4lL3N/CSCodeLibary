using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeAssignment
{
    internal class Employee
    {
        private string Name;
        private int IdNumber;
        private string Department;
        private string Position;

        //parameterless constructor
        public Employee()
        {
           Name = ""; 
           IdNumber = 0;
           Department = "";
           Position = ""; 
        }
        //constructor 1
        public Employee(string NameIn, int IdNumberIn, string DepartmentIn, string PositionIn)
        {
            Name = NameIn;
            IdNumber = IdNumberIn;
            Department = DepartmentIn;
            Position = PositionIn;
        }
        //constructor 2
        public Employee(string NameIn, int IdNumberIn)
        {
            Name = NameIn;
            IdNumber = IdNumberIn;
            Department = "";
            Position = ""; 
        }

        public string empName
        {
            get { return Name; }
            set { Name = value; }
        }
        public int empIdNumber
        {
            get { return IdNumber; }
            set { IdNumber = value; }
        }
        public string empDepartment
        {
            get { return Department; }
            set { Department = value; }
        }
        public string empPosition
        {
            get { return Position; }
            set { Position = value; }
        }

    }
}
