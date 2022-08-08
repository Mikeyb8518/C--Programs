namespace Stadium_Seating
{
    partial class stadium_seating_form
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
            this.tickets_sold_group = new System.Windows.Forms.GroupBox();
            this.ticket_sold_label = new System.Windows.Forms.Label();
            this.classA_label = new System.Windows.Forms.Label();
            this.classB_label = new System.Windows.Forms.Label();
            this.classC_label = new System.Windows.Forms.Label();
            this.classA_box = new System.Windows.Forms.TextBox();
            this.classB_box = new System.Windows.Forms.TextBox();
            this.classC_box = new System.Windows.Forms.TextBox();
            this.revenue_groupbox = new System.Windows.Forms.GroupBox();
            this.classA_label2 = new System.Windows.Forms.Label();
            this.classB_label2 = new System.Windows.Forms.Label();
            this.classC_label2 = new System.Windows.Forms.Label();
            this.revenue_classA_box = new System.Windows.Forms.TextBox();
            this.revenue_classB_box = new System.Windows.Forms.TextBox();
            this.revenue_classC_box = new System.Windows.Forms.TextBox();
            this.total_label = new System.Windows.Forms.Label();
            this.total_box = new System.Windows.Forms.TextBox();
            this.calculate_button = new System.Windows.Forms.Button();
            this.clear_button = new System.Windows.Forms.Button();
            this.exit_button = new System.Windows.Forms.Button();
            this.tickets_sold_group.SuspendLayout();
            this.revenue_groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // tickets_sold_group
            // 
            this.tickets_sold_group.Controls.Add(this.classC_box);
            this.tickets_sold_group.Controls.Add(this.classB_box);
            this.tickets_sold_group.Controls.Add(this.classA_box);
            this.tickets_sold_group.Controls.Add(this.classC_label);
            this.tickets_sold_group.Controls.Add(this.classB_label);
            this.tickets_sold_group.Controls.Add(this.classA_label);
            this.tickets_sold_group.Controls.Add(this.ticket_sold_label);
            this.tickets_sold_group.Location = new System.Drawing.Point(31, 53);
            this.tickets_sold_group.Name = "tickets_sold_group";
            this.tickets_sold_group.Size = new System.Drawing.Size(350, 219);
            this.tickets_sold_group.TabIndex = 0;
            this.tickets_sold_group.TabStop = false;
            this.tickets_sold_group.Text = "Tickets Sold";
            // 
            // ticket_sold_label
            // 
            this.ticket_sold_label.Location = new System.Drawing.Point(23, 27);
            this.ticket_sold_label.Name = "ticket_sold_label";
            this.ticket_sold_label.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ticket_sold_label.Size = new System.Drawing.Size(195, 42);
            this.ticket_sold_label.TabIndex = 0;
            this.ticket_sold_label.Text = "Enter the number of tickets sold for each class of seats.";
            this.ticket_sold_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ticket_sold_label.Click += new System.EventHandler(this.ticket_sold_label_Click);
            // 
            // classA_label
            // 
            this.classA_label.AutoSize = true;
            this.classA_label.Location = new System.Drawing.Point(56, 103);
            this.classA_label.Name = "classA_label";
            this.classA_label.Size = new System.Drawing.Size(56, 16);
            this.classA_label.TabIndex = 1;
            this.classA_label.Text = "Class A:";
            // 
            // classB_label
            // 
            this.classB_label.AutoSize = true;
            this.classB_label.Location = new System.Drawing.Point(56, 141);
            this.classB_label.Name = "classB_label";
            this.classB_label.Size = new System.Drawing.Size(56, 16);
            this.classB_label.TabIndex = 2;
            this.classB_label.Text = "Class B:";
            // 
            // classC_label
            // 
            this.classC_label.AutoSize = true;
            this.classC_label.Location = new System.Drawing.Point(56, 177);
            this.classC_label.Name = "classC_label";
            this.classC_label.Size = new System.Drawing.Size(56, 16);
            this.classC_label.TabIndex = 3;
            this.classC_label.Text = "Class C:";
            // 
            // classA_box
            // 
            this.classA_box.Location = new System.Drawing.Point(127, 100);
            this.classA_box.Name = "classA_box";
            this.classA_box.Size = new System.Drawing.Size(106, 22);
            this.classA_box.TabIndex = 1;
            this.classA_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classB_box
            // 
            this.classB_box.Location = new System.Drawing.Point(127, 138);
            this.classB_box.Name = "classB_box";
            this.classB_box.Size = new System.Drawing.Size(106, 22);
            this.classB_box.TabIndex = 2;
            this.classB_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // classC_box
            // 
            this.classC_box.Location = new System.Drawing.Point(127, 174);
            this.classC_box.Name = "classC_box";
            this.classC_box.Size = new System.Drawing.Size(106, 22);
            this.classC_box.TabIndex = 3;
            this.classC_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // revenue_groupbox
            // 
            this.revenue_groupbox.Controls.Add(this.total_box);
            this.revenue_groupbox.Controls.Add(this.total_label);
            this.revenue_groupbox.Controls.Add(this.revenue_classC_box);
            this.revenue_groupbox.Controls.Add(this.revenue_classB_box);
            this.revenue_groupbox.Controls.Add(this.revenue_classA_box);
            this.revenue_groupbox.Controls.Add(this.classC_label2);
            this.revenue_groupbox.Controls.Add(this.classB_label2);
            this.revenue_groupbox.Controls.Add(this.classA_label2);
            this.revenue_groupbox.Location = new System.Drawing.Point(440, 59);
            this.revenue_groupbox.Name = "revenue_groupbox";
            this.revenue_groupbox.Size = new System.Drawing.Size(291, 213);
            this.revenue_groupbox.TabIndex = 1;
            this.revenue_groupbox.TabStop = false;
            this.revenue_groupbox.Text = "Revenue Generated";
            // 
            // classA_label2
            // 
            this.classA_label2.AutoSize = true;
            this.classA_label2.Location = new System.Drawing.Point(39, 48);
            this.classA_label2.Name = "classA_label2";
            this.classA_label2.Size = new System.Drawing.Size(56, 16);
            this.classA_label2.TabIndex = 2;
            this.classA_label2.Text = "Class A:";
            // 
            // classB_label2
            // 
            this.classB_label2.AutoSize = true;
            this.classB_label2.Location = new System.Drawing.Point(39, 82);
            this.classB_label2.Name = "classB_label2";
            this.classB_label2.Size = new System.Drawing.Size(56, 16);
            this.classB_label2.TabIndex = 3;
            this.classB_label2.Text = "Class B:";
            // 
            // classC_label2
            // 
            this.classC_label2.AutoSize = true;
            this.classC_label2.Location = new System.Drawing.Point(39, 117);
            this.classC_label2.Name = "classC_label2";
            this.classC_label2.Size = new System.Drawing.Size(56, 16);
            this.classC_label2.TabIndex = 4;
            this.classC_label2.Text = "Class C:";
            // 
            // revenue_classA_box
            // 
            this.revenue_classA_box.Location = new System.Drawing.Point(119, 45);
            this.revenue_classA_box.Name = "revenue_classA_box";
            this.revenue_classA_box.Size = new System.Drawing.Size(106, 22);
            this.revenue_classA_box.TabIndex = 5;
            this.revenue_classA_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // revenue_classB_box
            // 
            this.revenue_classB_box.Location = new System.Drawing.Point(119, 79);
            this.revenue_classB_box.Name = "revenue_classB_box";
            this.revenue_classB_box.Size = new System.Drawing.Size(106, 22);
            this.revenue_classB_box.TabIndex = 6;
            this.revenue_classB_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // revenue_classC_box
            // 
            this.revenue_classC_box.Location = new System.Drawing.Point(119, 114);
            this.revenue_classC_box.Name = "revenue_classC_box";
            this.revenue_classC_box.Size = new System.Drawing.Size(106, 22);
            this.revenue_classC_box.TabIndex = 7;
            this.revenue_classC_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // total_label
            // 
            this.total_label.AutoSize = true;
            this.total_label.Location = new System.Drawing.Point(54, 172);
            this.total_label.Name = "total_label";
            this.total_label.Size = new System.Drawing.Size(41, 16);
            this.total_label.TabIndex = 8;
            this.total_label.Text = "Total:";
            // 
            // total_box
            // 
            this.total_box.Location = new System.Drawing.Point(119, 169);
            this.total_box.Name = "total_box";
            this.total_box.Size = new System.Drawing.Size(106, 22);
            this.total_box.TabIndex = 9;
            this.total_box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_button
            // 
            this.calculate_button.Location = new System.Drawing.Point(151, 309);
            this.calculate_button.Name = "calculate_button";
            this.calculate_button.Size = new System.Drawing.Size(98, 50);
            this.calculate_button.TabIndex = 3;
            this.calculate_button.Text = "Calculate Revenue";
            this.calculate_button.UseVisualStyleBackColor = true;
            this.calculate_button.Click += new System.EventHandler(this.calculate_button_Click);
            // 
            // clear_button
            // 
            this.clear_button.Location = new System.Drawing.Point(309, 309);
            this.clear_button.Name = "clear_button";
            this.clear_button.Size = new System.Drawing.Size(98, 50);
            this.clear_button.TabIndex = 3;
            this.clear_button.Text = "Clear";
            this.clear_button.UseVisualStyleBackColor = true;
            this.clear_button.Click += new System.EventHandler(this.clear_button_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(461, 309);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(98, 50);
            this.exit_button.TabIndex = 4;
            this.exit_button.Text = "Exit";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // stadium_seating_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(765, 396);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.clear_button);
            this.Controls.Add(this.calculate_button);
            this.Controls.Add(this.revenue_groupbox);
            this.Controls.Add(this.tickets_sold_group);
            this.Name = "stadium_seating_form";
            this.Text = "Stadium Seating";
            this.tickets_sold_group.ResumeLayout(false);
            this.tickets_sold_group.PerformLayout();
            this.revenue_groupbox.ResumeLayout(false);
            this.revenue_groupbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox tickets_sold_group;
        private System.Windows.Forms.Label ticket_sold_label;
        private System.Windows.Forms.TextBox classC_box;
        private System.Windows.Forms.TextBox classB_box;
        private System.Windows.Forms.TextBox classA_box;
        private System.Windows.Forms.Label classC_label;
        private System.Windows.Forms.Label classB_label;
        private System.Windows.Forms.Label classA_label;
        private System.Windows.Forms.GroupBox revenue_groupbox;
        private System.Windows.Forms.TextBox total_box;
        private System.Windows.Forms.Label total_label;
        private System.Windows.Forms.TextBox revenue_classC_box;
        private System.Windows.Forms.TextBox revenue_classB_box;
        private System.Windows.Forms.TextBox revenue_classA_box;
        private System.Windows.Forms.Label classC_label2;
        private System.Windows.Forms.Label classB_label2;
        private System.Windows.Forms.Label classA_label2;
        private System.Windows.Forms.Button calculate_button;
        private System.Windows.Forms.Button clear_button;
        private System.Windows.Forms.Button exit_button;
    }
}

