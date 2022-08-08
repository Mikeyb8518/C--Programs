namespace Sale_Tax_and_Total
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
            this.purchase_Label = new System.Windows.Forms.Label();
            this.purchase_Box = new System.Windows.Forms.TextBox();
            this.saleTax_Label = new System.Windows.Forms.Label();
            this.stateTax_Box = new System.Windows.Forms.TextBox();
            this.countyTax_Label = new System.Windows.Forms.Label();
            this.countyTax_Box = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Box = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // purchase_Label
            // 
            this.purchase_Label.AutoSize = true;
            this.purchase_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.purchase_Label.Location = new System.Drawing.Point(70, 95);
            this.purchase_Label.Name = "purchase_Label";
            this.purchase_Label.Size = new System.Drawing.Size(239, 18);
            this.purchase_Label.TabIndex = 0;
            this.purchase_Label.Text = "Enter the Amount of Purchase:";
            // 
            // purchase_Box
            // 
            this.purchase_Box.Location = new System.Drawing.Point(340, 94);
            this.purchase_Box.Name = "purchase_Box";
            this.purchase_Box.Size = new System.Drawing.Size(107, 22);
            this.purchase_Box.TabIndex = 1;
            this.purchase_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // saleTax_Label
            // 
            this.saleTax_Label.AutoSize = true;
            this.saleTax_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saleTax_Label.Location = new System.Drawing.Point(182, 151);
            this.saleTax_Label.Name = "saleTax_Label";
            this.saleTax_Label.Size = new System.Drawing.Size(127, 18);
            this.saleTax_Label.TabIndex = 2;
            this.saleTax_Label.Text = "After Sales Tax:";
            // 
            // stateTax_Box
            // 
            this.stateTax_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.stateTax_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.stateTax_Box.Location = new System.Drawing.Point(324, 151);
            this.stateTax_Box.Name = "stateTax_Box";
            this.stateTax_Box.Size = new System.Drawing.Size(85, 22);
            this.stateTax_Box.TabIndex = 3;
            this.stateTax_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // countyTax_Label
            // 
            this.countyTax_Label.AutoSize = true;
            this.countyTax_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countyTax_Label.Location = new System.Drawing.Point(171, 210);
            this.countyTax_Label.Name = "countyTax_Label";
            this.countyTax_Label.Size = new System.Drawing.Size(138, 18);
            this.countyTax_Label.TabIndex = 4;
            this.countyTax_Label.Text = "After County Tax:";
            // 
            // countyTax_Box
            // 
            this.countyTax_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.countyTax_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.countyTax_Box.Location = new System.Drawing.Point(324, 210);
            this.countyTax_Box.Name = "countyTax_Box";
            this.countyTax_Box.Size = new System.Drawing.Size(85, 22);
            this.countyTax_Box.TabIndex = 5;
            this.countyTax_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(168, 264);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(141, 18);
            this.total_Label.TabIndex = 6;
            this.total_Label.Text = "Total After Taxes:";
            // 
            // total_Box
            // 
            this.total_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_Box.Location = new System.Drawing.Point(324, 264);
            this.total_Box.Name = "total_Box";
            this.total_Box.Size = new System.Drawing.Size(85, 22);
            this.total_Box.TabIndex = 7;
            this.total_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(100, 334);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(108, 35);
            this.calculate_Button.TabIndex = 8;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(225, 334);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(99, 35);
            this.clear_Button.TabIndex = 9;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(340, 334);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(99, 35);
            this.exit_Button.TabIndex = 10;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 450);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_Box);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.countyTax_Box);
            this.Controls.Add(this.countyTax_Label);
            this.Controls.Add(this.stateTax_Box);
            this.Controls.Add(this.saleTax_Label);
            this.Controls.Add(this.purchase_Box);
            this.Controls.Add(this.purchase_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label purchase_Label;
        private System.Windows.Forms.TextBox purchase_Box;
        private System.Windows.Forms.Label saleTax_Label;
        private System.Windows.Forms.TextBox stateTax_Box;
        private System.Windows.Forms.Label countyTax_Label;
        private System.Windows.Forms.TextBox countyTax_Box;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox total_Box;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

