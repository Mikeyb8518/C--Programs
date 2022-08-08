namespace Calculating_the_Factorial_of_a_Number
{
    partial class factorialNumber_Form
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
            this.entry_Label = new System.Windows.Forms.Label();
            this.data_Textbox = new System.Windows.Forms.TextBox();
            this.factorial_Label = new System.Windows.Forms.Label();
            this.output_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entry_Label
            // 
            this.entry_Label.AutoSize = true;
            this.entry_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Label.Location = new System.Drawing.Point(12, 57);
            this.entry_Label.Name = "entry_Label";
            this.entry_Label.Size = new System.Drawing.Size(263, 16);
            this.entry_Label.TabIndex = 0;
            this.entry_Label.Text = "Please Enter a Nonnegative Number:";
            // 
            // data_Textbox
            // 
            this.data_Textbox.Location = new System.Drawing.Point(308, 54);
            this.data_Textbox.Name = "data_Textbox";
            this.data_Textbox.Size = new System.Drawing.Size(85, 22);
            this.data_Textbox.TabIndex = 1;
            this.data_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // factorial_Label
            // 
            this.factorial_Label.AutoSize = true;
            this.factorial_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.factorial_Label.Location = new System.Drawing.Point(62, 136);
            this.factorial_Label.Name = "factorial_Label";
            this.factorial_Label.Size = new System.Drawing.Size(186, 18);
            this.factorial_Label.TabIndex = 2;
            this.factorial_Label.Text = "Factorial Number Total:";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(271, 136);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(59, 20);
            this.output_Label.TabIndex = 3;
            this.output_Label.Text = "label1";
            this.output_Label.Visible = false;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(15, 193);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(102, 29);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(151, 193);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(88, 29);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(291, 193);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(88, 29);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // factorialNumber_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 266);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.factorial_Label);
            this.Controls.Add(this.data_Textbox);
            this.Controls.Add(this.entry_Label);
            this.Name = "factorialNumber_Form";
            this.Text = "Factorial Number";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entry_Label;
        private System.Windows.Forms.TextBox data_Textbox;
        private System.Windows.Forms.Label factorial_Label;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

