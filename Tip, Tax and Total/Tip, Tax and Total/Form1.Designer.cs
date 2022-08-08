namespace Tip__Tax_and_Total
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
            this.foodCharge_Label = new System.Windows.Forms.Label();
            this.charge_Text = new System.Windows.Forms.TextBox();
            this.total_Text = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // foodCharge_Label
            // 
            this.foodCharge_Label.AutoSize = true;
            this.foodCharge_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foodCharge_Label.Location = new System.Drawing.Point(30, 105);
            this.foodCharge_Label.Name = "foodCharge_Label";
            this.foodCharge_Label.Size = new System.Drawing.Size(245, 18);
            this.foodCharge_Label.TabIndex = 0;
            this.foodCharge_Label.Text = "Enter The Charge Of The Food:";
            // 
            // charge_Text
            // 
            this.charge_Text.Location = new System.Drawing.Point(301, 104);
            this.charge_Text.Multiline = true;
            this.charge_Text.Name = "charge_Text";
            this.charge_Text.Size = new System.Drawing.Size(154, 22);
            this.charge_Text.TabIndex = 1;
            this.charge_Text.TextChanged += new System.EventHandler(this.charge_Text_TextChanged);
            // 
            // total_Text
            // 
            this.total_Text.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Text.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.total_Text.Location = new System.Drawing.Point(286, 178);
            this.total_Text.Name = "total_Text";
            this.total_Text.Size = new System.Drawing.Size(114, 22);
            this.total_Text.TabIndex = 2;
            this.total_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(97, 178);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(166, 18);
            this.total_Label.TabIndex = 3;
            this.total_Label.Text = "Total With Tip && Tax:";
            // 
            // total_Button
            // 
            this.total_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Button.Location = new System.Drawing.Point(75, 261);
            this.total_Button.Name = "total_Button";
            this.total_Button.Size = new System.Drawing.Size(109, 48);
            this.total_Button.TabIndex = 4;
            this.total_Button.Text = "Calculate Total";
            this.total_Button.UseVisualStyleBackColor = true;
            this.total_Button.Click += new System.EventHandler(this.total_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(346, 261);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(109, 48);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(211, 261);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(109, 48);
            this.clear_Button.TabIndex = 6;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 450);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.total_Button);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.total_Text);
            this.Controls.Add(this.charge_Text);
            this.Controls.Add(this.foodCharge_Label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label foodCharge_Label;
        private System.Windows.Forms.TextBox charge_Text;
        private System.Windows.Forms.TextBox total_Text;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Button total_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button clear_Button;
    }
}

