namespace Joe_s_Automotive
{
    partial class automotive_Form
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
            this.oil_lube_Groupbox = new System.Windows.Forms.GroupBox();
            this.lube_Checkbox = new System.Windows.Forms.CheckBox();
            this.oil_Checkbox = new System.Windows.Forms.CheckBox();
            this.flush_Groupbox = new System.Windows.Forms.GroupBox();
            this.transFlush_Checkbox = new System.Windows.Forms.CheckBox();
            this.radiatorFlush_Checkbox = new System.Windows.Forms.CheckBox();
            this.misc_Groupbox = new System.Windows.Forms.GroupBox();
            this.tireRotation_Checkbox = new System.Windows.Forms.CheckBox();
            this.muffler_Checkbox = new System.Windows.Forms.CheckBox();
            this.inspection_Checkbox = new System.Windows.Forms.CheckBox();
            this.parts_Labor_Groupbox = new System.Windows.Forms.GroupBox();
            this.labor_Textbox = new System.Windows.Forms.TextBox();
            this.parts_Textbox = new System.Windows.Forms.TextBox();
            this.labor_Label = new System.Windows.Forms.Label();
            this.parts_Label = new System.Windows.Forms.Label();
            this.summary_Groupbox = new System.Windows.Forms.GroupBox();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.tax_Textbox = new System.Windows.Forms.TextBox();
            this.tax_Label = new System.Windows.Forms.Label();
            this.partTotal_Textbox = new System.Windows.Forms.TextBox();
            this.sumParts_Label = new System.Windows.Forms.Label();
            this.service_labor_Textbox = new System.Windows.Forms.TextBox();
            this.service_labor_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.oil_lube_Groupbox.SuspendLayout();
            this.flush_Groupbox.SuspendLayout();
            this.misc_Groupbox.SuspendLayout();
            this.parts_Labor_Groupbox.SuspendLayout();
            this.summary_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oil_lube_Groupbox
            // 
            this.oil_lube_Groupbox.Controls.Add(this.lube_Checkbox);
            this.oil_lube_Groupbox.Controls.Add(this.oil_Checkbox);
            this.oil_lube_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oil_lube_Groupbox.Location = new System.Drawing.Point(24, 18);
            this.oil_lube_Groupbox.Name = "oil_lube_Groupbox";
            this.oil_lube_Groupbox.Size = new System.Drawing.Size(238, 103);
            this.oil_lube_Groupbox.TabIndex = 0;
            this.oil_lube_Groupbox.TabStop = false;
            this.oil_lube_Groupbox.Text = "Oil and Lube";
            // 
            // lube_Checkbox
            // 
            this.lube_Checkbox.AutoSize = true;
            this.lube_Checkbox.Location = new System.Drawing.Point(6, 60);
            this.lube_Checkbox.Name = "lube_Checkbox";
            this.lube_Checkbox.Size = new System.Drawing.Size(149, 22);
            this.lube_Checkbox.TabIndex = 2;
            this.lube_Checkbox.Text = "Lube Job ($18.00)";
            this.lube_Checkbox.UseVisualStyleBackColor = true;
            // 
            // oil_Checkbox
            // 
            this.oil_Checkbox.AutoSize = true;
            this.oil_Checkbox.Location = new System.Drawing.Point(6, 32);
            this.oil_Checkbox.Name = "oil_Checkbox";
            this.oil_Checkbox.Size = new System.Drawing.Size(161, 22);
            this.oil_Checkbox.TabIndex = 1;
            this.oil_Checkbox.Text = "Oil Change ($26.00)";
            this.oil_Checkbox.UseVisualStyleBackColor = true;
            // 
            // flush_Groupbox
            // 
            this.flush_Groupbox.Controls.Add(this.transFlush_Checkbox);
            this.flush_Groupbox.Controls.Add(this.radiatorFlush_Checkbox);
            this.flush_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.flush_Groupbox.Location = new System.Drawing.Point(280, 18);
            this.flush_Groupbox.Name = "flush_Groupbox";
            this.flush_Groupbox.Size = new System.Drawing.Size(238, 103);
            this.flush_Groupbox.TabIndex = 1;
            this.flush_Groupbox.TabStop = false;
            this.flush_Groupbox.Text = "Flushes";
            // 
            // transFlush_Checkbox
            // 
            this.transFlush_Checkbox.AutoSize = true;
            this.transFlush_Checkbox.Location = new System.Drawing.Point(6, 60);
            this.transFlush_Checkbox.Name = "transFlush_Checkbox";
            this.transFlush_Checkbox.Size = new System.Drawing.Size(218, 22);
            this.transFlush_Checkbox.TabIndex = 2;
            this.transFlush_Checkbox.Text = "Transmission Flush ($80.00)";
            this.transFlush_Checkbox.UseVisualStyleBackColor = true;
            // 
            // radiatorFlush_Checkbox
            // 
            this.radiatorFlush_Checkbox.AutoSize = true;
            this.radiatorFlush_Checkbox.Location = new System.Drawing.Point(6, 32);
            this.radiatorFlush_Checkbox.Name = "radiatorFlush_Checkbox";
            this.radiatorFlush_Checkbox.Size = new System.Drawing.Size(184, 22);
            this.radiatorFlush_Checkbox.TabIndex = 1;
            this.radiatorFlush_Checkbox.Text = "Radiator Flush ($30.00)";
            this.radiatorFlush_Checkbox.UseVisualStyleBackColor = true;
            // 
            // misc_Groupbox
            // 
            this.misc_Groupbox.Controls.Add(this.tireRotation_Checkbox);
            this.misc_Groupbox.Controls.Add(this.muffler_Checkbox);
            this.misc_Groupbox.Controls.Add(this.inspection_Checkbox);
            this.misc_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.misc_Groupbox.Location = new System.Drawing.Point(24, 136);
            this.misc_Groupbox.Name = "misc_Groupbox";
            this.misc_Groupbox.Size = new System.Drawing.Size(238, 127);
            this.misc_Groupbox.TabIndex = 2;
            this.misc_Groupbox.TabStop = false;
            this.misc_Groupbox.Text = "Misc";
            // 
            // tireRotation_Checkbox
            // 
            this.tireRotation_Checkbox.AutoSize = true;
            this.tireRotation_Checkbox.Location = new System.Drawing.Point(6, 88);
            this.tireRotation_Checkbox.Name = "tireRotation_Checkbox";
            this.tireRotation_Checkbox.Size = new System.Drawing.Size(173, 22);
            this.tireRotation_Checkbox.TabIndex = 3;
            this.tireRotation_Checkbox.Text = "Tire Rotation ($20.00)";
            this.tireRotation_Checkbox.UseVisualStyleBackColor = true;
            // 
            // muffler_Checkbox
            // 
            this.muffler_Checkbox.AutoSize = true;
            this.muffler_Checkbox.Location = new System.Drawing.Point(6, 60);
            this.muffler_Checkbox.Name = "muffler_Checkbox";
            this.muffler_Checkbox.Size = new System.Drawing.Size(199, 22);
            this.muffler_Checkbox.TabIndex = 2;
            this.muffler_Checkbox.Text = "Replace Muffler ($100.00)";
            this.muffler_Checkbox.UseVisualStyleBackColor = true;
            // 
            // inspection_Checkbox
            // 
            this.inspection_Checkbox.AutoSize = true;
            this.inspection_Checkbox.Location = new System.Drawing.Point(6, 32);
            this.inspection_Checkbox.Name = "inspection_Checkbox";
            this.inspection_Checkbox.Size = new System.Drawing.Size(155, 22);
            this.inspection_Checkbox.TabIndex = 1;
            this.inspection_Checkbox.Text = "Inspection ($15.00)";
            this.inspection_Checkbox.UseVisualStyleBackColor = true;
            // 
            // parts_Labor_Groupbox
            // 
            this.parts_Labor_Groupbox.Controls.Add(this.labor_Textbox);
            this.parts_Labor_Groupbox.Controls.Add(this.parts_Textbox);
            this.parts_Labor_Groupbox.Controls.Add(this.labor_Label);
            this.parts_Labor_Groupbox.Controls.Add(this.parts_Label);
            this.parts_Labor_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parts_Labor_Groupbox.Location = new System.Drawing.Point(280, 136);
            this.parts_Labor_Groupbox.Name = "parts_Labor_Groupbox";
            this.parts_Labor_Groupbox.Size = new System.Drawing.Size(238, 127);
            this.parts_Labor_Groupbox.TabIndex = 3;
            this.parts_Labor_Groupbox.TabStop = false;
            this.parts_Labor_Groupbox.Text = "Parts and Labor";
            // 
            // labor_Textbox
            // 
            this.labor_Textbox.Location = new System.Drawing.Point(113, 73);
            this.labor_Textbox.Name = "labor_Textbox";
            this.labor_Textbox.Size = new System.Drawing.Size(72, 24);
            this.labor_Textbox.TabIndex = 5;
            this.labor_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // parts_Textbox
            // 
            this.parts_Textbox.Location = new System.Drawing.Point(99, 36);
            this.parts_Textbox.Name = "parts_Textbox";
            this.parts_Textbox.Size = new System.Drawing.Size(72, 24);
            this.parts_Textbox.TabIndex = 4;
            this.parts_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // labor_Label
            // 
            this.labor_Label.AutoSize = true;
            this.labor_Label.Location = new System.Drawing.Point(39, 73);
            this.labor_Label.Name = "labor_Label";
            this.labor_Label.Size = new System.Drawing.Size(68, 18);
            this.labor_Label.TabIndex = 1;
            this.labor_Label.Text = "Labor ($)";
            // 
            // parts_Label
            // 
            this.parts_Label.AutoSize = true;
            this.parts_Label.Location = new System.Drawing.Point(28, 39);
            this.parts_Label.Name = "parts_Label";
            this.parts_Label.Size = new System.Drawing.Size(65, 18);
            this.parts_Label.TabIndex = 0;
            this.parts_Label.Text = "Parts ($)";
            // 
            // summary_Groupbox
            // 
            this.summary_Groupbox.Controls.Add(this.total_Textbox);
            this.summary_Groupbox.Controls.Add(this.total_Label);
            this.summary_Groupbox.Controls.Add(this.tax_Textbox);
            this.summary_Groupbox.Controls.Add(this.tax_Label);
            this.summary_Groupbox.Controls.Add(this.partTotal_Textbox);
            this.summary_Groupbox.Controls.Add(this.sumParts_Label);
            this.summary_Groupbox.Controls.Add(this.service_labor_Textbox);
            this.summary_Groupbox.Controls.Add(this.service_labor_Label);
            this.summary_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary_Groupbox.Location = new System.Drawing.Point(24, 281);
            this.summary_Groupbox.Name = "summary_Groupbox";
            this.summary_Groupbox.Size = new System.Drawing.Size(494, 202);
            this.summary_Groupbox.TabIndex = 4;
            this.summary_Groupbox.TabStop = false;
            this.summary_Groupbox.Text = "Summary";
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Textbox.Location = new System.Drawing.Point(177, 155);
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(123, 24);
            this.total_Textbox.TabIndex = 7;
            this.total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Location = new System.Drawing.Point(77, 155);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(78, 18);
            this.total_Label.TabIndex = 6;
            this.total_Label.Text = "Total Fees";
            // 
            // tax_Textbox
            // 
            this.tax_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.tax_Textbox.Location = new System.Drawing.Point(177, 117);
            this.tax_Textbox.Name = "tax_Textbox";
            this.tax_Textbox.Size = new System.Drawing.Size(123, 24);
            this.tax_Textbox.TabIndex = 5;
            this.tax_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tax_Label
            // 
            this.tax_Label.AutoSize = true;
            this.tax_Label.Location = new System.Drawing.Point(55, 117);
            this.tax_Label.Name = "tax_Label";
            this.tax_Label.Size = new System.Drawing.Size(100, 18);
            this.tax_Label.TabIndex = 4;
            this.tax_Label.Text = "Tax (on parts)";
            // 
            // partTotal_Textbox
            // 
            this.partTotal_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.partTotal_Textbox.Location = new System.Drawing.Point(177, 73);
            this.partTotal_Textbox.Name = "partTotal_Textbox";
            this.partTotal_Textbox.Size = new System.Drawing.Size(123, 24);
            this.partTotal_Textbox.TabIndex = 3;
            this.partTotal_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // sumParts_Label
            // 
            this.sumParts_Label.AutoSize = true;
            this.sumParts_Label.Location = new System.Drawing.Point(112, 76);
            this.sumParts_Label.Name = "sumParts_Label";
            this.sumParts_Label.Size = new System.Drawing.Size(43, 18);
            this.sumParts_Label.TabIndex = 2;
            this.sumParts_Label.Text = "Parts";
            // 
            // service_labor_Textbox
            // 
            this.service_labor_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.service_labor_Textbox.Location = new System.Drawing.Point(177, 32);
            this.service_labor_Textbox.Name = "service_labor_Textbox";
            this.service_labor_Textbox.Size = new System.Drawing.Size(123, 24);
            this.service_labor_Textbox.TabIndex = 1;
            this.service_labor_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // service_labor_Label
            // 
            this.service_labor_Label.AutoSize = true;
            this.service_labor_Label.Location = new System.Drawing.Point(33, 32);
            this.service_labor_Label.Name = "service_labor_Label";
            this.service_labor_Label.Size = new System.Drawing.Size(127, 18);
            this.service_labor_Label.TabIndex = 0;
            this.service_labor_Label.Text = "Service and Labor";
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(82, 500);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(102, 28);
            this.calculate_Button.TabIndex = 5;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(215, 500);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(93, 28);
            this.clear_Button.TabIndex = 6;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(343, 500);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(93, 28);
            this.exit_Button.TabIndex = 7;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // automotive_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 540);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.summary_Groupbox);
            this.Controls.Add(this.parts_Labor_Groupbox);
            this.Controls.Add(this.misc_Groupbox);
            this.Controls.Add(this.flush_Groupbox);
            this.Controls.Add(this.oil_lube_Groupbox);
            this.Name = "automotive_Form";
            this.Text = "Joe\'s Automotive";
            this.oil_lube_Groupbox.ResumeLayout(false);
            this.oil_lube_Groupbox.PerformLayout();
            this.flush_Groupbox.ResumeLayout(false);
            this.flush_Groupbox.PerformLayout();
            this.misc_Groupbox.ResumeLayout(false);
            this.misc_Groupbox.PerformLayout();
            this.parts_Labor_Groupbox.ResumeLayout(false);
            this.parts_Labor_Groupbox.PerformLayout();
            this.summary_Groupbox.ResumeLayout(false);
            this.summary_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oil_lube_Groupbox;
        private System.Windows.Forms.CheckBox lube_Checkbox;
        private System.Windows.Forms.CheckBox oil_Checkbox;
        private System.Windows.Forms.GroupBox flush_Groupbox;
        private System.Windows.Forms.CheckBox transFlush_Checkbox;
        private System.Windows.Forms.CheckBox radiatorFlush_Checkbox;
        private System.Windows.Forms.GroupBox misc_Groupbox;
        private System.Windows.Forms.CheckBox tireRotation_Checkbox;
        private System.Windows.Forms.CheckBox muffler_Checkbox;
        private System.Windows.Forms.CheckBox inspection_Checkbox;
        private System.Windows.Forms.GroupBox parts_Labor_Groupbox;
        private System.Windows.Forms.TextBox labor_Textbox;
        private System.Windows.Forms.TextBox parts_Textbox;
        private System.Windows.Forms.Label labor_Label;
        private System.Windows.Forms.Label parts_Label;
        private System.Windows.Forms.GroupBox summary_Groupbox;
        private System.Windows.Forms.TextBox total_Textbox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox tax_Textbox;
        private System.Windows.Forms.Label tax_Label;
        private System.Windows.Forms.TextBox partTotal_Textbox;
        private System.Windows.Forms.Label sumParts_Label;
        private System.Windows.Forms.TextBox service_labor_Textbox;
        private System.Windows.Forms.Label service_labor_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

