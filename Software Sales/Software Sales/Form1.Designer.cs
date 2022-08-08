namespace Software_Sales
{
    partial class softwareSales_Form
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
            this.packagesBought_Label = new System.Windows.Forms.Label();
            this.packagesBought_Textbox = new System.Windows.Forms.TextBox();
            this.discount_Label = new System.Windows.Forms.Label();
            this.discount_Textbox = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // packagesBought_Label
            // 
            this.packagesBought_Label.AutoSize = true;
            this.packagesBought_Label.Location = new System.Drawing.Point(13, 46);
            this.packagesBought_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.packagesBought_Label.Name = "packagesBought_Label";
            this.packagesBought_Label.Size = new System.Drawing.Size(329, 18);
            this.packagesBought_Label.TabIndex = 0;
            this.packagesBought_Label.Text = "Enter the Number of Packages Purchased:";
            // 
            // packagesBought_Textbox
            // 
            this.packagesBought_Textbox.Location = new System.Drawing.Point(348, 43);
            this.packagesBought_Textbox.Name = "packagesBought_Textbox";
            this.packagesBought_Textbox.Size = new System.Drawing.Size(110, 24);
            this.packagesBought_Textbox.TabIndex = 1;
            this.packagesBought_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // discount_Label
            // 
            this.discount_Label.AutoSize = true;
            this.discount_Label.Location = new System.Drawing.Point(218, 133);
            this.discount_Label.Name = "discount_Label";
            this.discount_Label.Size = new System.Drawing.Size(124, 18);
            this.discount_Label.TabIndex = 2;
            this.discount_Label.Text = "Discount Price:";
            // 
            // discount_Textbox
            // 
            this.discount_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.discount_Textbox.Location = new System.Drawing.Point(348, 130);
            this.discount_Textbox.Name = "discount_Textbox";
            this.discount_Textbox.Size = new System.Drawing.Size(130, 24);
            this.discount_Textbox.TabIndex = 3;
            this.discount_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Location = new System.Drawing.Point(291, 223);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 4;
            this.total_Label.Text = "Total:";
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Textbox.Location = new System.Drawing.Point(348, 220);
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(119, 24);
            this.total_Textbox.TabIndex = 5;
            this.total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Location = new System.Drawing.Point(96, 302);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(102, 34);
            this.calculate_Button.TabIndex = 6;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Location = new System.Drawing.Point(240, 302);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(102, 34);
            this.clear_Button.TabIndex = 7;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Location = new System.Drawing.Point(388, 302);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(102, 34);
            this.exit_Button.TabIndex = 8;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // softwareSales_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 387);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_Textbox);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.discount_Textbox);
            this.Controls.Add(this.discount_Label);
            this.Controls.Add(this.packagesBought_Textbox);
            this.Controls.Add(this.packagesBought_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "softwareSales_Form";
            this.Text = "Software Sales";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label packagesBought_Label;
        private System.Windows.Forms.TextBox packagesBought_Textbox;
        private System.Windows.Forms.Label discount_Label;
        private System.Windows.Forms.TextBox discount_Textbox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox total_Textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

