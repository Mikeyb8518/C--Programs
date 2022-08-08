namespace Population
{
    partial class population_Form
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
            this.startingNumber_Label = new System.Windows.Forms.Label();
            this.dailyIncrease_Label = new System.Windows.Forms.Label();
            this.daysMultiply_Label = new System.Windows.Forms.Label();
            this.output_Listbox = new System.Windows.Forms.ListBox();
            this.days_Label = new System.Windows.Forms.Label();
            this.population_Label = new System.Windows.Forms.Label();
            this.startingNumber_Textbox = new System.Windows.Forms.TextBox();
            this.dailyIncrease_Textbox = new System.Windows.Forms.TextBox();
            this.days_Textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startingNumber_Label
            // 
            this.startingNumber_Label.AutoSize = true;
            this.startingNumber_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startingNumber_Label.Location = new System.Drawing.Point(12, 100);
            this.startingNumber_Label.Name = "startingNumber_Label";
            this.startingNumber_Label.Size = new System.Drawing.Size(236, 18);
            this.startingNumber_Label.TabIndex = 0;
            this.startingNumber_Label.Text = "Starting number of organisms:";
            // 
            // dailyIncrease_Label
            // 
            this.dailyIncrease_Label.AutoSize = true;
            this.dailyIncrease_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dailyIncrease_Label.Location = new System.Drawing.Point(67, 185);
            this.dailyIncrease_Label.Name = "dailyIncrease_Label";
            this.dailyIncrease_Label.Size = new System.Drawing.Size(181, 18);
            this.dailyIncrease_Label.TabIndex = 1;
            this.dailyIncrease_Label.Text = "Average daily increase:";
            // 
            // daysMultiply_Label
            // 
            this.daysMultiply_Label.AutoSize = true;
            this.daysMultiply_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.daysMultiply_Label.Location = new System.Drawing.Point(34, 276);
            this.daysMultiply_Label.Name = "daysMultiply_Label";
            this.daysMultiply_Label.Size = new System.Drawing.Size(214, 18);
            this.daysMultiply_Label.TabIndex = 2;
            this.daysMultiply_Label.Text = "Number of days to multiply:";
            // 
            // output_Listbox
            // 
            this.output_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Listbox.FormattingEnabled = true;
            this.output_Listbox.ItemHeight = 20;
            this.output_Listbox.Location = new System.Drawing.Point(455, 45);
            this.output_Listbox.Name = "output_Listbox";
            this.output_Listbox.Size = new System.Drawing.Size(380, 364);
            this.output_Listbox.TabIndex = 3;
            // 
            // days_Label
            // 
            this.days_Label.AutoSize = true;
            this.days_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.days_Label.Location = new System.Drawing.Point(451, 22);
            this.days_Label.Name = "days_Label";
            this.days_Label.Size = new System.Drawing.Size(52, 20);
            this.days_Label.TabIndex = 4;
            this.days_Label.Text = "Days";
            // 
            // population_Label
            // 
            this.population_Label.AutoSize = true;
            this.population_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_Label.Location = new System.Drawing.Point(588, 22);
            this.population_Label.Name = "population_Label";
            this.population_Label.Size = new System.Drawing.Size(207, 20);
            this.population_Label.TabIndex = 5;
            this.population_Label.Text = "Approximate Population";
            // 
            // startingNumber_Textbox
            // 
            this.startingNumber_Textbox.Location = new System.Drawing.Point(283, 99);
            this.startingNumber_Textbox.Name = "startingNumber_Textbox";
            this.startingNumber_Textbox.Size = new System.Drawing.Size(131, 22);
            this.startingNumber_Textbox.TabIndex = 1;
            this.startingNumber_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dailyIncrease_Textbox
            // 
            this.dailyIncrease_Textbox.Location = new System.Drawing.Point(283, 184);
            this.dailyIncrease_Textbox.Name = "dailyIncrease_Textbox";
            this.dailyIncrease_Textbox.Size = new System.Drawing.Size(131, 22);
            this.dailyIncrease_Textbox.TabIndex = 2;
            this.dailyIncrease_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // days_Textbox
            // 
            this.days_Textbox.Location = new System.Drawing.Point(283, 272);
            this.days_Textbox.Name = "days_Textbox";
            this.days_Textbox.Size = new System.Drawing.Size(131, 22);
            this.days_Textbox.TabIndex = 3;
            this.days_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(28, 373);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(103, 30);
            this.calculate_Button.TabIndex = 4;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(175, 373);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(96, 30);
            this.clear_Button.TabIndex = 5;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(318, 373);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(96, 30);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // population_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 435);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.days_Textbox);
            this.Controls.Add(this.dailyIncrease_Textbox);
            this.Controls.Add(this.startingNumber_Textbox);
            this.Controls.Add(this.population_Label);
            this.Controls.Add(this.days_Label);
            this.Controls.Add(this.output_Listbox);
            this.Controls.Add(this.daysMultiply_Label);
            this.Controls.Add(this.dailyIncrease_Label);
            this.Controls.Add(this.startingNumber_Label);
            this.Name = "population_Form";
            this.Text = "Population";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label startingNumber_Label;
        private System.Windows.Forms.Label dailyIncrease_Label;
        private System.Windows.Forms.Label daysMultiply_Label;
        private System.Windows.Forms.ListBox output_Listbox;
        private System.Windows.Forms.Label days_Label;
        private System.Windows.Forms.Label population_Label;
        private System.Windows.Forms.TextBox startingNumber_Textbox;
        private System.Windows.Forms.TextBox dailyIncrease_Textbox;
        private System.Windows.Forms.TextBox days_Textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

