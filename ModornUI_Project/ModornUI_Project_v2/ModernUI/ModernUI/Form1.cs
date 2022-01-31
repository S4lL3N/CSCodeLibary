using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModernUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            customizeDesign();
        }

        /*
         * https://www.youtube.com/watch?v=JP5rgXO_5Sk
         * 
         * just color picker
         * colors:
         *   Side panel        1. 11, 7, 17
         *   submenu panel     2. 35, 32, 39
         *   main bottom panel 3. 23, 21, 32
         *   main top panel    4. 32, 30,45
         */
        private void customizeDesign()
        {
            MediaSubmenuPanel.Visible = false;
            OtherButton1SubmenuPanel.Visible = false;
            HelpSubmenuPanel.Visible = false;
        }

        private void hideSubmenu()
        {
            if(MediaSubmenuPanel.Visible == true){
                MediaSubmenuPanel.Visible = false;
            }
            if (OtherButton1SubmenuPanel.Visible == true)
            {
                OtherButton1SubmenuPanel.Visible = false;
            }
            if (HelpSubmenuPanel.Visible == true)
            {
                HelpSubmenuPanel.Visible = false;
            }
        }

        private void showSubmenu(Panel submenu)
        {
            if (submenu.Visible == false)
            {
                hideSubmenu();
                submenu.Visible = true;
            }
            else 
            {
                submenu.Visible = false;
            }

        }
        #region Home
        //Home button
        private void button1_Click_1(object sender, EventArgs e)
        {
            showSubmenu(MediaSubmenuPanel);
        }
        //media submenu button 2
        private void button2_Click(object sender, EventArgs e)
        {
            //the logic
            openChildForm(new Form2());
            hideSubmenu();
        }
        //media submenu button 3
        private void button3_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        //media submenu button 4
        private void button4_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        //media submenu button 5
        private void button5_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }


        #endregion


        #region other button 1
        //other button 1
        private void button6_Click(object sender, EventArgs e)
        {
            showSubmenu(OtherButton1SubmenuPanel);
        }
        // other button submenu 1
        private void button10_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        // other button submenu 2
        private void button9_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        // other button submenu 3
        private void button8_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        // other button submenu 4
        private void button7_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }

        #endregion


        #region help
        //help button
        private void button11_Click(object sender, EventArgs e)
        {
            showSubmenu(HelpSubmenuPanel);
        }
        //help button submenu 1
        private void button15_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        //help button submenu 2
        private void button14_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        //help button submenu 3
        private void button13_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        //help button submenu 4
        private void button12_Click(object sender, EventArgs e)
        {
            //the logic
            hideSubmenu();
        }
        #endregion



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
            MainTopPanel.Controls.Add(childForm);
            MainTopPanel.Tag = childForm;
            childForm.Show();
        }
    }

}
