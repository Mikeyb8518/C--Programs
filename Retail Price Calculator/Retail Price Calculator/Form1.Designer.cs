namespace Retail_Price_Calculator
{
    partial class retail_Price_Form
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
            this.wholesale_Label = new System.Windows.Forms.Label();
            this.cost_Textbox = new System.Windows.Forms.TextBox();
            this.markup_Label = new System.Windows.Forms.Label();
            this.markup_Textbox = new System.Windows.Forms.TextBox();
            this.price_Groupbox = new System.Windows.Forms.GroupBox();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Textbox = new System.Windows.Forms.TextBox();
            this.calculate_Button = new System.Windows.Forms.Button();
            this.clear_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            this.price_Groupbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // wholesale_Label
            // 
            this.wholesale_Label.AutoSize = true;
            this.wholesale_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.wholesale_Label.Location = new System.Drawing.Point(9, 38);
            this.wholesale_Label.Name = "wholesale_Label";
            this.wholesale_Label.Size = new System.Drawing.Size(250, 16);
            this.wholesale_Label.TabIndex = 0;
            this.wholesale_Label.Text = "Please Enter The Whole Sale Cost:";
            // 
            // cost_Textbox
            // 
            this.cost_Textbox.Location = new System.Drawing.Point(293, 33);
            this.cost_Textbox.Name = "cost_Textbox";
            this.cost_Textbox.Size = new System.Drawing.Size(98, 24);
            this.cost_Textbox.TabIndex = 1;
            this.cost_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // markup_Label
            // 
            this.markup_Label.AutoSize = true;
            this.markup_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.markup_Label.Location = new System.Drawing.Point(73, 96);
            this.markup_Label.Name = "markup_Label";
            this.markup_Label.Size = new System.Drawing.Size(186, 16);
            this.markup_Label.TabIndex = 2;
            this.markup_Label.Text = "Enter Markup Percentage:";
            // 
            // markup_Textbox
            // 
            this.markup_Textbox.Location = new System.Drawing.Point(293, 96);
            this.markup_Textbox.Name = "markup_Textbox";
            this.markup_Textbox.Size = new System.Drawing.Size(98, 24);
            this.markup_Textbox.TabIndex = 2;
            this.markup_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // price_Groupbox
            // 
            this.price_Groupbox.Controls.Add(this.markup_Textbox);
            this.price_Groupbox.Controls.Add(this.markup_Label);
            this.price_Groupbox.Controls.Add(this.cost_Textbox);
            this.price_Groupbox.Controls.Add(this.wholesale_Label);
            this.price_Groupbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price_Groupbox.Location = new System.Drawing.Point(3, 10);
            this.price_Groupbox.Name = "price_Groupbox";
            this.price_Groupbox.Size = new System.Drawing.Size(452, 161);
            this.price_Groupbox.TabIndex = 3;
            this.price_Groupbox.TabStop = false;
            this.price_Groupbox.Text = "Price Calculator";
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(134, 202);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(51, 18);
            this.total_Label.TabIndex = 4;
            this.total_Label.Text = "Total:";
            // 
            // total_Textbox
            // 
            this.total_Textbox.BackColor = System.Drawing.SystemColors.Menu;
            this.total_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Textbox.Location = new System.Drawing.Point(200, 199);
            this.total_Textbox.Multiline = true;
            this.total_Textbox.Name = "total_Textbox";
            this.total_Textbox.Size = new System.Drawing.Size(97, 24);
            this.total_Textbox.TabIndex = 5;
            this.total_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // calculate_Button
            // 
            this.calculate_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculate_Button.Location = new System.Drawing.Point(33, 253);
            this.calculate_Button.Name = "calculate_Button";
            this.calculate_Button.Size = new System.Drawing.Size(105, 31);
            this.calculate_Button.TabIndex = 3;
            this.calculate_Button.Text = "Calculate";
            this.calculate_Button.UseVisualStyleBackColor = true;
            this.calculate_Button.Click += new System.EventHandler(this.calculate_Button_Click);
            // 
            // clear_Button
            // 
            this.clear_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clear_Button.Location = new System.Drawing.Point(174, 253);
            this.clear_Button.Name = "clear_Button";
            this.clear_Button.Size = new System.Drawing.Size(105, 31);
            this.clear_Button.TabIndex = 4;
            this.clear_Button.Text = "Clear";
            this.clear_Button.UseVisualStyleBackColor = true;
            this.clear_Button.Click += new System.EventHandler(this.clear_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(314, 253);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(105, 31);
            this.exit_Button.TabIndex = 5;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // retail_Price_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 308);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.clear_Button);
            this.Controls.Add(this.calculate_Button);
            this.Controls.Add(this.total_Textbox);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.price_Groupbox);
            this.Name = "retail_Price_Form";
            this.Text = "Retail Price Calculator";
            this.price_Groupbox.ResumeLayout(false);
            this.price_Groupbox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label wholesale_Label;
        private System.Windows.Forms.TextBox cost_Textbox;
        private System.Windows.Forms.Label markup_Label;
        private System.Windows.Forms.TextBox markup_Textbox;
        private System.Windows.Forms.GroupBox price_Groupbox;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox total_Textbox;
        private System.Windows.Forms.Button calculate_Button;
        private System.Windows.Forms.Button clear_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

