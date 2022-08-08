
namespace Heads_or_Tails
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.heads_Pic = new System.Windows.Forms.PictureBox();
            this.tails_Pic = new System.Windows.Forms.PictureBox();
            this.show_Heads_Button = new System.Windows.Forms.Button();
            this.show_Tails_Button = new System.Windows.Forms.Button();
            this.exit_Button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.heads_Pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tails_Pic)).BeginInit();
            this.SuspendLayout();
            // 
            // heads_Pic
            // 
            this.heads_Pic.Image = ((System.Drawing.Image)(resources.GetObject("heads_Pic.Image")));
            this.heads_Pic.Location = new System.Drawing.Point(39, 34);
            this.heads_Pic.Name = "heads_Pic";
            this.heads_Pic.Size = new System.Drawing.Size(168, 159);
            this.heads_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.heads_Pic.TabIndex = 0;
            this.heads_Pic.TabStop = false;
            this.heads_Pic.Visible = false;
            // 
            // tails_Pic
            // 
            this.tails_Pic.Image = ((System.Drawing.Image)(resources.GetObject("tails_Pic.Image")));
            this.tails_Pic.Location = new System.Drawing.Point(293, 34);
            this.tails_Pic.Name = "tails_Pic";
            this.tails_Pic.Size = new System.Drawing.Size(168, 159);
            this.tails_Pic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tails_Pic.TabIndex = 1;
            this.tails_Pic.TabStop = false;
            this.tails_Pic.Visible = false;
            // 
            // show_Heads_Button
            // 
            this.show_Heads_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_Heads_Button.Location = new System.Drawing.Point(26, 271);
            this.show_Heads_Button.Name = "show_Heads_Button";
            this.show_Heads_Button.Size = new System.Drawing.Size(124, 50);
            this.show_Heads_Button.TabIndex = 2;
            this.show_Heads_Button.Text = "Show Heads";
            this.show_Heads_Button.UseVisualStyleBackColor = true;
            this.show_Heads_Button.Click += new System.EventHandler(this.show_Heads_Button_Click);
            // 
            // show_Tails_Button
            // 
            this.show_Tails_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.show_Tails_Button.Location = new System.Drawing.Point(181, 271);
            this.show_Tails_Button.Name = "show_Tails_Button";
            this.show_Tails_Button.Size = new System.Drawing.Size(124, 50);
            this.show_Tails_Button.TabIndex = 3;
            this.show_Tails_Button.Text = "Show Tails";
            this.show_Tails_Button.UseVisualStyleBackColor = true;
            this.show_Tails_Button.Click += new System.EventHandler(this.show_Tails_Button_Click);
            // 
            // exit_Button
            // 
            this.exit_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_Button.Location = new System.Drawing.Point(337, 271);
            this.exit_Button.Name = "exit_Button";
            this.exit_Button.Size = new System.Drawing.Size(124, 50);
            this.exit_Button.TabIndex = 4;
            this.exit_Button.Text = "Exit";
            this.exit_Button.UseVisualStyleBackColor = true;
            this.exit_Button.Click += new System.EventHandler(this.exit_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 380);
            this.Controls.Add(this.exit_Button);
            this.Controls.Add(this.show_Tails_Button);
            this.Controls.Add(this.show_Heads_Button);
            this.Controls.Add(this.tails_Pic);
            this.Controls.Add(this.heads_Pic);
            this.Name = "Form1";
            this.Text = "Heads or Tails";
            ((System.ComponentModel.ISupportInitialize)(this.heads_Pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tails_Pic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox heads_Pic;
        private System.Windows.Forms.PictureBox tails_Pic;
        private System.Windows.Forms.Button show_Heads_Button;
        private System.Windows.Forms.Button show_Tails_Button;
        private System.Windows.Forms.Button exit_Button;
    }
}

