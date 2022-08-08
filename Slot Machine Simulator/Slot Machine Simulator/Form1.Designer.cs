namespace Slot_Machine_Simulator
{
    partial class slotMachine_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(slotMachine_Form));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.fruitList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.amount_Label = new System.Windows.Forms.Label();
            this.amount_Textbox = new System.Windows.Forms.TextBox();
            this.spin_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(44, 37);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 153);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // fruitList1
            // 
            this.fruitList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("fruitList1.ImageStream")));
            this.fruitList1.TransparentColor = System.Drawing.Color.Transparent;
            this.fruitList1.Images.SetKeyName(0, "Apple.bmp");
            this.fruitList1.Images.SetKeyName(1, "Banana.bmp");
            this.fruitList1.Images.SetKeyName(2, "Cherries.bmp");
            this.fruitList1.Images.SetKeyName(3, "Grapes.bmp");
            this.fruitList1.Images.SetKeyName(4, "Lemon.bmp");
            this.fruitList1.Images.SetKeyName(5, "Lime.bmp");
            this.fruitList1.Images.SetKeyName(6, "Orange.bmp");
            this.fruitList1.Images.SetKeyName(7, "Pear.bmp");
            this.fruitList1.Images.SetKeyName(8, "Strawberry.bmp");
            this.fruitList1.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // pictureBox2
            // 
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Location = new System.Drawing.Point(231, 37);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(161, 153);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Location = new System.Drawing.Point(416, 37);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(161, 153);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "Apple.bmp");
            this.imageList2.Images.SetKeyName(1, "Banana.bmp");
            this.imageList2.Images.SetKeyName(2, "Cherries.bmp");
            this.imageList2.Images.SetKeyName(3, "Grapes.bmp");
            this.imageList2.Images.SetKeyName(4, "Lemon.bmp");
            this.imageList2.Images.SetKeyName(5, "Lime.bmp");
            this.imageList2.Images.SetKeyName(6, "Orange.bmp");
            this.imageList2.Images.SetKeyName(7, "Pear.bmp");
            this.imageList2.Images.SetKeyName(8, "Strawberry.bmp");
            this.imageList2.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Apple.bmp");
            this.imageList3.Images.SetKeyName(1, "Banana.bmp");
            this.imageList3.Images.SetKeyName(2, "Cherries.bmp");
            this.imageList3.Images.SetKeyName(3, "Grapes.bmp");
            this.imageList3.Images.SetKeyName(4, "Lemon.bmp");
            this.imageList3.Images.SetKeyName(5, "Lime.bmp");
            this.imageList3.Images.SetKeyName(6, "Orange.bmp");
            this.imageList3.Images.SetKeyName(7, "Pear.bmp");
            this.imageList3.Images.SetKeyName(8, "Strawberry.bmp");
            this.imageList3.Images.SetKeyName(9, "Watermelon.bmp");
            // 
            // amount_Label
            // 
            this.amount_Label.AutoSize = true;
            this.amount_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_Label.Location = new System.Drawing.Point(146, 237);
            this.amount_Label.Name = "amount_Label";
            this.amount_Label.Size = new System.Drawing.Size(149, 18);
            this.amount_Label.TabIndex = 3;
            this.amount_Label.Text = "Amount Inserted: $";
            // 
            // amount_Textbox
            // 
            this.amount_Textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_Textbox.Location = new System.Drawing.Point(318, 236);
            this.amount_Textbox.Multiline = true;
            this.amount_Textbox.Name = "amount_Textbox";
            this.amount_Textbox.Size = new System.Drawing.Size(108, 23);
            this.amount_Textbox.TabIndex = 4;
            this.amount_Textbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.amount_Textbox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // spin_Button
            // 
            this.spin_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin_Button.Location = new System.Drawing.Point(170, 289);
            this.spin_Button.Name = "spin_Button";
            this.spin_Button.Size = new System.Drawing.Size(92, 31);
            this.spin_Button.TabIndex = 5;
            this.spin_Button.Text = "Spin";
            this.spin_Button.UseVisualStyleBackColor = true;
            this.spin_Button.Click += new System.EventHandler(this.spin_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(355, 289);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(92, 31);
            this.exit_Button.TabIndex = 6;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // slotMachine_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 350);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.spin_Button);
            this.Controls.Add(this.amount_Textbox);
            this.Controls.Add(this.amount_Label);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "slotMachine_Form";
            this.Text = "Slot Machine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList fruitList1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.ImageList imageList3;
        private System.Windows.Forms.Label amount_Label;
        private System.Windows.Forms.TextBox amount_Textbox;
        private System.Windows.Forms.Button spin_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

