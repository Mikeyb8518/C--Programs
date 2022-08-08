namespace Random_Number_File_Reader
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
            this.numberOutput_Listbox = new System.Windows.Forms.ListBox();
            this.display_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.total_Label = new System.Windows.Forms.Label();
            this.number_Label = new System.Windows.Forms.Label();
            this.total_Output_Label = new System.Windows.Forms.Label();
            this.numbers_Read_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // numberOutput_Listbox
            // 
            this.numberOutput_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numberOutput_Listbox.FormattingEnabled = true;
            this.numberOutput_Listbox.ItemHeight = 18;
            this.numberOutput_Listbox.Location = new System.Drawing.Point(14, 20);
            this.numberOutput_Listbox.Name = "numberOutput_Listbox";
            this.numberOutput_Listbox.Size = new System.Drawing.Size(406, 166);
            this.numberOutput_Listbox.TabIndex = 0;
            // 
            // display_Button
            // 
            this.display_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Button.Location = new System.Drawing.Point(76, 290);
            this.display_Button.Name = "display_Button";
            this.display_Button.Size = new System.Drawing.Size(103, 33);
            this.display_Button.TabIndex = 1;
            this.display_Button.Text = "Display";
            this.display_Button.UseVisualStyleBackColor = true;
            this.display_Button.Click += new System.EventHandler(this.display_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(224, 290);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(103, 33);
            this.exit_Button.TabIndex = 2;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(128, 205);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 3;
            this.total_Label.Text = "Total:";
            // 
            // number_Label
            // 
            this.number_Label.AutoSize = true;
            this.number_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number_Label.Location = new System.Drawing.Point(12, 242);
            this.number_Label.Name = "number_Label";
            this.number_Label.Size = new System.Drawing.Size(179, 18);
            this.number_Label.TabIndex = 4;
            this.number_Label.Text = "Total of Number Read:";
            // 
            // total_Output_Label
            // 
            this.total_Output_Label.AutoSize = true;
            this.total_Output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Output_Label.Location = new System.Drawing.Point(197, 205);
            this.total_Output_Label.Name = "total_Output_Label";
            this.total_Output_Label.Size = new System.Drawing.Size(17, 18);
            this.total_Output_Label.TabIndex = 5;
            this.total_Output_Label.Text = "0";
            // 
            // numbers_Read_Label
            // 
            this.numbers_Read_Label.AutoSize = true;
            this.numbers_Read_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numbers_Read_Label.Location = new System.Drawing.Point(221, 242);
            this.numbers_Read_Label.Name = "numbers_Read_Label";
            this.numbers_Read_Label.Size = new System.Drawing.Size(17, 18);
            this.numbers_Read_Label.TabIndex = 6;
            this.numbers_Read_Label.Text = "0";
            // 
            // random_Number_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 349);
            this.Controls.Add(this.numbers_Read_Label);
            this.Controls.Add(this.total_Output_Label);
            this.Controls.Add(this.number_Label);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.display_Button);
            this.Controls.Add(this.numberOutput_Listbox);
            this.Name = "random_Number_Form";
            this.Text = "Random Number File Reader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox numberOutput_Listbox;
        private System.Windows.Forms.Button display_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label number_Label;
        private System.Windows.Forms.Label total_Output_Label;
        private System.Windows.Forms.Label numbers_Read_Label;
    }
}

