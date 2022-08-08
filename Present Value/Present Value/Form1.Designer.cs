namespace Present_Value
{
    partial class present_Value_Form
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
            this.future_Label = new System.Windows.Forms.Label();
            this.interest_Label = new System.Windows.Forms.Label();
            this.years_Label = new System.Windows.Forms.Label();
            this.future_Value_Textbox = new System.Windows.Forms.TextBox();
            this.interest_Rate_Textbox = new System.Windows.Forms.TextBox();
            this.num_Years_Textbox = new System.Windows.Forms.TextBox();
            this.present_Value_Label = new System.Windows.Forms.Label();
            this.presentValue_Groupbox = new System.Windows.Forms.GroupBox();
            this.output_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.presentValue_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // future_Label
            // 
            this.future_Label.AutoSize = true;
            this.future_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.future_Label.Location = new System.Drawing.Point(104, 33);
            this.future_Label.Name = "future_Label";
            this.future_Label.Size = new System.Drawing.Size(133, 18);
            this.future_Label.TabIndex = 0;
            this.future_Label.Text = "Future Value: ($)";
            // 
            // interest_Label
            // 
            this.interest_Label.AutoSize = true;
            this.interest_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interest_Label.Location = new System.Drawing.Point(128, 91);
            this.interest_Label.Name = "interest_Label";
            this.interest_Label.Size = new System.Drawing.Size(109, 18);
            this.interest_Label.TabIndex = 1;
            this.interest_Label.Text = "Interest Rate:";
            // 
            // years_Label
            // 
            this.years_Label.AutoSize = true;
            this.years_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.years_Label.Location = new System.Drawing.Point(97, 154);
            this.years_Label.Name = "years_Label";
            this.years_Label.Size = new System.Drawing.Size(140, 18);
            this.years_Label.TabIndex = 2;
            this.years_Label.Text = "Number of Years:";
            // 
            // future_Value_Textbox
            // 
            this.future_Value_Textbox.Location = new System.Drawing.Point(259, 30);
            this.future_Value_Textbox.Name = "future_Value_Textbox";
            this.future_Value_Textbox.Size = new System.Drawing.Size(97, 24);
            this.future_Value_Textbox.TabIndex = 1;
            this.future_Value_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // interest_Rate_Textbox
            // 
            this.interest_Rate_Textbox.Location = new System.Drawing.Point(259, 88);
            this.interest_Rate_Textbox.Name = "interest_Rate_Textbox";
            this.interest_Rate_Textbox.Size = new System.Drawing.Size(97, 24);
            this.interest_Rate_Textbox.TabIndex = 2;
            this.interest_Rate_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // num_Years_Textbox
            // 
            this.num_Years_Textbox.Location = new System.Drawing.Point(259, 151);
            this.num_Years_Textbox.Name = "num_Years_Textbox";
            this.num_Years_Textbox.Size = new System.Drawing.Size(97, 24);
            this.num_Years_Textbox.TabIndex = 3;
            this.num_Years_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // present_Value_Label
            // 
            this.present_Value_Label.AutoSize = true;
            this.present_Value_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.present_Value_Label.Location = new System.Drawing.Point(173, 247);
            this.present_Value_Label.Name = "present_Value_Label";
            this.present_Value_Label.Size = new System.Drawing.Size(117, 18);
            this.present_Value_Label.TabIndex = 4;
            this.present_Value_Label.Text = "Present Value:";
            // 
            // presentValue_Groupbox
            // 
            this.presentValue_Groupbox.Controls.Add(this.num_Years_Textbox);
            this.presentValue_Groupbox.Controls.Add(this.interest_Rate_Textbox);
            this.presentValue_Groupbox.Controls.Add(this.future_Value_Textbox);
            this.presentValue_Groupbox.Controls.Add(this.years_Label);
            this.presentValue_Groupbox.Controls.Add(this.interest_Label);
            this.presentValue_Groupbox.Controls.Add(this.future_Label);
            this.presentValue_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.presentValue_Groupbox.Location = new System.Drawing.Point(35, 22);
            this.presentValue_Groupbox.Name = "presentValue_Groupbox";
            this.presentValue_Groupbox.Size = new System.Drawing.Size(516, 192);
            this.presentValue_Groupbox.TabIndex = 5;
            this.presentValue_Groupbox.TabStop = false;
            this.presentValue_Groupbox.Text = "Present Value";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(305, 247);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Label.TabIndex = 6;
            this.output_Label.Text = "0";
            this.output_Label.Visible = false;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(64, 308);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(102, 32);
            this.calculate_Button.TabIndex = 7;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(242, 308);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(102, 32);
            this.clear_Button.TabIndex = 8;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(421, 308);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(102, 32);
            this.exit_Button.TabIndex = 9;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // present_Value_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 369);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.presentValue_Groupbox);
            this.Controls.Add(this.present_Value_Label);
            this.Name = "present_Value_Form";
            this.Text = "Present Value";
            this.presentValue_Groupbox.ResumeLayout(false);
            this.presentValue_Groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label future_Label;
        private System.Windows.Forms.Label interest_Label;
        private System.Windows.Forms.Label years_Label;
        private System.Windows.Forms.TextBox future_Value_Textbox;
        private System.Windows.Forms.TextBox interest_Rate_Textbox;
        private System.Windows.Forms.TextBox num_Years_Textbox;
        private System.Windows.Forms.Label present_Value_Label;
        private System.Windows.Forms.GroupBox presentValue_Groupbox;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

