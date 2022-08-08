namespace Prime_Numbers
{
    partial class prime_Form
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
            this.prime_Label = new System.Windows.Forms.Label();
            this.prime_Textbox = new System.Windows.Forms.TextBox();
            this.check_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // prime_Label
            // 
            this.prime_Label.AutoSize = true;
            this.prime_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prime_Label.Location = new System.Drawing.Point(12, 77);
            this.prime_Label.Name = "prime_Label";
            this.prime_Label.Size = new System.Drawing.Size(270, 18);
            this.prime_Label.TabIndex = 0;
            this.prime_Label.Text = "Check To See If Number Is Prime: ";
            // 
            // prime_Textbox
            // 
            this.prime_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prime_Textbox.Location = new System.Drawing.Point(318, 74);
            this.prime_Textbox.Multiline = true;
            this.prime_Textbox.Name = "prime_Textbox";
            this.prime_Textbox.Size = new System.Drawing.Size(101, 26);
            this.prime_Textbox.TabIndex = 1;
            this.prime_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // check_Button
            // 
            this.check_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(50, 160);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(99, 36);
            this.check_Button.TabIndex = 2;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(174, 160);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(99, 36);
            this.clear_Button.TabIndex = 3;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(301, 160);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(99, 36);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // prime_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 231);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.prime_Textbox);
            this.Controls.Add(this.prime_Label);
            this.Name = "prime_Form";
            this.Text = "Prime Numbers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label prime_Label;
        private System.Windows.Forms.TextBox prime_Textbox;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

