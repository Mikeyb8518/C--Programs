namespace Sum_Of_Numbers_in_a_String
{
    partial class Sum_Form
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
            this.input_Numbers_Label = new System.Windows.Forms.Label();
            this.input_Textbox = new System.Windows.Forms.TextBox();
            this.total_Button = new System.Windows.Forms.Button();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // input_Numbers_Label
            // 
            this.input_Numbers_Label.AutoSize = true;
            this.input_Numbers_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Numbers_Label.Location = new System.Drawing.Point(40, 23);
            this.input_Numbers_Label.Name = "input_Numbers_Label";
            this.input_Numbers_Label.Size = new System.Drawing.Size(398, 18);
            this.input_Numbers_Label.TabIndex = 0;
            this.input_Numbers_Label.Text = "Please Enter a Series of Numbers Seperated By a Comma:";
            // 
            // input_Textbox
            // 
            this.input_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Textbox.Location = new System.Drawing.Point(85, 62);
            this.input_Textbox.Name = "input_Textbox";
            this.input_Textbox.Size = new System.Drawing.Size(298, 24);
            this.input_Textbox.TabIndex = 1;
            this.input_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Button
            // 
            this.total_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Button.Location = new System.Drawing.Point(31, 112);
            this.total_Button.Name = "total_Button";
            this.total_Button.Size = new System.Drawing.Size(144, 30);
            this.total_Button.TabIndex = 2;
            this.total_Button.Text = "Calculate Total";
            this.total_Button.UseVisualStyleBackColor = true;
            this.total_Button.Click += new System.EventHandler(this.total_Button_Click);
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(248, 117);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 3;
            this.total_Label.Text = "Total:";
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Textbox.Location = new System.Drawing.Point(309, 117);
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(74, 24);
            this.total_Textbox.TabIndex = 4;
            this.total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Sum_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 160);
            this.Controls.Add(this.total_Textbox);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.total_Button);
            this.Controls.Add(this.input_Textbox);
            this.Controls.Add(this.input_Numbers_Label);
            this.Name = "Sum_Form";
            this.Text = "Sum Of Numbers in a String";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_Numbers_Label;
        private System.Windows.Forms.TextBox input_Textbox;
        private System.Windows.Forms.Button total_Button;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox total_Textbox;
    }
}

