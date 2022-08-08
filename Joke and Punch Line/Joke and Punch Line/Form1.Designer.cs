
namespace Joke_and_Punch_Line
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
            this.setup_Box = new System.Windows.Forms.TextBox();
            this.punchline_Box = new System.Windows.Forms.TextBox();
            this.setup_Button = new System.Windows.Forms.Button();
            this.punchline_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // setup_Box
            // 
            this.setup_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.setup_Box.Location = new System.Drawing.Point(41, 62);
            this.setup_Box.Multiline = true;
            this.setup_Box.Name = "setup_Box";
            this.setup_Box.Size = new System.Drawing.Size(352, 44);
            this.setup_Box.TabIndex = 0;
            // 
            // punchline_Box
            // 
            this.punchline_Box.BackColor = System.Drawing.SystemColors.Menu;
            this.punchline_Box.Location = new System.Drawing.Point(41, 138);
            this.punchline_Box.Multiline = true;
            this.punchline_Box.Name = "punchline_Box";
            this.punchline_Box.Size = new System.Drawing.Size(352, 30);
            this.punchline_Box.TabIndex = 1;
            // 
            // setup_Button
            // 
            this.setup_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setup_Button.Location = new System.Drawing.Point(78, 220);
            this.setup_Button.Name = "setup_Button";
            this.setup_Button.Size = new System.Drawing.Size(108, 42);
            this.setup_Button.TabIndex = 2;
            this.setup_Button.Text = "Setup";
            this.setup_Button.UseVisualStyleBackColor = true;
            this.setup_Button.Click += new System.EventHandler(this.setup_Button_Click);
            // 
            // punchline_Button
            // 
            this.punchline_Button.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.punchline_Button.Location = new System.Drawing.Point(225, 220);
            this.punchline_Button.Name = "punchline_Button";
            this.punchline_Button.Size = new System.Drawing.Size(108, 42);
            this.punchline_Button.TabIndex = 3;
            this.punchline_Button.Text = "Punchline";
            this.punchline_Button.UseVisualStyleBackColor = true;
            this.punchline_Button.Click += new System.EventHandler(this.punchline_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 352);
            this.Controls.Add(this.punchline_Button);
            this.Controls.Add(this.setup_Button);
            this.Controls.Add(this.punchline_Box);
            this.Controls.Add(this.setup_Box);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox setup_Box;
        private System.Windows.Forms.TextBox punchline_Box;
        private System.Windows.Forms.Button setup_Button;
        private System.Windows.Forms.Button punchline_Button;
    }
}

