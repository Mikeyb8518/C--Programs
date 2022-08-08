namespace Random_Number_File_Writer
{
    partial class randomNumber_Form
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
            this.entry_Label = new System.Windows.Forms.Label();
            this.user_Entry_Textbox = new System.Windows.Forms.TextBox();
            this.save_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // entry_Label
            // 
            this.entry_Label.AutoSize = true;
            this.entry_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.entry_Label.Location = new System.Drawing.Point(12, 33);
            this.entry_Label.Name = "entry_Label";
            this.entry_Label.Size = new System.Drawing.Size(187, 18);
            this.entry_Label.TabIndex = 0;
            this.entry_Label.Text = "Please Enter a Number:";
            // 
            // user_Entry_Textbox
            // 
            this.user_Entry_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.user_Entry_Textbox.Location = new System.Drawing.Point(217, 33);
            this.user_Entry_Textbox.Name = "user_Entry_Textbox";
            this.user_Entry_Textbox.Size = new System.Drawing.Size(78, 22);
            this.user_Entry_Textbox.TabIndex = 1;
            this.user_Entry_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // save_Button
            // 
            this.save_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_Button.Location = new System.Drawing.Point(77, 104);
            this.save_Button.Name = "save_Button";
            this.save_Button.Size = new System.Drawing.Size(94, 33);
            this.save_Button.TabIndex = 2;
            this.save_Button.Text = "Save";
            this.save_Button.UseVisualStyleBackColor = true;
            this.save_Button.Click += new System.EventHandler(this.generate_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(201, 104);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(94, 33);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // randomNumber_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 177);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.save_Button);
            this.Controls.Add(this.user_Entry_Textbox);
            this.Controls.Add(this.entry_Label);
            this.Name = "randomNumber_Form";
            this.Text = "Random Number File Writer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label entry_Label;
        private System.Windows.Forms.TextBox user_Entry_Textbox;
        private System.Windows.Forms.Button save_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

