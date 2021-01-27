using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace seminar_8
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
        List<Point> points=new List<System.Drawing.Point>();
        List<Point> chs = new List<System.Drawing.Point>();
       
        

        private void Form1_Load(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            backcolor = Color.Snow;
            grp.Clear(backcolor);
            points = new List<Point>();

            points.Add(new Point(20, 110));
            points.Add(new Point(20, 90));
            points.Add(new Point(30, 100));
            points.Add(new Point(40, 90));
            points.Add(new Point(50, 70));
            points.Add(new Point(60, 70));
            points.Add(new Point(40, 90));
            points.Add(new Point(30, 60));
            points.Add(new Point(70, 120));
            points.Add(new Point(70, 110));


            for (int i = 0; i < points.Count - 1; i++)
            {
                for (int j = i + 1; j < points.Count; j++)
                {
                    int semn = 0;
                    for (int k = 0; k < points.Count; k++)
                    {
                        if ((k != i) && (k != j))
                            semn += orientare(points[i], points[j], points[k]);
                    }
                    if (Math.Abs(semn) == points.Count - 2)
                        chs.Add(points[j]);
                }
            }
            foreach(Point pch in chs)
            {
                listBox1.Items.Add(pch);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            grp.Clear(backcolor);
            Point P1 = new Point(20, 110);
            Pen p = new Pen(Color.DarkSlateGray, 3);
            grp.DrawEllipse(p, P1.X - 1, P1.Y - 1, 3, 4);
            grp.DrawString("P1", new Font("Tahoma", 5), Brushes.Black, P1.X + 1, P1.Y + 3);


            Point P2 = new Point(20, 90);
            grp.DrawEllipse(p, P2.X - 1, P2.Y - 1, 3, 4);
            grp.DrawString("P2", new Font("Tahoma", 5), Brushes.Black, P2.X + 1, P2.Y + 3);

            Point P3 = new Point(30, 100);
            grp.DrawEllipse(p, P3.X - 1, P3.Y - 1, 3, 4);
            grp.DrawString("P3", new Font("Tahoma", 5), Brushes.Black, P3.X + 1, P3.Y + 3);

            Point P4 = new Point(40, 90);
            grp.DrawEllipse(p, P4.X - 1, P4.Y - 1, 3, 4);
            grp.DrawString("P4", new Font("Tahoma", 5), Brushes.Black, P4.X + 1, P4.Y + 3);

            Point P5 = new Point(50, 70);
            grp.DrawEllipse(p, P5.X - 1, P5.Y - 1, 3, 4);
            grp.DrawString("P5", new Font("Tahoma", 5), Brushes.Black, P5.X + 1, P5.Y + 3);

            Point P6 = new Point(60, 70);
            grp.DrawEllipse(p, P6.X - 1, P6.Y - 1, 3, 4);
            grp.DrawString("P6", new Font("Tahoma", 5), Brushes.Black, P6.X + 1, P6.Y + 3);

            Point P7 = new Point(40, 90);
            grp.DrawEllipse(p, P7.X - 1, P7.Y - 1, 3, 4);
            grp.DrawString("P7", new Font("Tahoma", 5), Brushes.Black, P7.X + 3, P7.Y + 3);

            Point P8 = new Point(30, 60);
            grp.DrawEllipse(p, P8.X - 1, P8.Y - 1, 3, 4);
            grp.DrawString("P8", new Font("Tahoma", 5), Brushes.Black, P8.X + 1, P8.Y + 3);

            Point P9 = new Point(70, 120);
            grp.DrawEllipse(p, P9.X - 1, P9.Y - 1, 3, 4);
            grp.DrawString("P9", new Font("Tahoma", 5), Brushes.Black, P9.X + 1, P9.Y + 3);

            Point P10 = new Point(70, 110);
            grp.DrawEllipse(p, P10.X - 1, P10.Y - 1, 3, 4);
            grp.DrawString("P10", new Font("Tahoma", 5), Brushes.Black, P10.X + 1, P10.Y + 3);

            grp.DrawLine(new Pen(Color.Black), P8, P6);
            grp.DrawLine(new Pen(Color.Black), P6, P10);
            grp.DrawLine(new Pen(Color.Black), P10, P9);
            grp.DrawLine(new Pen(Color.Black), P9, P1);
            grp.DrawLine(new Pen(Color.Black), P1, P2);
            grp.DrawLine(new Pen(Color.Black), P2, P8);

            pictureBox1.Image = bmp;
        }
       public void NaiveAlgorithm(List<Point> points)
        {
            
           
        }
      
        public int orientare(Point P,Point Q,Point R)
        {
            int val = (Q.Y - P.Y) * (R.X - Q.X) - (Q.X - P.X) * (R.Y - Q.Y);
            if (val < 0)
                return -1;
            else if (val == 0)
                return 0;
            else return -1;

        }

       

        private void ButtonStart_Click(object sender, EventArgs e)
        {
        }



        private void buttonNext_Click_1(object sender, EventArgs e)
        {
            grp.Clear(backcolor);
            Point P1 = new Point(20, 110);
            Pen p = new Pen(Color.DarkSlateGray, 3);
            grp.DrawEllipse(p, P1.X - 1, P1.Y - 1, 3, 4);
            grp.DrawString("P1", new Font("Tahoma", 5), Brushes.Black, P1.X + 1, P1.Y + 3);


            Point P2 = new Point(20, 90);
            grp.DrawEllipse(p, P2.X - 1, P2.Y - 1, 3, 4);
            grp.DrawString("P2", new Font("Tahoma", 5), Brushes.Black, P2.X + 1, P2.Y + 3);

            Point P3 = new Point(30, 100);
            grp.DrawEllipse(p, P3.X - 1, P3.Y - 1, 3, 4);
            grp.DrawString("P3", new Font("Tahoma", 5), Brushes.Black, P3.X + 1, P3.Y + 3);

            Point P4 = new Point(40, 90);
            grp.DrawEllipse(p, P4.X - 1, P4.Y - 1, 3, 4);
            grp.DrawString("P4", new Font("Tahoma", 5), Brushes.Black, P4.X + 1, P4.Y + 3);

            Point P5 = new Point(50, 70);
            grp.DrawEllipse(p, P5.X - 1, P5.Y - 1, 3, 4);
            grp.DrawString("P5", new Font("Tahoma", 5), Brushes.Black, P5.X + 1, P5.Y + 3);

            Point P6 = new Point(60, 70);
            grp.DrawEllipse(p, P6.X - 1, P6.Y - 1, 3, 4);
            grp.DrawString("P6", new Font("Tahoma", 5), Brushes.Black, P6.X + 1, P6.Y + 3);

            Point P7 = new Point(40, 90);
            grp.DrawEllipse(p, P7.X - 1, P7.Y - 1, 3, 4);
            grp.DrawString("P7", new Font("Tahoma", 5), Brushes.Black, P7.X + 3, P7.Y + 3);

            Point P8 = new Point(30, 60);
            grp.DrawEllipse(p, P8.X - 1, P8.Y - 1, 3, 4);
            grp.DrawString("P8", new Font("Tahoma", 5), Brushes.Black, P8.X + 1, P8.Y + 3);

            Point P9 = new Point(70, 120);
            grp.DrawEllipse(p, P9.X - 1, P9.Y - 1, 3, 4);
            grp.DrawString("P9", new Font("Tahoma", 5), Brushes.Black, P9.X + 1, P9.Y + 3);

            Point P10 = new Point(70, 110);
            grp.DrawEllipse(p, P10.X - 1, P10.Y - 1, 3, 4);
            grp.DrawString("P10", new Font("Tahoma", 5), Brushes.Black, P10.X + 1, P10.Y + 3);
            grp.DrawLine(new Pen(Color.Red), P1, P2);
            grp.DrawLine(new Pen(Color.Red), P1, P10);
            grp.DrawLine(new Pen(Color.Red), P2, P10);
            pictureBox1.Image = bmp;

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        

    }
}

