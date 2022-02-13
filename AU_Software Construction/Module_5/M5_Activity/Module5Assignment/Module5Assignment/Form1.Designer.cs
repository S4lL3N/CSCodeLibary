namespace Module5Assignment
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BrowseButton = new System.Windows.Forms.Button();
            this.KeywordLabel = new System.Windows.Forms.Label();
            this.KeywordTextBox = new System.Windows.Forms.TextBox();
            this.SearchButton = new System.Windows.Forms.Button();
            this.ResultListBox = new System.Windows.Forms.ListBox();
            this.BrowseOpenFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // BrowseButton
            // 
            this.BrowseButton.Location = new System.Drawing.Point(12, 12);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(139, 27);
            this.BrowseButton.TabIndex = 0;
            this.BrowseButton.Text = "Browse Files";
            this.BrowseButton.UseVisualStyleBackColor = true;
            this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
            // 
            // KeywordLabel
            // 
            this.KeywordLabel.AutoSize = true;
            this.KeywordLabel.Location = new System.Drawing.Point(12, 51);
            this.KeywordLabel.Name = "KeywordLabel";
            this.KeywordLabel.Size = new System.Drawing.Size(62, 16);
            this.KeywordLabel.TabIndex = 1;
            this.KeywordLabel.Text = "Keyword:";
            // 
            // KeywordTextBox
            // 
            this.KeywordTextBox.Location = new System.Drawing.Point(77, 48);
            this.KeywordTextBox.Name = "KeywordTextBox";
            this.KeywordTextBox.Size = new System.Drawing.Size(176, 22);
            this.KeywordTextBox.TabIndex = 2;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(259, 47);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 23);
            this.SearchButton.TabIndex = 3;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // ResultListBox
            // 
            this.ResultListBox.FormattingEnabled = true;
            this.ResultListBox.ItemHeight = 16;
            this.ResultListBox.Location = new System.Drawing.Point(15, 76);
            this.ResultListBox.Name = "ResultListBox";
            this.ResultListBox.Size = new System.Drawing.Size(319, 132);
            this.ResultListBox.TabIndex = 4;
            // 
            // BrowseOpenFileDialog
            // 
            this.BrowseOpenFileDialog.FileName = "Testing.txt";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 223);
            this.Controls.Add(this.ResultListBox);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.KeywordTextBox);
            this.Controls.Add(this.KeywordLabel);
            this.Controls.Add(this.BrowseButton);
            this.Name = "Form1";
            this.Text = "Module 5 Assignment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BrowseButton;
        private System.Windows.Forms.Label KeywordLabel;
        private System.Windows.Forms.TextBox KeywordTextBox;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.ListBox ResultListBox;
        private System.Windows.Forms.OpenFileDialog BrowseOpenFileDialog;
    }
}

