namespace Fat_Percentage_Calculator
{
    partial class Fat_Percentage_Form
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
            this.total_cal_Label = new System.Windows.Forms.Label();
            this.fat_grams_Label = new System.Windows.Forms.Label();
            this.calories_from_fat_Label = new System.Windows.Forms.Label();
            this.percentage_from_fat_Label = new System.Windows.Forms.Label();
            this.lowfat_checkBox = new System.Windows.Forms.CheckBox();
            this.lowfat_Label = new System.Windows.Forms.Label();
            this.output_cal_Label = new System.Windows.Forms.Label();
            this.output_percentage_Label = new System.Windows.Forms.Label();
            this.num_cals_Text = new System.Windows.Forms.TextBox();
            this.fatgrams_Text = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // total_cal_Label
            // 
            this.total_cal_Label.AutoSize = true;
            this.total_cal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_cal_Label.Location = new System.Drawing.Point(12, 46);
            this.total_cal_Label.Name = "total_cal_Label";
            this.total_cal_Label.Size = new System.Drawing.Size(265, 18);
            this.total_cal_Label.TabIndex = 0;
            this.total_cal_Label.Text = "Enter the total number of calories:";
            // 
            // fat_grams_Label
            // 
            this.fat_grams_Label.AutoSize = true;
            this.fat_grams_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fat_grams_Label.Location = new System.Drawing.Point(418, 46);
            this.fat_grams_Label.Name = "fat_grams_Label";
            this.fat_grams_Label.Size = new System.Drawing.Size(238, 18);
            this.fat_grams_Label.TabIndex = 1;
            this.fat_grams_Label.Text = "Enter the number of fat grams:";
            // 
            // calories_from_fat_Label
            // 
            this.calories_from_fat_Label.AutoSize = true;
            this.calories_from_fat_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calories_from_fat_Label.Location = new System.Drawing.Point(164, 236);
            this.calories_from_fat_Label.Name = "calories_from_fat_Label";
            this.calories_from_fat_Label.Size = new System.Drawing.Size(261, 18);
            this.calories_from_fat_Label.TabIndex = 2;
            this.calories_from_fat_Label.Text = "Total number of calories from fat:";
            // 
            // percentage_from_fat_Label
            // 
            this.percentage_from_fat_Label.AutoSize = true;
            this.percentage_from_fat_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentage_from_fat_Label.Location = new System.Drawing.Point(178, 292);
            this.percentage_from_fat_Label.Name = "percentage_from_fat_Label";
            this.percentage_from_fat_Label.Size = new System.Drawing.Size(247, 18);
            this.percentage_from_fat_Label.TabIndex = 3;
            this.percentage_from_fat_Label.Text = "Percentage of calories from fat:";
            // 
            // lowfat_checkBox
            // 
            this.lowfat_checkBox.AutoSize = true;
            this.lowfat_checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowfat_checkBox.Location = new System.Drawing.Point(59, 99);
            this.lowfat_checkBox.Name = "lowfat_checkBox";
            this.lowfat_checkBox.Size = new System.Drawing.Size(180, 20);
            this.lowfat_checkBox.TabIndex = 3;
            this.lowfat_checkBox.Text = "Check to see if low-fat";
            this.lowfat_checkBox.UseVisualStyleBackColor = true;
            // 
            // lowfat_Label
            // 
            this.lowfat_Label.AutoSize = true;
            this.lowfat_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowfat_Label.Location = new System.Drawing.Point(495, 238);
            this.lowfat_Label.Name = "lowfat_Label";
            this.lowfat_Label.Size = new System.Drawing.Size(0, 16);
            this.lowfat_Label.TabIndex = 5;
            // 
            // output_cal_Label
            // 
            this.output_cal_Label.AutoSize = true;
            this.output_cal_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_cal_Label.Location = new System.Drawing.Point(455, 236);
            this.output_cal_Label.Name = "output_cal_Label";
            this.output_cal_Label.Size = new System.Drawing.Size(17, 18);
            this.output_cal_Label.TabIndex = 6;
            this.output_cal_Label.Text = "0";
            // 
            // output_percentage_Label
            // 
            this.output_percentage_Label.AutoSize = true;
            this.output_percentage_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_percentage_Label.Location = new System.Drawing.Point(455, 292);
            this.output_percentage_Label.Name = "output_percentage_Label";
            this.output_percentage_Label.Size = new System.Drawing.Size(17, 18);
            this.output_percentage_Label.TabIndex = 7;
            this.output_percentage_Label.Text = "0";
            // 
            // num_cals_Text
            // 
            this.num_cals_Text.Location = new System.Drawing.Point(312, 45);
            this.num_cals_Text.Name = "num_cals_Text";
            this.num_cals_Text.Size = new System.Drawing.Size(91, 22);
            this.num_cals_Text.TabIndex = 1;
            this.num_cals_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fatgrams_Text
            // 
            this.fatgrams_Text.Location = new System.Drawing.Point(684, 45);
            this.fatgrams_Text.Name = "fatgrams_Text";
            this.fatgrams_Text.Size = new System.Drawing.Size(91, 22);
            this.fatgrams_Text.TabIndex = 2;
            this.fatgrams_Text.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(142, 152);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(97, 30);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(337, 152);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(88, 30);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(530, 152);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(88, 30);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Fat_Percentage_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 341);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.fatgrams_Text);
            this.Controls.Add(this.num_cals_Text);
            this.Controls.Add(this.output_percentage_Label);
            this.Controls.Add(this.output_cal_Label);
            this.Controls.Add(this.lowfat_Label);
            this.Controls.Add(this.lowfat_checkBox);
            this.Controls.Add(this.percentage_from_fat_Label);
            this.Controls.Add(this.calories_from_fat_Label);
            this.Controls.Add(this.fat_grams_Label);
            this.Controls.Add(this.total_cal_Label);
            this.Name = "Fat_Percentage_Form";
            this.Text = "Fat Percentage Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label total_cal_Label;
        private System.Windows.Forms.Label fat_grams_Label;
        private System.Windows.Forms.Label calories_from_fat_Label;
        private System.Windows.Forms.Label percentage_from_fat_Label;
        private System.Windows.Forms.CheckBox lowfat_checkBox;
        private System.Windows.Forms.Label lowfat_Label;
        private System.Windows.Forms.Label output_cal_Label;
        private System.Windows.Forms.Label output_percentage_Label;
        private System.Windows.Forms.TextBox num_cals_Text;
        private System.Windows.Forms.TextBox fatgrams_Text;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

