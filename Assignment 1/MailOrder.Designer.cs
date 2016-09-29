namespace Assignment_1
{
    partial class SalesBonus
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SalesBonus));
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.TotalHoursLabel = new System.Windows.Forms.Label();
            this.TotalMonthlySalesLabel = new System.Windows.Forms.Label();
            this.EmployeeNameTextbox = new System.Windows.Forms.TextBox();
            this.EmployeeIDTextbox = new System.Windows.Forms.TextBox();
            this.TotalHoursTextbox = new System.Windows.Forms.TextBox();
            this.TotalMonthlySalesTextbox = new System.Windows.Forms.TextBox();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.SalesBonusTextbox = new System.Windows.Forms.TextBox();
            this.CalculateButton = new System.Windows.Forms.Button();
            this.NextButton = new System.Windows.Forms.Button();
            this.PrintButton = new System.Windows.Forms.Button();
            this.LanguagesGroupBox = new System.Windows.Forms.GroupBox();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.LanguagesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Location = new System.Drawing.Point(12, 230);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(232, 32);
            this.EmployeeNameLabel.TabIndex = 0;
            this.EmployeeNameLabel.Text = "Employee Name:";
            this.EmployeeNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Location = new System.Drawing.Point(12, 286);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(184, 32);
            this.EmployeeIDLabel.TabIndex = 1;
            this.EmployeeIDLabel.Text = "Employee ID:";
            // 
            // TotalHoursLabel
            // 
            this.TotalHoursLabel.AutoSize = true;
            this.TotalHoursLabel.Location = new System.Drawing.Point(12, 342);
            this.TotalHoursLabel.Name = "TotalHoursLabel";
            this.TotalHoursLabel.Size = new System.Drawing.Size(169, 32);
            this.TotalHoursLabel.TabIndex = 2;
            this.TotalHoursLabel.Text = "Total Hours:";
            this.TotalHoursLabel.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TotalMonthlySalesLabel
            // 
            this.TotalMonthlySalesLabel.AutoSize = true;
            this.TotalMonthlySalesLabel.Location = new System.Drawing.Point(12, 398);
            this.TotalMonthlySalesLabel.Name = "TotalMonthlySalesLabel";
            this.TotalMonthlySalesLabel.Size = new System.Drawing.Size(273, 32);
            this.TotalMonthlySalesLabel.TabIndex = 3;
            this.TotalMonthlySalesLabel.Text = "Total Monthly Sales:";
            // 
            // EmployeeNameTextbox
            // 
            this.EmployeeNameTextbox.Location = new System.Drawing.Point(318, 227);
            this.EmployeeNameTextbox.Name = "EmployeeNameTextbox";
            this.EmployeeNameTextbox.Size = new System.Drawing.Size(287, 38);
            this.EmployeeNameTextbox.TabIndex = 4;
            // 
            // EmployeeIDTextbox
            // 
            this.EmployeeIDTextbox.Location = new System.Drawing.Point(318, 283);
            this.EmployeeIDTextbox.Name = "EmployeeIDTextbox";
            this.EmployeeIDTextbox.Size = new System.Drawing.Size(287, 38);
            this.EmployeeIDTextbox.TabIndex = 5;
            // 
            // TotalHoursTextbox
            // 
            this.TotalHoursTextbox.Location = new System.Drawing.Point(318, 339);
            this.TotalHoursTextbox.Name = "TotalHoursTextbox";
            this.TotalHoursTextbox.Size = new System.Drawing.Size(287, 38);
            this.TotalHoursTextbox.TabIndex = 6;
            // 
            // TotalMonthlySalesTextbox
            // 
            this.TotalMonthlySalesTextbox.Location = new System.Drawing.Point(318, 395);
            this.TotalMonthlySalesTextbox.Name = "TotalMonthlySalesTextbox";
            this.TotalMonthlySalesTextbox.Size = new System.Drawing.Size(287, 38);
            this.TotalMonthlySalesTextbox.TabIndex = 7;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Location = new System.Drawing.Point(12, 454);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(183, 32);
            this.SalesBonusLabel.TabIndex = 8;
            this.SalesBonusLabel.Text = "Sales Bonus:";
            // 
            // SalesBonusTextbox
            // 
            this.SalesBonusTextbox.Location = new System.Drawing.Point(318, 451);
            this.SalesBonusTextbox.Name = "SalesBonusTextbox";
            this.SalesBonusTextbox.ReadOnly = true;
            this.SalesBonusTextbox.Size = new System.Drawing.Size(287, 38);
            this.SalesBonusTextbox.TabIndex = 9;
            // 
            // CalculateButton
            // 
            this.CalculateButton.Location = new System.Drawing.Point(46, 551);
            this.CalculateButton.Name = "CalculateButton";
            this.CalculateButton.Size = new System.Drawing.Size(170, 50);
            this.CalculateButton.TabIndex = 10;
            this.CalculateButton.Text = "Calculate";
            this.CalculateButton.UseVisualStyleBackColor = true;
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(306, 550);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(100, 51);
            this.NextButton.TabIndex = 11;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            // 
            // PrintButton
            // 
            this.PrintButton.Location = new System.Drawing.Point(505, 550);
            this.PrintButton.Name = "PrintButton";
            this.PrintButton.Size = new System.Drawing.Size(100, 51);
            this.PrintButton.TabIndex = 12;
            this.PrintButton.Text = "Print";
            this.PrintButton.UseVisualStyleBackColor = true;
            // 
            // LanguagesGroupBox
            // 
            this.LanguagesGroupBox.Controls.Add(this.FrenchRadioButton);
            this.LanguagesGroupBox.Controls.Add(this.EnglishRadioButton);
            this.LanguagesGroupBox.Location = new System.Drawing.Point(318, 12);
            this.LanguagesGroupBox.Name = "LanguagesGroupBox";
            this.LanguagesGroupBox.Size = new System.Drawing.Size(287, 185);
            this.LanguagesGroupBox.TabIndex = 13;
            this.LanguagesGroupBox.TabStop = false;
            this.LanguagesGroupBox.Text = "Languages";
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(20, 117);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(140, 36);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.Text = "French";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(20, 52);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(147, 36);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(33, 43);
            this.LogoPictureBox.MaximumSize = new System.Drawing.Size(239, 143);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(239, 122);
            this.LogoPictureBox.TabIndex = 14;
            this.LogoPictureBox.TabStop = false;
            // 
            // SalesBonus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 613);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.LanguagesGroupBox);
            this.Controls.Add(this.PrintButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.CalculateButton);
            this.Controls.Add(this.SalesBonusTextbox);
            this.Controls.Add(this.SalesBonusLabel);
            this.Controls.Add(this.TotalMonthlySalesTextbox);
            this.Controls.Add(this.TotalHoursTextbox);
            this.Controls.Add(this.EmployeeIDTextbox);
            this.Controls.Add(this.EmployeeNameTextbox);
            this.Controls.Add(this.TotalMonthlySalesLabel);
            this.Controls.Add(this.TotalHoursLabel);
            this.Controls.Add(this.EmployeeIDLabel);
            this.Controls.Add(this.EmployeeNameLabel);
            this.Name = "SalesBonus";
            this.Text = "Sales Bonus Calculator";
            this.LanguagesGroupBox.ResumeLayout(false);
            this.LanguagesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label TotalHoursLabel;
        private System.Windows.Forms.Label TotalMonthlySalesLabel;
        private System.Windows.Forms.TextBox EmployeeNameTextbox;
        private System.Windows.Forms.TextBox EmployeeIDTextbox;
        private System.Windows.Forms.TextBox TotalHoursTextbox;
        private System.Windows.Forms.TextBox TotalMonthlySalesTextbox;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.TextBox SalesBonusTextbox;
        private System.Windows.Forms.Button CalculateButton;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button PrintButton;
        private System.Windows.Forms.GroupBox LanguagesGroupBox;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.PictureBox LogoPictureBox;
    }
}

