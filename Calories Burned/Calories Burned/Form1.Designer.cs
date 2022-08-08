namespace Calories_Burned
{
    partial class caloriesBurned_Form
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
            this.caloriesBurned_Groupbox = new System.Windows.Forms.GroupBox();
            this.caloriesBurned_Listbox = new System.Windows.Forms.ListBox();
            this.display_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.caloriesBurned_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // caloriesBurned_Groupbox
            // 
            this.caloriesBurned_Groupbox.Controls.Add(this.caloriesBurned_Listbox);
            this.caloriesBurned_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesBurned_Groupbox.Location = new System.Drawing.Point(16, 25);
            this.caloriesBurned_Groupbox.Name = "caloriesBurned_Groupbox";
            this.caloriesBurned_Groupbox.Size = new System.Drawing.Size(511, 201);
            this.caloriesBurned_Groupbox.TabIndex = 0;
            this.caloriesBurned_Groupbox.TabStop = false;
            this.caloriesBurned_Groupbox.Text = "Calories Burned on Treadmill";
            // 
            // caloriesBurned_Listbox
            // 
            this.caloriesBurned_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.caloriesBurned_Listbox.FormattingEnabled = true;
            this.caloriesBurned_Listbox.ItemHeight = 18;
            this.caloriesBurned_Listbox.Location = new System.Drawing.Point(10, 29);
            this.caloriesBurned_Listbox.Name = "caloriesBurned_Listbox";
            this.caloriesBurned_Listbox.Size = new System.Drawing.Size(485, 148);
            this.caloriesBurned_Listbox.TabIndex = 0;
            // 
            // display_Button
            // 
            this.display_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Button.Location = new System.Drawing.Point(83, 232);
            this.display_Button.Name = "display_Button";
            this.display_Button.Size = new System.Drawing.Size(95, 31);
            this.display_Button.TabIndex = 1;
            this.display_Button.Text = "Display";
            this.display_Button.UseVisualStyleBackColor = true;
            this.display_Button.Click += new System.EventHandler(this.display_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(224, 232);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(95, 31);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(369, 232);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(95, 31);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // caloriesBurned_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(539, 291);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.display_Button);
            this.Controls.Add(this.caloriesBurned_Groupbox);
            this.Name = "caloriesBurned_Form";
            this.Text = "Calories Burned";
            this.caloriesBurned_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox caloriesBurned_Groupbox;
        private System.Windows.Forms.ListBox caloriesBurned_Listbox;
        private System.Windows.Forms.Button display_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

