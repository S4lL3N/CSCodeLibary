namespace Module4Activity
{
    partial class MainForm
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
            this.DormitoriesLabel = new System.Windows.Forms.Label();
            this.AllenRadioButton = new System.Windows.Forms.RadioButton();
            this.PikeRadioButton = new System.Windows.Forms.RadioButton();
            this.FarthingRadioButton = new System.Windows.Forms.RadioButton();
            this.UnivRadioButton = new System.Windows.Forms.RadioButton();
            this.MealLabel = new System.Windows.Forms.Label();
            this.SevenRadioButton = new System.Windows.Forms.RadioButton();
            this.FourteenRadioButton = new System.Windows.Forms.RadioButton();
            this.UnlimitedRadioButton = new System.Windows.Forms.RadioButton();
            this.DormPanel = new System.Windows.Forms.Panel();
            this.MealPanel = new System.Windows.Forms.Panel();
            this.Calculatebutton = new System.Windows.Forms.Button();
            this.TotalPanel = new System.Windows.Forms.Panel();
            this.DormPanel.SuspendLayout();
            this.MealPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DormitoriesLabel
            // 
            this.DormitoriesLabel.AutoSize = true;
            this.DormitoriesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DormitoriesLabel.Location = new System.Drawing.Point(3, 11);
            this.DormitoriesLabel.Name = "DormitoriesLabel";
            this.DormitoriesLabel.Size = new System.Drawing.Size(116, 25);
            this.DormitoriesLabel.TabIndex = 0;
            this.DormitoriesLabel.Text = "Dormitories:";
            // 
            // AllenRadioButton
            // 
            this.AllenRadioButton.AutoSize = true;
            this.AllenRadioButton.Location = new System.Drawing.Point(113, 40);
            this.AllenRadioButton.Name = "AllenRadioButton";
            this.AllenRadioButton.Size = new System.Drawing.Size(209, 20);
            this.AllenRadioButton.TabIndex = 1;
            this.AllenRadioButton.TabStop = true;
            this.AllenRadioButton.Text = "Allen Hall-$1,500 per semester";
            this.AllenRadioButton.UseVisualStyleBackColor = true;
            this.AllenRadioButton.CheckedChanged += new System.EventHandler(this.AllenRadioButton_CheckedChanged);
            // 
            // PikeRadioButton
            // 
            this.PikeRadioButton.AutoSize = true;
            this.PikeRadioButton.Location = new System.Drawing.Point(113, 66);
            this.PikeRadioButton.Name = "PikeRadioButton";
            this.PikeRadioButton.Size = new System.Drawing.Size(209, 20);
            this.PikeRadioButton.TabIndex = 1;
            this.PikeRadioButton.TabStop = true;
            this.PikeRadioButton.Text = "Pike Hall- $1,600 per semester";
            this.PikeRadioButton.UseVisualStyleBackColor = true;
            this.PikeRadioButton.CheckedChanged += new System.EventHandler(this.PikeRadioButton_CheckedChanged);
            // 
            // FarthingRadioButton
            // 
            this.FarthingRadioButton.AutoSize = true;
            this.FarthingRadioButton.Location = new System.Drawing.Point(113, 92);
            this.FarthingRadioButton.Name = "FarthingRadioButton";
            this.FarthingRadioButton.Size = new System.Drawing.Size(230, 20);
            this.FarthingRadioButton.TabIndex = 1;
            this.FarthingRadioButton.TabStop = true;
            this.FarthingRadioButton.Text = "Farthing Hall- $1,800 per semester";
            this.FarthingRadioButton.UseVisualStyleBackColor = true;
            this.FarthingRadioButton.CheckedChanged += new System.EventHandler(this.FarthingRadioButton_CheckedChanged);
            // 
            // UnivRadioButton
            // 
            this.UnivRadioButton.AutoSize = true;
            this.UnivRadioButton.Location = new System.Drawing.Point(113, 118);
            this.UnivRadioButton.Name = "UnivRadioButton";
            this.UnivRadioButton.Size = new System.Drawing.Size(254, 20);
            this.UnivRadioButton.TabIndex = 1;
            this.UnivRadioButton.TabStop = true;
            this.UnivRadioButton.Text = "University Suites- $2,500 per semester";
            this.UnivRadioButton.UseVisualStyleBackColor = true;
            this.UnivRadioButton.CheckedChanged += new System.EventHandler(this.UnivRadioButton_CheckedChanged);
            // 
            // MealLabel
            // 
            this.MealLabel.AutoSize = true;
            this.MealLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MealLabel.Location = new System.Drawing.Point(3, 12);
            this.MealLabel.Name = "MealLabel";
            this.MealLabel.Size = new System.Drawing.Size(115, 25);
            this.MealLabel.TabIndex = 2;
            this.MealLabel.Text = "Meal Plans:";
            // 
            // SevenRadioButton
            // 
            this.SevenRadioButton.AutoSize = true;
            this.SevenRadioButton.Location = new System.Drawing.Point(117, 41);
            this.SevenRadioButton.Name = "SevenRadioButton";
            this.SevenRadioButton.Size = new System.Drawing.Size(250, 20);
            this.SevenRadioButton.TabIndex = 3;
            this.SevenRadioButton.TabStop = true;
            this.SevenRadioButton.Text = "7 meals per week- $600 per semester";
            this.SevenRadioButton.UseVisualStyleBackColor = true;
            this.SevenRadioButton.CheckedChanged += new System.EventHandler(this.SevenRadioButton_CheckedChanged);
            // 
            // FourteenRadioButton
            // 
            this.FourteenRadioButton.AutoSize = true;
            this.FourteenRadioButton.Location = new System.Drawing.Point(117, 67);
            this.FourteenRadioButton.Name = "FourteenRadioButton";
            this.FourteenRadioButton.Size = new System.Drawing.Size(270, 20);
            this.FourteenRadioButton.TabIndex = 3;
            this.FourteenRadioButton.TabStop = true;
            this.FourteenRadioButton.Text = "14 meals per week - $1,200 per semester";
            this.FourteenRadioButton.UseVisualStyleBackColor = true;
            this.FourteenRadioButton.CheckedChanged += new System.EventHandler(this.FourteenRadioButton_CheckedChanged);
            // 
            // UnlimitedRadioButton
            // 
            this.UnlimitedRadioButton.AutoSize = true;
            this.UnlimitedRadioButton.Location = new System.Drawing.Point(117, 93);
            this.UnlimitedRadioButton.Name = "UnlimitedRadioButton";
            this.UnlimitedRadioButton.Size = new System.Drawing.Size(251, 20);
            this.UnlimitedRadioButton.TabIndex = 3;
            this.UnlimitedRadioButton.TabStop = true;
            this.UnlimitedRadioButton.Text = "Unlimited meals- $1,700 per semester";
            this.UnlimitedRadioButton.UseVisualStyleBackColor = true;
            this.UnlimitedRadioButton.CheckedChanged += new System.EventHandler(this.UnlimitedRadioButton_CheckedChanged);
            // 
            // DormPanel
            // 
            this.DormPanel.Controls.Add(this.DormitoriesLabel);
            this.DormPanel.Controls.Add(this.AllenRadioButton);
            this.DormPanel.Controls.Add(this.PikeRadioButton);
            this.DormPanel.Controls.Add(this.FarthingRadioButton);
            this.DormPanel.Controls.Add(this.UnivRadioButton);
            this.DormPanel.Location = new System.Drawing.Point(12, 22);
            this.DormPanel.Name = "DormPanel";
            this.DormPanel.Size = new System.Drawing.Size(386, 182);
            this.DormPanel.TabIndex = 4;
            // 
            // MealPanel
            // 
            this.MealPanel.Controls.Add(this.MealLabel);
            this.MealPanel.Controls.Add(this.SevenRadioButton);
            this.MealPanel.Controls.Add(this.UnlimitedRadioButton);
            this.MealPanel.Controls.Add(this.FourteenRadioButton);
            this.MealPanel.Location = new System.Drawing.Point(411, 22);
            this.MealPanel.Name = "MealPanel";
            this.MealPanel.Size = new System.Drawing.Size(400, 182);
            this.MealPanel.TabIndex = 5;
            // 
            // Calculatebutton
            // 
            this.Calculatebutton.Location = new System.Drawing.Point(12, 210);
            this.Calculatebutton.Name = "Calculatebutton";
            this.Calculatebutton.Size = new System.Drawing.Size(144, 46);
            this.Calculatebutton.TabIndex = 6;
            this.Calculatebutton.Text = "Calculate Total";
            this.Calculatebutton.UseVisualStyleBackColor = true;
            this.Calculatebutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // TotalPanel
            // 
            this.TotalPanel.Location = new System.Drawing.Point(163, 211);
            this.TotalPanel.Name = "TotalPanel";
            this.TotalPanel.Size = new System.Drawing.Size(390, 45);
            this.TotalPanel.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 283);
            this.Controls.Add(this.TotalPanel);
            this.Controls.Add(this.Calculatebutton);
            this.Controls.Add(this.MealPanel);
            this.Controls.Add(this.DormPanel);
            this.Name = "MainForm";
            this.Text = "Dorm and Meal Plan Calculator";
            this.DormPanel.ResumeLayout(false);
            this.DormPanel.PerformLayout();
            this.MealPanel.ResumeLayout(false);
            this.MealPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label DormitoriesLabel;
        private System.Windows.Forms.RadioButton AllenRadioButton;
        private System.Windows.Forms.RadioButton PikeRadioButton;
        private System.Windows.Forms.RadioButton FarthingRadioButton;
        private System.Windows.Forms.RadioButton UnivRadioButton;
        private System.Windows.Forms.Label MealLabel;
        private System.Windows.Forms.RadioButton SevenRadioButton;
        private System.Windows.Forms.RadioButton FourteenRadioButton;
        private System.Windows.Forms.RadioButton UnlimitedRadioButton;
        private System.Windows.Forms.Panel DormPanel;
        private System.Windows.Forms.Panel MealPanel;
        private System.Windows.Forms.Button Calculatebutton;
        private System.Windows.Forms.Panel TotalPanel;
    }
}

