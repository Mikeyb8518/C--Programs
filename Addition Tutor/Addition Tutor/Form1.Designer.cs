namespace Addition_Tutor
{
    partial class addition_Tutor_Form
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
            this.addition_Groupbox = new System.Windows.Forms.GroupBox();
            this.number1_Label = new System.Windows.Forms.Label();
            this.addition_Label = new System.Windows.Forms.Label();
            this.number2_Label = new System.Windows.Forms.Label();
            this.equal_Label = new System.Windows.Forms.Label();
            this.answer_Textbox = new System.Windows.Forms.TextBox();
            this.generate_Button = new System.Windows.Forms.Button();
            this.check_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.addition_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // addition_Groupbox
            // 
            this.addition_Groupbox.Controls.Add(this.answer_Textbox);
            this.addition_Groupbox.Controls.Add(this.equal_Label);
            this.addition_Groupbox.Controls.Add(this.number2_Label);
            this.addition_Groupbox.Controls.Add(this.addition_Label);
            this.addition_Groupbox.Controls.Add(this.number1_Label);
            this.addition_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition_Groupbox.Location = new System.Drawing.Point(15, 20);
            this.addition_Groupbox.Name = "addition_Groupbox";
            this.addition_Groupbox.Size = new System.Drawing.Size(443, 188);
            this.addition_Groupbox.TabIndex = 0;
            this.addition_Groupbox.TabStop = false;
            this.addition_Groupbox.Text = "Solve the addition problem";
            // 
            // number1_Label
            // 
            this.number1_Label.AutoSize = true;
            this.number1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1_Label.Location = new System.Drawing.Point(63, 88);
            this.number1_Label.Name = "number1_Label";
            this.number1_Label.Size = new System.Drawing.Size(27, 29);
            this.number1_Label.TabIndex = 0;
            this.number1_Label.Text = "0";
            // 
            // addition_Label
            // 
            this.addition_Label.AutoSize = true;
            this.addition_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition_Label.Location = new System.Drawing.Point(117, 88);
            this.addition_Label.Name = "addition_Label";
            this.addition_Label.Size = new System.Drawing.Size(28, 29);
            this.addition_Label.TabIndex = 1;
            this.addition_Label.Text = "+";
            // 
            // number2_Label
            // 
            this.number2_Label.AutoSize = true;
            this.number2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2_Label.Location = new System.Drawing.Point(170, 88);
            this.number2_Label.Name = "number2_Label";
            this.number2_Label.Size = new System.Drawing.Size(27, 29);
            this.number2_Label.TabIndex = 2;
            this.number2_Label.Text = "0";
            // 
            // equal_Label
            // 
            this.equal_Label.AutoSize = true;
            this.equal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equal_Label.Location = new System.Drawing.Point(225, 88);
            this.equal_Label.Name = "equal_Label";
            this.equal_Label.Size = new System.Drawing.Size(28, 29);
            this.equal_Label.TabIndex = 3;
            this.equal_Label.Text = "=";
            // 
            // answer_Textbox
            // 
            this.answer_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.answer_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_Textbox.Location = new System.Drawing.Point(279, 82);
            this.answer_Textbox.Multiline = true;
            this.answer_Textbox.Name = "answer_Textbox";
            this.answer_Textbox.Size = new System.Drawing.Size(94, 35);
            this.answer_Textbox.TabIndex = 1;
            this.answer_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // generate_Button
            // 
            this.generate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generate_Button.Location = new System.Drawing.Point(15, 214);
            this.generate_Button.Name = "generate_Button";
            this.generate_Button.Size = new System.Drawing.Size(101, 34);
            this.generate_Button.TabIndex = 1;
            this.generate_Button.Text = "Generate";
            this.generate_Button.UseVisualStyleBackColor = true;
            this.generate_Button.Click += new System.EventHandler(this.generate_Button_Click);
            // 
            // check_Button
            // 
            this.check_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(122, 214);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(101, 34);
            this.check_Button.TabIndex = 2;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(229, 214);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(101, 34);
            this.clear_Button.TabIndex = 3;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(336, 214);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(101, 34);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // addition_Tutor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 284);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.generate_Button);
            this.Controls.Add(this.addition_Groupbox);
            this.Name = "addition_Tutor_Form";
            this.Text = "Addition Tutor";
            this.addition_Groupbox.ResumeLayout(false);
            this.addition_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox addition_Groupbox;
        private System.Windows.Forms.TextBox answer_Textbox;
        private System.Windows.Forms.Label equal_Label;
        private System.Windows.Forms.Label addition_Label;
        private System.Windows.Forms.Button generate_Button;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
        public System.Windows.Forms.Label number2_Label;
        public System.Windows.Forms.Label number1_Label;
    }
}

