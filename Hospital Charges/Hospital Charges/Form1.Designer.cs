namespace Hospital_Charges
{
    partial class hospitalCharges_Form
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
            this.hospitalCharges_Groupbox = new System.Windows.Forms.GroupBox();
            this.days_Spent_Label = new System.Windows.Forms.Label();
            this.days_Textbox = new System.Windows.Forms.TextBox();
            this.medication_Label = new System.Windows.Forms.Label();
            this.med_Charges_Textbox = new System.Windows.Forms.TextBox();
            this.surgical_Label = new System.Windows.Forms.Label();
            this.surgical_Charges_Textbox = new System.Windows.Forms.TextBox();
            this.lab_Label = new System.Windows.Forms.Label();
            this.lab_Fee_Textbox = new System.Windows.Forms.TextBox();
            this.phy_Rehab_Label = new System.Windows.Forms.Label();
            this.phy_Rehab_Textbox = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.output_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.hospitalCharges_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // hospitalCharges_Groupbox
            // 
            this.hospitalCharges_Groupbox.Controls.Add(this.phy_Rehab_Textbox);
            this.hospitalCharges_Groupbox.Controls.Add(this.phy_Rehab_Label);
            this.hospitalCharges_Groupbox.Controls.Add(this.lab_Fee_Textbox);
            this.hospitalCharges_Groupbox.Controls.Add(this.lab_Label);
            this.hospitalCharges_Groupbox.Controls.Add(this.surgical_Charges_Textbox);
            this.hospitalCharges_Groupbox.Controls.Add(this.surgical_Label);
            this.hospitalCharges_Groupbox.Controls.Add(this.med_Charges_Textbox);
            this.hospitalCharges_Groupbox.Controls.Add(this.medication_Label);
            this.hospitalCharges_Groupbox.Controls.Add(this.days_Textbox);
            this.hospitalCharges_Groupbox.Controls.Add(this.days_Spent_Label);
            this.hospitalCharges_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hospitalCharges_Groupbox.Location = new System.Drawing.Point(20, 20);
            this.hospitalCharges_Groupbox.Name = "hospitalCharges_Groupbox";
            this.hospitalCharges_Groupbox.Size = new System.Drawing.Size(654, 179);
            this.hospitalCharges_Groupbox.TabIndex = 0;
            this.hospitalCharges_Groupbox.TabStop = false;
            this.hospitalCharges_Groupbox.Text = "Hospital Charges";
            // 
            // days_Spent_Label
            // 
            this.days_Spent_Label.AutoSize = true;
            this.days_Spent_Label.Location = new System.Drawing.Point(6, 41);
            this.days_Spent_Label.Name = "days_Spent_Label";
            this.days_Spent_Label.Size = new System.Drawing.Size(200, 16);
            this.days_Spent_Label.TabIndex = 0;
            this.days_Spent_Label.Text = "Number of Days in Hospital:";
            // 
            // days_Textbox
            // 
            this.days_Textbox.Location = new System.Drawing.Point(226, 38);
            this.days_Textbox.Name = "days_Textbox";
            this.days_Textbox.Size = new System.Drawing.Size(86, 22);
            this.days_Textbox.TabIndex = 1;
            this.days_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // medication_Label
            // 
            this.medication_Label.AutoSize = true;
            this.medication_Label.Location = new System.Drawing.Point(344, 41);
            this.medication_Label.Name = "medication_Label";
            this.medication_Label.Size = new System.Drawing.Size(149, 16);
            this.medication_Label.TabIndex = 2;
            this.medication_Label.Text = "Medication Charges:";
            // 
            // med_Charges_Textbox
            // 
            this.med_Charges_Textbox.Location = new System.Drawing.Point(514, 38);
            this.med_Charges_Textbox.Name = "med_Charges_Textbox";
            this.med_Charges_Textbox.Size = new System.Drawing.Size(86, 22);
            this.med_Charges_Textbox.TabIndex = 2;
            this.med_Charges_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // surgical_Label
            // 
            this.surgical_Label.AutoSize = true;
            this.surgical_Label.Location = new System.Drawing.Point(41, 89);
            this.surgical_Label.Name = "surgical_Label";
            this.surgical_Label.Size = new System.Drawing.Size(130, 16);
            this.surgical_Label.TabIndex = 3;
            this.surgical_Label.Text = "Surgical Charges:";
            // 
            // surgical_Charges_Textbox
            // 
            this.surgical_Charges_Textbox.Location = new System.Drawing.Point(190, 89);
            this.surgical_Charges_Textbox.Name = "surgical_Charges_Textbox";
            this.surgical_Charges_Textbox.Size = new System.Drawing.Size(86, 22);
            this.surgical_Charges_Textbox.TabIndex = 3;
            this.surgical_Charges_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lab_Label
            // 
            this.lab_Label.AutoSize = true;
            this.lab_Label.Location = new System.Drawing.Point(375, 92);
            this.lab_Label.Name = "lab_Label";
            this.lab_Label.Size = new System.Drawing.Size(76, 16);
            this.lab_Label.TabIndex = 4;
            this.lab_Label.Text = "Lab Fees:";
            // 
            // lab_Fee_Textbox
            // 
            this.lab_Fee_Textbox.Location = new System.Drawing.Point(468, 89);
            this.lab_Fee_Textbox.Name = "lab_Fee_Textbox";
            this.lab_Fee_Textbox.Size = new System.Drawing.Size(86, 22);
            this.lab_Fee_Textbox.TabIndex = 4;
            this.lab_Fee_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // phy_Rehab_Label
            // 
            this.phy_Rehab_Label.AutoSize = true;
            this.phy_Rehab_Label.Location = new System.Drawing.Point(159, 133);
            this.phy_Rehab_Label.Name = "phy_Rehab_Label";
            this.phy_Rehab_Label.Size = new System.Drawing.Size(170, 16);
            this.phy_Rehab_Label.TabIndex = 5;
            this.phy_Rehab_Label.Text = "Physical Rehabilitation:";
            // 
            // phy_Rehab_Textbox
            // 
            this.phy_Rehab_Textbox.Location = new System.Drawing.Point(347, 133);
            this.phy_Rehab_Textbox.Name = "phy_Rehab_Textbox";
            this.phy_Rehab_Textbox.Size = new System.Drawing.Size(86, 22);
            this.phy_Rehab_Textbox.TabIndex = 5;
            this.phy_Rehab_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(280, 223);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 1;
            this.total_Label.Text = "Total:";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(347, 223);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Label.TabIndex = 2;
            this.output_Label.Text = "0";
            this.output_Label.Visible = false;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(68, 269);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(123, 30);
            this.calculate_Button.TabIndex = 6;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(283, 269);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(96, 30);
            this.clear_Button.TabIndex = 7;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(488, 269);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(96, 30);
            this.exit_Button.TabIndex = 8;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // hospitalCharges_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 329);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.hospitalCharges_Groupbox);
            this.Name = "hospitalCharges_Form";
            this.Text = "Hospital Charges";
            this.hospitalCharges_Groupbox.ResumeLayout(false);
            this.hospitalCharges_Groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox hospitalCharges_Groupbox;
        private System.Windows.Forms.TextBox med_Charges_Textbox;
        private System.Windows.Forms.Label medication_Label;
        private System.Windows.Forms.TextBox days_Textbox;
        private System.Windows.Forms.Label days_Spent_Label;
        private System.Windows.Forms.Label surgical_Label;
        private System.Windows.Forms.TextBox surgical_Charges_Textbox;
        private System.Windows.Forms.TextBox lab_Fee_Textbox;
        private System.Windows.Forms.Label lab_Label;
        private System.Windows.Forms.TextBox phy_Rehab_Textbox;
        private System.Windows.Forms.Label phy_Rehab_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

