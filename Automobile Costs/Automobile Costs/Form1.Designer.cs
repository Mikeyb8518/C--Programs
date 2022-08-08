namespace Automobile_Costs
{
    partial class automobile_Cost_Form
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
            this.loan_payment_Label = new System.Windows.Forms.Label();
            this.insurance_Label = new System.Windows.Forms.Label();
            this.gas_Label = new System.Windows.Forms.Label();
            this.oil_Label = new System.Windows.Forms.Label();
            this.tires_Label = new System.Windows.Forms.Label();
            this.maintenance_Label = new System.Windows.Forms.Label();
            this.total_Label = new System.Windows.Forms.Label();
            this.loan_Box = new System.Windows.Forms.TextBox();
            this.insurance_Box = new System.Windows.Forms.TextBox();
            this.gas_Box = new System.Windows.Forms.TextBox();
            this.oil_Box = new System.Windows.Forms.TextBox();
            this.tire_Box = new System.Windows.Forms.TextBox();
            this.maintenance_Box = new System.Windows.Forms.TextBox();
            this.total_Box = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.enter_Cost_Label = new System.Windows.Forms.Label();
            this.clear_Button = new System.Windows.Forms.Button();
            this.Exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loan_payment_Label
            // 
            this.loan_payment_Label.AutoSize = true;
            this.loan_payment_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loan_payment_Label.Location = new System.Drawing.Point(34, 81);
            this.loan_payment_Label.Name = "loan_payment_Label";
            this.loan_payment_Label.Size = new System.Drawing.Size(134, 20);
            this.loan_payment_Label.TabIndex = 0;
            this.loan_payment_Label.Text = "Loan Payment:";
            // 
            // insurance_Label
            // 
            this.insurance_Label.AutoSize = true;
            this.insurance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insurance_Label.Location = new System.Drawing.Point(34, 157);
            this.insurance_Label.Name = "insurance_Label";
            this.insurance_Label.Size = new System.Drawing.Size(142, 20);
            this.insurance_Label.TabIndex = 1;
            this.insurance_Label.Text = "Insurance Cost:";
            // 
            // gas_Label
            // 
            this.gas_Label.AutoSize = true;
            this.gas_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gas_Label.Location = new System.Drawing.Point(74, 228);
            this.gas_Label.Name = "gas_Label";
            this.gas_Label.Size = new System.Drawing.Size(94, 20);
            this.gas_Label.TabIndex = 2;
            this.gas_Label.Text = "Gas Cost:";
            // 
            // oil_Label
            // 
            this.oil_Label.AutoSize = true;
            this.oil_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oil_Label.Location = new System.Drawing.Point(416, 81);
            this.oil_Label.Name = "oil_Label";
            this.oil_Label.Size = new System.Drawing.Size(84, 20);
            this.oil_Label.TabIndex = 3;
            this.oil_Label.Text = "Oil Cost:";
            // 
            // tires_Label
            // 
            this.tires_Label.AutoSize = true;
            this.tires_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tires_Label.Location = new System.Drawing.Point(416, 157);
            this.tires_Label.Name = "tires_Label";
            this.tires_Label.Size = new System.Drawing.Size(93, 20);
            this.tires_Label.TabIndex = 4;
            this.tires_Label.Text = "Tire Cost:";
            // 
            // maintenance_Label
            // 
            this.maintenance_Label.AutoSize = true;
            this.maintenance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maintenance_Label.Location = new System.Drawing.Point(343, 228);
            this.maintenance_Label.Name = "maintenance_Label";
            this.maintenance_Label.Size = new System.Drawing.Size(166, 20);
            this.maintenance_Label.TabIndex = 5;
            this.maintenance_Label.Text = "Maintenance Cost:";
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(254, 300);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(57, 20);
            this.total_Label.TabIndex = 6;
            this.total_Label.Text = "Total:";
            // 
            // loan_Box
            // 
            this.loan_Box.Location = new System.Drawing.Point(203, 81);
            this.loan_Box.Multiline = true;
            this.loan_Box.Name = "loan_Box";
            this.loan_Box.Size = new System.Drawing.Size(123, 22);
            this.loan_Box.TabIndex = 1;
            this.loan_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // insurance_Box
            // 
            this.insurance_Box.Location = new System.Drawing.Point(203, 157);
            this.insurance_Box.Multiline = true;
            this.insurance_Box.Name = "insurance_Box";
            this.insurance_Box.Size = new System.Drawing.Size(123, 22);
            this.insurance_Box.TabIndex = 2;
            this.insurance_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gas_Box
            // 
            this.gas_Box.Location = new System.Drawing.Point(203, 228);
            this.gas_Box.Multiline = true;
            this.gas_Box.Name = "gas_Box";
            this.gas_Box.Size = new System.Drawing.Size(123, 22);
            this.gas_Box.TabIndex = 3;
            this.gas_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // oil_Box
            // 
            this.oil_Box.Location = new System.Drawing.Point(534, 81);
            this.oil_Box.Multiline = true;
            this.oil_Box.Name = "oil_Box";
            this.oil_Box.Size = new System.Drawing.Size(123, 22);
            this.oil_Box.TabIndex = 4;
            this.oil_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tire_Box
            // 
            this.tire_Box.Location = new System.Drawing.Point(534, 157);
            this.tire_Box.Multiline = true;
            this.tire_Box.Name = "tire_Box";
            this.tire_Box.Size = new System.Drawing.Size(123, 22);
            this.tire_Box.TabIndex = 5;
            this.tire_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // maintenance_Box
            // 
            this.maintenance_Box.Location = new System.Drawing.Point(534, 228);
            this.maintenance_Box.Multiline = true;
            this.maintenance_Box.Name = "maintenance_Box";
            this.maintenance_Box.Size = new System.Drawing.Size(123, 22);
            this.maintenance_Box.TabIndex = 6;
            this.maintenance_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Box
            // 
            this.total_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Box.Location = new System.Drawing.Point(334, 300);
            this.total_Box.Multiline = true;
            this.total_Box.Name = "total_Box";
            this.total_Box.Size = new System.Drawing.Size(123, 22);
            this.total_Box.TabIndex = 13;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(139, 373);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(104, 31);
            this.calculate_Button.TabIndex = 7;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // enter_Cost_Label
            // 
            this.enter_Cost_Label.AutoSize = true;
            this.enter_Cost_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_Cost_Label.Location = new System.Drawing.Point(31, 24);
            this.enter_Cost_Label.Name = "enter_Cost_Label";
            this.enter_Cost_Label.Size = new System.Drawing.Size(295, 16);
            this.enter_Cost_Label.TabIndex = 15;
            this.enter_Cost_Label.Text = "Enter Monthly Expenses For Your Vehicle:";
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(304, 373);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(99, 31);
            this.clear_Button.TabIndex = 8;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // Exit_Button
            // 
            this.Exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Button.Location = new System.Drawing.Point(458, 373);
            this.Exit_Button.Name = "Exit_Button";
            this.Exit_Button.Size = new System.Drawing.Size(99, 31);
            this.Exit_Button.TabIndex = 9;
            this.Exit_Button.Text = "Exit";
            this.Exit_Button.UseVisualStyleBackColor = true;
            this.Exit_Button.Click += new System.EventHandler(this.Exit_Button_Click);
            // 
            // automobile_Cost_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 450);
            this.Controls.Add(this.Exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.enter_Cost_Label);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_Box);
            this.Controls.Add(this.maintenance_Box);
            this.Controls.Add(this.tire_Box);
            this.Controls.Add(this.oil_Box);
            this.Controls.Add(this.gas_Box);
            this.Controls.Add(this.insurance_Box);
            this.Controls.Add(this.loan_Box);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.maintenance_Label);
            this.Controls.Add(this.tires_Label);
            this.Controls.Add(this.oil_Label);
            this.Controls.Add(this.gas_Label);
            this.Controls.Add(this.insurance_Label);
            this.Controls.Add(this.loan_payment_Label);
            this.Name = "automobile_Cost_Form";
            this.Text = "Automobile Costs";
            this.Load += new System.EventHandler(this.automobile_Cost_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loan_payment_Label;
        private System.Windows.Forms.Label insurance_Label;
        private System.Windows.Forms.Label gas_Label;
        private System.Windows.Forms.Label oil_Label;
        private System.Windows.Forms.Label tires_Label;
        private System.Windows.Forms.Label maintenance_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox loan_Box;
        private System.Windows.Forms.TextBox insurance_Box;
        private System.Windows.Forms.TextBox gas_Box;
        private System.Windows.Forms.TextBox oil_Box;
        private System.Windows.Forms.TextBox tire_Box;
        private System.Windows.Forms.TextBox maintenance_Box;
        private System.Windows.Forms.TextBox total_Box;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Label enter_Cost_Label;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button Exit_Button;
    }
}

