namespace Workshop_Selector
{
    partial class workshop_Form
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
            this.workshop_Groupbox = new System.Windows.Forms.GroupBox();
            this.workshop_Listbox = new System.Windows.Forms.ListBox();
            this.location_Groupbox = new System.Windows.Forms.GroupBox();
            this.location_Listbox = new System.Windows.Forms.ListBox();
            this.registration_Label = new System.Windows.Forms.Label();
            this.output_registration_Label = new System.Windows.Forms.Label();
            this.lodging_Label = new System.Windows.Forms.Label();
            this.output_lodging_Label = new System.Windows.Forms.Label();
            this.total_Label = new System.Windows.Forms.Label();
            this.output_total_Label = new System.Windows.Forms.Label();
            this.select_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.workshop_Groupbox.SuspendLayout();
            this.location_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // workshop_Groupbox
            // 
            this.workshop_Groupbox.Controls.Add(this.workshop_Listbox);
            this.workshop_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshop_Groupbox.Location = new System.Drawing.Point(32, 29);
            this.workshop_Groupbox.Name = "workshop_Groupbox";
            this.workshop_Groupbox.Size = new System.Drawing.Size(246, 196);
            this.workshop_Groupbox.TabIndex = 0;
            this.workshop_Groupbox.TabStop = false;
            this.workshop_Groupbox.Text = "WorkShop";
            // 
            // workshop_Listbox
            // 
            this.workshop_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workshop_Listbox.FormattingEnabled = true;
            this.workshop_Listbox.ItemHeight = 20;
            this.workshop_Listbox.Items.AddRange(new object[] {
            "Handling Stress",
            "Time Management",
            "Supervision Skills",
            "Negotitation",
            "How to Interview"});
            this.workshop_Listbox.Location = new System.Drawing.Point(9, 48);
            this.workshop_Listbox.Name = "workshop_Listbox";
            this.workshop_Listbox.Size = new System.Drawing.Size(224, 104);
            this.workshop_Listbox.TabIndex = 0;
            // 
            // location_Groupbox
            // 
            this.location_Groupbox.Controls.Add(this.location_Listbox);
            this.location_Groupbox.Location = new System.Drawing.Point(341, 29);
            this.location_Groupbox.Name = "location_Groupbox";
            this.location_Groupbox.Size = new System.Drawing.Size(246, 196);
            this.location_Groupbox.TabIndex = 1;
            this.location_Groupbox.TabStop = false;
            this.location_Groupbox.Text = "Location";
            // 
            // location_Listbox
            // 
            this.location_Listbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.location_Listbox.FormattingEnabled = true;
            this.location_Listbox.ItemHeight = 20;
            this.location_Listbox.Items.AddRange(new object[] {
            "Austin",
            "Chicago",
            "Dallas",
            "Orlando",
            "Phoenix",
            "Raleigh"});
            this.location_Listbox.Location = new System.Drawing.Point(11, 46);
            this.location_Listbox.Name = "location_Listbox";
            this.location_Listbox.Size = new System.Drawing.Size(224, 124);
            this.location_Listbox.TabIndex = 1;
            // 
            // registration_Label
            // 
            this.registration_Label.AutoSize = true;
            this.registration_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registration_Label.Location = new System.Drawing.Point(184, 267);
            this.registration_Label.Name = "registration_Label";
            this.registration_Label.Size = new System.Drawing.Size(104, 18);
            this.registration_Label.TabIndex = 2;
            this.registration_Label.Text = "Registration:";
            // 
            // output_registration_Label
            // 
            this.output_registration_Label.AutoSize = true;
            this.output_registration_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_registration_Label.Location = new System.Drawing.Point(294, 267);
            this.output_registration_Label.Name = "output_registration_Label";
            this.output_registration_Label.Size = new System.Drawing.Size(17, 18);
            this.output_registration_Label.TabIndex = 3;
            this.output_registration_Label.Text = "0";
            this.output_registration_Label.Visible = false;
            // 
            // lodging_Label
            // 
            this.lodging_Label.AutoSize = true;
            this.lodging_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lodging_Label.Location = new System.Drawing.Point(216, 313);
            this.lodging_Label.Name = "lodging_Label";
            this.lodging_Label.Size = new System.Drawing.Size(72, 18);
            this.lodging_Label.TabIndex = 4;
            this.lodging_Label.Text = "Lodging:";
            // 
            // output_lodging_Label
            // 
            this.output_lodging_Label.AutoSize = true;
            this.output_lodging_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_lodging_Label.Location = new System.Drawing.Point(294, 313);
            this.output_lodging_Label.Name = "output_lodging_Label";
            this.output_lodging_Label.Size = new System.Drawing.Size(17, 18);
            this.output_lodging_Label.TabIndex = 5;
            this.output_lodging_Label.Text = "0";
            this.output_lodging_Label.Visible = false;
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(227, 361);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 6;
            this.total_Label.Text = "Total:";
            // 
            // output_total_Label
            // 
            this.output_total_Label.AutoSize = true;
            this.output_total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_total_Label.Location = new System.Drawing.Point(284, 361);
            this.output_total_Label.Name = "output_total_Label";
            this.output_total_Label.Size = new System.Drawing.Size(17, 18);
            this.output_total_Label.TabIndex = 7;
            this.output_total_Label.Text = "0";
            this.output_total_Label.Visible = false;
            // 
            // select_Button
            // 
            this.select_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.select_Button.Location = new System.Drawing.Point(81, 417);
            this.select_Button.Name = "select_Button";
            this.select_Button.Size = new System.Drawing.Size(101, 34);
            this.select_Button.TabIndex = 8;
            this.select_Button.Text = "Select";
            this.select_Button.UseVisualStyleBackColor = true;
            this.select_Button.Click += new System.EventHandler(this.select_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(230, 417);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(101, 34);
            this.clear_Button.TabIndex = 9;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(378, 417);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(101, 34);
            this.exit_Button.TabIndex = 10;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // workshop_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 506);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.select_Button);
            this.Controls.Add(this.output_total_Label);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.output_lodging_Label);
            this.Controls.Add(this.lodging_Label);
            this.Controls.Add(this.output_registration_Label);
            this.Controls.Add(this.registration_Label);
            this.Controls.Add(this.location_Groupbox);
            this.Controls.Add(this.workshop_Groupbox);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "workshop_Form";
            this.Text = "Workshop Selector";
            this.workshop_Groupbox.ResumeLayout(false);
            this.location_Groupbox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox workshop_Groupbox;
        private System.Windows.Forms.ListBox workshop_Listbox;
        private System.Windows.Forms.GroupBox location_Groupbox;
        private System.Windows.Forms.ListBox location_Listbox;
        private System.Windows.Forms.Label registration_Label;
        private System.Windows.Forms.Label output_registration_Label;
        private System.Windows.Forms.Label lodging_Label;
        private System.Windows.Forms.Label output_lodging_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.Label output_total_Label;
        private System.Windows.Forms.Button select_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

