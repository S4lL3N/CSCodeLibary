using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Module5Assignment
{
    public partial class Form1 : Form
    {
        string fileName;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            //BrowseOpenFileDialog.InitialDirectory = @"C:\Users\S4lL3\Documents\Code Library\C#\Software Construction\M5_Assignment";
            DialogResult result = BrowseOpenFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                fileName = BrowseOpenFileDialog.FileName;
            }
            
        }
        
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchString = KeywordTextBox.Text;
            
            StreamReader sr = new StreamReader(path: fileName);
            
            while (!sr.EndOfStream)
            {
                
                var line = sr.ReadLine();
                if (String.IsNullOrEmpty(line)) continue;
                if (line.IndexOf(searchString, StringComparison.CurrentCultureIgnoreCase) >= 0)
                {
                    ResultListBox.Items.Add(line);
                }
            }

        }
    }
}
