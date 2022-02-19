namespace Module6Assignment
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
            this.ShiftNumberLabel = new System.Windows.Forms.Label();
            this.HourlyRateLabel = new System.Windows.Forms.Label();
            this.ShiftTextBox = new System.Windows.Forms.TextBox();
            this.HourlyTextBox = new System.Windows.Forms.TextBox();
            this.NameLabel = new System.Windows.Forms.Label();
            this.NameTextBox = new System.Windows.Forms.TextBox();
            this.NumberLabel = new System.Windows.Forms.Label();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ShiftNumberLabel
            // 
            this.ShiftNumberLabel.AutoSize = true;
            this.ShiftNumberLabel.Location = new System.Drawing.Point(12, 96);
            this.ShiftNumberLabel.Name = "ShiftNumberLabel";
            this.ShiftNumberLabel.Size = new System.Drawing.Size(86, 16);
            this.ShiftNumberLabel.TabIndex = 0;
            this.ShiftNumberLabel.Text = "Shift Number:";
            // 
            // HourlyRateLabel
            // 
            this.HourlyRateLabel.AutoSize = true;
            this.HourlyRateLabel.Location = new System.Drawing.Point(11, 128);
            this.HourlyRateLabel.Name = "HourlyRateLabel";
            this.HourlyRateLabel.Size = new System.Drawing.Size(81, 16);
            this.HourlyRateLabel.TabIndex = 1;
            this.HourlyRateLabel.Text = "Hourly Rate:";
            // 
            // ShiftTextBox
            // 
            this.ShiftTextBox.Location = new System.Drawing.Point(141, 96);
            this.ShiftTextBox.Name = "ShiftTextBox";
            this.ShiftTextBox.Size = new System.Drawing.Size(100, 22);
            this.ShiftTextBox.TabIndex = 2;
            this.ShiftTextBox.TextChanged += new System.EventHandler(this.ShiftTextBox_TextChanged);
            // 
            // HourlyTextBox
            // 
            this.HourlyTextBox.Location = new System.Drawing.Point(141, 125);
            this.HourlyTextBox.Name = "HourlyTextBox";
            this.HourlyTextBox.Size = new System.Drawing.Size(100, 22);
            this.HourlyTextBox.TabIndex = 3;
            this.HourlyTextBox.TextChanged += new System.EventHandler(this.HourlyTextBox_TextChanged);
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Location = new System.Drawing.Point(12, 67);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(112, 16);
            this.NameLabel.TabIndex = 0;
            this.NameLabel.Text = "Employee Name:";
            // 
            // NameTextBox
            // 
            this.NameTextBox.Location = new System.Drawing.Point(141, 67);
            this.NameTextBox.Name = "NameTextBox";
            this.NameTextBox.Size = new System.Drawing.Size(100, 22);
            this.NameTextBox.TabIndex = 2;
            this.NameTextBox.TextChanged += new System.EventHandler(this.NameTextBox_TextChanged);
            // 
            // NumberLabel
            // 
            this.NumberLabel.AutoSize = true;
            this.NumberLabel.Location = new System.Drawing.Point(12, 37);
            this.NumberLabel.Name = "NumberLabel";
            this.NumberLabel.Size = new System.Drawing.Size(123, 16);
            this.NumberLabel.TabIndex = 0;
            this.NumberLabel.Text = "Employee Number:";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(141, 37);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(100, 22);
            this.NumberTextBox.TabIndex = 2;
            this.NumberTextBox.TextChanged += new System.EventHandler(this.NumberTextBox_TextChanged);
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(114, 167);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(127, 37);
            this.SaveButton.TabIndex = 4;
            this.SaveButton.Text = "Save/Display";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(266, 225);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.HourlyTextBox);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.NameTextBox);
            this.Controls.Add(this.ShiftTextBox);
            this.Controls.Add(this.HourlyRateLabel);
            this.Controls.Add(this.NumberLabel);
            this.Controls.Add(this.NameLabel);
            this.Controls.Add(this.ShiftNumberLabel);
            this.Name = "Form1";
            this.Text = "Production Worker";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ShiftNumberLabel;
        private System.Windows.Forms.Label HourlyRateLabel;
        private System.Windows.Forms.TextBox ShiftTextBox;
        private System.Windows.Forms.TextBox HourlyTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.TextBox NameTextBox;
        private System.Windows.Forms.Label NumberLabel;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.Button SaveButton;
    }
}

