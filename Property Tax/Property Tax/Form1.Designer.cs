namespace Property_Tax
{
    partial class property_tax_form
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
            this.property_value_label = new System.Windows.Forms.Label();
            this.value_box = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.Label();
            this.total_box = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // property_value_label
            // 
            this.property_value_label.AutoSize = true;
            this.property_value_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.property_value_label.Location = new System.Drawing.Point(42, 83);
            this.property_value_label.Name = "property_value_label";
            this.property_value_label.Size = new System.Drawing.Size(340, 20);
            this.property_value_label.TabIndex = 0;
            this.property_value_label.Text = "Enter The Price Value Of The Property:";
            // 
            // value_box
            // 
            this.value_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.value_box.Location = new System.Drawing.Point(436, 81);
            this.value_box.Name = "value_box";
            this.value_box.Size = new System.Drawing.Size(157, 24);
            this.value_box.TabIndex = 1;
            this.value_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_label.Location = new System.Drawing.Point(159, 201);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(223, 20);
            this.total_label.TabIndex = 2;
            this.total_label.Text = "Total Property Sales Tax:";
            // 
            // total_box
            // 
            this.total_box.BackColor = System.Drawing.SystemColors.Menu;
            this.total_box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_box.Location = new System.Drawing.Point(417, 199);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(157, 24);
            this.total_box.TabIndex = 3;
            this.total_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_button
            // 
            this.calculate_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_button.Location = new System.Drawing.Point(57, 312);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(104, 28);
            this.calculate_button.TabIndex = 4;
            this.calculate_button.Text = "Calculate";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_button.Location = new System.Drawing.Point(245, 312);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(104, 28);
            this.clear_button.TabIndex = 5;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(436, 312);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(104, 28);
            this.exit_button.TabIndex = 6;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // property_tax_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(629, 450);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.total_box);
            this.Controls.Add(this.total_label);
            this.Controls.Add(this.value_box);
            this.Controls.Add(this.property_value_label);
            this.Name = "property_tax_form";
            this.Text = "Property Tax";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label property_value_label;
        private System.Windows.Forms.TextBox value_box;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
    }
}

