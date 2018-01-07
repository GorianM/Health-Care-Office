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
        private int timeslotHight = 30;
        private int timeslotCount;
        private int x = 0, y = 0, width;
        public int Height { get; set; }
        List<string> timeRanges;
        private string[] days = {"Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

        


        public ScedullerTable(int width)
        {
            this.width = width;
            TimeRangeHelper trh = new TimeRangeHelper();
            timeRanges = trh.getTimeRanges();
            timeslotCount = timeRanges.Count;
            Height = (timeslotCount + 1) * timeslotHight;
           
            
        }
        public void onPaint(PaintEventArgs e, Font font)
        {
            brush = new SolidBrush(Color.Black);
            pen = new Pen(brush);
            //draw vertical Lines
            for (int i = 0; i< days.Length;i++)
            {
                SizeF size = e.Graphics.MeasureString(days[i], font);
                int xmidle = (int)((((width / days.Length * (i)) + (width / days.Length * (i + 1))) / 2) - size.Width / 2);
                e.Graphics.DrawString(days[i], font, brush, new Point(xmidle,0));
            }

            
            for(int i = 0; i<timeslotCount+1;i++)
            {
                //draw horizontal lines
                e.Graphics.DrawLine(pen,0, i * timeslotHight, width, i * timeslotHight);
                if(i>0)
                {
                    string time = timeRanges.ElementAt(i - 1);
                    SizeF size = e.Graphics.MeasureString(time, font);
                    int xmidle = (int)(width/days.Length/2-size.Width/2);
                    e.Graphics.DrawString(time, font, brush, new Point(xmidle, i * timeslotHight + 10));
                }
                
            }

            for (int i = 0; i < 9; i++)
            {
                e.Graphics.DrawLine(pen, i*(width/8), 0, i * (width / 8), Height);
            }

            pen.Dispose();
            brush.Dispose();
        }


        public void SetWidth(int width) { this.width = width; }
    }
}
