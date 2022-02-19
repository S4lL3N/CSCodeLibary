using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module6Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            ProductionWorker pw = new ProductionWorker(int.Parse(NumberTextBox.Text), NameTextBox.Text, int.Parse(ShiftTextBox.Text), float.Parse(HourlyTextBox.Text));
            MessageBox.Show("Id: " + pw.EmployeeNumber.ToString() + "\nName: " + pw.EmployeeName + "\nShift: " + pw.ShiftNumber.ToString() + "\nHourly Rate: " + pw.HourlyRate.ToString());
        }

        private void NumberTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ShiftTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void HourlyTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
