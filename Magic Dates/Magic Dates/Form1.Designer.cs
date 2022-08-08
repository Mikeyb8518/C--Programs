namespace Magic_Dates
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
            this.month_Label = new System.Windows.Forms.Label();
            this.day_Label = new System.Windows.Forms.Label();
            this.year_Label = new System.Windows.Forms.Label();
            this.month_Textbox = new System.Windows.Forms.TextBox();
            this.day_Textbox = new System.Windows.Forms.TextBox();
            this.year_Textbox = new System.Windows.Forms.TextBox();
            this.Calculate_Button = new System.Windows.Forms.Button();
            this.reset_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // month_Label
            // 
            this.month_Label.AutoSize = true;
            this.month_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.month_Label.Location = new System.Drawing.Point(60, 70);
            this.month_Label.Name = "month_Label";
            this.month_Label.Size = new System.Drawing.Size(236, 18);
            this.month_Label.TabIndex = 0;
            this.month_Label.Text = "Enter Month In Numeric Form:";
            // 
            // day_Label
            // 
            this.day_Label.AutoSize = true;
            this.day_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day_Label.Location = new System.Drawing.Point(78, 129);
            this.day_Label.Name = "day_Label";
            this.day_Label.Size = new System.Drawing.Size(218, 18);
            this.day_Label.TabIndex = 1;
            this.day_Label.Text = "Enter Day In Numeric Form:";
            // 
            // year_Label
            // 
            this.year_Label.AutoSize = true;
            this.year_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.year_Label.Location = new System.Drawing.Point(113, 186);
            this.year_Label.Name = "year_Label";
            this.year_Label.Size = new System.Drawing.Size(183, 18);
            this.year_Label.TabIndex = 2;
            this.year_Label.Text = "Enter A Two Digit Year:";
            // 
            // month_Textbox
            // 
            this.month_Textbox.Location = new System.Drawing.Point(325, 69);
            this.month_Textbox.Name = "month_Textbox";
            this.month_Textbox.Size = new System.Drawing.Size(76, 22);
            this.month_Textbox.TabIndex = 1;
            this.month_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.month_Textbox.TextChanged += new System.EventHandler(this.month_Textbox_TextChanged);
            // 
            // day_Textbox
            // 
            this.day_Textbox.Location = new System.Drawing.Point(325, 128);
            this.day_Textbox.Name = "day_Textbox";
            this.day_Textbox.Size = new System.Drawing.Size(76, 22);
            this.day_Textbox.TabIndex = 2;
            this.day_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // year_Textbox
            // 
            this.year_Textbox.Location = new System.Drawing.Point(325, 185);
            this.year_Textbox.Name = "year_Textbox";
            this.year_Textbox.Size = new System.Drawing.Size(76, 22);
            this.year_Textbox.TabIndex = 3;
            this.year_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Calculate_Button
            // 
            this.Calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculate_Button.Location = new System.Drawing.Point(26, 272);
            this.Calculate_Button.Name = "Calculate_Button";
            this.Calculate_Button.Size = new System.Drawing.Size(109, 37);
            this.Calculate_Button.TabIndex = 4;
            this.Calculate_Button.Text = "Calculate";
            this.Calculate_Button.UseVisualStyleBackColor = true;
            this.Calculate_Button.Click += new System.EventHandler(this.Calculate_Button_Click);
            // 
            // reset_Button
            // 
            this.reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Button.Location = new System.Drawing.Point(174, 272);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(109, 37);
            this.reset_Button.TabIndex = 5;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(325, 272);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(109, 37);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 367);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.Calculate_Button);
            this.Controls.Add(this.year_Textbox);
            this.Controls.Add(this.day_Textbox);
            this.Controls.Add(this.month_Textbox);
            this.Controls.Add(this.year_Label);
            this.Controls.Add(this.day_Label);
            this.Controls.Add(this.month_Label);
            this.Name = "Form1";
            this.Text = "Magic Dates";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label month_Label;
        private System.Windows.Forms.Label day_Label;
        private System.Windows.Forms.Label year_Label;
        private System.Windows.Forms.TextBox month_Textbox;
        private System.Windows.Forms.TextBox day_Textbox;
        private System.Windows.Forms.TextBox year_Textbox;
        private System.Windows.Forms.Button Calculate_Button;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

