namespace How_Much_Insurance
{
    partial class how_much_insurance_Form
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
            this.replacement_Label = new System.Windows.Forms.Label();
            this.replacement_cost_Box = new System.Windows.Forms.TextBox();
            this.insurance_coverage_Label = new System.Windows.Forms.Label();
            this.coverage_Box = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // replacement_Label
            // 
            this.replacement_Label.AutoSize = true;
            this.replacement_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.replacement_Label.Location = new System.Drawing.Point(82, 119);
            this.replacement_Label.Name = "replacement_Label";
            this.replacement_Label.Size = new System.Drawing.Size(309, 18);
            this.replacement_Label.TabIndex = 0;
            this.replacement_Label.Text = "Please Enter The Cost Of Replacement:";
            // 
            // replacement_cost_Box
            // 
            this.replacement_cost_Box.Location = new System.Drawing.Point(428, 118);
            this.replacement_cost_Box.Name = "replacement_cost_Box";
            this.replacement_cost_Box.Size = new System.Drawing.Size(155, 22);
            this.replacement_cost_Box.TabIndex = 1;
            // 
            // insurance_coverage_Label
            // 
            this.insurance_coverage_Label.AutoSize = true;
            this.insurance_coverage_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurance_coverage_Label.Location = new System.Drawing.Point(86, 179);
            this.insurance_coverage_Label.Name = "insurance_coverage_Label";
            this.insurance_coverage_Label.Size = new System.Drawing.Size(305, 18);
            this.insurance_coverage_Label.TabIndex = 2;
            this.insurance_coverage_Label.Text = "How Much Insurance You Should Have:";
            // 
            // coverage_Box
            // 
            this.coverage_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.coverage_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.coverage_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coverage_Box.Location = new System.Drawing.Point(428, 179);
            this.coverage_Box.Name = "coverage_Box";
            this.coverage_Box.Size = new System.Drawing.Size(155, 17);
            this.coverage_Box.TabIndex = 3;
            this.coverage_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(166, 249);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(104, 28);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(297, 249);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(94, 28);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(414, 249);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(94, 28);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // how_much_insurance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 338);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.coverage_Box);
            this.Controls.Add(this.insurance_coverage_Label);
            this.Controls.Add(this.replacement_cost_Box);
            this.Controls.Add(this.replacement_Label);
            this.Name = "how_much_insurance_Form";
            this.Text = "How Much Insurance?";
            this.Load += new System.EventHandler(this.how_much_insurance_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label replacement_Label;
        private System.Windows.Forms.TextBox replacement_cost_Box;
        private System.Windows.Forms.Label insurance_coverage_Label;
        private System.Windows.Forms.TextBox coverage_Box;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

