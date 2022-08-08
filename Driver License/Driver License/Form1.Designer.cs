namespace Driver_License
{
    partial class driver_License_Form
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
            this.file_Label = new System.Windows.Forms.Label();
            this.student_File_Textbox = new System.Windows.Forms.TextBox();
            this.numCorrect_Label = new System.Windows.Forms.Label();
            this.result_Label = new System.Windows.Forms.Label();
            this.output_Result_Textbox = new System.Windows.Forms.TextBox();
            this.output_NumCorrect_Label = new System.Windows.Forms.Label();
            this.NumIncorrect_Label = new System.Windows.Forms.Label();
            this.output_NumIncorrect_Label = new System.Windows.Forms.Label();
            this.incorrect_Label = new System.Windows.Forms.Label();
            this.incorrect_Listbox = new System.Windows.Forms.ListBox();
            this.check_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // file_Label
            // 
            this.file_Label.AutoSize = true;
            this.file_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.file_Label.Location = new System.Drawing.Point(12, 30);
            this.file_Label.Name = "file_Label";
            this.file_Label.Size = new System.Drawing.Size(178, 16);
            this.file_Label.TabIndex = 0;
            this.file_Label.Text = "Enter Student File Name:";
            // 
            // student_File_Textbox
            // 
            this.student_File_Textbox.Location = new System.Drawing.Point(211, 27);
            this.student_File_Textbox.Name = "student_File_Textbox";
            this.student_File_Textbox.Size = new System.Drawing.Size(186, 22);
            this.student_File_Textbox.TabIndex = 1;
            this.student_File_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numCorrect_Label
            // 
            this.numCorrect_Label.AutoSize = true;
            this.numCorrect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numCorrect_Label.Location = new System.Drawing.Point(47, 148);
            this.numCorrect_Label.Name = "numCorrect_Label";
            this.numCorrect_Label.Size = new System.Drawing.Size(119, 16);
            this.numCorrect_Label.TabIndex = 2;
            this.numCorrect_Label.Text = "Number Correct:";
            // 
            // result_Label
            // 
            this.result_Label.AutoSize = true;
            this.result_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_Label.Location = new System.Drawing.Point(47, 87);
            this.result_Label.Name = "result_Label";
            this.result_Label.Size = new System.Drawing.Size(143, 16);
            this.result_Label.TabIndex = 3;
            this.result_Label.Text = "Results (Pass/Fail):";
            // 
            // output_Result_Textbox
            // 
            this.output_Result_Textbox.Location = new System.Drawing.Point(211, 84);
            this.output_Result_Textbox.Multiline = true;
            this.output_Result_Textbox.Name = "output_Result_Textbox";
            this.output_Result_Textbox.Size = new System.Drawing.Size(104, 22);
            this.output_Result_Textbox.TabIndex = 4;
            this.output_Result_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_NumCorrect_Label
            // 
            this.output_NumCorrect_Label.AutoSize = true;
            this.output_NumCorrect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_NumCorrect_Label.Location = new System.Drawing.Point(175, 148);
            this.output_NumCorrect_Label.Name = "output_NumCorrect_Label";
            this.output_NumCorrect_Label.Size = new System.Drawing.Size(15, 16);
            this.output_NumCorrect_Label.TabIndex = 5;
            this.output_NumCorrect_Label.Text = "0";
            this.output_NumCorrect_Label.Visible = false;
            // 
            // NumIncorrect_Label
            // 
            this.NumIncorrect_Label.AutoSize = true;
            this.NumIncorrect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NumIncorrect_Label.Location = new System.Drawing.Point(278, 148);
            this.NumIncorrect_Label.Name = "NumIncorrect_Label";
            this.NumIncorrect_Label.Size = new System.Drawing.Size(129, 16);
            this.NumIncorrect_Label.TabIndex = 6;
            this.NumIncorrect_Label.Text = "Number Incorrect:";
            // 
            // output_NumIncorrect_Label
            // 
            this.output_NumIncorrect_Label.AutoSize = true;
            this.output_NumIncorrect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_NumIncorrect_Label.Location = new System.Drawing.Point(424, 148);
            this.output_NumIncorrect_Label.Name = "output_NumIncorrect_Label";
            this.output_NumIncorrect_Label.Size = new System.Drawing.Size(15, 16);
            this.output_NumIncorrect_Label.TabIndex = 7;
            this.output_NumIncorrect_Label.Text = "0";
            this.output_NumIncorrect_Label.Visible = false;
            // 
            // incorrect_Label
            // 
            this.incorrect_Label.AutoSize = true;
            this.incorrect_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.incorrect_Label.Location = new System.Drawing.Point(56, 203);
            this.incorrect_Label.Name = "incorrect_Label";
            this.incorrect_Label.Size = new System.Drawing.Size(134, 16);
            this.incorrect_Label.TabIndex = 8;
            this.incorrect_Label.Text = "Questions Missed:";
            // 
            // incorrect_Listbox
            // 
            this.incorrect_Listbox.FormattingEnabled = true;
            this.incorrect_Listbox.ItemHeight = 16;
            this.incorrect_Listbox.Location = new System.Drawing.Point(211, 203);
            this.incorrect_Listbox.Name = "incorrect_Listbox";
            this.incorrect_Listbox.Size = new System.Drawing.Size(139, 84);
            this.incorrect_Listbox.TabIndex = 9;
            // 
            // check_Button
            // 
            this.check_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(52, 349);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(96, 32);
            this.check_Button.TabIndex = 10;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(211, 349);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(96, 32);
            this.clear_Button.TabIndex = 11;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(377, 349);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(96, 32);
            this.exit_Button.TabIndex = 12;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // driver_License_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(544, 400);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.incorrect_Listbox);
            this.Controls.Add(this.incorrect_Label);
            this.Controls.Add(this.output_NumIncorrect_Label);
            this.Controls.Add(this.NumIncorrect_Label);
            this.Controls.Add(this.output_NumCorrect_Label);
            this.Controls.Add(this.output_Result_Textbox);
            this.Controls.Add(this.result_Label);
            this.Controls.Add(this.numCorrect_Label);
            this.Controls.Add(this.student_File_Textbox);
            this.Controls.Add(this.file_Label);
            this.Name = "driver_License_Form";
            this.Text = "Driver License Exam";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label file_Label;
        private System.Windows.Forms.TextBox student_File_Textbox;
        private System.Windows.Forms.Label numCorrect_Label;
        private System.Windows.Forms.Label result_Label;
        private System.Windows.Forms.TextBox output_Result_Textbox;
        private System.Windows.Forms.Label output_NumCorrect_Label;
        private System.Windows.Forms.Label NumIncorrect_Label;
        private System.Windows.Forms.Label output_NumIncorrect_Label;
        private System.Windows.Forms.Label incorrect_Label;
        private System.Windows.Forms.ListBox incorrect_Listbox;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

