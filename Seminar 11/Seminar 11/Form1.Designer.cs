﻿namespace Seminar_11
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
            this.Ex2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(723, 487);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Ex1
            // 
            this.Ex1.Location = new System.Drawing.Point(768, 12);
            this.Ex1.Name = "Ex1";
            this.Ex1.Size = new System.Drawing.Size(75, 23);
            this.Ex1.TabIndex = 1;
            this.Ex1.Text = "Ex1";
            this.Ex1.UseVisualStyleBackColor = true;
            this.Ex1.Click += new System.EventHandler(this.Ex1_Click);
            // 
            // Ex2
            // 
            this.Ex2.Location = new System.Drawing.Point(768, 60);
            this.Ex2.Name = "Ex2";
            this.Ex2.Size = new System.Drawing.Size(75, 23);
            this.Ex2.TabIndex = 2;
            this.Ex2.Text = "Ex2";
            this.Ex2.UseVisualStyleBackColor = true;
            this.Ex2.Click += new System.EventHandler(this.Ex2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 526);
            this.Controls.Add(this.Ex2);
            this.Controls.Add(this.Ex1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Ex1;
        private System.Windows.Forms.Button Ex2;
    }
}

