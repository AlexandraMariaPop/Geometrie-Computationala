namespace curs10
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
            this.Ex2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 472);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // ex1
            // 
            this.ex1.Location = new System.Drawing.Point(750, 23);
            this.ex1.Name = "ex1";
            this.ex1.Size = new System.Drawing.Size(75, 23);
            this.ex1.TabIndex = 1;
            this.ex1.Text = "Ex1";
            this.ex1.UseVisualStyleBackColor = true;
            this.ex1.Click += new System.EventHandler(this.ex1_Click);
            // 
            // Ex2
            // 
            this.Ex2.Location = new System.Drawing.Point(750, 85);
            this.Ex2.Name = "Ex2";
            this.Ex2.Size = new System.Drawing.Size(75, 23);
            this.Ex2.TabIndex = 2;
            this.Ex2.Text = "Ex2";
            this.Ex2.UseVisualStyleBackColor = true;
            this.Ex2.Click += new System.EventHandler(this.Ex2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(747, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Vizionea camerelor este data de liniile Roz";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 496);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Ex2);
            this.Controls.Add(this.ex1);
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
        private System.Windows.Forms.Button ex1;
        private System.Windows.Forms.Button Ex2;
        private System.Windows.Forms.Label label1;
    }
}

