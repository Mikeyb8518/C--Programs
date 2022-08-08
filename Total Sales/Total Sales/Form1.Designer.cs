namespace Total_Sales
{
    partial class total_Sales_Form
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
            this.sales_Groupbox = new System.Windows.Forms.GroupBox();
            this.sales_Listbox = new System.Windows.Forms.ListBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.output_Label = new System.Windows.Forms.Label();
            this.sales_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.sales_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // sales_Groupbox
            // 
            this.sales_Groupbox.Controls.Add(this.sales_Listbox);
            this.sales_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_Groupbox.Location = new System.Drawing.Point(16, 16);
            this.sales_Groupbox.Name = "sales_Groupbox";
            this.sales_Groupbox.Size = new System.Drawing.Size(368, 224);
            this.sales_Groupbox.TabIndex = 0;
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
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(114, 260);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 1;
            this.total_Label.Text = "Total:";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(180, 260);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Label.TabIndex = 2;
            this.output_Label.Text = "0";
            this.output_Label.Visible = false;
            // 
            // sales_Button
            // 
            this.sales_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sales_Button.Location = new System.Drawing.Point(82, 305);
            this.sales_Button.Name = "sales_Button";
            this.sales_Button.Size = new System.Drawing.Size(106, 37);
            this.sales_Button.TabIndex = 3;
            this.sales_Button.Text = "Get Sales";
            this.sales_Button.UseVisualStyleBackColor = true;
            this.sales_Button.Click += new System.EventHandler(this.sales_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(208, 305);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(92, 37);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // total_Sales_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(401, 366);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.sales_Button);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.sales_Groupbox);
            this.Name = "total_Sales_Form";
            this.Text = "Total Sales";
            this.sales_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox sales_Groupbox;
        private System.Windows.Forms.ListBox sales_Listbox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Button sales_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

