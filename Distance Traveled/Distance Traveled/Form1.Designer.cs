namespace Distance_Traveled
{
    partial class distacne_Form
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
            this.distance_Label = new System.Windows.Forms.Label();
            this.speed_Text = new System.Windows.Forms.TextBox();
            this.distanceTraveled_Label = new System.Windows.Forms.Label();
            this.output_Text = new System.Windows.Forms.TextBox();
            this.fiveHour_Button = new System.Windows.Forms.Button();
            this.eightHour_Button = new System.Windows.Forms.Button();
            this.twelveHours_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // distance_Label
            // 
            this.distance_Label.AutoSize = true;
            this.distance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_Label.Location = new System.Drawing.Point(73, 116);
            this.distance_Label.Name = "distance_Label";
            this.distance_Label.Size = new System.Drawing.Size(240, 18);
            this.distance_Label.TabIndex = 0;
            this.distance_Label.Text = "Please Enter Car\'s Speed(In MPH):";
            // 
            // speed_Text
            // 
            this.speed_Text.Location = new System.Drawing.Point(346, 115);
            this.speed_Text.Multiline = true;
            this.speed_Text.Name = "speed_Text";
            this.speed_Text.Size = new System.Drawing.Size(135, 22);
            this.speed_Text.TabIndex = 1;
            // 
            // distanceTraveled_Label
            // 
            this.distanceTraveled_Label.AutoSize = true;
            this.distanceTraveled_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distanceTraveled_Label.Location = new System.Drawing.Point(95, 176);
            this.distanceTraveled_Label.Name = "distanceTraveled_Label";
            this.distanceTraveled_Label.Size = new System.Drawing.Size(213, 20);
            this.distanceTraveled_Label.TabIndex = 2;
            this.distanceTraveled_Label.Text = "Distance Traveled In Miles:";
            // 
            // output_Text
            // 
            this.output_Text.BackColor = System.Drawing.SystemColors.Menu;
            this.output_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_Text.Location = new System.Drawing.Point(332, 177);
            this.output_Text.Multiline = true;
            this.output_Text.Name = "output_Text";
            this.output_Text.Size = new System.Drawing.Size(134, 21);
            this.output_Text.TabIndex = 3;
            // 
            // fiveHour_Button
            // 
            this.fiveHour_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fiveHour_Button.Location = new System.Drawing.Point(123, 290);
            this.fiveHour_Button.Name = "fiveHour_Button";
            this.fiveHour_Button.Size = new System.Drawing.Size(129, 44);
            this.fiveHour_Button.TabIndex = 4;
            this.fiveHour_Button.Text = "Distance After 5 Hours";
            this.fiveHour_Button.UseVisualStyleBackColor = true;
            this.fiveHour_Button.Click += new System.EventHandler(this.fiveHour_Button_Click);
            // 
            // eightHour_Button
            // 
            this.eightHour_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eightHour_Button.Location = new System.Drawing.Point(271, 290);
            this.eightHour_Button.Name = "eightHour_Button";
            this.eightHour_Button.Size = new System.Drawing.Size(129, 44);
            this.eightHour_Button.TabIndex = 5;
            this.eightHour_Button.Text = "Distance After 8 Hours";
            this.eightHour_Button.UseVisualStyleBackColor = true;
            this.eightHour_Button.Click += new System.EventHandler(this.eightHour_Button_Click);
            // 
            // twelveHours_Button
            // 
            this.twelveHours_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.twelveHours_Button.Location = new System.Drawing.Point(418, 290);
            this.twelveHours_Button.Name = "twelveHours_Button";
            this.twelveHours_Button.Size = new System.Drawing.Size(129, 44);
            this.twelveHours_Button.TabIndex = 6;
            this.twelveHours_Button.Text = "Distance After 12 Hours";
            this.twelveHours_Button.UseVisualStyleBackColor = true;
            this.twelveHours_Button.Click += new System.EventHandler(this.twelveHours_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(213, 340);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(100, 44);
            this.clear_Button.TabIndex = 7;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(356, 340);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(100, 44);
            this.exit_Button.TabIndex = 8;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // distacne_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 450);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.twelveHours_Button);
            this.Controls.Add(this.eightHour_Button);
            this.Controls.Add(this.fiveHour_Button);
            this.Controls.Add(this.output_Text);
            this.Controls.Add(this.distanceTraveled_Label);
            this.Controls.Add(this.speed_Text);
            this.Controls.Add(this.distance_Label);
            this.Name = "distacne_Form";
            this.Text = "Distance Traveled";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distance_Label;
        private System.Windows.Forms.TextBox speed_Text;
        private System.Windows.Forms.Label distanceTraveled_Label;
        private System.Windows.Forms.TextBox output_Text;
        private System.Windows.Forms.Button fiveHour_Button;
        private System.Windows.Forms.Button eightHour_Button;
        private System.Windows.Forms.Button twelveHours_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

