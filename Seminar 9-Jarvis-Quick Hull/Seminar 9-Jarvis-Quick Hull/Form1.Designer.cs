namespace Seminar_9_Jarvis_Quick_Hull
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.butonGenerare = new System.Windows.Forms.Button();
            this.buttonSet = new System.Windows.Forms.Button();
            this.buttonSet2 = new System.Windows.Forms.Button();
            this.UpDownPointCount = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPointCount)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.MistyRose;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(770, 506);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // butonGenerare
            // 
            this.butonGenerare.BackColor = System.Drawing.Color.Plum;
            this.butonGenerare.Location = new System.Drawing.Point(803, 24);
            this.butonGenerare.Name = "butonGenerare";
            this.butonGenerare.Size = new System.Drawing.Size(113, 31);
            this.butonGenerare.TabIndex = 1;
            this.butonGenerare.Text = "Generare Jarvis";
            this.butonGenerare.UseVisualStyleBackColor = false;
            this.butonGenerare.Click += new System.EventHandler(this.butonGenerare_Click);
            // 
            // buttonSet
            // 
            this.buttonSet.BackColor = System.Drawing.Color.Plum;
            this.buttonSet.Location = new System.Drawing.Point(803, 197);
            this.buttonSet.Name = "buttonSet";
            this.buttonSet.Size = new System.Drawing.Size(113, 31);
            this.buttonSet.TabIndex = 2;
            this.buttonSet.Text = "Ex 2";
            this.buttonSet.UseVisualStyleBackColor = false;
            this.buttonSet.Click += new System.EventHandler(this.buttonSet_Click);
            // 
            // buttonSet2
            // 
            this.buttonSet2.BackColor = System.Drawing.Color.Plum;
            this.buttonSet2.Location = new System.Drawing.Point(803, 350);
            this.buttonSet2.Name = "buttonSet2";
            this.buttonSet2.Size = new System.Drawing.Size(113, 31);
            this.buttonSet2.TabIndex = 3;
            this.buttonSet2.Text = "Quick Hull";
            this.buttonSet2.UseVisualStyleBackColor = false;
            this.buttonSet2.Click += new System.EventHandler(this.buttonSet2_Click);
            // 
            // UpDownPointCount
            // 
            this.UpDownPointCount.Location = new System.Drawing.Point(803, 108);
            this.UpDownPointCount.Name = "UpDownPointCount";
            this.UpDownPointCount.Size = new System.Drawing.Size(120, 20);
            this.UpDownPointCount.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(788, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Introduceti 20 pentru a afisa 20 de puncte random";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(1031, 539);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.UpDownPointCount);
            this.Controls.Add(this.buttonSet2);
            this.Controls.Add(this.buttonSet);
            this.Controls.Add(this.butonGenerare);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UpDownPointCount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button butonGenerare;
        private System.Windows.Forms.Button buttonSet;
        private System.Windows.Forms.Button buttonSet2;
        private System.Windows.Forms.NumericUpDown UpDownPointCount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
    }
}

