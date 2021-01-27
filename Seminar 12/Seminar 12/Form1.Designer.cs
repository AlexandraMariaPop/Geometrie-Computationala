namespace Seminar_12
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
            this.Ex1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Ex2 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Ex3 = new System.Windows.Forms.Button();
            this.Ex4 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(974, 646);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Ex1
            // 
            this.Ex1.Location = new System.Drawing.Point(980, 14);
            this.Ex1.Name = "Ex1";
            this.Ex1.Size = new System.Drawing.Size(75, 23);
            this.Ex1.TabIndex = 1;
            this.Ex1.Text = "Ex1";
            this.Ex1.UseVisualStyleBackColor = true;
            this.Ex1.Click += new System.EventHandler(this.Ex1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1070, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(209, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Ex2
            // 
            this.Ex2.Location = new System.Drawing.Point(980, 85);
            this.Ex2.Name = "Ex2";
            this.Ex2.Size = new System.Drawing.Size(75, 23);
            this.Ex2.TabIndex = 3;
            this.Ex2.Text = "Ex2";
            this.Ex2.UseVisualStyleBackColor = true;
            this.Ex2.Click += new System.EventHandler(this.Ex2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(1070, 85);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(209, 23);
            this.textBox2.TabIndex = 4;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Ex3
            // 
            this.Ex3.Location = new System.Drawing.Point(980, 155);
            this.Ex3.Name = "Ex3";
            this.Ex3.Size = new System.Drawing.Size(75, 23);
            this.Ex3.TabIndex = 5;
            this.Ex3.Text = "Ex3";
            this.Ex3.UseVisualStyleBackColor = true;
            this.Ex3.Click += new System.EventHandler(this.Ex3_Click);
            // 
            // Ex4
            // 
            this.Ex4.Location = new System.Drawing.Point(980, 220);
            this.Ex4.Name = "Ex4";
            this.Ex4.Size = new System.Drawing.Size(75, 23);
            this.Ex4.TabIndex = 6;
            this.Ex4.Text = "Ex4";
            this.Ex4.UseVisualStyleBackColor = true;
            this.Ex4.Click += new System.EventHandler(this.Ex4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 649);
            this.Controls.Add(this.Ex4);
            this.Controls.Add(this.Ex3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.Ex2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Ex1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ex1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Ex2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button Ex3;
        private System.Windows.Forms.Button Ex4;
    }
}

