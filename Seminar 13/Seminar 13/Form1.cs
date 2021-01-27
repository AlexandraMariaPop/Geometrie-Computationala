using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //1. Determinați diagrama Voronoi pentru puncteleA(30,50), B(60, 60), C(90,50), D(90,50), E(90, 70) , F (100,80) .
        //2. Se consideră o mulțime de 10 puncte aleatoriu și un punct introdus de la tastatură. Să se
        //afișeze care este cel mai apropiat punct față de cel introdus de la tastatură, folosind diagrama Voronoi.
        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);

            Engine.RefreshGraph();
        }

        private void Ex1_Click(object sender, EventArgs e)
        {
            Engine.initP();
            Engine.Drawmap();
            Engine.grp.DrawString("A", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 30 + 2, 50 + 8);
            Engine.grp.DrawString("B", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 60 + 2, 60 + 8);
            Engine.grp.DrawString("C", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 90 - 19, 50 - 15);
            Engine.grp.DrawString("D", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 90 +10, 50 - 15);
            Engine.grp.DrawString("E", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 90 - 15, 70 -8);
            Engine.grp.DrawString("F", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 100+5 , 80+5);
        }

        private void Ex1_Marit_Click(object sender, EventArgs e)
        {
            Engine.initPMax();
            Engine.Drawmap();
            Engine.grp.DrawString("A", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 30 *3+ 2, 50 * 3 + 8);
            Engine.grp.DrawString("B", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 60 * 3 + 2, 60 * 3 + 8);
            Engine.grp.DrawString("C", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 90 * 3 - 19, 50 * 3 - 15);
            Engine.grp.DrawString("D", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 90 * 3 + 10, 50 * 3 - 15);
            Engine.grp.DrawString("E", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 90 * 3 - 15, 70 * 3 - 8);
            Engine.grp.DrawString("F", new Font("Tahoma", 8, FontStyle.Regular), new SolidBrush(Color.Black), 100 * 3 + 5, 80 * 3 + 5);
        }

        private void Ex2_Click(object sender, EventArgs e)
        {
            try
            {
                Engine.initPRandom(10);
                Engine.Drawmap();
                List<OP> points = new List<OP>();
                points = Engine.p;
                PointF aux = new PointF(float.Parse(textBox1.Text), float.Parse(textBox2.Text));

                float distantaminima = Engine.SqDistance(aux, points[0].location);
                PointF randomaux = points[0].location;
                foreach (var item in points)
                {
                    if (Engine.SqDistance(aux, item.location) < distantaminima)
                    {
                        distantaminima = Engine.SqDistance(aux, item.location);
                        randomaux = item.location;
                    }
                }
                Engine.grp.DrawEllipse(new Pen(Color.Black, 5), aux.X, aux.Y, 5, 5);
                Engine.grp.DrawLine(new Pen(Color.Black, 3), aux, randomaux);
                DialogResult result= MessageBox.Show( $"Cel mai apropiat punct de cel introdus({aux.X}, {aux.Y}) este ({randomaux.X}, {randomaux.Y})");
                    Engine.grp.DrawEllipse(new Pen(Color.Black, 3), aux.X, aux.Y, 3, 4);
            }
            catch
            {
                if (String.IsNullOrEmpty(textBox1.Text)|| String.IsNullOrEmpty(textBox1.Text))
                {
                   DialogResult result= MessageBox.Show("Introduceti un punct", "", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                        this.Close();
                    


                }
            }
            
        }
    }
}
