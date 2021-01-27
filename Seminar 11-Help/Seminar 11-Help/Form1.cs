using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Seminar_11_Help
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Engine.InitGraph(pictureBox1);
            
            Engine.RefreshGraph();
        }

        private void btn_generate_Click(object sender, EventArgs e)
        {
            Engine.initP();
            Engine.Drawmap();
        }
    }
}
