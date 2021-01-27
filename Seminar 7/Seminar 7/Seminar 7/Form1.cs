using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_7
{
    public partial class Form1 : Form
    {
        Graphics grp;
        Bitmap bmp;
        Color backColor;
        public Form1()
        {
            backColor = Color.White;
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            
            

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ex1_Click(object sender, EventArgs e)
        {
           
            grp.Clear(backColor);
            grp.DrawLine(new Pen(Color.Black, 2), 0, 0, 300, 180); // dreapta
            grp.DrawLine(new Pen(Color.DarkRed, 2), 50, 30, 50, 180); // segment
            pictureBox1.Image = bmp;
        }
    }
}
