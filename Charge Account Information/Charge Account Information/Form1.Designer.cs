namespace Charge_Account_Information
{
    partial class charge_Account_Form
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
            this.charge_Label = new System.Windows.Forms.Label();
            this.output_Textbox = new System.Windows.Forms.TextBox();
            this.check_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // charge_Label
            // 
            this.charge_Label.AutoSize = true;
            this.charge_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.charge_Label.Location = new System.Drawing.Point(12, 28);
            this.charge_Label.Name = "charge_Label";
            this.charge_Label.Size = new System.Drawing.Size(338, 16);
            this.charge_Label.TabIndex = 0;
            this.charge_Label.Text = "Enter Chrage Account Number(Must be 7 Digits):";
            // 
            // output_Textbox
            // 
            this.output_Textbox.Location = new System.Drawing.Point(404, 25);
            this.output_Textbox.Name = "output_Textbox";
            this.output_Textbox.Size = new System.Drawing.Size(128, 22);
            this.output_Textbox.TabIndex = 1;
            this.output_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_Button
            // 
            this.check_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(65, 80);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(89, 33);
            this.check_Button.TabIndex = 2;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(212, 80);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(89, 33);
            this.clear_Button.TabIndex = 3;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(368, 80);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(89, 33);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // charge_Account_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 141);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.output_Textbox);
            this.Controls.Add(this.charge_Label);
            this.Name = "charge_Account_Form";
            this.Text = "Charge Account Information";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label charge_Label;
        private System.Windows.Forms.TextBox output_Textbox;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

