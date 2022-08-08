namespace Celsius_and_Fahrenheit_Converter
{
    partial class celsius_fahrenheit_converter_Form
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
            this.temperature_Label = new System.Windows.Forms.Label();
            this.input_Box = new System.Windows.Forms.TextBox();
            this.output_Label = new System.Windows.Forms.Label();
            this.output_Box = new System.Windows.Forms.TextBox();
            this.convert_Fahrenheit_Button = new System.Windows.Forms.Button();
            this.convert_Celsius_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // temperature_Label
            // 
            this.temperature_Label.AutoSize = true;
            this.temperature_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.temperature_Label.Location = new System.Drawing.Point(69, 76);
            this.temperature_Label.Name = "temperature_Label";
            this.temperature_Label.Size = new System.Drawing.Size(237, 18);
            this.temperature_Label.TabIndex = 0;
            this.temperature_Label.Text = "Please Enter the Temperature:";
            // 
            // input_Box
            // 
            this.input_Box.Location = new System.Drawing.Point(346, 75);
            this.input_Box.Name = "input_Box";
            this.input_Box.Size = new System.Drawing.Size(108, 22);
            this.input_Box.TabIndex = 1;
            this.input_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(59, 146);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(247, 18);
            this.output_Label.TabIndex = 2;
            this.output_Label.Text = "Output in Fahrenheit or Celsius:";
            // 
            // output_Box
            // 
            this.output_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.output_Box.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Box.Location = new System.Drawing.Point(346, 146);
            this.output_Box.Name = "output_Box";
            this.output_Box.Size = new System.Drawing.Size(91, 17);
            this.output_Box.TabIndex = 3;
            this.output_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convert_Fahrenheit_Button
            // 
            this.convert_Fahrenheit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Fahrenheit_Button.Location = new System.Drawing.Point(62, 213);
            this.convert_Fahrenheit_Button.Name = "convert_Fahrenheit_Button";
            this.convert_Fahrenheit_Button.Size = new System.Drawing.Size(136, 45);
            this.convert_Fahrenheit_Button.TabIndex = 4;
            this.convert_Fahrenheit_Button.Text = "Convert to Fahrenheit";
            this.convert_Fahrenheit_Button.UseVisualStyleBackColor = true;
            this.convert_Fahrenheit_Button.Click += new System.EventHandler(this.convert_Fahrenheit_Button_Click);
            // 
            // convert_Celsius_Button
            // 
            this.convert_Celsius_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Celsius_Button.Location = new System.Drawing.Point(217, 213);
            this.convert_Celsius_Button.Name = "convert_Celsius_Button";
            this.convert_Celsius_Button.Size = new System.Drawing.Size(136, 45);
            this.convert_Celsius_Button.TabIndex = 5;
            this.convert_Celsius_Button.Text = "Convert to Celsius";
            this.convert_Celsius_Button.UseVisualStyleBackColor = true;
            this.convert_Celsius_Button.Click += new System.EventHandler(this.convert_Celsius_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(375, 212);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(136, 45);
            this.clear_Button.TabIndex = 6;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(530, 212);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(136, 45);
            this.exit_Button.TabIndex = 7;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // celsius_fahrenheit_converter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(724, 304);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.convert_Celsius_Button);
            this.Controls.Add(this.convert_Fahrenheit_Button);
            this.Controls.Add(this.output_Box);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.input_Box);
            this.Controls.Add(this.temperature_Label);
            this.Name = "celsius_fahrenheit_converter_Form";
            this.Text = "Celsius and Fahrenheit Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label temperature_Label;
        private System.Windows.Forms.TextBox input_Box;
        private System.Windows.Forms.Label output_Label;
        private System.Windows.Forms.TextBox output_Box;
        private System.Windows.Forms.Button convert_Fahrenheit_Button;
        private System.Windows.Forms.Button convert_Celsius_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

