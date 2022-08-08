namespace Rock__Paper__Scissors_Game
{
    partial class rock_Paper_Scissor_Form
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
            this.choices_Groupbox = new System.Windows.Forms.GroupBox();
            this.rock_Picturebox = new System.Windows.Forms.PictureBox();
            this.paper_Picturebox = new System.Windows.Forms.PictureBox();
            this.scissor_Picturebox = new System.Windows.Forms.PictureBox();
            this.computer_Label = new System.Windows.Forms.Label();
            this.user_Label = new System.Windows.Forms.Label();
            this.comp_Textbox = new System.Windows.Forms.TextBox();
            this.user_Textbox = new System.Windows.Forms.TextBox();
            this.result_Textbox = new System.Windows.Forms.TextBox();
            this.choices_Groupbox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.rock_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_Picturebox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_Picturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // choices_Groupbox
            // 
            this.choices_Groupbox.Controls.Add(this.scissor_Picturebox);
            this.choices_Groupbox.Controls.Add(this.rock_Picturebox);
            this.choices_Groupbox.Controls.Add(this.paper_Picturebox);
            this.choices_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choices_Groupbox.Location = new System.Drawing.Point(25, 19);
            this.choices_Groupbox.Name = "choices_Groupbox";
            this.choices_Groupbox.Size = new System.Drawing.Size(600, 226);
            this.choices_Groupbox.TabIndex = 0;
            this.choices_Groupbox.TabStop = false;
            this.choices_Groupbox.Text = "Choices";
            // 
            // rock_Picturebox
            // 
            this.rock_Picturebox.Image = global::Rock__Paper__Scissors_Game.Properties.Resources.Rock;
            this.rock_Picturebox.Location = new System.Drawing.Point(32, 33);
            this.rock_Picturebox.Name = "rock_Picturebox";
            this.rock_Picturebox.Size = new System.Drawing.Size(159, 163);
            this.rock_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rock_Picturebox.TabIndex = 0;
            this.rock_Picturebox.TabStop = false;
            this.rock_Picturebox.Click += new System.EventHandler(this.rock_Picturebox_Click);
            // 
            // paper_Picturebox
            // 
            this.paper_Picturebox.Image = global::Rock__Paper__Scissors_Game.Properties.Resources.Paper;
            this.paper_Picturebox.Location = new System.Drawing.Point(220, 33);
            this.paper_Picturebox.Name = "paper_Picturebox";
            this.paper_Picturebox.Size = new System.Drawing.Size(159, 163);
            this.paper_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.paper_Picturebox.TabIndex = 1;
            this.paper_Picturebox.TabStop = false;
            this.paper_Picturebox.Click += new System.EventHandler(this.paper_Picturebox_Click);
            // 
            // scissor_Picturebox
            // 
            this.scissor_Picturebox.Image = global::Rock__Paper__Scissors_Game.Properties.Resources.Scissors;
            this.scissor_Picturebox.Location = new System.Drawing.Point(410, 33);
            this.scissor_Picturebox.Name = "scissor_Picturebox";
            this.scissor_Picturebox.Size = new System.Drawing.Size(159, 163);
            this.scissor_Picturebox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.scissor_Picturebox.TabIndex = 2;
            this.scissor_Picturebox.TabStop = false;
            this.scissor_Picturebox.Click += new System.EventHandler(this.scissor_Picturebox_Click);
            // 
            // computer_Label
            // 
            this.computer_Label.AutoSize = true;
            this.computer_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.computer_Label.Location = new System.Drawing.Point(168, 276);
            this.computer_Label.Name = "computer_Label";
            this.computer_Label.Size = new System.Drawing.Size(145, 18);
            this.computer_Label.TabIndex = 1;
            this.computer_Label.Text = "Computer Choice:";
            // 
            // user_Label
            // 
            this.user_Label.AutoSize = true;
            this.user_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.user_Label.Location = new System.Drawing.Point(206, 328);
            this.user_Label.Name = "user_Label";
            this.user_Label.Size = new System.Drawing.Size(107, 18);
            this.user_Label.TabIndex = 2;
            this.user_Label.Text = "User Choice:";
            // 
            // comp_Textbox
            // 
            this.comp_Textbox.Enabled = false;
            this.comp_Textbox.Location = new System.Drawing.Point(329, 275);
            this.comp_Textbox.Multiline = true;
            this.comp_Textbox.Name = "comp_Textbox";
            this.comp_Textbox.Size = new System.Drawing.Size(121, 26);
            this.comp_Textbox.TabIndex = 3;
            // 
            // user_Textbox
            // 
            this.user_Textbox.Enabled = false;
            this.user_Textbox.Location = new System.Drawing.Point(329, 328);
            this.user_Textbox.Multiline = true;
            this.user_Textbox.Name = "user_Textbox";
            this.user_Textbox.Size = new System.Drawing.Size(121, 26);
            this.user_Textbox.TabIndex = 4;
            // 
            // result_Textbox
            // 
            this.result_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.result_Textbox.Enabled = false;
            this.result_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_Textbox.Location = new System.Drawing.Point(148, 394);
            this.result_Textbox.Name = "result_Textbox";
            this.result_Textbox.Size = new System.Drawing.Size(325, 24);
            this.result_Textbox.TabIndex = 5;
            this.result_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rock_Paper_Scissor_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 460);
            this.Controls.Add(this.result_Textbox);
            this.Controls.Add(this.user_Textbox);
            this.Controls.Add(this.comp_Textbox);
            this.Controls.Add(this.user_Label);
            this.Controls.Add(this.computer_Label);
            this.Controls.Add(this.choices_Groupbox);
            this.Name = "rock_Paper_Scissor_Form";
            this.Text = "Rock, Paper, Scissors, Game";
            this.Load += new System.EventHandler(this.rock_Paper_Scissor_Form_Load);
            this.choices_Groupbox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.rock_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paper_Picturebox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scissor_Picturebox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox choices_Groupbox;
        private System.Windows.Forms.PictureBox scissor_Picturebox;
        private System.Windows.Forms.PictureBox rock_Picturebox;
        private System.Windows.Forms.PictureBox paper_Picturebox;
        private System.Windows.Forms.Label computer_Label;
        private System.Windows.Forms.Label user_Label;
        private System.Windows.Forms.TextBox comp_Textbox;
        private System.Windows.Forms.TextBox user_Textbox;
        private System.Windows.Forms.TextBox result_Textbox;
    }
}

