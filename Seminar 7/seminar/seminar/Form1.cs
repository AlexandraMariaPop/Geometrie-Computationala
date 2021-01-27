using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp,bmp4;
        Color backcolor;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            bmp4 = new Bitmap(pictureBox1.Width/2, pictureBox1.Height/2);
            grp = Graphics.FromImage(bmp);
            backcolor = Color.Snow;
            grp.Clear(backcolor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);


            SolidBrush drawBrush = new SolidBrush(Color.Black);

            PointF segmA = new PointF(250, 61);
            PointF segmB = new PointF(20, 60);
            PointF drptA = new PointF(1, 1);
            PointF drptB = new PointF(500, 500);
            grp.DrawLine(new Pen(Color.Black, 3), drptA, drptB);
            grp.DrawLine(new Pen(Color.Blue, 2), segmA, segmB);
            Pen p = new Pen(Color.DarkSlateGray, 3);
            grp.DrawEllipse(p, segmA.X - 1, segmA.Y - 1, 3, 4);
            grp.DrawString("A", new Font("Tahoma", 12), Brushes.Black, segmA.X + 10, segmA.Y + 10);
            grp.DrawString("B", new Font("Tahoma", 12), Brushes.Black, segmB.X + 10, segmB.Y + 10);

            grp.DrawString("d", new Font("Tahoma", 12), Brushes.Black, drptA.X + 10, drptA.Y + 20);
            grp.DrawEllipse(p, segmB.X - 1, segmB.Y - 1, 3, 4);

            //coeficientii ecuatiei generale a dreptei 
            float dreaptaA = drptB.Y - drptA.Y;
            float dreaptaB = drptA.X - drptB.X;
            float dreaptaC = drptB.X * drptA.Y - drptA.X * drptB.Y;

            float segmentA = segmB.Y - segmA.Y;
            float segmentB = segmA.X - segmB.X;
            float segmentC = segmB.X * segmA.Y - segmA.X * segmB.Y;


            float ysol = (dreaptaC * segmentA - dreaptaA * segmentC) / (segmentB * dreaptaA - dreaptaB * segmentA);
            float xsol = (dreaptaB * ((dreaptaC * segmentA - dreaptaA * segmentC) / (segmentB * dreaptaA - dreaptaB * segmentA)) + dreaptaA) / dreaptaA;
            PointF sol = new PointF(xsol, ysol);
            grp.DrawEllipse(new Pen(Color.Red, 3), xsol - 1, ysol - 1, 3, 4);
            SolidBrush solidb = new SolidBrush(Color.Red);
            grp.FillEllipse(solidb, 56, 56, 10, 10);
            pictureBox1.Image = bmp;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);


            PointF drptA1 = new PointF(250, 0);
            PointF drptB1 = new PointF(-1, 60);
            PointF drptA = new PointF(1, 1);
            PointF drptB = new PointF(700, 400);
            grp.DrawLine(new Pen(Color.Black, 3), drptA, drptB);
            grp.DrawLine(new Pen(Color.Blue, 3), drptA1, drptB1);
            Pen p = new Pen(Color.DarkSlateGray, 3);
            grp.DrawString("d1", new Font("Tahoma", 12), Brushes.Black, drptA.X + 150, drptA.Y + 100);
            grp.DrawString("d2", new Font("Tahoma", 12), Brushes.Black, drptA1.X + 5, drptA1.Y + 10);

            //coeficientii ecuatiei generale a dreptei 
            float dreaptaA = drptB.Y - drptA.Y;
            float dreaptaB = drptA.X - drptB.X;
            float dreaptaC = drptB.X * drptA.Y - drptA.X * drptB.Y;

            float segmentA = drptB1.Y - drptA1.Y;
            float segmentB = drptA1.X - drptB1.X;
            float segmentC = drptB1.X * drptA1.Y - drptA1.X * drptB1.Y;


            float ysol = (dreaptaC * segmentA - dreaptaA * segmentC) / (segmentB * dreaptaA - dreaptaB * segmentA);
            float xsol = (dreaptaB * ((dreaptaC * segmentA - dreaptaA * segmentC) / (segmentB * dreaptaA - dreaptaB * segmentA)) + dreaptaA) / dreaptaA;
            PointF sol = new PointF(xsol, ysol);
            grp.DrawEllipse(new Pen(Color.Red, 3), xsol - 1, ysol - 1, 3, 4);

            SolidBrush solidb = new SolidBrush(Color.Red);
            grp.FillEllipse(solidb, 69, 38, 10, 10);
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);
            PointF A1 = new PointF(300, 333);
            PointF B1 = new PointF(10, 10);
            grp.DrawLine(new Pen(Color.Black, 3), A1, B1);
            grp.DrawString("A1", new Font("Tahoma", 12), Brushes.Black, A1.X + 5, A1.Y + 5);
            grp.DrawString("B1", new Font("Tahoma", 12), Brushes.Black, B1.X + 20, B1.Y + 5);
            Pen p = new Pen(Color.DarkSlateGray, 3);
            grp.DrawEllipse(p, A1.X - 1, A1.Y - 1, 3, 4);
            grp.DrawEllipse(p, B1.X - 1, B1.Y - 1, 3, 4);


            PointF A2 = new PointF(30, 80);
            PointF B2 = new PointF(277, 80);
            grp.DrawString("A2", new Font("Tahoma", 12), Brushes.Black, A2.X + 5, A2.Y + 5);
            grp.DrawString("B2", new Font("Tahoma", 12), Brushes.Black, B2.X + 20, B2.Y + 5);
            grp.DrawLine(new Pen(Color.Blue, 3), A2, B2);

            grp.DrawEllipse(p, A2.X - 1, A2.Y - 1, 3, 4);
            grp.DrawEllipse(p, B2.X - 1, B2.Y - 1, 3, 4);

            //ecuatiile dreptelor

            float segmA1 = B1.Y - A1.Y;
            float segmB1 = A1.X - B1.X;
            float segmC1 = B1.X * A1.Y - A1.X * B1.Y;

            float segmA2 = B2.Y - A2.Y;
            float segmB2 = A2.X - B2.X;
            float segmC2 = B2.X * A2.Y - A2.X * B2.Y;


            float ysol = (segmC1 * segmA2 - segmA1 * segmC2) / (segmB2 * segmA1 - segmB1 * segmA2);
            float xsol = (segmB1 * ((segmC1 * segmA2 - segmA1 * segmC2) / (segmB2 * segmA1 - segmB1 * segmA2)) + segmA1) / segmA1;
            PointF sol = new PointF(xsol, ysol);
            grp.DrawEllipse(new Pen(Color.Red, 3), xsol - 1, ysol - 1, 3, 4);
            SolidBrush solidb = new SolidBrush(Color.Red);
            grp.FillEllipse(solidb, 69, 75, 10, 10);

            pictureBox1.Image = bmp;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);
            int xM = pictureBox1.Width / 2;
            int yM = pictureBox1.Height / 2;
            Pen p = new Pen(Color.DarkSlateGray, 3);
            int n = 0;
            n++;
            PointF A = new PointF(xM + 10, yM + 10);
            n++;
            grp.DrawEllipse(p, A.X - 1, A.Y - 1, 3, 4);
            PointF B = new PointF(xM + 50, yM + 30);
            
            grp.DrawEllipse(p, B.X - 1, B.Y - 1, 3, 4);
            PointF C = new PointF(xM - 20, yM - 30);
            
            int nr = 50;
            grp.DrawEllipse(p, C.X - 1,C.Y - 1, 3, 4);
            PointF D = new PointF(xM + 30, yM - 10);
            grp.DrawEllipse(p, D.X - 1, D.Y - 1, 3, 4);
            PointF E = new PointF(xM + 30, yM + 40);
            grp.DrawEllipse(p, E.X - 1, E.Y - 1, 3, 4);
            PointF F = new PointF(xM - 20, yM -70);
            grp.DrawEllipse(p, F.X - 1, F.Y - 1, 3, 4);
            PointF G= new PointF(xM -40, yM -20);
            grp.DrawEllipse(p, G.X - 1, G.Y - 1, 3, 4);
            PointF H = new PointF(xM + 30, yM + 10);
            grp.DrawEllipse(p, F.X - 1, F.Y - 1, 3, 4);
            PointF I = new PointF(xM -20, yM + 40);
            
            grp.DrawEllipse(p, I.X - 1, I.Y - 1, 3, 4);
            PointF K = new PointF(xM + 30, yM -40);
            grp.DrawEllipse(p, K.X - 1, K.Y - 1, 3, 4);
            PointF L = new PointF(xM -30, yM + 30);
            grp.DrawEllipse(p, L.X - 1, L.Y - 1, 3, 4);
            
            PointF M = new PointF(xM + 10, yM + 30);
            grp.DrawEllipse(p, M.X - 1, M.Y - 1, 3, 4);
            grp.DrawLine(new Pen(Color.Black, 3), A, B);
            grp.DrawLine(new Pen(Color.Black, 3), G, H);
            grp.DrawLine(new Pen(Color.Black, 3), C, D);
            n++;
            grp.DrawLine(new Pen(Color.Blue, 3), L, M);
            grp.DrawLine(new Pen(Color.Blue, 3), E,F);
            n++;
            grp.DrawLine(new Pen(Color.Blue, 3), I, K);

            textBox1.Text = $"SUNT {n} INTERSECTII";

            float segmA1 = B.Y - A.Y;
            float segmB1 = A.X - B.X;
            float segmC1 = B.X * A.Y - A.X * B.Y;

            float segmA2 = C.Y - D.Y;
            float segmB2 = D.X - C.X;
            float segmC2 = C.X * D.Y - D.X * C.Y;
            n = (int)Math.Sqrt(nr / 2);

            float ysol = (segmC1 * segmA2 - segmA1 * segmC2) / (segmB2 * segmA1 - segmB1 * segmA2);
            float xsol = (segmB1 * ((segmC1 * segmA2 - segmA1 * segmC2) / (segmB2 * segmA1 - segmB1 * segmA2)) + segmA1) / segmA1;
            PointF sol = new PointF(xsol, ysol);

            double dAC = Convert.ToSingle(Math.Sqrt((A.X - C.X) * (A.X - C.X) + (A.Y - C.Y) * (A.Y - C.Y)));
            double dAB = Convert.ToSingle(Math.Sqrt((A.X - B.X) * (A.X - B.X) + (A.Y - B.Y) * (A.Y - B.Y)));
            double dCB = Convert.ToSingle(Math.Sqrt((C.X - B.X) * (C.X - B.X) + (C.Y - B.Y) * (C.Y - B.Y)));
            n++;
            textBox1.Text = $"SUNT {n} INTERSECTII";
            pictureBox1.Image = bmp;
            ////Se dau punctele A(10,10), B(50,30), C(-20,-30), D(30,-10), E(30,40), F(-20,-70), G(-40,-
           // 20), H(30, 10), I(-20, 40), K(30, -40), L(-30, 30), M(10, 30).Fie mulțimea S1 formată din
            //segmentele AB, GH, CD, LM, mulțimea S2 formată din segmentele EF, IK, LM.Folosind
            //algoritmul de maturare plană, determinați toate intersecțiile dintre un segment din
            //mulțimea S1, cu un segment din mulțimea S2.
        }
    }
}
