namespace Celsius_to_Fahrenheit_Table
{
    partial class celsiusTofahrenheit_Form
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
            this.table_Groupbox = new System.Windows.Forms.GroupBox();
            this.temperature_Listbox = new System.Windows.Forms.ListBox();
            this.convert_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.table_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // table_Groupbox
            // 
            this.table_Groupbox.Controls.Add(this.temperature_Listbox);
            this.table_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.table_Groupbox.Location = new System.Drawing.Point(12, 12);
            this.table_Groupbox.Name = "table_Groupbox";
            this.table_Groupbox.Size = new System.Drawing.Size(371, 318);
            this.table_Groupbox.TabIndex = 0;
            this.table_Groupbox.TabStop = false;
            this.table_Groupbox.Text = "Table";
            // 
            // temperature_Listbox
            // 
            this.temperature_Listbox.FormattingEnabled = true;
            this.temperature_Listbox.ItemHeight = 18;
            this.temperature_Listbox.Location = new System.Drawing.Point(6, 27);
            this.temperature_Listbox.Name = "temperature_Listbox";
            this.temperature_Listbox.Size = new System.Drawing.Size(359, 274);
            this.temperature_Listbox.TabIndex = 0;
            // 
            // convert_Button
            // 
            this.convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.Location = new System.Drawing.Point(12, 355);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(100, 32);
            this.convert_Button.TabIndex = 1;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(133, 355);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(100, 32);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(249, 355);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(100, 32);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // celsiusTofahrenheit_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(395, 402);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.convert_Button);
            this.Controls.Add(this.table_Groupbox);
            this.Name = "celsiusTofahrenheit_Form";
            this.Text = "Celsius to Fahrenheit";
            this.table_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox table_Groupbox;
        private System.Windows.Forms.ListBox temperature_Listbox;
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

