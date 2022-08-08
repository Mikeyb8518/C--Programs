namespace Change_For_a_Dollar_Game
{
    partial class dollarGame_Form
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
            this.pennies_Label = new System.Windows.Forms.Label();
            this.nickels_Label = new System.Windows.Forms.Label();
            this.dimes_Label = new System.Windows.Forms.Label();
            this.quarters_Label = new System.Windows.Forms.Label();
            this.change_Label = new System.Windows.Forms.Label();
            this.pennies_Textbox = new System.Windows.Forms.TextBox();
            this.nickels_Textbox = new System.Windows.Forms.TextBox();
            this.dimes_Textbox = new System.Windows.Forms.TextBox();
            this.quarters_Textbox = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pennies_Label
            // 
            this.pennies_Label.AutoSize = true;
            this.pennies_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pennies_Label.Location = new System.Drawing.Point(40, 119);
            this.pennies_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pennies_Label.Name = "pennies_Label";
            this.pennies_Label.Size = new System.Drawing.Size(73, 18);
            this.pennies_Label.TabIndex = 0;
            this.pennies_Label.Text = "Pennies:";
            // 
            // nickels_Label
            // 
            this.nickels_Label.AutoSize = true;
            this.nickels_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickels_Label.Location = new System.Drawing.Point(40, 198);
            this.nickels_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nickels_Label.Name = "nickels_Label";
            this.nickels_Label.Size = new System.Drawing.Size(69, 18);
            this.nickels_Label.TabIndex = 1;
            this.nickels_Label.Text = "Nickels:";
            // 
            // dimes_Label
            // 
            this.dimes_Label.AutoSize = true;
            this.dimes_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimes_Label.Location = new System.Drawing.Point(281, 119);
            this.dimes_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dimes_Label.Name = "dimes_Label";
            this.dimes_Label.Size = new System.Drawing.Size(61, 18);
            this.dimes_Label.TabIndex = 2;
            this.dimes_Label.Text = "Dimes:";
            // 
            // quarters_Label
            // 
            this.quarters_Label.AutoSize = true;
            this.quarters_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarters_Label.Location = new System.Drawing.Point(263, 198);
            this.quarters_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.quarters_Label.Name = "quarters_Label";
            this.quarters_Label.Size = new System.Drawing.Size(79, 18);
            this.quarters_Label.TabIndex = 3;
            this.quarters_Label.Text = "Quarters:";
            // 
            // change_Label
            // 
            this.change_Label.AutoSize = true;
            this.change_Label.Location = new System.Drawing.Point(16, 51);
            this.change_Label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.change_Label.Name = "change_Label";
            this.change_Label.Size = new System.Drawing.Size(186, 20);
            this.change_Label.TabIndex = 4;
            this.change_Label.Text = "Please Enter Change";
            // 
            // pennies_Textbox
            // 
            this.pennies_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.pennies_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pennies_Textbox.Location = new System.Drawing.Point(126, 115);
            this.pennies_Textbox.Name = "pennies_Textbox";
            this.pennies_Textbox.Size = new System.Drawing.Size(76, 24);
            this.pennies_Textbox.TabIndex = 1;
            this.pennies_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // nickels_Textbox
            // 
            this.nickels_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.nickels_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nickels_Textbox.Location = new System.Drawing.Point(126, 195);
            this.nickels_Textbox.Name = "nickels_Textbox";
            this.nickels_Textbox.Size = new System.Drawing.Size(76, 24);
            this.nickels_Textbox.TabIndex = 2;
            this.nickels_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dimes_Textbox
            // 
            this.dimes_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.dimes_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dimes_Textbox.Location = new System.Drawing.Point(349, 115);
            this.dimes_Textbox.Name = "dimes_Textbox";
            this.dimes_Textbox.Size = new System.Drawing.Size(76, 24);
            this.dimes_Textbox.TabIndex = 3;
            this.dimes_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // quarters_Textbox
            // 
            this.quarters_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.quarters_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quarters_Textbox.Location = new System.Drawing.Point(349, 195);
            this.quarters_Textbox.Name = "quarters_Textbox";
            this.quarters_Textbox.Size = new System.Drawing.Size(76, 24);
            this.quarters_Textbox.TabIndex = 4;
            this.quarters_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Location = new System.Drawing.Point(158, 285);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(57, 20);
            this.total_Label.TabIndex = 9;
            this.total_Label.Text = "Total:";
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Window;
            this.total_Textbox.Location = new System.Drawing.Point(231, 282);
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(95, 27);
            this.total_Textbox.TabIndex = 10;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(63, 356);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(86, 29);
            this.calculate_Button.TabIndex = 11;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(197, 356);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(86, 29);
            this.clear_Button.TabIndex = 12;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(326, 356);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(86, 29);
            this.exit_Button.TabIndex = 13;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // dollarGame_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 442);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_Textbox);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.quarters_Textbox);
            this.Controls.Add(this.dimes_Textbox);
            this.Controls.Add(this.nickels_Textbox);
            this.Controls.Add(this.pennies_Textbox);
            this.Controls.Add(this.change_Label);
            this.Controls.Add(this.quarters_Label);
            this.Controls.Add(this.dimes_Label);
            this.Controls.Add(this.nickels_Label);
            this.Controls.Add(this.pennies_Label);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "dollarGame_Form";
            this.Text = "Change For A Dollar Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label pennies_Label;
        private System.Windows.Forms.Label nickels_Label;
        private System.Windows.Forms.Label dimes_Label;
        private System.Windows.Forms.Label quarters_Label;
        private System.Windows.Forms.Label change_Label;
        private System.Windows.Forms.TextBox pennies_Textbox;
        private System.Windows.Forms.TextBox nickels_Textbox;
        private System.Windows.Forms.TextBox dimes_Textbox;
        private System.Windows.Forms.TextBox quarters_Textbox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox total_Textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

