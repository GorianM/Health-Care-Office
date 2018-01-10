using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScedullerControlLibrary
{
    class TimeSlot
    {
        public string Time { get; set; }
        public int Hour { get; set; }
        public int Minute { get; set; }
        public int Y { get; set; }

        public TimeSlot(string time,int hour,int minute,int y)
        {
			Time = time;
			Hour = hour;
			Minute = minute;
			Y = y;

        }

		public TimeSlot(string time)
		{
			Time = time;
		}

		public TimeSlot(string time,int hour, int minute)
		{
			Time = time;
			Hour = hour;
			Minute = minute;
			Y = -999;
		}

		public override string ToString()
		{
			return "TimeSlot Time: "+Time+" Hour: "+Hour+" Minute: "+ Minute+" Y: "+ Y;
		}

	}
}
