using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        Color backcolor;
        Random rnd = new Random();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            backcolor = Color.Black;
            grp.Clear(backcolor);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);

            PointF A = new PointF(rnd.Next(750), rnd.Next(500));
            PointF B = new PointF(rnd.Next(750), rnd.Next(500));
            PointF C = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.Gray, 3), A, B);
            grp.DrawLine(new Pen(Color.Gray, 3), A, C);
            grp.DrawLine(new Pen(Color.Gray, 3), C, B);

            PointF D = new PointF(rnd.Next(750), rnd.Next(500));
            PointF E = new PointF(rnd.Next(750), rnd.Next(500));
            PointF F = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.Maroon, 3), D, E);
            grp.DrawLine(new Pen(Color.Maroon, 3), D, F);
            grp.DrawLine(new Pen(Color.Maroon, 3), E, F);

            PointF G = new PointF(rnd.Next(750), rnd.Next(500));
            PointF H = new PointF(rnd.Next(750), rnd.Next(500));
            PointF I = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.Red, 3), G, H);
            grp.DrawLine(new Pen(Color.Red, 3), H, I);
            grp.DrawLine(new Pen(Color.Red, 3), G, I);

            PointF J = new PointF(rnd.Next(750), rnd.Next(500));
            PointF K = new PointF(rnd.Next(750), rnd.Next(500));
            PointF L = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.DarkGreen, 3), J, K);
            grp.DrawLine(new Pen(Color.DarkGreen, 3), J, L);
            grp.DrawLine(new Pen(Color.DarkGreen, 3), K, L);

            PointF M = new PointF(rnd.Next(750), rnd.Next(500));
            PointF N = new PointF(rnd.Next(750), rnd.Next(500));
            PointF O = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.Gold, 3), M, N);
            grp.DrawLine(new Pen(Color.Gold, 3), M, O);
            grp.DrawLine(new Pen(Color.Gold, 3), N, O);

            PointF P = new PointF(rnd.Next(750), rnd.Next(500));
            PointF Q = new PointF(rnd.Next(750), rnd.Next(500));
            PointF R = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.Lime, 3), P, Q);
            grp.DrawLine(new Pen(Color.Lime, 3), P, R);
            grp.DrawLine(new Pen(Color.Lime, 3), Q, R);

            PointF S = new PointF(rnd.Next(750), rnd.Next(500));
            PointF T = new PointF(rnd.Next(750), rnd.Next(500));
            PointF U = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.MediumTurquoise, 3), S, T);
            grp.DrawLine(new Pen(Color.MediumTurquoise, 3), S, U);
            grp.DrawLine(new Pen(Color.MediumTurquoise, 3), T, U);

            PointF V = new PointF(rnd.Next(750), rnd.Next(500));
            PointF W = new PointF(rnd.Next(750), rnd.Next(500));
            PointF X = new PointF(rnd.Next(750), rnd.Next(500));

            grp.DrawLine(new Pen(Color.HotPink, 3), V, W);
            grp.DrawLine(new Pen(Color.HotPink, 3), V, X);
            grp.DrawLine(new Pen(Color.HotPink, 3), W,X);

            pictureBox1.Image = bmp;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);

            int patrat1 = rnd.Next(300);
            int patrat2 = rnd.Next(300);
            int patrat3 = rnd.Next(300);
            int patrat4 = rnd.Next(300);
            int patrat5 = rnd.Next(300);
            int patrat6 = rnd.Next(300);
            int patrat7 = rnd.Next(300);
            int patrat8 = rnd.Next(300);

            PointF A = new PointF(rnd.Next(pictureBox1.Width - patrat1), rnd.Next(pictureBox1.Height - patrat1));
            PointF B = new PointF(rnd.Next(pictureBox1.Width - patrat2), rnd.Next(pictureBox1.Height - patrat2));
            PointF C = new PointF(rnd.Next(pictureBox1.Width - patrat3), rnd.Next(pictureBox1.Height - patrat3));
            PointF D = new PointF(rnd.Next(pictureBox1.Width - patrat4), rnd.Next(pictureBox1.Height - patrat4));
            PointF E = new PointF(rnd.Next(pictureBox1.Width - patrat5), rnd.Next(pictureBox1.Height - patrat5));
            PointF F = new PointF(rnd.Next(pictureBox1.Width - patrat6), rnd.Next(pictureBox1.Height - patrat6));
            PointF G = new PointF(rnd.Next(pictureBox1.Width - patrat7), rnd.Next(pictureBox1.Height - patrat7));
            PointF H = new PointF(rnd.Next(pictureBox1.Width - patrat8), rnd.Next(pictureBox1.Height - patrat8));
            
            grp.DrawRectangle(new Pen(Color.HotPink, 3),A.X,A.Y,patrat1,patrat1);
            grp.DrawRectangle(new Pen(Color.Aqua, 3), B.X, B.Y, patrat2, patrat2);
            grp.DrawRectangle(new Pen(Color.Red, 3), C.X, C.Y, patrat3, patrat3);
            grp.DrawRectangle(new Pen(Color.DarkGreen, 3), D.X, D.Y, patrat4, patrat4);
            grp.DrawRectangle(new Pen(Color.Violet, 3), E.X, E.Y, patrat5, patrat5);
            grp.DrawRectangle(new Pen(Color.Maroon, 3), F.X, F.Y, patrat6, patrat6);
            grp.DrawRectangle(new Pen(Color.Lime, 3), G.X, G.Y, patrat7, patrat7);
            grp.DrawRectangle(new Pen(Color.Gold, 3), H.X, H.Y, patrat8, patrat8);
            pictureBox1.Image = bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);

            int cerc1 = rnd.Next(150);
            int cerc2 = rnd.Next(150);
            int cerc3 = rnd.Next(150);
            int cerc4 = rnd.Next(150);
            int cerc5 = rnd.Next(300);
            int cerc6 = rnd.Next(300);
            int cerc7 = rnd.Next(200);
            int cerc8 = rnd.Next(200);

            PointF A = new PointF(rnd.Next(pictureBox1.Width-cerc1), rnd.Next(pictureBox1.Height-cerc1));
            PointF B = new PointF(rnd.Next(pictureBox1.Width - cerc2), rnd.Next(pictureBox1.Height - cerc2));
            PointF C = new PointF(rnd.Next(pictureBox1.Width - cerc3), rnd.Next(pictureBox1.Height - cerc3));
            PointF D = new PointF(rnd.Next(pictureBox1.Width - cerc4), rnd.Next(pictureBox1.Height - cerc4));
            PointF E = new PointF(rnd.Next(pictureBox1.Width - cerc5), rnd.Next(pictureBox1.Height - cerc5));
            PointF F = new PointF(rnd.Next(pictureBox1.Width - cerc6), rnd.Next(pictureBox1.Height - cerc6));
            PointF G = new PointF(rnd.Next(pictureBox1.Width - cerc7), rnd.Next(pictureBox1.Height - cerc7));
            PointF H = new PointF(rnd.Next(pictureBox1.Width - cerc8), rnd.Next(pictureBox1.Height - cerc8));
           
            grp.DrawEllipse(new Pen(Color.HotPink, 3), A.X, A.Y, cerc1, cerc1);
            grp.DrawEllipse(new Pen(Color.Aqua, 3), B.X, B.Y, cerc2, cerc2);
            grp.DrawEllipse(new Pen(Color.Red, 3), C.X, C.Y, cerc3, cerc3);
            grp.DrawEllipse(new Pen(Color.DarkGreen, 3), D.X, D.Y, cerc4, cerc4);
            grp.DrawEllipse(new Pen(Color.Violet, 3), E.X, E.Y, cerc5, cerc5);
            grp.DrawEllipse(new Pen(Color.Maroon, 3), F.X, F.Y, cerc6, cerc6);
            grp.DrawEllipse(new Pen(Color.Lime, 3), G.X, G.Y, cerc7, cerc7);
            grp.DrawEllipse(new Pen(Color.Gold, 3), H.X, H.Y, cerc8, cerc8);
            pictureBox1.Image = bmp;

            pictureBox1.Image = bmp;
        }
    }
}
