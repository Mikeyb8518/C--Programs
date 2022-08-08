namespace Sales_Analysis
{
    partial class sales_Analysis_Form
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
            this.exit_Button = new System.Windows.Forms.Button();
            this.sales_Button = new System.Windows.Forms.Button();
            this.output_Total_Label = new System.Windows.Forms.Label();
            this.total_Label = new System.Windows.Forms.Label();
            this.sales_Groupbox = new System.Windows.Forms.GroupBox();
            this.sales_Listbox = new System.Windows.Forms.ListBox();
            this.average_Label = new System.Windows.Forms.Label();
            this.output_Average_Label = new System.Windows.Forms.Label();
            this.highest_Sale_Label = new System.Windows.Forms.Label();
            this.output_High_Label = new System.Windows.Forms.Label();
            this.lowest_Sale_Label = new System.Windows.Forms.Label();
            this.output_Lowest_Label = new System.Windows.Forms.Label();
            this.sales_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(342, 275);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(92, 37);
            this.exit_Button.TabIndex = 10;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // sales_Button
            // 
            this.sales_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_Button.Location = new System.Drawing.Point(186, 275);
            this.sales_Button.Name = "sales_Button";
            this.sales_Button.Size = new System.Drawing.Size(106, 37);
            this.sales_Button.TabIndex = 9;
            this.sales_Button.Text = "Get Sales";
            this.sales_Button.UseVisualStyleBackColor = true;
            this.sales_Button.Click += new System.EventHandler(this.sales_Button_Click);
            // 
            // output_Total_Label
            // 
            this.output_Total_Label.AutoSize = true;
            this.output_Total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Total_Label.Location = new System.Drawing.Point(515, 48);
            this.output_Total_Label.Name = "output_Total_Label";
            this.output_Total_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Total_Label.TabIndex = 8;
            this.output_Total_Label.Text = "0";
            this.output_Total_Label.Visible = false;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(429, 48);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 7;
            this.total_Label.Text = "Total:";
            // 
            // sales_Groupbox
            // 
            this.sales_Groupbox.Controls.Add(this.sales_Listbox);
            this.sales_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_Groupbox.Location = new System.Drawing.Point(12, 22);
            this.sales_Groupbox.Name = "sales_Groupbox";
            this.sales_Groupbox.Size = new System.Drawing.Size(368, 224);
            this.sales_Groupbox.TabIndex = 6;
            this.sales_Groupbox.TabStop = false;
            this.sales_Groupbox.Text = "Sales";
            // 
            // sales_Listbox
            // 
            this.sales_Listbox.FormattingEnabled = true;
            this.sales_Listbox.ItemHeight = 16;
            this.sales_Listbox.Location = new System.Drawing.Point(14, 26);
            this.sales_Listbox.Name = "sales_Listbox";
            this.sales_Listbox.Size = new System.Drawing.Size(338, 180);
            this.sales_Listbox.TabIndex = 0;
            // 
            // average_Label
            // 
            this.average_Label.AutoSize = true;
            this.average_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_Label.Location = new System.Drawing.Point(396, 99);
            this.average_Label.Name = "average_Label";
            this.average_Label.Size = new System.Drawing.Size(120, 18);
            this.average_Label.TabIndex = 11;
            this.average_Label.Text = "Sales Average:";
            // 
            // output_Average_Label
            // 
            this.output_Average_Label.AutoSize = true;
            this.output_Average_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Average_Label.Location = new System.Drawing.Point(532, 99);
            this.output_Average_Label.Name = "output_Average_Label";
            this.output_Average_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Average_Label.TabIndex = 12;
            this.output_Average_Label.Text = "0";
            this.output_Average_Label.Visible = false;
            // 
            // highest_Sale_Label
            // 
            this.highest_Sale_Label.AutoSize = true;
            this.highest_Sale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highest_Sale_Label.Location = new System.Drawing.Point(408, 148);
            this.highest_Sale_Label.Name = "highest_Sale_Label";
            this.highest_Sale_Label.Size = new System.Drawing.Size(108, 18);
            this.highest_Sale_Label.TabIndex = 13;
            this.highest_Sale_Label.Text = "Highest Sale:";
            // 
            // output_High_Label
            // 
            this.output_High_Label.AutoSize = true;
            this.output_High_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_High_Label.Location = new System.Drawing.Point(532, 148);
            this.output_High_Label.Name = "output_High_Label";
            this.output_High_Label.Size = new System.Drawing.Size(17, 18);
            this.output_High_Label.TabIndex = 14;
            this.output_High_Label.Text = "0";
            this.output_High_Label.Visible = false;
            // 
            // lowest_Sale_Label
            // 
            this.lowest_Sale_Label.AutoSize = true;
            this.lowest_Sale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowest_Sale_Label.Location = new System.Drawing.Point(408, 198);
            this.lowest_Sale_Label.Name = "lowest_Sale_Label";
            this.lowest_Sale_Label.Size = new System.Drawing.Size(105, 18);
            this.lowest_Sale_Label.TabIndex = 15;
            this.lowest_Sale_Label.Text = "Lowest Sale:";
            // 
            // output_Lowest_Label
            // 
            this.output_Lowest_Label.AutoSize = true;
            this.output_Lowest_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Lowest_Label.Location = new System.Drawing.Point(532, 198);
            this.output_Lowest_Label.Name = "output_Lowest_Label";
            this.output_Lowest_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Lowest_Label.TabIndex = 16;
            this.output_Lowest_Label.Text = "0";
            this.output_Lowest_Label.Visible = false;
            // 
            // sales_Analysis_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 331);
            this.Controls.Add(this.output_Lowest_Label);
            this.Controls.Add(this.lowest_Sale_Label);
            this.Controls.Add(this.output_High_Label);
            this.Controls.Add(this.highest_Sale_Label);
            this.Controls.Add(this.output_Average_Label);
            this.Controls.Add(this.average_Label);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.sales_Button);
            this.Controls.Add(this.output_Total_Label);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.sales_Groupbox);
            this.Name = "sales_Analysis_Form";
            this.Text = "Sales Analysis";
            this.sales_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button sales_Button;
        private System.Windows.Forms.Label output_Total_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.GroupBox sales_Groupbox;
        private System.Windows.Forms.ListBox sales_Listbox;
        private System.Windows.Forms.Label average_Label;
        private System.Windows.Forms.Label output_Average_Label;
        private System.Windows.Forms.Label highest_Sale_Label;
        private System.Windows.Forms.Label output_High_Label;
        private System.Windows.Forms.Label lowest_Sale_Label;
        private System.Windows.Forms.Label output_Lowest_Label;
    }
}

