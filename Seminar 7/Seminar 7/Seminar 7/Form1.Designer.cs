namespace Seminar_7
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ex1 = new System.Windows.Forms.Button();
            this.ex2 = new System.Windows.Forms.Button();
            this.ex3 = new System.Windows.Forms.Button();
            this.ex4 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(543, 412);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ex1
            // 
            this.ex1.Location = new System.Drawing.Point(609, 32);
            this.ex1.Name = "ex1";
            this.ex1.Size = new System.Drawing.Size(75, 23);
            this.ex1.TabIndex = 1;
            this.ex1.Text = "ex1";
            this.ex1.UseVisualStyleBackColor = true;
            this.ex1.Click += new System.EventHandler(this.ex1_Click);
            // 
            // ex2
            // 
            this.ex2.Location = new System.Drawing.Point(609, 152);
            this.ex2.Name = "ex2";
            this.ex2.Size = new System.Drawing.Size(75, 23);
            this.ex2.TabIndex = 2;
            this.ex2.Text = "ex2";
            this.ex2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ex2.UseVisualStyleBackColor = true;
            // 
            // ex3
            // 
            this.ex3.Location = new System.Drawing.Point(609, 266);
            this.ex3.Name = "ex3";
            this.ex3.Size = new System.Drawing.Size(75, 23);
            this.ex3.TabIndex = 3;
            this.ex3.Text = "ex3";
            this.ex3.UseVisualStyleBackColor = true;
            // 
            // ex4
            // 
            this.ex4.Location = new System.Drawing.Point(902, 266);
            this.ex4.Name = "ex4";
            this.ex4.Size = new System.Drawing.Size(75, 23);
            this.ex4.TabIndex = 4;
            this.ex4.Text = "ex4";
            this.ex4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(731, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "ex1-2";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 478);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ex4);
            this.Controls.Add(this.ex3);
            this.Controls.Add(this.ex2);
            this.Controls.Add(this.ex1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button ex1;
        private System.Windows.Forms.Button ex2;
        private System.Windows.Forms.Button ex3;
        private System.Windows.Forms.Button ex4;
        private System.Windows.Forms.Button button1;
    }
}

