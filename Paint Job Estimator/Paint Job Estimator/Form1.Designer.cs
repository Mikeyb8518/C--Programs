namespace Paint_Job_Estimator
{
    partial class paint_Job_Form
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
            this.wallspace_Label = new System.Windows.Forms.Label();
            this.wallspace_box = new System.Windows.Forms.TextBox();
            this.paint_Cost_Label = new System.Windows.Forms.Label();
            this.paint_cost_box = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.total_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // wallspace_Label
            // 
            this.wallspace_Label.AutoSize = true;
            this.wallspace_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wallspace_Label.Location = new System.Drawing.Point(40, 56);
            this.wallspace_Label.Name = "wallspace_Label";
            this.wallspace_Label.Size = new System.Drawing.Size(251, 18);
            this.wallspace_Label.TabIndex = 0;
            this.wallspace_Label.Text = "Enter The Amount of Wallspace:";
            // 
            // wallspace_box
            // 
            this.wallspace_box.Location = new System.Drawing.Point(312, 55);
            this.wallspace_box.Name = "wallspace_box";
            this.wallspace_box.Size = new System.Drawing.Size(143, 22);
            this.wallspace_box.TabIndex = 1;
            this.wallspace_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // paint_Cost_Label
            // 
            this.paint_Cost_Label.AutoSize = true;
            this.paint_Cost_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.paint_Cost_Label.Location = new System.Drawing.Point(101, 125);
            this.paint_Cost_Label.Name = "paint_Cost_Label";
            this.paint_Cost_Label.Size = new System.Drawing.Size(190, 18);
            this.paint_Cost_Label.TabIndex = 2;
            this.paint_Cost_Label.Text = "Enter The Cost of Paint:";
            // 
            // paint_cost_box
            // 
            this.paint_cost_box.Location = new System.Drawing.Point(312, 125);
            this.paint_cost_box.Name = "paint_cost_box";
            this.paint_cost_box.Size = new System.Drawing.Size(143, 22);
            this.paint_cost_box.TabIndex = 3;
            this.paint_cost_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.Location = new System.Drawing.Point(104, 356);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(103, 29);
            this.calculate_button.TabIndex = 6;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(266, 356);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(103, 29);
            this.clear_button.TabIndex = 7;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(431, 356);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(103, 29);
            this.exit_button.TabIndex = 8;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(171, 216);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(0, 16);
            this.total_label.TabIndex = 9;
            // 
            // paint_Job_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.paint_cost_box);
            this.Controls.Add(this.paint_Cost_Label);
            this.Controls.Add(this.wallspace_box);
            this.Controls.Add(this.wallspace_Label);
            this.Name = "paint_Job_Form";
            this.Text = "Paint Job Estimator";
            this.Load += new System.EventHandler(this.paint_Job_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wallspace_Label;
        private System.Windows.Forms.TextBox wallspace_box;
        private System.Windows.Forms.Label paint_Cost_Label;
        private System.Windows.Forms.TextBox paint_cost_box;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label total_label;
    }
}

