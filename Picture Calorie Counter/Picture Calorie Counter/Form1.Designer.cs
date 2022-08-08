namespace Picture_Calorie_Counter
{
    partial class calorie_Counter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(calorie_Counter));
            this.banana_Box = new System.Windows.Forms.PictureBox();
            this.apple_Box = new System.Windows.Forms.PictureBox();
            this.orange_Box = new System.Windows.Forms.PictureBox();
            this.pear_Box = new System.Windows.Forms.PictureBox();
            this.click_Label = new System.Windows.Forms.Label();
            this.total_Label = new System.Windows.Forms.Label();
            this.total_Box = new System.Windows.Forms.TextBox();
            this.reset_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.banana_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_Box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pear_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // banana_Box
            // 
            this.banana_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.banana_Box.Image = ((System.Drawing.Image)(resources.GetObject("banana_Box.Image")));
            this.banana_Box.Location = new System.Drawing.Point(48, 48);
            this.banana_Box.Name = "banana_Box";
            this.banana_Box.Size = new System.Drawing.Size(146, 163);
            this.banana_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.banana_Box.TabIndex = 0;
            this.banana_Box.TabStop = false;
            this.banana_Box.Click += new System.EventHandler(this.banana_Box_Click);
            // 
            // apple_Box
            // 
            this.apple_Box.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.apple_Box.Image = ((System.Drawing.Image)(resources.GetObject("apple_Box.Image")));
            this.apple_Box.Location = new System.Drawing.Point(214, 48);
            this.apple_Box.Name = "apple_Box";
            this.apple_Box.Size = new System.Drawing.Size(146, 163);
            this.apple_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.apple_Box.TabIndex = 1;
            this.apple_Box.TabStop = false;
            this.apple_Box.Click += new System.EventHandler(this.apple_Box_Click);
            // 
            // orange_Box
            // 
            this.orange_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.orange_Box.Image = ((System.Drawing.Image)(resources.GetObject("orange_Box.Image")));
            this.orange_Box.Location = new System.Drawing.Point(48, 231);
            this.orange_Box.Name = "orange_Box";
            this.orange_Box.Size = new System.Drawing.Size(146, 163);
            this.orange_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.orange_Box.TabIndex = 2;
            this.orange_Box.TabStop = false;
            this.orange_Box.Click += new System.EventHandler(this.orange_Box_Click);
            // 
            // pear_Box
            // 
            this.pear_Box.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pear_Box.Image = ((System.Drawing.Image)(resources.GetObject("pear_Box.Image")));
            this.pear_Box.Location = new System.Drawing.Point(214, 231);
            this.pear_Box.Name = "pear_Box";
            this.pear_Box.Size = new System.Drawing.Size(146, 163);
            this.pear_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pear_Box.TabIndex = 3;
            this.pear_Box.TabStop = false;
            this.pear_Box.Click += new System.EventHandler(this.pear_Box_Click);
            // 
            // click_Label
            // 
            this.click_Label.AutoSize = true;
            this.click_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.click_Label.Location = new System.Drawing.Point(128, 18);
            this.click_Label.Name = "click_Label";
            this.click_Label.Size = new System.Drawing.Size(151, 18);
            this.click_Label.TabIndex = 4;
            this.click_Label.Text = "Click The Picutres:";
            // 
            // total_Label
            // 
            this.total_Label.AutoSize = true;
            this.total_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Label.Location = new System.Drawing.Point(408, 68);
            this.total_Label.Name = "total_Label";
            this.total_Label.Size = new System.Drawing.Size(114, 18);
            this.total_Label.TabIndex = 5;
            this.total_Label.Text = "Total Calories";
            // 
            // total_Box
            // 
            this.total_Box.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.total_Box.Location = new System.Drawing.Point(393, 92);
            this.total_Box.Multiline = true;
            this.total_Box.Name = "total_Box";
            this.total_Box.Size = new System.Drawing.Size(151, 29);
            this.total_Box.TabIndex = 6;
            this.total_Box.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // reset_Button
            // 
            this.reset_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reset_Button.Location = new System.Drawing.Point(411, 318);
            this.reset_Button.Name = "reset_Button";
            this.reset_Button.Size = new System.Drawing.Size(98, 28);
            this.reset_Button.TabIndex = 7;
            this.reset_Button.Text = "Reset";
            this.reset_Button.UseVisualStyleBackColor = true;
            this.reset_Button.Click += new System.EventHandler(this.reset_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(411, 366);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(98, 28);
            this.exit_Button.TabIndex = 8;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // calorie_Counter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 450);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.reset_Button);
            this.Controls.Add(this.total_Box);
            this.Controls.Add(this.total_Label);
            this.Controls.Add(this.click_Label);
            this.Controls.Add(this.pear_Box);
            this.Controls.Add(this.orange_Box);
            this.Controls.Add(this.apple_Box);
            this.Controls.Add(this.banana_Box);
            this.Name = "calorie_Counter";
            this.Text = "Calorie Counter";
            this.Load += new System.EventHandler(this.calorie_Counter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banana_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.apple_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orange_Box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pear_Box)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox banana_Box;
        private System.Windows.Forms.PictureBox apple_Box;
        private System.Windows.Forms.PictureBox orange_Box;
        private System.Windows.Forms.PictureBox pear_Box;
        private System.Windows.Forms.Label click_Label;
        private System.Windows.Forms.Label total_Label;
        private System.Windows.Forms.TextBox total_Box;
        private System.Windows.Forms.Button reset_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

