namespace Pennies_for_Pay_new_
{
    partial class pennies_Form
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
            this.pennies_Groupbox = new System.Windows.Forms.GroupBox();
            this.days_Textbox = new System.Windows.Forms.TextBox();
            this.days_Label = new System.Windows.Forms.Label();
            this.output_Listbox = new System.Windows.Forms.ListBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.pennies_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // pennies_Groupbox
            // 
            this.pennies_Groupbox.Controls.Add(this.days_Textbox);
            this.pennies_Groupbox.Controls.Add(this.days_Label);
            this.pennies_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pennies_Groupbox.Location = new System.Drawing.Point(13, 13);
            this.pennies_Groupbox.Name = "pennies_Groupbox";
            this.pennies_Groupbox.Size = new System.Drawing.Size(424, 79);
            this.pennies_Groupbox.TabIndex = 0;
            this.pennies_Groupbox.TabStop = false;
            this.pennies_Groupbox.Text = "Pennies for Pay";
            // 
            // days_Textbox
            // 
            this.days_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.days_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_Textbox.Location = new System.Drawing.Point(241, 40);
            this.days_Textbox.Name = "days_Textbox";
            this.days_Textbox.Size = new System.Drawing.Size(74, 24);
            this.days_Textbox.TabIndex = 1;
            this.days_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // days_Label
            // 
            this.days_Label.AutoSize = true;
            this.days_Label.Location = new System.Drawing.Point(45, 43);
            this.days_Label.Name = "days_Label";
            this.days_Label.Size = new System.Drawing.Size(174, 18);
            this.days_Label.TabIndex = 0;
            this.days_Label.Text = "Enter number of days:";
            // 
            // output_Listbox
            // 
            this.output_Listbox.FormattingEnabled = true;
            this.output_Listbox.ItemHeight = 16;
            this.output_Listbox.Location = new System.Drawing.Point(13, 104);
            this.output_Listbox.Name = "output_Listbox";
            this.output_Listbox.Size = new System.Drawing.Size(423, 244);
            this.output_Listbox.TabIndex = 1;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(39, 388);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(97, 26);
            this.calculate_Button.TabIndex = 2;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(172, 388);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(97, 26);
            this.clear_Button.TabIndex = 3;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(308, 388);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(97, 26);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // pennies_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 438);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.output_Listbox);
            this.Controls.Add(this.pennies_Groupbox);
            this.Name = "pennies_Form";
            this.Text = "Pennies For Pay";
            this.pennies_Groupbox.ResumeLayout(false);
            this.pennies_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox pennies_Groupbox;
        private System.Windows.Forms.TextBox days_Textbox;
        private System.Windows.Forms.Label days_Label;
        private System.Windows.Forms.ListBox output_Listbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

