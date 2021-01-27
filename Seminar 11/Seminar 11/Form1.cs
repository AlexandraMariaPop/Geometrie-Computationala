using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap bmp;
        Graphics grp;
        Color backcolor = Color.AntiqueWhite;
        List<Point> t;
        Dictionary<Point, string> pointHash = new Dictionary<Point, string>();

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            
        }

        private void Ex1_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);
            t = new List<Point>();
            Point P1 = new Point(20*2, 80*2);

            Point P2 = new Point(50 * 2, 25 * 2);
            Point P3 = new Point(110 * 2, 70 * 2);
            Point P4 = new Point(90 * 2, 130 * 2);
            Point P5 = new Point(60 * 2, 70 * 2);
            Point P6 = new Point(35 * 2, 110 * 2);
            Point P7 = new Point(30 * 2, 80 * 2);
            t.Add(new Point(20*2, 80 * 2));
            t.Add(new Point(50 * 2, 25 * 2));
            t.Add(new Point(110 * 2, 70 * 2));
            t.Add(new Point(90 * 2, 130 * 2));
            t.Add(new Point(60 * 2, 70 * 2));
            t.Add(new Point(35 * 2, 110 * 2));
            t.Add(new Point(30 * 2, 80 * 2));
            pointHash = new Dictionary<Point, string>();
            for (int i = 0; i < t.Count; i++)
                pointHash.Add(t[i], "P" + (i + 1));
           
            for (int i = 0; i < t.Count; i++)
            {
                grp.DrawEllipse(new Pen(Color.Black), t[i].X, t[i].Y, 5, 5);
                grp.FillEllipse(new SolidBrush(Color.Black), t[i].X, t[i].Y, 5, 5);
                grp.DrawString(pointHash[t[i]], new Font("Verdana", 8, FontStyle.Bold), new SolidBrush(Color.Black), t[i]);

            }
           // grp.DrawLine()
            grp.DrawPolygon(new Pen(Color.Black), t.ToArray());
            // Triunghiulare(t);
            Brush rosu = new SolidBrush(Color.DarkRed);
            Brush verde = new SolidBrush(Color.GreenYellow);
            Brush albastru = new SolidBrush(Color.Aquamarine);
            
            grp.DrawLine(new Pen(Color.Red), P2, P7);
            grp.DrawLine(new Pen(Color.Red), P5, P7);
            grp.DrawLine(new Pen(Color.Red), P3, P5);
            grp.DrawLine(new Pen(Color.Red), P2, P5);

            Point[] p1 = new Point[3];
            p1[0] = P1;
            p1[1] = P2;
            p1[2] = P7;
            grp.FillPolygon(rosu, p1);
            Point[] p2 = new Point[3];
            p2[0] = P5;
            p2[1] = P2;
            p2[2] = P7;
            grp.FillPolygon(verde, p2);

            Point[] p3 = new Point[3];
            p3[0] = P5;
            p3[1] = P6;
            p3[2] = P7;
            grp.FillPolygon(albastru, p3);

            Point[] p4 = new Point[3];
            p4[0] = P5;
            p4[1] = P2;
            p4[2] = P3;
            grp.FillPolygon(albastru, p4);

            Point[] p5 = new Point[3];
            p5[0] = P5;
            p5[1] = P3;
            p5[2] = P4;
            grp.FillPolygon(rosu, p5);

            pictureBox1.Image = bmp;

        }
       private void Triunghiulare(List<Point> t)
        {
            if (t.Count <= 3)
                return;
            int i = 0;
            while (i < t.Count - 3 && !digvalid(t[i], t[i + 2], i))
                i++;
            grp.DrawLine(new Pen(Color.Red), t[i], t[i + 2]);
            t.Remove(t[i + 1]);
            Triunghiulare(t);
        }
        private bool digvalid(Point point1, Point point2, int index)
        {

            Point M = new Point((point1.X + point2.X) / 2, (point1.Y + point2.Y) / 2);
            if (index == t.Count - 1)
                index = 0;
            for (int i = 0; i < t.Count - 1; i++)


            {

                if (SeIntersecteaza(point1, point2, t[i], t[i + 1]) || !isInside(t, M))
                    return false;
            }
            return true;
        }
        bool SeIntersecteaza(Point p1, Point q1, Point p2, Point q2)
        {
            // Find the four orientations needed for general and 
            // special cases 
            int o1 = Orientare2(p1, q1, p2);
            int o2 = Orientare2(p1, q1, q2);
            int o3 = Orientare2(p2, q2, p1);
            int o4 = Orientare2(p2, q2, q1);

            // General case 
            if (o1 != o2 && o3 != o4)
                return true;

            // Special Cases 
            // p1, q1 and p2 are colinear and p2 lies on segment p1q1 
            if (o1 == 0 && onSegment(p1, p2, q1)) return true;

            // p1, q1 and p2 are colinear and q2 lies on segment p1q1 
            if (o2 == 0 && onSegment(p1, q2, q1)) return true;

            // p2, q2 and p1 are colinear and p1 lies on segment p2q2 
            if (o3 == 0 && onSegment(p2, p1, q2)) return true;

            // p2, q2 and q1 are colinear and q1 lies on segment p2q2 
            if (o4 == 0 && onSegment(p2, q1, q2)) return true;

            return false; // Doesn't fall in any of the above cases 
        }
        bool isInside(List<Point> t, Point p)
        {
            if (t.Count < 3)
                return false;
            Point extreme = new Point(3000, p.Y);
            int count = 0, i = 0;
            do
            {
                int next = (i + 1) % t.Count;

                // Check if the line segment from 'p' to 'extreme' intersects 
                // with the line segment from 'polygon[i]' to 'polygon[next]' 
                if (SeIntersecteaza(t[i], t[next], p, extreme))
                {
                    // If the point 'p' is colinear with line segment 'i-next', 
                    // then check if it lies on segment. If it lies, return true, 
                    // otherwise false 
                    if (Orientare(t[i], p, t[next]) == 0)
                        return onSegment(t[i], p, t[next]);

                    count++;
                }
                i = next;
            } while (i != 0);

            return (count % 2 == 1);
        }
        private float Orientare(Point A, Point B, Point C)
        {
            double temp = (B.Y - A.Y) * (C.X - A.X) - (C.Y - A.Y) * (B.X - A.X);
            if (temp < 0)
                return -1;
            else if (temp == 0)
                return 0;
            else
                return 1;
        }
        bool onSegment(Point p, Point q, Point r)
        {
            if (q.X <= Math.Max(p.X, r.X) && q.X >= Math.Min(p.X, r.X) &&
                    q.Y <= Math.Max(p.Y, r.Y) && q.Y >= Math.Min(p.Y, r.Y))
                return true;
            return false;
        }
        private int Orientare2(Point A, Point B, Point C)
        {
            double temp = (B.Y - A.Y) * (C.X - A.X) - (C.Y - A.Y) * (B.X - A.X);
            if (temp == 0) return 0;  // colinear 
            return (temp > 0) ? 1 : 2; // clock or counterclock wise
        }

        private void Ex2_Click(object sender, EventArgs e)
        {

        }
    }
}
