namespace Body_Mass_Index
{
    partial class bodyMassIndex_Form
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
            this.weight_Label = new System.Windows.Forms.Label();
            this.height_Label = new System.Windows.Forms.Label();
            this.weight_Box = new System.Windows.Forms.TextBox();
            this.height_Box = new System.Windows.Forms.TextBox();
            this.bodyMass_Label = new System.Windows.Forms.Label();
            this.output_Box = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // weight_Label
            // 
            this.weight_Label.AutoSize = true;
            this.weight_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weight_Label.Location = new System.Drawing.Point(104, 49);
            this.weight_Label.Name = "weight_Label";
            this.weight_Label.Size = new System.Drawing.Size(206, 18);
            this.weight_Label.TabIndex = 0;
            this.weight_Label.Text = "Please Enter Your Weight:";
            // 
            // height_Label
            // 
            this.height_Label.AutoSize = true;
            this.height_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.height_Label.Location = new System.Drawing.Point(36, 113);
            this.height_Label.Name = "height_Label";
            this.height_Label.Size = new System.Drawing.Size(274, 18);
            this.height_Label.TabIndex = 1;
            this.height_Label.Text = "Please Enter Your Height in Inches:";
            // 
            // weight_Box
            // 
            this.weight_Box.Location = new System.Drawing.Point(345, 48);
            this.weight_Box.Name = "weight_Box";
            this.weight_Box.Size = new System.Drawing.Size(116, 22);
            this.weight_Box.TabIndex = 1;
            this.weight_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // height_Box
            // 
            this.height_Box.Location = new System.Drawing.Point(345, 112);
            this.height_Box.Name = "height_Box";
            this.height_Box.Size = new System.Drawing.Size(116, 22);
            this.height_Box.TabIndex = 2;
            this.height_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // bodyMass_Label
            // 
            this.bodyMass_Label.AutoSize = true;
            this.bodyMass_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bodyMass_Label.Location = new System.Drawing.Point(104, 187);
            this.bodyMass_Label.Name = "bodyMass_Label";
            this.bodyMass_Label.Size = new System.Drawing.Size(141, 18);
            this.bodyMass_Label.TabIndex = 4;
            this.bodyMass_Label.Text = "Body Mass Index:";
            // 
            // output_Box
            // 
            this.output_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.output_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.output_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Box.Location = new System.Drawing.Point(267, 185);
            this.output_Box.Name = "output_Box";
            this.output_Box.Size = new System.Drawing.Size(116, 24);
            this.output_Box.TabIndex = 5;
            this.output_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(66, 248);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(103, 30);
            this.calculate_Button.TabIndex = 3;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(189, 248);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(103, 30);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(316, 248);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(103, 30);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // bodyMassIndex_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 330);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.output_Box);
            this.Controls.Add(this.bodyMass_Label);
            this.Controls.Add(this.height_Box);
            this.Controls.Add(this.weight_Box);
            this.Controls.Add(this.height_Label);
            this.Controls.Add(this.weight_Label);
            this.Name = "bodyMassIndex_Form";
            this.Text = "Body Mass Index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label weight_Label;
        private System.Windows.Forms.Label height_Label;
        private System.Windows.Forms.TextBox weight_Box;
        private System.Windows.Forms.TextBox height_Box;
        private System.Windows.Forms.Label bodyMass_Label;
        private System.Windows.Forms.TextBox output_Box;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

