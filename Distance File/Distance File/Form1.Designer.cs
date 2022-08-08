namespace Distance_File
{
    partial class distanceFile_Form
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
            this.speed_Label = new System.Windows.Forms.Label();
            this.hours_Label = new System.Windows.Forms.Label();
            this.speed_Textbox = new System.Windows.Forms.TextBox();
            this.hours_Textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // speed_Label
            // 
            this.speed_Label.AutoSize = true;
            this.speed_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.speed_Label.Location = new System.Drawing.Point(12, 37);
            this.speed_Label.Name = "speed_Label";
            this.speed_Label.Size = new System.Drawing.Size(158, 18);
            this.speed_Label.TabIndex = 0;
            this.speed_Label.Text = "Vehicle Speed in MPH:";
            // 
            // hours_Label
            // 
            this.hours_Label.AutoSize = true;
            this.hours_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hours_Label.Location = new System.Drawing.Point(65, 88);
            this.hours_Label.Name = "hours_Label";
            this.hours_Label.Size = new System.Drawing.Size(105, 18);
            this.hours_Label.TabIndex = 1;
            this.hours_Label.Text = "Hours Travled:";
            // 
            // speed_Textbox
            // 
            this.speed_Textbox.Location = new System.Drawing.Point(186, 36);
            this.speed_Textbox.Name = "speed_Textbox";
            this.speed_Textbox.Size = new System.Drawing.Size(113, 22);
            this.speed_Textbox.TabIndex = 1;
            this.speed_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // hours_Textbox
            // 
            this.hours_Textbox.Location = new System.Drawing.Point(186, 88);
            this.hours_Textbox.Name = "hours_Textbox";
            this.hours_Textbox.Size = new System.Drawing.Size(113, 22);
            this.hours_Textbox.TabIndex = 2;
            this.hours_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(28, 155);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(93, 29);
            this.calculate_Button.TabIndex = 3;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(156, 155);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(93, 29);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(283, 155);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(93, 29);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // distanceFile_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 212);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.hours_Textbox);
            this.Controls.Add(this.speed_Textbox);
            this.Controls.Add(this.hours_Label);
            this.Controls.Add(this.speed_Label);
            this.Name = "distanceFile_Form";
            this.Text = "Distance File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label speed_Label;
        private System.Windows.Forms.Label hours_Label;
        private System.Windows.Forms.TextBox speed_Textbox;
        private System.Windows.Forms.TextBox hours_Textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

