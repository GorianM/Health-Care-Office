using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScedullerControlLibrary
{
    class ScedullerTable
    {


        private Brush brush;
        private Pen pen;
        private int x = 0, y = 0, width, height = 2900;
        private string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        public ScedullerTable(int width)
        {
            this.width = width;
            brush = new SolidBrush(Color.Black);
            pen = new Pen(brush);
        }
        public void onPaint(PaintEventArgs e, Font font)
        {
            
            for(int i = 0; i< days.Length;i++)
            {
                SizeF size = e.Graphics.MeasureString(days[i], font);
                int xmidle = (int)((((width / 8 * (i + 1)) + (width / 8 * (i + 2))) / 2) - size.Width / 2);
                e.Graphics.DrawString(days[i], font, brush, new Point(xmidle,0));
            }

            for(int i = 0; i<24*60/15+30;i++)
            {
                e.Graphics.DrawLine(pen,0, i * 30, width, i * 30);
            }

            for (int i = 0; i < 9; i++)
            {
                e.Graphics.DrawLine(pen, i*(width/8), 0, i * (width / 8), height);
            }
        }


        public void SetWidth(int width) { this.width = width; }
    }
}
