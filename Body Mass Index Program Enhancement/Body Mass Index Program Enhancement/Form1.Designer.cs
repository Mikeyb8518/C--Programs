namespace Body_Mass_Index_Program_Enhancement
{
    partial class BMI_Form
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
            this.height_Label = new System.Windows.Forms.Label();
            this.weight_Label = new System.Windows.Forms.Label();
            this.body_Mass_Label = new System.Windows.Forms.Label();
            this.height_Textbox = new System.Windows.Forms.TextBox();
            this.weight_Textbox = new System.Windows.Forms.TextBox();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.convert_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.output_Textbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_Label.Location = new System.Drawing.Point(12, 49);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(234, 18);
            this.height_Label.TabIndex = 0;
            this.height_Label.Text = "Please Enter Height in Inches:";
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_Label.Location = new System.Drawing.Point(12, 116);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(246, 18);
            this.weight_Label.TabIndex = 1;
            this.weight_Label.Text = "Please Enter Weight in Pounds:";
            // 
            // body_Mass_Label
            // 
            this.body_Mass_Label.AutoSize = true;
            this.body_Mass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.body_Mass_Label.Location = new System.Drawing.Point(64, 187);
            this.body_Mass_Label.Name = "body_Mass_Label";
            this.body_Mass_Label.Size = new System.Drawing.Size(140, 18);
            this.body_Mass_Label.TabIndex = 2;
            this.body_Mass_Label.Text = "Body Mass Total:";
            // 
            // height_Textbox
            // 
            this.height_Textbox.Location = new System.Drawing.Point(287, 48);
            this.height_Textbox.Name = "height_Textbox";
            this.height_Textbox.Size = new System.Drawing.Size(104, 22);
            this.height_Textbox.TabIndex = 1;
            this.height_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // weight_Textbox
            // 
            this.weight_Textbox.Location = new System.Drawing.Point(297, 115);
            this.weight_Textbox.Name = "weight_Textbox";
            this.weight_Textbox.Size = new System.Drawing.Size(104, 22);
            this.weight_Textbox.TabIndex = 2;
            this.weight_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Textbox.Location = new System.Drawing.Point(223, 186);
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(104, 22);
            this.total_Textbox.TabIndex = 5;
            this.total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convert_Button
            // 
            this.convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.Location = new System.Drawing.Point(79, 308);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(95, 33);
            this.convert_Button.TabIndex = 3;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(210, 308);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(95, 33);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(338, 308);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(95, 33);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // output_Textbox
            // 
            this.output_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.output_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Textbox.Location = new System.Drawing.Point(109, 247);
            this.output_Textbox.Name = "output_Textbox";
            this.output_Textbox.Size = new System.Drawing.Size(282, 27);
            this.output_Textbox.TabIndex = 9;
            this.output_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // BMI_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 384);
            this.Controls.Add(this.output_Textbox);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.convert_Button);
            this.Controls.Add(this.total_Textbox);
            this.Controls.Add(this.weight_Textbox);
            this.Controls.Add(this.height_Textbox);
            this.Controls.Add(this.body_Mass_Label);
            this.Controls.Add(this.weight_Label);
            this.Controls.Add(this.height_Label);
            this.Name = "BMI_Form";
            this.Text = "Body Mass Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label height_Label;
        private System.Windows.Forms.Label weight_Label;
        private System.Windows.Forms.Label body_Mass_Label;
        private System.Windows.Forms.TextBox height_Textbox;
        private System.Windows.Forms.TextBox weight_Textbox;
        private System.Windows.Forms.TextBox total_Textbox;
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.TextBox output_Textbox;
    }
}

