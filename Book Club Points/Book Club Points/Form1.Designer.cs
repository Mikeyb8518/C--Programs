namespace Book_Club_Points
{
    partial class bookClub_Form
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
            this.book_Bought_Label = new System.Windows.Forms.Label();
            this.bought_Textbox = new System.Windows.Forms.TextBox();
            this.points_Label = new System.Windows.Forms.Label();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // book_Bought_Label
            // 
            this.book_Bought_Label.AutoSize = true;
            this.book_Bought_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.book_Bought_Label.Location = new System.Drawing.Point(46, 77);
            this.book_Bought_Label.Name = "book_Bought_Label";
            this.book_Bought_Label.Size = new System.Drawing.Size(353, 18);
            this.book_Bought_Label.TabIndex = 0;
            this.book_Bought_Label.Text = "Please enter the number of Books purchased:";
            // 
            // bought_Textbox
            // 
            this.bought_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bought_Textbox.Location = new System.Drawing.Point(442, 76);
            this.bought_Textbox.Name = "bought_Textbox";
            this.bought_Textbox.Size = new System.Drawing.Size(130, 24);
            this.bought_Textbox.TabIndex = 1;
            this.bought_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // points_Label
            // 
            this.points_Label.AutoSize = true;
            this.points_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.points_Label.Location = new System.Drawing.Point(224, 195);
            this.points_Label.Name = "points_Label";
            this.points_Label.Size = new System.Drawing.Size(175, 18);
            this.points_Label.TabIndex = 2;
            this.points_Label.Text = "Total Points Available:";
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Textbox.Location = new System.Drawing.Point(442, 192);
            this.total_Textbox.Multiline = true;
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(104, 30);
            this.total_Textbox.TabIndex = 3;
            this.total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(49, 305);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(110, 36);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(236, 305);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(110, 36);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(418, 305);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(110, 36);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // bookClub_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 390);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_Textbox);
            this.Controls.Add(this.points_Label);
            this.Controls.Add(this.bought_Textbox);
            this.Controls.Add(this.book_Bought_Label);
            this.Name = "bookClub_Form";
            this.Text = "Book Club Points";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label book_Bought_Label;
        private System.Windows.Forms.TextBox bought_Textbox;
        private System.Windows.Forms.Label points_Label;
        private System.Windows.Forms.TextBox total_Textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

