namespace Falling_Distance
{
    partial class falling_distance_Form
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
            this.distance_Groupbox = new System.Windows.Forms.GroupBox();
            this.time_Label = new System.Windows.Forms.Label();
            this.seconds_Textbox = new System.Windows.Forms.TextBox();
            this.distance_Label = new System.Windows.Forms.Label();
            this.total_textbox = new System.Windows.Forms.TextBox();
            this.convert_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.distance_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // distance_Groupbox
            // 
            this.distance_Groupbox.Controls.Add(this.total_textbox);
            this.distance_Groupbox.Controls.Add(this.distance_Label);
            this.distance_Groupbox.Controls.Add(this.seconds_Textbox);
            this.distance_Groupbox.Controls.Add(this.time_Label);
            this.distance_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_Groupbox.Location = new System.Drawing.Point(12, 16);
            this.distance_Groupbox.Name = "distance_Groupbox";
            this.distance_Groupbox.Size = new System.Drawing.Size(421, 162);
            this.distance_Groupbox.TabIndex = 0;
            this.distance_Groupbox.TabStop = false;
            this.distance_Groupbox.Text = "Falling Distance";
            // 
            // time_Label
            // 
            this.time_Label.AutoSize = true;
            this.time_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time_Label.Location = new System.Drawing.Point(6, 46);
            this.time_Label.Name = "time_Label";
            this.time_Label.Size = new System.Drawing.Size(272, 16);
            this.time_Label.TabIndex = 0;
            this.time_Label.Text = "Number of Seconds Object has Fallen:";
            // 
            // seconds_Textbox
            // 
            this.seconds_Textbox.Location = new System.Drawing.Point(305, 41);
            this.seconds_Textbox.Name = "seconds_Textbox";
            this.seconds_Textbox.Size = new System.Drawing.Size(82, 24);
            this.seconds_Textbox.TabIndex = 1;
            this.seconds_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // distance_Label
            // 
            this.distance_Label.AutoSize = true;
            this.distance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_Label.Location = new System.Drawing.Point(21, 122);
            this.distance_Label.Name = "distance_Label";
            this.distance_Label.Size = new System.Drawing.Size(208, 16);
            this.distance_Label.TabIndex = 2;
            this.distance_Label.Text = "Distance Object has Travled:";
            // 
            // total_textbox
            // 
            this.total_textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_textbox.Location = new System.Drawing.Point(254, 117);
            this.total_textbox.Name = "total_textbox";
            this.total_textbox.Size = new System.Drawing.Size(142, 24);
            this.total_textbox.TabIndex = 2;
            this.total_textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convert_Button
            // 
            this.convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.Location = new System.Drawing.Point(36, 194);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(103, 31);
            this.convert_Button.TabIndex = 2;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(163, 194);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(103, 31);
            this.clear_Button.TabIndex = 3;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(296, 194);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(103, 31);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // falling_distance_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 251);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.convert_Button);
            this.Controls.Add(this.distance_Groupbox);
            this.Name = "falling_distance_Form";
            this.Text = "Falling Distance";
            this.distance_Groupbox.ResumeLayout(false);
            this.distance_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox distance_Groupbox;
        private System.Windows.Forms.TextBox total_textbox;
        private System.Windows.Forms.Label distance_Label;
        private System.Windows.Forms.TextBox seconds_Textbox;
        private System.Windows.Forms.Label time_Label;
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

