namespace Calories_from_Fat_and_Carbohydrates
{
    partial class Calories_Fat_Carbs_Form
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
            this.calories_Groupbox = new System.Windows.Forms.GroupBox();
            this.fatGrams_Label = new System.Windows.Forms.Label();
            this.carbsGrams_Label = new System.Windows.Forms.Label();
            this.fatGrams_Textbox = new System.Windows.Forms.TextBox();
            this.carbs_Textbox = new System.Windows.Forms.TextBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.output_Label = new System.Windows.Forms.Label();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.calories_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // calories_Groupbox
            // 
            this.calories_Groupbox.Controls.Add(this.output_Label);
            this.calories_Groupbox.Controls.Add(this.total_Label);
            this.calories_Groupbox.Controls.Add(this.carbs_Textbox);
            this.calories_Groupbox.Controls.Add(this.fatGrams_Textbox);
            this.calories_Groupbox.Controls.Add(this.carbsGrams_Label);
            this.calories_Groupbox.Controls.Add(this.fatGrams_Label);
            this.calories_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calories_Groupbox.Location = new System.Drawing.Point(25, 19);
            this.calories_Groupbox.Name = "calories_Groupbox";
            this.calories_Groupbox.Size = new System.Drawing.Size(395, 212);
            this.calories_Groupbox.TabIndex = 0;
            this.calories_Groupbox.TabStop = false;
            this.calories_Groupbox.Text = "Calories From Fat and Carbs";
            // 
            // fatGrams_Label
            // 
            this.fatGrams_Label.AutoSize = true;
            this.fatGrams_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatGrams_Label.Location = new System.Drawing.Point(29, 45);
            this.fatGrams_Label.Name = "fatGrams_Label";
            this.fatGrams_Label.Size = new System.Drawing.Size(197, 16);
            this.fatGrams_Label.TabIndex = 1;
            this.fatGrams_Label.Text = "Enter Number of Fat Grams:";
            // 
            // carbsGrams_Label
            // 
            this.carbsGrams_Label.AutoSize = true;
            this.carbsGrams_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.carbsGrams_Label.Location = new System.Drawing.Point(29, 98);
            this.carbsGrams_Label.Name = "carbsGrams_Label";
            this.carbsGrams_Label.Size = new System.Drawing.Size(216, 16);
            this.carbsGrams_Label.TabIndex = 2;
            this.carbsGrams_Label.Text = "Enter Number of Carbs Grams:";
            // 
            // fatGrams_Textbox
            // 
            this.fatGrams_Textbox.Location = new System.Drawing.Point(251, 40);
            this.fatGrams_Textbox.Name = "fatGrams_Textbox";
            this.fatGrams_Textbox.Size = new System.Drawing.Size(83, 24);
            this.fatGrams_Textbox.TabIndex = 1;
            this.fatGrams_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // carbs_Textbox
            // 
            this.carbs_Textbox.Location = new System.Drawing.Point(267, 93);
            this.carbs_Textbox.Name = "carbs_Textbox";
            this.carbs_Textbox.Size = new System.Drawing.Size(83, 24);
            this.carbs_Textbox.TabIndex = 2;
            this.carbs_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Location = new System.Drawing.Point(83, 165);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(119, 18);
            this.total_Label.TabIndex = 3;
            this.total_Label.Text = "Total Calories:";
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Location = new System.Drawing.Point(219, 165);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(17, 18);
            this.output_Label.TabIndex = 4;
            this.output_Label.Text = "0";
            this.output_Label.Visible = false;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(40, 251);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(103, 32);
            this.calculate_Button.TabIndex = 3;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(176, 251);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(103, 32);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(306, 251);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(103, 32);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Calories_Fat_Carbs_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 308);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.calories_Groupbox);
            this.Name = "Calories_Fat_Carbs_Form";
            this.Text = "Calories From Fat and Carbs";
            this.calories_Groupbox.ResumeLayout(false);
            this.calories_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox calories_Groupbox;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox carbs_Textbox;
        private System.Windows.Forms.TextBox fatGrams_Textbox;
        private System.Windows.Forms.Label carbsGrams_Label;
        private System.Windows.Forms.Label fatGrams_Label;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

