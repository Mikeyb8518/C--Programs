namespace Kinetic_Energy
{
    partial class kinetic_Energy_Form
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
            this.kinetic_Energy_Groupbox = new System.Windows.Forms.GroupBox();
            this.mass_Label = new System.Windows.Forms.Label();
            this.mass_Textbox = new System.Windows.Forms.TextBox();
            this.velocity_Label = new System.Windows.Forms.Label();
            this.velocity_Textbox = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.output_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.kinetic_Energy_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // kinetic_Energy_Groupbox
            // 
            this.kinetic_Energy_Groupbox.Controls.Add(this.output_Label);
            this.kinetic_Energy_Groupbox.Controls.Add(this.total_Label);
            this.kinetic_Energy_Groupbox.Controls.Add(this.velocity_Textbox);
            this.kinetic_Energy_Groupbox.Controls.Add(this.velocity_Label);
            this.kinetic_Energy_Groupbox.Controls.Add(this.mass_Textbox);
            this.kinetic_Energy_Groupbox.Controls.Add(this.mass_Label);
            this.kinetic_Energy_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kinetic_Energy_Groupbox.Location = new System.Drawing.Point(18, 21);
            this.kinetic_Energy_Groupbox.Name = "kinetic_Energy_Groupbox";
            this.kinetic_Energy_Groupbox.Size = new System.Drawing.Size(476, 207);
            this.kinetic_Energy_Groupbox.TabIndex = 0;
            this.kinetic_Energy_Groupbox.TabStop = false;
            this.kinetic_Energy_Groupbox.Text = "Calculate Kinetic Energy";
            // 
            // mass_Label
            // 
            this.mass_Label.AutoSize = true;
            this.mass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mass_Label.Location = new System.Drawing.Point(78, 38);
            this.mass_Label.Name = "mass_Label";
            this.mass_Label.Size = new System.Drawing.Size(234, 16);
            this.mass_Label.TabIndex = 0;
            this.mass_Label.Text = "Enter Objects Mass in Kilograms:";
            // 
            // mass_Textbox
            // 
            this.mass_Textbox.Location = new System.Drawing.Point(336, 33);
            this.mass_Textbox.Name = "mass_Textbox";
            this.mass_Textbox.Size = new System.Drawing.Size(92, 24);
            this.mass_Textbox.TabIndex = 1;
            this.mass_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // velocity_Label
            // 
            this.velocity_Label.AutoSize = true;
            this.velocity_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.velocity_Label.Location = new System.Drawing.Point(6, 98);
            this.velocity_Label.Name = "velocity_Label";
            this.velocity_Label.Size = new System.Drawing.Size(324, 16);
            this.velocity_Label.TabIndex = 2;
            this.velocity_Label.Text = "Enter Objects Velocity in Meters Per Seconds:";
            // 
            // velocity_Textbox
            // 
            this.velocity_Textbox.Location = new System.Drawing.Point(368, 93);
            this.velocity_Textbox.Name = "velocity_Textbox";
            this.velocity_Textbox.Size = new System.Drawing.Size(92, 24);
            this.velocity_Textbox.TabIndex = 3;
            this.velocity_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(126, 169);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(155, 16);
            this.total_Label.TabIndex = 4;
            this.total_Label.Text = "Kenetic Energy Total:";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(297, 169);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(15, 16);
            this.output_Label.TabIndex = 5;
            this.output_Label.Text = "0";
            this.output_Label.Visible = false;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(57, 253);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(102, 34);
            this.calculate_Button.TabIndex = 1;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(197, 253);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(102, 34);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(335, 253);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(102, 34);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // kinetic_Energy_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 312);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.kinetic_Energy_Groupbox);
            this.Name = "kinetic_Energy_Form";
            this.Text = "Kinetic Energy";
            this.kinetic_Energy_Groupbox.ResumeLayout(false);
            this.kinetic_Energy_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox kinetic_Energy_Groupbox;
        private System.Windows.Forms.TextBox mass_Textbox;
        private System.Windows.Forms.Label mass_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox velocity_Textbox;
        private System.Windows.Forms.Label velocity_Label;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

