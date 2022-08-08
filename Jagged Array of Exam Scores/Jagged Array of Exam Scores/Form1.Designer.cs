namespace Jagged_Array_of_Exam_Scores
{
    partial class jagged_Exam_Scores_Form
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
            this.scores_Groupbox = new System.Windows.Forms.GroupBox();
            this.exam1_Listbox = new System.Windows.Forms.ListBox();
            this.exam2_Listbox = new System.Windows.Forms.ListBox();
            this.exam3_Listbox = new System.Windows.Forms.ListBox();
            this.average1_Label = new System.Windows.Forms.Label();
            this.average2_Label = new System.Windows.Forms.Label();
            this.average3_Label = new System.Windows.Forms.Label();
            this.output_Average1_Label = new System.Windows.Forms.Label();
            this.output_Average2_Label = new System.Windows.Forms.Label();
            this.output_Average3_Label = new System.Windows.Forms.Label();
            this.total_Average_Label = new System.Windows.Forms.Label();
            this.output_TotalAvg_Label = new System.Windows.Forms.Label();
            this.highest_Label = new System.Windows.Forms.Label();
            this.output_Hightest_Label = new System.Windows.Forms.Label();
            this.lowest_Label = new System.Windows.Forms.Label();
            this.output_Lowest_Label = new System.Windows.Forms.Label();
            this.average_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.scores_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // scores_Groupbox
            // 
            this.scores_Groupbox.Controls.Add(this.exit_Button);
            this.scores_Groupbox.Controls.Add(this.average_Button);
            this.scores_Groupbox.Controls.Add(this.exam3_Listbox);
            this.scores_Groupbox.Controls.Add(this.exam2_Listbox);
            this.scores_Groupbox.Controls.Add(this.exam1_Listbox);
            this.scores_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scores_Groupbox.Location = new System.Drawing.Point(12, 16);
            this.scores_Groupbox.Name = "scores_Groupbox";
            this.scores_Groupbox.Size = new System.Drawing.Size(547, 324);
            this.scores_Groupbox.TabIndex = 0;
            this.scores_Groupbox.TabStop = false;
            this.scores_Groupbox.Text = "Exam Scores";
            // 
            // exam1_Listbox
            // 
            this.exam1_Listbox.FormattingEnabled = true;
            this.exam1_Listbox.ItemHeight = 18;
            this.exam1_Listbox.Location = new System.Drawing.Point(9, 33);
            this.exam1_Listbox.Name = "exam1_Listbox";
            this.exam1_Listbox.Size = new System.Drawing.Size(165, 202);
            this.exam1_Listbox.TabIndex = 0;
            // 
            // exam2_Listbox
            // 
            this.exam2_Listbox.FormattingEnabled = true;
            this.exam2_Listbox.ItemHeight = 18;
            this.exam2_Listbox.Location = new System.Drawing.Point(191, 33);
            this.exam2_Listbox.Name = "exam2_Listbox";
            this.exam2_Listbox.Size = new System.Drawing.Size(165, 202);
            this.exam2_Listbox.TabIndex = 1;
            // 
            // exam3_Listbox
            // 
            this.exam3_Listbox.FormattingEnabled = true;
            this.exam3_Listbox.ItemHeight = 18;
            this.exam3_Listbox.Location = new System.Drawing.Point(371, 33);
            this.exam3_Listbox.Name = "exam3_Listbox";
            this.exam3_Listbox.Size = new System.Drawing.Size(165, 202);
            this.exam3_Listbox.TabIndex = 2;
            // 
            // average1_Label
            // 
            this.average1_Label.AutoSize = true;
            this.average1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average1_Label.Location = new System.Drawing.Point(582, 40);
            this.average1_Label.Name = "average1_Label";
            this.average1_Label.Size = new System.Drawing.Size(147, 16);
            this.average1_Label.TabIndex = 3;
            this.average1_Label.Text = "Average For Exam1:";
            // 
            // average2_Label
            // 
            this.average2_Label.AutoSize = true;
            this.average2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average2_Label.Location = new System.Drawing.Point(582, 91);
            this.average2_Label.Name = "average2_Label";
            this.average2_Label.Size = new System.Drawing.Size(147, 16);
            this.average2_Label.TabIndex = 4;
            this.average2_Label.Text = "Average For Exam2:";
            // 
            // average3_Label
            // 
            this.average3_Label.AutoSize = true;
            this.average3_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average3_Label.Location = new System.Drawing.Point(582, 140);
            this.average3_Label.Name = "average3_Label";
            this.average3_Label.Size = new System.Drawing.Size(147, 16);
            this.average3_Label.TabIndex = 5;
            this.average3_Label.Text = "Average For Exam3:";
            // 
            // output_Average1_Label
            // 
            this.output_Average1_Label.AutoSize = true;
            this.output_Average1_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Average1_Label.Location = new System.Drawing.Point(736, 40);
            this.output_Average1_Label.Name = "output_Average1_Label";
            this.output_Average1_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Average1_Label.TabIndex = 6;
            this.output_Average1_Label.Text = "0";
            this.output_Average1_Label.Visible = false;
            // 
            // output_Average2_Label
            // 
            this.output_Average2_Label.AutoSize = true;
            this.output_Average2_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Average2_Label.Location = new System.Drawing.Point(736, 89);
            this.output_Average2_Label.Name = "output_Average2_Label";
            this.output_Average2_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Average2_Label.TabIndex = 7;
            this.output_Average2_Label.Text = "0";
            this.output_Average2_Label.Visible = false;
            // 
            // output_Average3_Label
            // 
            this.output_Average3_Label.AutoSize = true;
            this.output_Average3_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Average3_Label.Location = new System.Drawing.Point(736, 138);
            this.output_Average3_Label.Name = "output_Average3_Label";
            this.output_Average3_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Average3_Label.TabIndex = 8;
            this.output_Average3_Label.Text = "0";
            this.output_Average3_Label.Visible = false;
            // 
            // total_Average_Label
            // 
            this.total_Average_Label.AutoSize = true;
            this.total_Average_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Average_Label.Location = new System.Drawing.Point(619, 193);
            this.total_Average_Label.Name = "total_Average_Label";
            this.total_Average_Label.Size = new System.Drawing.Size(110, 16);
            this.total_Average_Label.TabIndex = 5;
            this.total_Average_Label.Text = "Total Average:";
            // 
            // output_TotalAvg_Label
            // 
            this.output_TotalAvg_Label.AutoSize = true;
            this.output_TotalAvg_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_TotalAvg_Label.Location = new System.Drawing.Point(736, 193);
            this.output_TotalAvg_Label.Name = "output_TotalAvg_Label";
            this.output_TotalAvg_Label.Size = new System.Drawing.Size(17, 18);
            this.output_TotalAvg_Label.TabIndex = 7;
            this.output_TotalAvg_Label.Text = "0";
            this.output_TotalAvg_Label.Visible = false;
            // 
            // highest_Label
            // 
            this.highest_Label.AutoSize = true;
            this.highest_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highest_Label.Location = new System.Drawing.Point(578, 245);
            this.highest_Label.Name = "highest_Label";
            this.highest_Label.Size = new System.Drawing.Size(151, 16);
            this.highest_Label.TabIndex = 8;
            this.highest_Label.Text = "Highest Exam Score:";
            // 
            // output_Hightest_Label
            // 
            this.output_Hightest_Label.AutoSize = true;
            this.output_Hightest_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Hightest_Label.Location = new System.Drawing.Point(749, 245);
            this.output_Hightest_Label.Name = "output_Hightest_Label";
            this.output_Hightest_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Hightest_Label.TabIndex = 9;
            this.output_Hightest_Label.Text = "0";
            this.output_Hightest_Label.Visible = false;
            // 
            // lowest_Label
            // 
            this.lowest_Label.AutoSize = true;
            this.lowest_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowest_Label.Location = new System.Drawing.Point(583, 299);
            this.lowest_Label.Name = "lowest_Label";
            this.lowest_Label.Size = new System.Drawing.Size(146, 16);
            this.lowest_Label.TabIndex = 10;
            this.lowest_Label.Text = "Lowest Exam Score:";
            // 
            // output_Lowest_Label
            // 
            this.output_Lowest_Label.AutoSize = true;
            this.output_Lowest_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Lowest_Label.Location = new System.Drawing.Point(749, 297);
            this.output_Lowest_Label.Name = "output_Lowest_Label";
            this.output_Lowest_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Lowest_Label.TabIndex = 11;
            this.output_Lowest_Label.Text = "0";
            this.output_Lowest_Label.Visible = false;
            // 
            // average_Button
            // 
            this.average_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.average_Button.Location = new System.Drawing.Point(121, 258);
            this.average_Button.Name = "average_Button";
            this.average_Button.Size = new System.Drawing.Size(116, 41);
            this.average_Button.TabIndex = 3;
            this.average_Button.Text = "Get Average";
            this.average_Button.UseVisualStyleBackColor = true;
            this.average_Button.Click += new System.EventHandler(this.average_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(304, 258);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(116, 41);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // jagged_Exam_Scores_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 367);
            this.Controls.Add(this.output_Average1_Label);
            this.Controls.Add(this.output_Average3_Label);
            this.Controls.Add(this.average1_Label);
            this.Controls.Add(this.output_Lowest_Label);
            this.Controls.Add(this.output_Average2_Label);
            this.Controls.Add(this.average3_Label);
            this.Controls.Add(this.lowest_Label);
            this.Controls.Add(this.output_Hightest_Label);
            this.Controls.Add(this.highest_Label);
            this.Controls.Add(this.average2_Label);
            this.Controls.Add(this.output_TotalAvg_Label);
            this.Controls.Add(this.total_Average_Label);
            this.Controls.Add(this.scores_Groupbox);
            this.Name = "jagged_Exam_Scores_Form";
            this.Text = "Exam Scores";
            this.Load += new System.EventHandler(this.jagged_Exam_Scores_Form_Load);
            this.scores_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox scores_Groupbox;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Button average_Button;
        private System.Windows.Forms.ListBox exam3_Listbox;
        private System.Windows.Forms.ListBox exam2_Listbox;
        private System.Windows.Forms.ListBox exam1_Listbox;
        private System.Windows.Forms.Label average1_Label;
        private System.Windows.Forms.Label average2_Label;
        private System.Windows.Forms.Label average3_Label;
        private System.Windows.Forms.Label output_Average1_Label;
        private System.Windows.Forms.Label output_Average2_Label;
        private System.Windows.Forms.Label output_Average3_Label;
        private System.Windows.Forms.Label total_Average_Label;
        private System.Windows.Forms.Label output_TotalAvg_Label;
        private System.Windows.Forms.Label highest_Label;
        private System.Windows.Forms.Label output_Hightest_Label;
        private System.Windows.Forms.Label lowest_Label;
        private System.Windows.Forms.Label output_Lowest_Label;
    }
}

