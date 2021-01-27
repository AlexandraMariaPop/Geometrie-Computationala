using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace Seminar_12
{
    public static class Engine
    {
        public static Graphics grp;
        public static Bitmap bmp;
        public static int rezx, rezy;
        public static Color backColor = Color.Aquamarine;
        public static PictureBox display;

        public static void InitGraph(PictureBox T)
        {
            display = T;
            rezx = T.Width;
            rezy = T.Height;

            bmp = new Bitmap(rezx, rezy);
            grp = Graphics.FromImage(bmp);
            ClearGraph();
            RefreshGraph();
        }

        public static void ClearGraph()
        {
            grp.Clear(backColor);
        }

        public static void RefreshGraph()
        {
            display.Image = bmp;
        }
        public static Random rnd = new Random();
        public static PointF getRNDPoint()
        {
            return new PointF(rnd.Next(rezx), rnd.Next(rezy));
        }
        public static float getRNDAngle()
        {
            return (float)(rnd.NextDouble() * (Math.PI * 2));
        }
        public static Color getRNDColor()
        {
            return Color.FromArgb(Engine.rnd.Next(256), Engine.rnd.Next(256), Engine.rnd.Next(256));
        }
        public static PointF[] drawPG(PointF center, int n, float l, float fi)
        {
            PointF[] tor = new PointF[n];
            float uc = (2.0f * (float)Math.PI) / (float)n;

            for (int i = 0; i < n; i++)
            {
                tor[i].X = center.X + l * (float)Math.Cos(uc * i + fi);
                tor[i].Y = center.Y + l * (float)Math.Sin(uc * i + fi);
            }

            return tor;
        }
    }
}
