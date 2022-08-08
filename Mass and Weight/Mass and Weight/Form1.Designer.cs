namespace Mass_and_Weight
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
            this.mass_Label = new System.Windows.Forms.Label();
            this.mass_input_textbox = new System.Windows.Forms.TextBox();
            this.weight_Label = new System.Windows.Forms.Label();
            this.weight_textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mass_Label
            // 
            this.mass_Label.AutoSize = true;
            this.mass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mass_Label.Location = new System.Drawing.Point(42, 65);
            this.mass_Label.Name = "mass_Label";
            this.mass_Label.Size = new System.Drawing.Size(186, 18);
            this.mass_Label.TabIndex = 0;
            this.mass_Label.Text = "Enter an object\'s mass:";
            // 
            // mass_input_textbox
            // 
            this.mass_input_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mass_input_textbox.Location = new System.Drawing.Point(253, 62);
            this.mass_input_textbox.Name = "mass_input_textbox";
            this.mass_input_textbox.Size = new System.Drawing.Size(107, 24);
            this.mass_input_textbox.TabIndex = 1;
            this.mass_input_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_Label.Location = new System.Drawing.Point(163, 160);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(65, 18);
            this.weight_Label.TabIndex = 2;
            this.weight_Label.Text = "Weight:";
            // 
            // weight_textbox
            // 
            this.weight_textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.weight_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_textbox.Location = new System.Drawing.Point(253, 157);
            this.weight_textbox.Name = "weight_textbox";
            this.weight_textbox.Size = new System.Drawing.Size(107, 24);
            this.weight_textbox.TabIndex = 3;
            this.weight_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(45, 229);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(104, 36);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(187, 229);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(104, 36);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(329, 229);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(104, 36);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 312);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.weight_textbox);
            this.Controls.Add(this.weight_Label);
            this.Controls.Add(this.mass_input_textbox);
            this.Controls.Add(this.mass_Label);
            this.Name = "Form1";
            this.Text = "Mass and Weight";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label mass_Label;
        private System.Windows.Forms.TextBox mass_input_textbox;
        private System.Windows.Forms.Label weight_Label;
        private System.Windows.Forms.TextBox weight_textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

