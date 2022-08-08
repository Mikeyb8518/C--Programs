namespace Roman_Numeral_Converter
{
    partial class Form1
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
            this.input_Label = new System.Windows.Forms.Label();
            this.convert_Label = new System.Windows.Forms.Label();
            this.input_Textbox = new System.Windows.Forms.TextBox();
            this.convert_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.output_Label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // input_Label
            // 
            this.input_Label.AutoSize = true;
            this.input_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.input_Label.Location = new System.Drawing.Point(37, 93);
            this.input_Label.Name = "input_Label";
            this.input_Label.Size = new System.Drawing.Size(271, 18);
            this.input_Label.TabIndex = 0;
            this.input_Label.Text = "Please Enter A Number From 1-10:";
            // 
            // convert_Label
            // 
            this.convert_Label.AutoSize = true;
            this.convert_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Label.Location = new System.Drawing.Point(100, 169);
            this.convert_Label.Name = "convert_Label";
            this.convert_Label.Size = new System.Drawing.Size(208, 18);
            this.convert_Label.TabIndex = 1;
            this.convert_Label.Text = "Output In Roman Numeral:";
            // 
            // input_Textbox
            // 
            this.input_Textbox.Location = new System.Drawing.Point(343, 92);
            this.input_Textbox.Name = "input_Textbox";
            this.input_Textbox.Size = new System.Drawing.Size(137, 22);
            this.input_Textbox.TabIndex = 1;
            this.input_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convert_Button
            // 
            this.convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.Location = new System.Drawing.Point(67, 252);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(97, 31);
            this.convert_Button.TabIndex = 3;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(211, 252);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(97, 31);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(352, 252);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(97, 31);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // output_Label
            // 
            this.output_Label.AutoSize = true;
            this.output_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_Label.Location = new System.Drawing.Point(363, 168);
            this.output_Label.Name = "output_Label";
            this.output_Label.Size = new System.Drawing.Size(0, 22);
            this.output_Label.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 352);
            this.Controls.Add(this.output_Label);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.convert_Button);
            this.Controls.Add(this.input_Textbox);
            this.Controls.Add(this.convert_Label);
            this.Controls.Add(this.input_Label);
            this.Name = "Form1";
            this.Text = "Roman Numeral Converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label input_Label;
        private System.Windows.Forms.Label convert_Label;
        private System.Windows.Forms.TextBox input_Textbox;
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.Label output_Label;
    }
}

