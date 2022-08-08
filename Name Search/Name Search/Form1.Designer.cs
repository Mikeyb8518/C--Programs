namespace Name_Search
{
    partial class search_Form
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
            this.search_Groupbox = new System.Windows.Forms.GroupBox();
            this.boySearch_Textbox = new System.Windows.Forms.TextBox();
            this.boyName_Label = new System.Windows.Forms.Label();
            this.search_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.girlName_Label = new System.Windows.Forms.Label();
            this.girlSearch_Textbox = new System.Windows.Forms.TextBox();
            this.search_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // search_Groupbox
            // 
            this.search_Groupbox.Controls.Add(this.girlSearch_Textbox);
            this.search_Groupbox.Controls.Add(this.girlName_Label);
            this.search_Groupbox.Controls.Add(this.boySearch_Textbox);
            this.search_Groupbox.Controls.Add(this.boyName_Label);
            this.search_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Groupbox.Location = new System.Drawing.Point(19, 15);
            this.search_Groupbox.Name = "search_Groupbox";
            this.search_Groupbox.Size = new System.Drawing.Size(461, 144);
            this.search_Groupbox.TabIndex = 0;
            this.search_Groupbox.TabStop = false;
            this.search_Groupbox.Text = "Search Boy or Girls Name";
            // 
            // boySearch_Textbox
            // 
            this.boySearch_Textbox.Location = new System.Drawing.Point(193, 45);
            this.boySearch_Textbox.Name = "boySearch_Textbox";
            this.boySearch_Textbox.Size = new System.Drawing.Size(142, 22);
            this.boySearch_Textbox.TabIndex = 1;
            this.boySearch_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // boyName_Label
            // 
            this.boyName_Label.AutoSize = true;
            this.boyName_Label.Location = new System.Drawing.Point(53, 48);
            this.boyName_Label.Name = "boyName_Label";
            this.boyName_Label.Size = new System.Drawing.Size(123, 16);
            this.boyName_Label.TabIndex = 0;
            this.boyName_Label.Text = "Enter Boy Name:";
            // 
            // search_Button
            // 
            this.search_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.search_Button.Location = new System.Drawing.Point(49, 181);
            this.search_Button.Name = "search_Button";
            this.search_Button.Size = new System.Drawing.Size(99, 36);
            this.search_Button.TabIndex = 1;
            this.search_Button.Text = "Search";
            this.search_Button.UseVisualStyleBackColor = true;
            this.search_Button.Click += new System.EventHandler(this.search_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(196, 181);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(99, 36);
            this.clear_Button.TabIndex = 2;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(340, 181);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(99, 36);
            this.exit_Button.TabIndex = 3;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // girlName_Label
            // 
            this.girlName_Label.AutoSize = true;
            this.girlName_Label.Location = new System.Drawing.Point(53, 102);
            this.girlName_Label.Name = "girlName_Label";
            this.girlName_Label.Size = new System.Drawing.Size(120, 16);
            this.girlName_Label.TabIndex = 2;
            this.girlName_Label.Text = "Enter Girl Name:";
            // 
            // girlSearch_Textbox
            // 
            this.girlSearch_Textbox.Location = new System.Drawing.Point(193, 102);
            this.girlSearch_Textbox.Name = "girlSearch_Textbox";
            this.girlSearch_Textbox.Size = new System.Drawing.Size(142, 22);
            this.girlSearch_Textbox.TabIndex = 3;
            this.girlSearch_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // search_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 230);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.search_Button);
            this.Controls.Add(this.search_Groupbox);
            this.Name = "search_Form";
            this.Text = "Name Search";
            this.Load += new System.EventHandler(this.search_Form_Load);
            this.search_Groupbox.ResumeLayout(false);
            this.search_Groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox search_Groupbox;
        private System.Windows.Forms.TextBox boySearch_Textbox;
        private System.Windows.Forms.Label boyName_Label;
        private System.Windows.Forms.Button search_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
        private System.Windows.Forms.TextBox girlSearch_Textbox;
        private System.Windows.Forms.Label girlName_Label;
    }
}

