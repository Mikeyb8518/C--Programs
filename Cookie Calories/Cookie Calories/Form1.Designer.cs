namespace Cookie_Calories
{
    partial class cookie_counter_Form
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
            this.cookie_amount_Label = new System.Windows.Forms.Label();
            this.max_number_of_cookies_Label = new System.Windows.Forms.Label();
            this.calorie_counter_Label = new System.Windows.Forms.Label();
            this.cookies_Box = new System.Windows.Forms.TextBox();
            this.calorie_Box = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cookie_amount_Label
            // 
            this.cookie_amount_Label.AutoSize = true;
            this.cookie_amount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cookie_amount_Label.Location = new System.Drawing.Point(49, 111);
            this.cookie_amount_Label.Name = "cookie_amount_Label";
            this.cookie_amount_Label.Size = new System.Drawing.Size(316, 20);
            this.cookie_amount_Label.TabIndex = 0;
            this.cookie_amount_Label.Text = "Enter the Number Of Cookies Eaten:";
            // 
            // max_number_of_cookies_Label
            // 
            this.max_number_of_cookies_Label.AutoSize = true;
            this.max_number_of_cookies_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.max_number_of_cookies_Label.Location = new System.Drawing.Point(88, 131);
            this.max_number_of_cookies_Label.Name = "max_number_of_cookies_Label";
            this.max_number_of_cookies_Label.Size = new System.Drawing.Size(231, 16);
            this.max_number_of_cookies_Label.TabIndex = 1;
            this.max_number_of_cookies_Label.Text = "(The Max Number Is 40 Cookies)";
            // 
            // calorie_counter_Label
            // 
            this.calorie_counter_Label.AutoSize = true;
            this.calorie_counter_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorie_counter_Label.Location = new System.Drawing.Point(135, 194);
            this.calorie_counter_Label.Name = "calorie_counter_Label";
            this.calorie_counter_Label.Size = new System.Drawing.Size(230, 20);
            this.calorie_counter_Label.TabIndex = 2;
            this.calorie_counter_Label.Text = "Total Number Of Calories:";
            // 
            // cookies_Box
            // 
            this.cookies_Box.Location = new System.Drawing.Point(420, 111);
            this.cookies_Box.Name = "cookies_Box";
            this.cookies_Box.Size = new System.Drawing.Size(142, 22);
            this.cookies_Box.TabIndex = 1;
            this.cookies_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calorie_Box
            // 
            this.calorie_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.calorie_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.calorie_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calorie_Box.Location = new System.Drawing.Point(420, 195);
            this.calorie_Box.Name = "calorie_Box";
            this.calorie_Box.Size = new System.Drawing.Size(144, 17);
            this.calorie_Box.TabIndex = 3;
            this.calorie_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(113, 282);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(111, 29);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(365, 282);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(111, 29);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(239, 282);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(111, 29);
            this.clear_Button.TabIndex = 6;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // cookie_counter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(615, 450);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.calorie_Box);
            this.Controls.Add(this.cookies_Box);
            this.Controls.Add(this.calorie_counter_Label);
            this.Controls.Add(this.max_number_of_cookies_Label);
            this.Controls.Add(this.cookie_amount_Label);
            this.Name = "cookie_counter_Form";
            this.Text = "Cookie Counter";
            this.Load += new System.EventHandler(this.cookie_counter_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cookie_amount_Label;
        private System.Windows.Forms.Label max_number_of_cookies_Label;
        private System.Windows.Forms.Label calorie_counter_Label;
        private System.Windows.Forms.TextBox cookies_Box;
        private System.Windows.Forms.TextBox calorie_Box;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button clear_Button;
    }
}

