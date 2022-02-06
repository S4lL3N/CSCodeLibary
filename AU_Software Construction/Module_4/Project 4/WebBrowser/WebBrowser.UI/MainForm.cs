﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebBrowser.UI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void exitWebBrowserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Web Broswer Project for CPSC-2710\nBy: Shae Allen -- SWA0014");
        }

        private void webUserControl1_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && (e.KeyCode == Keys.T))
            {
                //this.tabControl1.TabPages.Add(new TabPage("New Tab"));

            }
            if (e.Control && (e.KeyCode == Keys.W))
            {
                this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            
        }

        private void newTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //this.tabControl1.TabPages.Add(new TabPage("New Tab"));
            TabPage tabPage = new TabPage();
            tabPage.Text = "New Tab";
            WebUserControl webUserControl = new WebUserControl();
            webUserControl.Dock = DockStyle.Fill;
            tabPage.Controls.Add(webUserControl);
            tabControl1.TabPages.Add((TabPage)tabPage);
        }
        private void closeCurrentTabToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.tabControl1.TabPages.RemoveAt(this.tabControl1.SelectedIndex);
        }
    }
}
