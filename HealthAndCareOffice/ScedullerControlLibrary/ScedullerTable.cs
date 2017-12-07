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
        private string[] days = {"Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

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
                int xmidle = (int)((((width / days.Length * (i)) + (width / days.Length * (i + 1))) / 2) - size.Width / 2);
                e.Graphics.DrawString(days[i], font, brush, new Point(xmidle,0));
            }
            string time = "00:00";
            string h, m;
            int hours = 0;
            int mins = 0;
            for(int i = 0; i<24*60/15+30;i++)
            {
                e.Graphics.DrawLine(pen,0, i * 30, width, i * 30);
                if(i>0)
                {
                    mins += 15;
                    if(mins == 60)
                    {
                        mins = 0;
                        hours++;
                    }
                    if(hours<10) h ="0"+ hours + "";
                    else h = hours + "";

                    if (mins < 10) m = "0" + mins + "";
                    else m = mins + "";

                    time = h + ":" + m;
                    SizeF size = e.Graphics.MeasureString(time, font);
                    int xmidle = (int)(width/days.Length/2-size.Width/2);
                    e.Graphics.DrawString(time, font, brush, new Point(xmidle, i * 30+10));
                }
                
            }

            for (int i = 0; i < 9; i++)
            {
                e.Graphics.DrawLine(pen, i*(width/8), 0, i * (width / 8), height);
            }


        }


        public void SetWidth(int width) { this.width = width; }
    }
}
