using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sem7
{
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Graphics grp;
        Color backcolor;
        public Form1()
        {
            
        }

        private void ex1_Click(object sender, EventArgs e)
        {
            bmp = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            grp = Graphics.FromImage(bmp);
            backcolor = Color.White;
            grp.Clear(backcolor);
            grp.DrawLine(new Pen(Color.Black, 2), 0, 0, 300, 180); // dreapta
            grp.DrawLine(new Pen(Color.Red, 2), 50, 30, 50, 180); // segment
            pictureBox1.Image = bmp;
        }
    }
}
