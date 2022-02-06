using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Module4Activity
{
    public partial class MainForm : Form
    {
        float dormCost = 0;
        float mealCost = 0;
        float totalCost = 0;
        public MainForm()
        {
            InitializeComponent();
        }

        private void AllenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dormCost = 1500;

        }

        private void PikeRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dormCost = 1600;
        }

        private void FarthingRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dormCost = 1800;
        }

        private void UnivRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            dormCost = 2500;
        }

        private void SevenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 600;
        }

        private void FourteenRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 1200;
        }

        private void UnlimitedRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            mealCost = 1700;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            totalCost = dormCost + mealCost;
            TotalForm totals = new TotalForm();
            totals.TotalLabelText = this.totalCost.ToString("C");
            //totals.Show();
            openChildForm(totals);
        }


        private Form activeform = null;
        private void openChildForm(Form childForm)
        {
            if (activeform != null)
            {
                activeform.Close();
            }
            activeform = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            //add the panel to show the form
            TotalPanel.Controls.Add(childForm);
            TotalPanel.Tag = childForm;
            childForm.Show();
        }
    }
}
