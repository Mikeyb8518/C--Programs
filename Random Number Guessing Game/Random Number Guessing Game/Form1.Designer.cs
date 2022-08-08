namespace Random_Number_Guessing_Game
{
    partial class random_Number_Form
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
            this.guess_Groupbox = new System.Windows.Forms.GroupBox();
            this.random_Number_Label = new System.Windows.Forms.Label();
            this.user_Guess_Label = new System.Windows.Forms.Label();
            this.user_Answer_Textbox = new System.Windows.Forms.TextBox();
            this.answer_Label = new System.Windows.Forms.Label();
            this.check_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.guess_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // guess_Groupbox
            // 
            this.guess_Groupbox.Controls.Add(this.answer_Label);
            this.guess_Groupbox.Controls.Add(this.random_Number_Label);
            this.guess_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guess_Groupbox.Location = new System.Drawing.Point(29, 21);
            this.guess_Groupbox.Name = "guess_Groupbox";
            this.guess_Groupbox.Size = new System.Drawing.Size(290, 197);
            this.guess_Groupbox.TabIndex = 0;
            this.guess_Groupbox.TabStop = false;
            this.guess_Groupbox.Text = "Random Number";
            // 
            // random_Number_Label
            // 
            this.random_Number_Label.AutoSize = true;
            this.random_Number_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.random_Number_Label.Location = new System.Drawing.Point(90, 50);
            this.random_Number_Label.Name = "random_Number_Label";
            this.random_Number_Label.Size = new System.Drawing.Size(84, 91);
            this.random_Number_Label.TabIndex = 0;
            this.random_Number_Label.Text = "0";
            this.random_Number_Label.Visible = false;
            // 
            // user_Guess_Label
            // 
            this.user_Guess_Label.AutoSize = true;
            this.user_Guess_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Guess_Label.Location = new System.Drawing.Point(15, 238);
            this.user_Guess_Label.Name = "user_Guess_Label";
            this.user_Guess_Label.Size = new System.Drawing.Size(203, 18);
            this.user_Guess_Label.TabIndex = 1;
            this.user_Guess_Label.Text = "Please Enter Your Guess:";
            // 
            // user_Answer_Textbox
            // 
            this.user_Answer_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Answer_Textbox.Location = new System.Drawing.Point(244, 238);
            this.user_Answer_Textbox.Name = "user_Answer_Textbox";
            this.user_Answer_Textbox.Size = new System.Drawing.Size(84, 24);
            this.user_Answer_Textbox.TabIndex = 2;
            this.user_Answer_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // answer_Label
            // 
            this.answer_Label.AutoSize = true;
            this.answer_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.answer_Label.Location = new System.Drawing.Point(117, 166);
            this.answer_Label.Name = "answer_Label";
            this.answer_Label.Size = new System.Drawing.Size(57, 16);
            this.answer_Label.TabIndex = 1;
            this.answer_Label.Text = "Answer";
            this.answer_Label.Visible = false;
            // 
            // check_Button
            // 
            this.check_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(64, 281);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(90, 28);
            this.check_Button.TabIndex = 5;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(184, 281);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(90, 28);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // random_Number_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 327);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.user_Answer_Textbox);
            this.Controls.Add(this.user_Guess_Label);
            this.Controls.Add(this.guess_Groupbox);
            this.Name = "random_Number_Form";
            this.Text = "Random Number Guessing Game";
            this.Load += new System.EventHandler(this.random_Number_Form_Load);
            this.guess_Groupbox.ResumeLayout(false);
            this.guess_Groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox guess_Groupbox;
        private System.Windows.Forms.Label user_Guess_Label;
        private System.Windows.Forms.Label answer_Label;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button exit_Button;
        protected System.Windows.Forms.Label random_Number_Label;
        public System.Windows.Forms.TextBox user_Answer_Textbox;
    }
}

