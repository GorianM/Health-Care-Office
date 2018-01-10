using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private int timeslotHight = 60;
        private int timeslotCount;
        private int x = 0, y = 0, width;
        public int Height { get; set; }
        List<TimeSlot> timeRanges;
        private string[] days = {"Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday",};

        


        public ScedullerTable(int width)
        {
            this.width = width;

			TimeRangeHelper.addTimeRange(8, 14, 15);
			TimeRangeHelper.addTimeRange(17, 21, 15);
			timeRanges = TimeRangeHelper.getTimeRanges();

			timeslotCount = timeRanges.Count;
			for (int i = 1; i < timeslotCount + 1; i++)
			{

				TimeRangeHelper.TimeRanges.ElementAt(i - 1).Y = i * timeslotHight;
			}

			Debug.WriteLine(TimeRangeHelper.TimeRanges.ElementAt(5).ToString());
			
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
                int yMidle = (int)(timeslotHight / 2 - size.Height / 2);
                e.Graphics.DrawString(days[i], font, brush, new Point(xmidle,yMidle));
            }

            
            for(int i = 0; i<timeslotCount+1;i++)
            {
                //draw horizontal lines
                e.Graphics.DrawLine(pen,0, i * timeslotHight, width, i * timeslotHight);
                if(i>0)
                {
                    string time = timeRanges.ElementAt(i - 1).Time;
                    SizeF size = e.Graphics.MeasureString(time, font);
                    int xmidle = (int)(width/days.Length/2-size.Width/2);
                    int yMidle = (int)(i*timeslotHight+timeslotHight/2-size.Height/2);
					
                    e.Graphics.DrawString(time, font, brush, new Point(xmidle, yMidle));
                }
                
            }

            for (int i = 0; i < 9; i++)
            {
                e.Graphics.DrawLine(pen, i*(width/days.Length), 0, i * (width / days.Length), Height);
            }

            pen.Dispose();
            brush.Dispose();
        }


        public void SetWidth(int width) { this.width = width; }
    }
}
