namespace Prime_Number_List
{
    partial class prime_Number_List_Form
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
            this.prime_Groupbox = new System.Windows.Forms.GroupBox();
            this.prime_Listbox = new System.Windows.Forms.ListBox();
            this.check_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.prime_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // prime_Groupbox
            // 
            this.prime_Groupbox.Controls.Add(this.prime_Listbox);
            this.prime_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prime_Groupbox.Location = new System.Drawing.Point(22, 21);
            this.prime_Groupbox.Name = "prime_Groupbox";
            this.prime_Groupbox.Size = new System.Drawing.Size(385, 257);
            this.prime_Groupbox.TabIndex = 0;
            this.prime_Groupbox.TabStop = false;
            this.prime_Groupbox.Text = "Prime Numbers";
            // 
            // prime_Listbox
            // 
            this.prime_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prime_Listbox.FormattingEnabled = true;
            this.prime_Listbox.ItemHeight = 18;
            this.prime_Listbox.Location = new System.Drawing.Point(6, 21);
            this.prime_Listbox.Name = "prime_Listbox";
            this.prime_Listbox.Size = new System.Drawing.Size(364, 202);
            this.prime_Listbox.TabIndex = 0;
            // 
            // check_Button
            // 
            this.check_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.check_Button.Location = new System.Drawing.Point(42, 293);
            this.check_Button.Name = "check_Button";
            this.check_Button.Size = new System.Drawing.Size(83, 29);
            this.check_Button.TabIndex = 1;
            this.check_Button.Text = "Check";
            this.check_Button.UseVisualStyleBackColor = true;
            this.check_Button.Click += new System.EventHandler(this.check_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(163, 293);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(83, 29);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(287, 293);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(83, 29);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // prime_Number_List_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(431, 348);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.check_Button);
            this.Controls.Add(this.prime_Groupbox);
            this.Name = "prime_Number_List_Form";
            this.Text = "Prime Number List";
            this.prime_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox prime_Groupbox;
        private System.Windows.Forms.ListBox prime_Listbox;
        private System.Windows.Forms.Button check_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

