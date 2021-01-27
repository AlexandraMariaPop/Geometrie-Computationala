using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Seminar_11_Help
{
    public class OP
    {
        public PointF location;
        public Color fill;
        public OP(PointF location,Color fill)
        {
            this.location = location;
            this.fill = fill;

        }
        public void draw(Graphics grp)
        {
            grp.FillEllipse(new SolidBrush(fill), location.X - 5, location.Y-5, 11, 11);
            grp.DrawEllipse(new Pen(Color.Black), location.X - 5, location.Y - 5, 11, 11);

        }

    }
}
