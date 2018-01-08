using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScedullerControlLibrary
{
    public class Day
    {
        private string name;
        public int Width { get; set; }
        public int Height { get; set; }
        
        private int headerHeight = 20;
        private int timeSlotDuration = 15;
        private int heightPerMinute = 2;
        private string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        private int day;
        private Font font;

        public Day(int day,int width, Font font)
        {
            this.Width = width;
            this.Height = 30;
            this.font = font;
            this.name = days[day];
            this.day = day;
            
            

        }


        Brush brush = null;
        Pen pen = null;
        Point point;        
        SizeF stringSize = new SizeF(0,0);

        public void onPaint(PaintEventArgs e, Font font)
        {
            if (this.font == null) this.font = font;
            stringSize = e.Graphics.MeasureString(name, font);
            if (brush == null)brush = new SolidBrush(Color.Magenta);
            if (pen == null) pen = new Pen(new SolidBrush(Color.Black));
            point = new Point((int)((day + 1) * Width + (Width / 2 - stringSize.Width / 2)), (int)(headerHeight / 2 - stringSize.Height / 2));
            e.Graphics.DrawString(name, font, new SolidBrush(Color.Black), point);

            

           
        }
    }
}
