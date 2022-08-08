namespace Ocean_Levels
{
    partial class oceanLevels_Form
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
            this.oceanLevel_Groupbox = new System.Windows.Forms.GroupBox();
            this.oceanLevel_Listbox = new System.Windows.Forms.ListBox();
            this.display_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.oceanLevel_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // oceanLevel_Groupbox
            // 
            this.oceanLevel_Groupbox.Controls.Add(this.oceanLevel_Listbox);
            this.oceanLevel_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceanLevel_Groupbox.Location = new System.Drawing.Point(19, 24);
            this.oceanLevel_Groupbox.Name = "oceanLevel_Groupbox";
            this.oceanLevel_Groupbox.Size = new System.Drawing.Size(526, 280);
            this.oceanLevel_Groupbox.TabIndex = 0;
            this.oceanLevel_Groupbox.TabStop = false;
            this.oceanLevel_Groupbox.Text = "Ocean Level For The Next 10 Years";
            // 
            // oceanLevel_Listbox
            // 
            this.oceanLevel_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oceanLevel_Listbox.FormattingEnabled = true;
            this.oceanLevel_Listbox.ItemHeight = 18;
            this.oceanLevel_Listbox.Location = new System.Drawing.Point(6, 29);
            this.oceanLevel_Listbox.Name = "oceanLevel_Listbox";
            this.oceanLevel_Listbox.Size = new System.Drawing.Size(514, 238);
            this.oceanLevel_Listbox.TabIndex = 0;
            // 
            // display_Button
            // 
            this.display_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.display_Button.Location = new System.Drawing.Point(70, 325);
            this.display_Button.Name = "display_Button";
            this.display_Button.Size = new System.Drawing.Size(103, 31);
            this.display_Button.TabIndex = 1;
            this.display_Button.Text = "Display";
            this.display_Button.UseVisualStyleBackColor = true;
            this.display_Button.Click += new System.EventHandler(this.display_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(213, 325);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(103, 31);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(362, 325);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(103, 31);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // oceanLevels_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 383);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.display_Button);
            this.Controls.Add(this.oceanLevel_Groupbox);
            this.Name = "oceanLevels_Form";
            this.Text = "Ocean Levels";
            this.oceanLevel_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox oceanLevel_Groupbox;
        private System.Windows.Forms.ListBox oceanLevel_Listbox;
        private System.Windows.Forms.Button display_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

