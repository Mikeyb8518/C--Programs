namespace World_Series_Champions
{
    partial class champions_Form
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
            this.teams_Groupbox = new System.Windows.Forms.GroupBox();
            this.teams_Listbox = new System.Windows.Forms.ListBox();
            this.teams_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // teams_Groupbox
            // 
            this.teams_Groupbox.Controls.Add(this.teams_Listbox);
            this.teams_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teams_Groupbox.Location = new System.Drawing.Point(16, 22);
            this.teams_Groupbox.Name = "teams_Groupbox";
            this.teams_Groupbox.Size = new System.Drawing.Size(304, 416);
            this.teams_Groupbox.TabIndex = 0;
            this.teams_Groupbox.TabStop = false;
            this.teams_Groupbox.Text = "MLB Teams";
            // 
            // teams_Listbox
            // 
            this.teams_Listbox.FormattingEnabled = true;
            this.teams_Listbox.ItemHeight = 18;
            this.teams_Listbox.Location = new System.Drawing.Point(20, 35);
            this.teams_Listbox.Name = "teams_Listbox";
            this.teams_Listbox.Size = new System.Drawing.Size(264, 364);
            this.teams_Listbox.TabIndex = 0;
            this.teams_Listbox.SelectedIndexChanged += new System.EventHandler(this.teams_Listbox_SelectedIndexChanged);
            // 
            // champions_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 450);
            this.Controls.Add(this.teams_Groupbox);
            this.Name = "champions_Form";
            this.Text = "World Series Champions";
            this.Load += new System.EventHandler(this.champions_Form_Load);
            this.teams_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox teams_Groupbox;
        private System.Windows.Forms.ListBox teams_Listbox;
    }
}

