using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace curs10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Graphics grp;
        Bitmap bmp;
        Color backcolor = Color.Aquamarine;
        List<Point> points = new List<Point>();
        Dictionary<Point, string> dic = new Dictionary<Point, String>();
        List<Point> points2 = new List<Point>();
        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            grp.TranslateTransform(pictureBox1.Width / 2, pictureBox1.Height / 2);
        }
        Point P1 = new Point(10*2, 0 * 2);
        Point P2 = new Point(20 * 2, 20 * 2);
        Point P3 = new Point(0 * 2, 70 * 2);
        Point P4 = new Point(40 * 2, 90 * 2);
        Point P5 = new Point(70 * 2, 70 * 2);
        Point P6 = new Point(110 * 2, 40 * 2);
        Point P7 = new Point(20 * 2, 80 * 2);

        
        public void FillTriunghi(Point A, Point B, Point C, Color c)
        {
            grp.FillPolygon(new SolidBrush(c), new Point[] { A, B, C });
        }
        public static Point SymetricOx(Point p)
        {
            Point M = new Point(p.X, 0);
            int sY = p.Y * (-1);
            int sX = p.X;
            return new Point(sX, sY);

        }
        public void DrawCircle(Point p, Color color)
        {
            int radius = 8;
            
            grp.DrawEllipse(new Pen(color), p.X, p.Y, radius, radius);
            grp.FillEllipse(new SolidBrush(color), p.X, p.Y, radius, radius);
        }
        public void Tricolorare1()
        {
            Color roz = Color.DeepPink;
            Color albastru = Color.DarkBlue;
            Color verde = Color.Green;
            DrawCircle(points[0], roz);
            DrawCircle(points[1], albastru);
            DrawCircle(points[2], verde);
            
            DrawCircle(points[3], albastru);
            DrawCircle(points[5], roz);

            DrawCircle(points[4], verde);
            DrawCircle(points[6], albastru);


        }
        
        public void Noteaza()
        {
            Font font = new Font("Tahoma", 11, FontStyle.Regular);
            for (int i = 0; i < points2.Count; i++)
                grp.DrawString(dic[points2[i]], font, new SolidBrush(Color.Black), points2[i]);
        }
        
       public void DrawLinie(Point A, Point B)
        {
            grp.DrawLine(new Pen(Color.DeepPink), A, B);
        }
       
        private void ex1_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);
            Font textFont = new Font("Tahoma", 10, FontStyle.Regular);
            grp.DrawEllipse(new Pen(Color.Black, 3), P1.X - 1, P1.Y - 1, 3, 4);
            grp.DrawString("P1", textFont, new SolidBrush(Color.Black), P1.X + 7, P1.Y -11);

            grp.DrawEllipse(new Pen(Color.Black, 3), P2.X - 1, P2.Y - 1, 3, 4);
            grp.DrawString("P2", textFont, new SolidBrush(Color.Black), P2.X +5, P2.Y -20);

            grp.DrawEllipse(new Pen(Color.Black, 3), P3.X - 1, P3.Y - 1, 3, 4);
            grp.DrawString("P3", textFont, new SolidBrush(Color.Black), P3.X - 11, P3.Y +11);
            grp.DrawEllipse(new Pen(Color.Black, 3), P4.X - 1, P4.Y - 1, 3, 4);
            grp.DrawString("P4", textFont, new SolidBrush(Color.Black), P4.X + 7, P4.Y + 2);
            grp.DrawEllipse(new Pen(Color.Black, 3), P5.X - 1, P5.Y - 1, 3, 4);
            grp.DrawString("P5", textFont, new SolidBrush(Color.Black), P5.X + 7, P5.Y + 2);
            grp.DrawEllipse(new Pen(Color.Black, 3), P6.X - 1, P6.Y - 1, 3, 4);
            grp.DrawString("P6", textFont, new SolidBrush(Color.Black), P6.X + 7, P6.Y + 2);
            grp.DrawEllipse(new Pen(Color.Black, 3), P7.X - 1, P7.Y - 1, 3, 4);
            grp.DrawString("P7", textFont, new SolidBrush(Color.Black), P7.X + 1, P7.Y + 4);
            grp.DrawLine(new Pen(Color.Black, 3), P1, P2);
            grp.DrawLine(new Pen(Color.Black, 3), P1, P3);
            grp.DrawLine(new Pen(Color.Black, 3), P6, P2);
            grp.DrawLine(new Pen(Color.Black, 3), P6, P5);
            grp.DrawLine(new Pen(Color.Black, 3), P4, P5);
            grp.DrawLine(new Pen(Color.Black, 3), P4, P7);
            grp.DrawLine(new Pen(Color.Black, 3), P7, P3);
            grp.DrawLine(new Pen(Color.Black, 3), P3, P1);

          
            points.Add(P1);
            points.Add(P2);
            points.Add(P3);
            points.Add(P4);
            points.Add(P5);
            points.Add(P6);
            points.Add(P7);

            

            Point[] pointArray = points.ToArray();
            Tricolorare1();
            grp.DrawPolygon(new Pen(Color.DarkSeaGreen), pointArray);

            grp.DrawLine(new Pen(Color.DeepPink), P2, P4);
            grp.DrawLine(new Pen(Color.DeepPink), P4, P5);
            grp.DrawLine(new Pen(Color.DeepPink), P3, P6);
            grp.DrawLine(new Pen(Color.DeepPink), P7, P4);
            grp.DrawLine(new Pen(Color.DeepPink), P5, P1);

         

            pictureBox1.Image = bmp;
        }

        public void Tricolorare()
        {
            Color roz = Color.Yellow;
            Color albastru = Color.OliveDrab;
            Color verde = Color.Green;
            DrawCircle(points2[0], roz);
            DrawCircle(points2[1], albastru);
            DrawCircle(points2[2], verde);
            
            DrawCircle(points2[3], albastru);
            DrawCircle(points2[9], roz);
            DrawCircle(points2[5], roz);

            DrawCircle(points2[4], verde);
            DrawCircle(points2[8], albastru);
            DrawCircle(points2[6], albastru);
            DrawCircle(points2[7], verde);
            DrawCircle(points2[10], verde);
            DrawCircle(points2[11], albastru);

        }



        private void Ex2_Click(object sender, EventArgs e)
        {
            grp.Clear(Color.AliceBlue);
           
            points2.Add(new Point(40*2, 40 * 2));
            points2.Add(new Point(50 * 2, 60 * 2));
            points2.Add(new Point(60 * 2, 40 * 2));
            points2.Add(new Point(70 * 2, 40 * 2));
            points2.Add(new Point(90 * 2, 60 * 2));
            points2.Add(new Point(110 * 2, 60 * 2));

            for (int i = 5; i >= 0; i--)
                points2.Add(SymetricOx(points2[i]));

            for (int i = 0; i < points2.Count; i++)
                dic.Add(points2[i], (i + 1).ToString());

            
            Point[] pointArray = points2.ToArray();
            Tricolorare();
            grp.DrawPolygon(new Pen(Color.Black,2), pointArray);

            Noteaza();

            

            DrawLinie(points2[5], points2[3]);
            DrawLinie(points2[5], points2[8]);
            DrawLinie(points2[5], points2[7]);
            
            DrawLinie(points2[3], points2[9]);
            DrawLinie(points2[0], points2[2]);
            
            DrawLinie(points2[5], points2[9]);
            
            DrawLinie(points2[9], points2[0]);
            DrawLinie(points2[11], points2[9]);
            
            pictureBox1.Image = bmp;
        }

        


    }
}
