using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar5ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        Bitmap bmp1, bmp2, bmp3, bmp4;
        Graphics grp1, grp2, grp3, grp4;

        private void bisect_Click(object sender, EventArgs e)
        {
            xA = Convert.ToInt32(textBox1.Text);
            xB = Convert.ToInt32(textBox2.Text);
            xC = Convert.ToInt32(textBox3.Text);
            yA = Convert.ToInt32(textBox4.Text);
            yB = Convert.ToInt32(textBox5.Text);
            yC = Convert.ToInt32(textBox6.Text);

            PointF A = new PointF(xA, yA);
            PointF B = new PointF(xB, yB);
            PointF C = new PointF(xC, yC);

            grp2.DrawLine(Pens.Black, A, B);
            grp2.DrawLine(Pens.Black, A, C);
            grp2.DrawLine(Pens.Black, C, B);  

            Bisectoare(B, A, C, Color.Blue);
            Bisectoare(A, B, C, Color.Blue);
            Bisectoare(A, C, B, Color.Blue);

            pictureBox2.Image = bmp2;



        }
        private float Panta(PointF A, PointF B)
        {
            return (B.Y - A.Y) / (B.X - A.X);
        }
        private PointF Intersectie(PointF b, PointF c, PointF a, float panta)
        {
            float A1 = panta, A2 = Panta(b, c);
            float B1, B2;
            B1 = B2 = -1;
            float C1, C2;
            C1 = a.X * A1 - a.Y;
            C2 = A2 * b.X - b.Y;
            float det = A1 * B2 - A2 * B1;
            if (det == 0)
                throw new Exception("Eroare");
            float dx = C1 * B2 - B1 * C2;
            float dY = A1 * C2 - C1 * A2;
            float X = dx / det;
            float Y = dY / det;
            return new PointF(X, Y);


        }
        private void Bisectoare(PointF B, PointF A, PointF C, Color color)
        {
            float Aleft = Panta(B, A), Aright = Panta(A, C);
            float Bleft, BRight;
            Bleft = BRight = -1;
            float Cleft, Cright;
            Cleft = Aleft * A.X + A.Y;
            Cright = Aright * A.X + A.Y;
            float tleft, tright;
            tleft = (float)Math.Sqrt(Aleft * Aleft + Cleft * Cleft);
            tright = (float)Math.Sqrt(Aright * Aright + Cright * Cright);
            float pantabisectoare = (-tleft * Aright - tright * Aleft) / (tright * Aleft + tleft * BRight);
            //   float nbisectoare = -(tleft * Cright - tright * Cleft) / (tright * Bleft - tleft * BRight);
            float p2 = (Aleft * tright + Aright * tleft) / (-tright * Bleft - tleft * BRight);
            PointF Inter = Intersectie(B, C, A, p2);


            grp2.DrawLine(new Pen(color), A, Inter);


        }

        private void inaltime_Click(object sender, EventArgs e)
        {
            xA = Convert.ToInt32(textBox1.Text);
            xB = Convert.ToInt32(textBox2.Text);
            xC = Convert.ToInt32(textBox3.Text);
            yA = Convert.ToInt32(textBox4.Text);
            yB = Convert.ToInt32(textBox5.Text);
            yC = Convert.ToInt32(textBox6.Text);

            PointF A = new PointF(xA, yA);
            PointF B = new PointF(xB, yB);
            PointF C = new PointF(xC, yC);

            PointF med_A = new PointF((xB + xC) / 2, (yB + yC) / 2);
            PointF med_B = new PointF((xA + xC) / 2, (yA + yC) / 2);
            PointF med_C = new PointF((xB + xA) / 2, (yB + yA) / 2);

            grp3.DrawLine(Pens.Black, A, B);
            grp3.DrawLine(Pens.Black, A, C);
            grp3.DrawLine(Pens.Black, C, B);

            grp3.DrawLine(Pens.Green, A, med_A);
            grp3.DrawLine(Pens.Green, B, med_B);
            grp3.DrawLine(Pens.Green, C, med_C);

            pictureBox3.Image = bmp3;
        }

        private void Mediatoare_Click(object sender, EventArgs e)
        {
            xA = Convert.ToInt32(textBox1.Text);
            xB = Convert.ToInt32(textBox2.Text);
            xC = Convert.ToInt32(textBox3.Text);
            yA = Convert.ToInt32(textBox4.Text);
            yB = Convert.ToInt32(textBox5.Text);
            yC = Convert.ToInt32(textBox6.Text);

            PointF A = new PointF(xA, yA);
            PointF B = new PointF(xB, yB);
            PointF C = new PointF(xC, yC);

            PointF med_A = new PointF((xB + xC) / 2, (yB + yC) / 2);
            PointF med_B = new PointF((xA + xC) / 2, (yA + yC) / 2);
            PointF med_C = new PointF((xB + xA) / 2, (yB + yA) / 2);

            grp4.DrawLine(Pens.Black, A, B);
            grp4.DrawLine(Pens.Black, A, C);
            grp4.DrawLine(Pens.Black, C, B);

            grp4.DrawLine(Pens.Magenta, A, med_A);
            grp4.DrawLine(Pens.Magenta, B, med_B);
            grp4.DrawLine(Pens.Magenta, C, med_C);

            pictureBox4.Image = bmp4;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void Mediana_Click(object sender, EventArgs e)
        {
            xA = Convert.ToInt32(textBox1.Text);
            xB = Convert.ToInt32(textBox2.Text);
            xC = Convert.ToInt32(textBox3.Text);
            yA = Convert.ToInt32(textBox4.Text);
            yB = Convert.ToInt32(textBox5.Text);
            yC = Convert.ToInt32(textBox6.Text);

            PointF A = new PointF(xA, yA);
            PointF B = new PointF(xB, yB);
            PointF C = new PointF(xC, yC);

            PointF med_A = new PointF((xB + xC) / 2, (yB + yC) / 2);
            PointF med_B = new PointF((xA + xC) / 2, (yA + yC) / 2);
            PointF med_C = new PointF((xB + xA) / 2, (yB + yA) / 2);

            grp1.DrawLine(Pens.Black, A, B);
            grp1.DrawLine(Pens.Black, A, C);
            grp1.DrawLine(Pens.Black, C, B);

            grp1.DrawLine(Pens.Red, A, med_A);
            grp1.DrawLine(Pens.Red, B, med_B);
            grp1.DrawLine(Pens.Red, C, med_C);

            pictureBox1.Image = bmp1;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        int xA, yA, xB, yB, xC, yC;

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp1 = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp1 = Graphics.FromImage(bmp1);

            bmp2 = new Bitmap(pictureBox2.Width, pictureBox2.Height);
            grp2 = Graphics.FromImage(bmp2);

            pictureBox1.Image = bmp1;
            pictureBox2.Image = bmp2;

            bmp3 = new Bitmap(pictureBox3.Width, pictureBox3.Height);
            grp3 = Graphics.FromImage(bmp3);

            bmp4 = new Bitmap(pictureBox4.Width, pictureBox4.Height);
            grp4 = Graphics.FromImage(bmp4);

            pictureBox3.Image = bmp3;
            pictureBox4.Image = bmp4;

        }
    }
}
