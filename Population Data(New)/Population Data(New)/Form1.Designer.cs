namespace Population_Data_New_
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
            this.population_Groupbox = new System.Windows.Forms.GroupBox();
            this.output_LeastIncrease_Label = new System.Windows.Forms.Label();
            this.output_GreatIncrease_Label = new System.Windows.Forms.Label();
            this.output_Average_Label = new System.Windows.Forms.Label();
            this.leastIncrease_Label = new System.Windows.Forms.Label();
            this.greatestIncrease_Label = new System.Windows.Forms.Label();
            this.average_Label = new System.Windows.Forms.Label();
            this.read_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.population_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // population_Groupbox
            // 
            this.population_Groupbox.Controls.Add(this.output_LeastIncrease_Label);
            this.population_Groupbox.Controls.Add(this.output_GreatIncrease_Label);
            this.population_Groupbox.Controls.Add(this.output_Average_Label);
            this.population_Groupbox.Controls.Add(this.leastIncrease_Label);
            this.population_Groupbox.Controls.Add(this.greatestIncrease_Label);
            this.population_Groupbox.Controls.Add(this.average_Label);
            this.population_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.population_Groupbox.Location = new System.Drawing.Point(20, 23);
            this.population_Groupbox.Name = "population_Groupbox";
            this.population_Groupbox.Size = new System.Drawing.Size(323, 222);
            this.population_Groupbox.TabIndex = 0;
            this.population_Groupbox.TabStop = false;
            this.population_Groupbox.Text = "US Population Growth From 1950-1990";
            // 
            // output_LeastIncrease_Label
            // 
            this.output_LeastIncrease_Label.AutoSize = true;
            this.output_LeastIncrease_Label.Location = new System.Drawing.Point(172, 175);
            this.output_LeastIncrease_Label.Name = "output_LeastIncrease_Label";
            this.output_LeastIncrease_Label.Size = new System.Drawing.Size(15, 16);
            this.output_LeastIncrease_Label.TabIndex = 5;
            this.output_LeastIncrease_Label.Text = "0";
            this.output_LeastIncrease_Label.Visible = false;
            // 
            // output_GreatIncrease_Label
            // 
            this.output_GreatIncrease_Label.AutoSize = true;
            this.output_GreatIncrease_Label.Location = new System.Drawing.Point(172, 112);
            this.output_GreatIncrease_Label.Name = "output_GreatIncrease_Label";
            this.output_GreatIncrease_Label.Size = new System.Drawing.Size(15, 16);
            this.output_GreatIncrease_Label.TabIndex = 4;
            this.output_GreatIncrease_Label.Text = "0";
            this.output_GreatIncrease_Label.Visible = false;
            // 
            // output_Average_Label
            // 
            this.output_Average_Label.AutoSize = true;
            this.output_Average_Label.Location = new System.Drawing.Point(172, 46);
            this.output_Average_Label.Name = "output_Average_Label";
            this.output_Average_Label.Size = new System.Drawing.Size(15, 16);
            this.output_Average_Label.TabIndex = 3;
            this.output_Average_Label.Text = "0";
            this.output_Average_Label.Visible = false;
            // 
            // leastIncrease_Label
            // 
            this.leastIncrease_Label.AutoSize = true;
            this.leastIncrease_Label.Location = new System.Drawing.Point(27, 175);
            this.leastIncrease_Label.Name = "leastIncrease_Label";
            this.leastIncrease_Label.Size = new System.Drawing.Size(113, 16);
            this.leastIncrease_Label.TabIndex = 2;
            this.leastIncrease_Label.Text = "Least Increase:";
            // 
            // greatestIncrease_Label
            // 
            this.greatestIncrease_Label.AutoSize = true;
            this.greatestIncrease_Label.Location = new System.Drawing.Point(19, 112);
            this.greatestIncrease_Label.Name = "greatestIncrease_Label";
            this.greatestIncrease_Label.Size = new System.Drawing.Size(134, 16);
            this.greatestIncrease_Label.TabIndex = 1;
            this.greatestIncrease_Label.Text = "Greatest Increase:";
            // 
            // average_Label
            // 
            this.average_Label.AutoSize = true;
            this.average_Label.Location = new System.Drawing.Point(19, 46);
            this.average_Label.Name = "average_Label";
            this.average_Label.Size = new System.Drawing.Size(121, 16);
            this.average_Label.TabIndex = 0;
            this.average_Label.Text = "Average Growth:";
            // 
            // read_Button
            // 
            this.read_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.read_Button.Location = new System.Drawing.Point(50, 251);
            this.read_Button.Name = "read_Button";
            this.read_Button.Size = new System.Drawing.Size(100, 33);
            this.read_Button.TabIndex = 1;
            this.read_Button.Text = "Read";
            this.read_Button.UseVisualStyleBackColor = true;
            this.read_Button.Click += new System.EventHandler(this.read_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(195, 251);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(100, 33);
            this.exit_Button.TabIndex = 2;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // population_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(365, 304);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.read_Button);
            this.Controls.Add(this.population_Groupbox);
            this.Name = "population_Form";
            this.Text = "US Population";
            this.Load += new System.EventHandler(this.population_Form_Load);
            this.population_Groupbox.ResumeLayout(false);
            this.population_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox population_Groupbox;
        private System.Windows.Forms.Label output_LeastIncrease_Label;
        private System.Windows.Forms.Label output_GreatIncrease_Label;
        private System.Windows.Forms.Label output_Average_Label;
        private System.Windows.Forms.Label leastIncrease_Label;
        private System.Windows.Forms.Label greatestIncrease_Label;
        private System.Windows.Forms.Label average_Label;
        private System.Windows.Forms.Button read_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

