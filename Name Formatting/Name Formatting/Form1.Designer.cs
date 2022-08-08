namespace Name_Formatting
{
    partial class name_Form
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
            this.firstName_Label = new System.Windows.Forms.Label();
            this.lastName_Label = new System.Windows.Forms.Label();
            this.middleName_Label = new System.Windows.Forms.Label();
            this.titleName_Label = new System.Windows.Forms.Label();
            this.firstName_Text = new System.Windows.Forms.TextBox();
            this.lastName_Text = new System.Windows.Forms.TextBox();
            this.middleName_Text = new System.Windows.Forms.TextBox();
            this.titleName_Text = new System.Windows.Forms.TextBox();
            this.allNames_Button = new System.Windows.Forms.Button();
            this.firstMiddleLast_Button = new System.Windows.Forms.Button();
            this.firstLast_Button = new System.Windows.Forms.Button();
            this.lastFirstMiddleTitle_Button = new System.Windows.Forms.Button();
            this.lastFirstMiddle_Button = new System.Windows.Forms.Button();
            this.lastFirst_Button = new System.Windows.Forms.Button();
            this.name_Output = new System.Windows.Forms.TextBox();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // firstName_Label
            // 
            this.firstName_Label.AutoSize = true;
            this.firstName_Label.Location = new System.Drawing.Point(231, 83);
            this.firstName_Label.Name = "firstName_Label";
            this.firstName_Label.Size = new System.Drawing.Size(109, 16);
            this.firstName_Label.TabIndex = 0;
            this.firstName_Label.Text = "Enter First Name:";
            // 
            // lastName_Label
            // 
            this.lastName_Label.AutoSize = true;
            this.lastName_Label.Location = new System.Drawing.Point(228, 166);
            this.lastName_Label.Name = "lastName_Label";
            this.lastName_Label.Size = new System.Drawing.Size(109, 16);
            this.lastName_Label.TabIndex = 1;
            this.lastName_Label.Text = "Enter Last Name:";
            // 
            // middleName_Label
            // 
            this.middleName_Label.AutoSize = true;
            this.middleName_Label.Location = new System.Drawing.Point(215, 125);
            this.middleName_Label.Name = "middleName_Label";
            this.middleName_Label.Size = new System.Drawing.Size(125, 16);
            this.middleName_Label.TabIndex = 2;
            this.middleName_Label.Text = "Enter Middle Name:";
            // 
            // titleName_Label
            // 
            this.titleName_Label.AutoSize = true;
            this.titleName_Label.Location = new System.Drawing.Point(142, 200);
            this.titleName_Label.Name = "titleName_Label";
            this.titleName_Label.Size = new System.Drawing.Size(245, 16);
            this.titleName_Label.TabIndex = 3;
            this.titleName_Label.Text = "Enter Title Name(Mr., Mrs., Ms., Dr., Etc.):";
            // 
            // firstName_Text
            // 
            this.firstName_Text.Location = new System.Drawing.Point(346, 80);
            this.firstName_Text.Multiline = true;
            this.firstName_Text.Name = "firstName_Text";
            this.firstName_Text.Size = new System.Drawing.Size(180, 26);
            this.firstName_Text.TabIndex = 1;
            // 
            // lastName_Text
            // 
            this.lastName_Text.Location = new System.Drawing.Point(343, 163);
            this.lastName_Text.Multiline = true;
            this.lastName_Text.Name = "lastName_Text";
            this.lastName_Text.Size = new System.Drawing.Size(167, 26);
            this.lastName_Text.TabIndex = 3;
            // 
            // middleName_Text
            // 
            this.middleName_Text.Location = new System.Drawing.Point(346, 122);
            this.middleName_Text.Multiline = true;
            this.middleName_Text.Name = "middleName_Text";
            this.middleName_Text.Size = new System.Drawing.Size(167, 26);
            this.middleName_Text.TabIndex = 2;
            // 
            // titleName_Text
            // 
            this.titleName_Text.Location = new System.Drawing.Point(411, 197);
            this.titleName_Text.Multiline = true;
            this.titleName_Text.Name = "titleName_Text";
            this.titleName_Text.Size = new System.Drawing.Size(180, 26);
            this.titleName_Text.TabIndex = 4;
            // 
            // allNames_Button
            // 
            this.allNames_Button.Location = new System.Drawing.Point(35, 339);
            this.allNames_Button.Name = "allNames_Button";
            this.allNames_Button.Size = new System.Drawing.Size(114, 43);
            this.allNames_Button.TabIndex = 8;
            this.allNames_Button.Text = "Display All Names";
            this.allNames_Button.UseVisualStyleBackColor = true;
            this.allNames_Button.Click += new System.EventHandler(this.allNames_Button_Click);
            // 
            // firstMiddleLast_Button
            // 
            this.firstMiddleLast_Button.Location = new System.Drawing.Point(163, 339);
            this.firstMiddleLast_Button.Name = "firstMiddleLast_Button";
            this.firstMiddleLast_Button.Size = new System.Drawing.Size(114, 43);
            this.firstMiddleLast_Button.TabIndex = 9;
            this.firstMiddleLast_Button.Text = "Display First, Middle, Last";
            this.firstMiddleLast_Button.UseVisualStyleBackColor = true;
            this.firstMiddleLast_Button.Click += new System.EventHandler(this.firstMiddleLast_Button_Click);
            // 
            // firstLast_Button
            // 
            this.firstLast_Button.Location = new System.Drawing.Point(283, 339);
            this.firstLast_Button.Name = "firstLast_Button";
            this.firstLast_Button.Size = new System.Drawing.Size(114, 43);
            this.firstLast_Button.TabIndex = 10;
            this.firstLast_Button.Text = "Display First && Last";
            this.firstLast_Button.UseVisualStyleBackColor = true;
            this.firstLast_Button.Click += new System.EventHandler(this.firstLast_Button_Click);
            // 
            // lastFirstMiddleTitle_Button
            // 
            this.lastFirstMiddleTitle_Button.Location = new System.Drawing.Point(403, 339);
            this.lastFirstMiddleTitle_Button.Name = "lastFirstMiddleTitle_Button";
            this.lastFirstMiddleTitle_Button.Size = new System.Drawing.Size(127, 43);
            this.lastFirstMiddleTitle_Button.TabIndex = 11;
            this.lastFirstMiddleTitle_Button.Text = "Display Last, First Middle Title";
            this.lastFirstMiddleTitle_Button.UseVisualStyleBackColor = true;
            this.lastFirstMiddleTitle_Button.Click += new System.EventHandler(this.lastFirstMiddleTitle_Button_Click);
            // 
            // lastFirstMiddle_Button
            // 
            this.lastFirstMiddle_Button.Location = new System.Drawing.Point(536, 339);
            this.lastFirstMiddle_Button.Name = "lastFirstMiddle_Button";
            this.lastFirstMiddle_Button.Size = new System.Drawing.Size(114, 43);
            this.lastFirstMiddle_Button.TabIndex = 12;
            this.lastFirstMiddle_Button.Text = "Display Last First Middle";
            this.lastFirstMiddle_Button.UseVisualStyleBackColor = true;
            this.lastFirstMiddle_Button.Click += new System.EventHandler(this.lastFirstMiddle_Button_Click);
            // 
            // lastFirst_Button
            // 
            this.lastFirst_Button.Location = new System.Drawing.Point(656, 339);
            this.lastFirst_Button.Name = "lastFirst_Button";
            this.lastFirst_Button.Size = new System.Drawing.Size(114, 43);
            this.lastFirst_Button.TabIndex = 13;
            this.lastFirst_Button.Text = "Display Last && First ";
            this.lastFirst_Button.UseVisualStyleBackColor = true;
            this.lastFirst_Button.Click += new System.EventHandler(this.lastFirst_Button_Click);
            // 
            // name_Output
            // 
            this.name_Output.BackColor = System.Drawing.SystemColors.Menu;
            this.name_Output.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.name_Output.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_Output.Location = new System.Drawing.Point(195, 258);
            this.name_Output.Multiline = true;
            this.name_Output.Name = "name_Output";
            this.name_Output.Size = new System.Drawing.Size(387, 26);
            this.name_Output.TabIndex = 14;
            this.name_Output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(283, 410);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(95, 31);
            this.clear_Button.TabIndex = 15;
            this.clear_Button.Text = "Clear Button";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(403, 410);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(98, 31);
            this.exit_Button.TabIndex = 16;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // name_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 468);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.name_Output);
            this.Controls.Add(this.lastFirst_Button);
            this.Controls.Add(this.lastFirstMiddle_Button);
            this.Controls.Add(this.lastFirstMiddleTitle_Button);
            this.Controls.Add(this.firstLast_Button);
            this.Controls.Add(this.firstMiddleLast_Button);
            this.Controls.Add(this.allNames_Button);
            this.Controls.Add(this.titleName_Text);
            this.Controls.Add(this.middleName_Text);
            this.Controls.Add(this.lastName_Text);
            this.Controls.Add(this.firstName_Text);
            this.Controls.Add(this.titleName_Label);
            this.Controls.Add(this.middleName_Label);
            this.Controls.Add(this.lastName_Label);
            this.Controls.Add(this.firstName_Label);
            this.Name = "name_Form";
            this.Text = "Name Formatting";
            this.Load += new System.EventHandler(this.name_Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label firstName_Label;
        private System.Windows.Forms.Label lastName_Label;
        private System.Windows.Forms.Label middleName_Label;
        private System.Windows.Forms.Label titleName_Label;
        private System.Windows.Forms.TextBox firstName_Text;
        private System.Windows.Forms.TextBox lastName_Text;
        private System.Windows.Forms.TextBox middleName_Text;
        private System.Windows.Forms.TextBox titleName_Text;
        private System.Windows.Forms.Button allNames_Button;
        private System.Windows.Forms.Button firstMiddleLast_Button;
        private System.Windows.Forms.Button firstLast_Button;
        private System.Windows.Forms.Button lastFirstMiddleTitle_Button;
        private System.Windows.Forms.Button lastFirstMiddle_Button;
        private System.Windows.Forms.Button lastFirst_Button;
        private System.Windows.Forms.TextBox name_Output;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

