/*
 * Module 2 assignment part 1: Hospital Charges
 * @author Shae Allen – CPSC-2710-AO1 
 * @version 1/22/22
 * 
 * Create an application that calculates the total cost of a hospital stay. The daily base charge is
 * $350. The hospital also charges for medication, surgical fees, lab fees, and physical rehab.
 */
namespace HospitalCharges
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        //Days in hospital
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        //Medication charges
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        //surgical charges
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        //lab fees
        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        //physical rehabilitation charges
        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
        //totals label
        private void label6_Click(object sender, EventArgs e)
        {

        }
        //Numerical Totals
        private void label7_Click(object sender, EventArgs e)
        {

        }
        //calculate button
        private void button1_Click(object sender, EventArgs e)
        {
            label7.Text = CalcTotalCharges();
        }
        //clear button
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            label7.Text = "$0.00";
        }
        /*
         * Calculates and returns the base charges for the hospital stay. This is
         * computed as $350 times the number of days in the hospital.
         */
        private float CalcStayCharges()
        {
            int days;
            float StayCharges;

            days = int.Parse(textBox1.Text);
            StayCharges = days * 350;

            return StayCharges;
        }
        /*
         * calculates and returns the total of the medication, surgical, lab, and
         * physical rehabilitation charges.
         */
        private float CalcMiscCharges()
        {
            float charges;
            float medicationCharges;
            float surgicalCharges;
            float labFees;
            float phyRehabCharges;

            medicationCharges = float.Parse(textBox2.Text);
            surgicalCharges = float.Parse(textBox3.Text);
            labFees = float.Parse(textBox4.Text);
            phyRehabCharges = float.Parse(textBox5.Text);

            charges = medicationCharges + surgicalCharges + labFees + phyRehabCharges;
            return charges; 
        }
        /*
         * calculates and returns the total charges
         */
        private String CalcTotalCharges()
        {
            float totalCharges;
            float stayCharge;
            float miscCharges;
            String totalChargesString;

            stayCharge = CalcStayCharges();
            miscCharges = CalcMiscCharges();
            totalCharges = stayCharge + miscCharges;

            totalChargesString = "$" + totalCharges.ToString();

            return totalChargesString;
            
        }
    }
}