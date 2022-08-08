namespace Tuition_Increase
{
    partial class tuitionIncrease_Form
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
            this.tuition_Groupbox = new System.Windows.Forms.GroupBox();
            this.tuition_Listbox = new System.Windows.Forms.ListBox();
            this.display_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.tuition_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tuition_Groupbox
            // 
            this.tuition_Groupbox.Controls.Add(this.tuition_Listbox);
            this.tuition_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuition_Groupbox.Location = new System.Drawing.Point(13, 21);
            this.tuition_Groupbox.Name = "tuition_Groupbox";
            this.tuition_Groupbox.Size = new System.Drawing.Size(439, 171);
            this.tuition_Groupbox.TabIndex = 0;
            this.tuition_Groupbox.TabStop = false;
            this.tuition_Groupbox.Text = "Tuition";
            // 
            // tuition_Listbox
            // 
            this.tuition_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tuition_Listbox.FormattingEnabled = true;
            this.tuition_Listbox.ItemHeight = 18;
            this.tuition_Listbox.Location = new System.Drawing.Point(14, 34);
            this.tuition_Listbox.Name = "tuition_Listbox";
            this.tuition_Listbox.Size = new System.Drawing.Size(412, 112);
            this.tuition_Listbox.TabIndex = 0;
            // 
            // display_Button
            // 
            this.display_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Button.Location = new System.Drawing.Point(49, 198);
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
            this.clear_Button.Location = new System.Drawing.Point(172, 198);
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
            this.exit_Button.Location = new System.Drawing.Point(300, 198);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(95, 31);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // tuitionIncrease_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 251);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.display_Button);
            this.Controls.Add(this.tuition_Groupbox);
            this.Name = "tuitionIncrease_Form";
            this.Text = "Tuition Increase";
            this.tuition_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tuition_Groupbox;
        private System.Windows.Forms.ListBox tuition_Listbox;
        private System.Windows.Forms.Button display_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

