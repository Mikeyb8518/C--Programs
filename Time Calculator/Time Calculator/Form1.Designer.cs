namespace Time_Calculator
{
    partial class time_calculator_Form
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
            this.enter_seconds_Label = new System.Windows.Forms.Label();
            this.seconds_Textbox = new System.Windows.Forms.TextBox();
            this.convert_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.works_Label = new System.Windows.Forms.Label();
            this.works_Textbox = new System.Windows.Forms.TextBox();
            this.display_Label = new System.Windows.Forms.Label();
            this.output_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // enter_seconds_Label
            // 
            this.enter_seconds_Label.AutoSize = true;
            this.enter_seconds_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enter_seconds_Label.Location = new System.Drawing.Point(12, 67);
            this.enter_seconds_Label.Name = "enter_seconds_Label";
            this.enter_seconds_Label.Size = new System.Drawing.Size(295, 18);
            this.enter_seconds_Label.TabIndex = 0;
            this.enter_seconds_Label.Text = "Please Enter the Number Of Seconds:";
            // 
            // seconds_Textbox
            // 
            this.seconds_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.seconds_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.seconds_Textbox.Location = new System.Drawing.Point(357, 66);
            this.seconds_Textbox.Name = "seconds_Textbox";
            this.seconds_Textbox.Size = new System.Drawing.Size(128, 22);
            this.seconds_Textbox.TabIndex = 1;
            this.seconds_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convert_Button
            // 
            this.convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.Location = new System.Drawing.Point(66, 326);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(95, 29);
            this.convert_Button.TabIndex = 3;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(212, 326);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(95, 29);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(357, 326);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(95, 29);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // works_Label
            // 
            this.works_Label.AutoSize = true;
            this.works_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.works_Label.Location = new System.Drawing.Point(31, 131);
            this.works_Label.Name = "works_Label";
            this.works_Label.Size = new System.Drawing.Size(276, 18);
            this.works_Label.TabIndex = 11;
            this.works_Label.Text = "Please Enter the Number of Works:";
            // 
            // works_Textbox
            // 
            this.works_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.works_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.works_Textbox.Location = new System.Drawing.Point(357, 130);
            this.works_Textbox.Multiline = true;
            this.works_Textbox.Name = "works_Textbox";
            this.works_Textbox.Size = new System.Drawing.Size(127, 25);
            this.works_Textbox.TabIndex = 2;
            this.works_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // display_Label
            // 
            this.display_Label.AutoSize = true;
            this.display_Label.Location = new System.Drawing.Point(104, 231);
            this.display_Label.Name = "display_Label";
            this.display_Label.Size = new System.Drawing.Size(44, 16);
            this.display_Label.TabIndex = 13;
            this.display_Label.Text = "label1";
            this.display_Label.Visible = false;
            // 
            // output_Textbox
            // 
            this.output_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.output_Textbox.Location = new System.Drawing.Point(238, 225);
            this.output_Textbox.Name = "output_Textbox";
            this.output_Textbox.Size = new System.Drawing.Size(104, 22);
            this.output_Textbox.TabIndex = 14;
            this.output_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // time_calculator_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 389);
            this.Controls.Add(this.output_Textbox);
            this.Controls.Add(this.display_Label);
            this.Controls.Add(this.works_Textbox);
            this.Controls.Add(this.works_Label);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.convert_Button);
            this.Controls.Add(this.seconds_Textbox);
            this.Controls.Add(this.enter_seconds_Label);
            this.Name = "time_calculator_Form";
            this.Text = "Time Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label enter_seconds_Label;
        private System.Windows.Forms.TextBox seconds_Textbox;
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label works_Label;
        private System.Windows.Forms.TextBox works_Textbox;
        private System.Windows.Forms.Label display_Label;
        private System.Windows.Forms.TextBox output_Textbox;
    }
}

