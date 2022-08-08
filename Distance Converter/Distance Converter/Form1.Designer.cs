namespace Distance_Converter
{
    partial class distanceConverter_Form
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
            this.distance_Label = new System.Windows.Forms.Label();
            this.distance_Textbox = new System.Windows.Forms.TextBox();
            this.from_Groupbox = new System.Windows.Forms.GroupBox();
            this.to_Groupbox = new System.Windows.Forms.GroupBox();
            this.from_Listbox = new System.Windows.Forms.ListBox();
            this.to_Listbox = new System.Windows.Forms.ListBox();
            this.conversion_Label = new System.Windows.Forms.Label();
            this.total_Box = new System.Windows.Forms.TextBox();
            this.convert_Button = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.from_Groupbox.SuspendLayout();
            this.to_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // distance_Label
            // 
            this.distance_Label.AutoSize = true;
            this.distance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_Label.Location = new System.Drawing.Point(27, 29);
            this.distance_Label.Name = "distance_Label";
            this.distance_Label.Size = new System.Drawing.Size(188, 18);
            this.distance_Label.TabIndex = 0;
            this.distance_Label.Text = "Enter a distance to convert:";
            // 
            // distance_Textbox
            // 
            this.distance_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance_Textbox.Location = new System.Drawing.Point(233, 28);
            this.distance_Textbox.Name = "distance_Textbox";
            this.distance_Textbox.Size = new System.Drawing.Size(111, 24);
            this.distance_Textbox.TabIndex = 1;
            this.distance_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // from_Groupbox
            // 
            this.from_Groupbox.Controls.Add(this.from_Listbox);
            this.from_Groupbox.Location = new System.Drawing.Point(19, 99);
            this.from_Groupbox.Name = "from_Groupbox";
            this.from_Groupbox.Size = new System.Drawing.Size(167, 141);
            this.from_Groupbox.TabIndex = 2;
            this.from_Groupbox.TabStop = false;
            this.from_Groupbox.Text = "From";
            // 
            // to_Groupbox
            // 
            this.to_Groupbox.Controls.Add(this.to_Listbox);
            this.to_Groupbox.Location = new System.Drawing.Point(209, 99);
            this.to_Groupbox.Name = "to_Groupbox";
            this.to_Groupbox.Size = new System.Drawing.Size(181, 141);
            this.to_Groupbox.TabIndex = 3;
            this.to_Groupbox.TabStop = false;
            this.to_Groupbox.Text = "To";
            // 
            // from_Listbox
            // 
            this.from_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.from_Listbox.FormattingEnabled = true;
            this.from_Listbox.ItemHeight = 18;
            this.from_Listbox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.from_Listbox.Location = new System.Drawing.Point(23, 47);
            this.from_Listbox.Name = "from_Listbox";
            this.from_Listbox.Size = new System.Drawing.Size(126, 76);
            this.from_Listbox.TabIndex = 0;
            // 
            // to_Listbox
            // 
            this.to_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.to_Listbox.FormattingEnabled = true;
            this.to_Listbox.ItemHeight = 18;
            this.to_Listbox.Items.AddRange(new object[] {
            "Inches",
            "Feet",
            "Yards"});
            this.to_Listbox.Location = new System.Drawing.Point(24, 47);
            this.to_Listbox.Name = "to_Listbox";
            this.to_Listbox.Size = new System.Drawing.Size(126, 76);
            this.to_Listbox.TabIndex = 1;
            // 
            // conversion_Label
            // 
            this.conversion_Label.AutoSize = true;
            this.conversion_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversion_Label.Location = new System.Drawing.Point(44, 282);
            this.conversion_Label.Name = "conversion_Label";
            this.conversion_Label.Size = new System.Drawing.Size(142, 18);
            this.conversion_Label.TabIndex = 4;
            this.conversion_Label.Text = "Converted Distance:";
            // 
            // total_Box
            // 
            this.total_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Box.Location = new System.Drawing.Point(209, 282);
            this.total_Box.Name = "total_Box";
            this.total_Box.Size = new System.Drawing.Size(121, 22);
            this.total_Box.TabIndex = 5;
            this.total_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // convert_Button
            // 
            this.convert_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.convert_Button.Location = new System.Drawing.Point(100, 355);
            this.convert_Button.Name = "convert_Button";
            this.convert_Button.Size = new System.Drawing.Size(85, 27);
            this.convert_Button.TabIndex = 6;
            this.convert_Button.Text = "Convert";
            this.convert_Button.UseVisualStyleBackColor = true;
            this.convert_Button.Click += new System.EventHandler(this.convert_Button_Click);
            // 
            // Exit
            // 
            this.Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Location = new System.Drawing.Point(209, 355);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(85, 27);
            this.Exit.TabIndex = 7;
            this.Exit.Text = "Exit";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // distanceConverter_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 450);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.convert_Button);
            this.Controls.Add(this.total_Box);
            this.Controls.Add(this.conversion_Label);
            this.Controls.Add(this.to_Groupbox);
            this.Controls.Add(this.from_Groupbox);
            this.Controls.Add(this.distance_Textbox);
            this.Controls.Add(this.distance_Label);
            this.Name = "distanceConverter_Form";
            this.Text = "Distance Converter";
            this.from_Groupbox.ResumeLayout(false);
            this.to_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label distance_Label;
        private System.Windows.Forms.TextBox distance_Textbox;
        private System.Windows.Forms.GroupBox from_Groupbox;
        private System.Windows.Forms.ListBox from_Listbox;
        private System.Windows.Forms.GroupBox to_Groupbox;
        private System.Windows.Forms.ListBox to_Listbox;
        private System.Windows.Forms.Label conversion_Label;
        private System.Windows.Forms.TextBox total_Box;
        private System.Windows.Forms.Button convert_Button;
        private System.Windows.Forms.Button Exit;
    }
}

