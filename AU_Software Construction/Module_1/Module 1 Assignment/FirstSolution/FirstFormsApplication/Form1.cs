/*
 * Module 1 assignment part 3: First Forms Application
 * @author Shae Allen – CPSC-2710-AO1 
 * @version 1/15/22
 * 
 * Your form should contain three textboxes, a button and a label. Two of the textboxes will be used to enter numbers, and the third will be used to
 * enter an operation to perform (addition, subtraction, or multiplication). The program will output the result of performing the selected operation
 * on the two numbers to the label.
 */

namespace FirstFormsApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label4.Text = Solve();
        }
        private String Solve()
        {
            float number1;
            float number2;
            String operation;
            float answer;

            number1 = float.Parse(textBox1.Text);
            operation = textBox2.Text;
            number2 = float.Parse(textBox3.Text);
            

            if (operation.Equals("+"))
            {
                answer = number1 + number2;
            }
            else if (operation.Equals("-"))
            {
                answer = number1 - number2;
            }
            else if (operation.Equals("*"))
            {
                answer = number1 * number2;
            }
            else
            {
                answer = number1 / number2;
            }

            return "Answer: " + answer;


        }
    }
}