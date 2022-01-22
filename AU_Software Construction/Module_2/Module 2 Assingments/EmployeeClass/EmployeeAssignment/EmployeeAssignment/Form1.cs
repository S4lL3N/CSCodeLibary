namespace EmployeeAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee emp = new Employee("Susan Meyers", 47899, "Accounting", "Vice President");
            Employee emp2 = new Employee("Mark Jones", 39119, "IT", "Programmer");
            Employee emp3 = new Employee("Joy Rogers", 81774, "Manufacturing", "Engineer");
            Employee emp4 = new Employee();


            MessageBox.Show("Name: " + emp.empName + " Id: " + emp.empIdNumber.ToString() + " Department: " + emp.empDepartment + " Position: " + emp.empPosition);
            MessageBox.Show("Name: " + emp2.empName + " Id: " + emp2.empIdNumber.ToString() + " Department: " + emp2.empDepartment + " Position: " + emp2.empPosition);
            MessageBox.Show("Name: " + emp3.empName + " Id: " + emp3.empIdNumber.ToString() + " Department: " + emp3.empDepartment + " Position: " + emp3.empPosition);
            MessageBox.Show("Name: " + emp4.empName + " Id: " + emp4.empIdNumber.ToString() + " Department: " + emp4.empDepartment + " Position: " + emp4.empPosition);
        }
    }
}