using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScedullerControlLibrary
{
    class TimeRangeHelper
    {
        public static List<TimeSlot> TimeRanges = new List<TimeSlot>();
        public TimeRangeHelper()
        {
            
            

        }

        public static void addTimeRange(int startTime,int endTime,int minsPerHour)
        {
            int time = startTime;
            int mins = 0;
            string stringTime;
            while(time<endTime)
            {
                if(time<10){stringTime = "0" + time;}
                else{stringTime = time+"";}

                if(mins<10){stringTime+= " : 0"+mins;}
                else{stringTime += " : " + mins;}
                
                TimeRanges.Add(new TimeSlot(stringTime,time,mins));
				Debug.WriteLine(TimeRanges.ElementAt(TimeRanges.Count - 1).ToString());
                mins += minsPerHour;
                if (mins == 60)
                {
                    mins = 0;
                    time++;
                }
            }

            if (time < 10) { stringTime = "0" + time; }
            else { stringTime = time + ""; }

            if (mins < 10) { stringTime += " : 0" + mins; }
            else { stringTime += " : " + mins; }

            TimeRanges.Add(new TimeSlot(stringTime,time,mins));

        }

        public static List<TimeSlot> getTimeRanges()
        {
            return TimeRanges;
        }

		public static int getYByTime(int hour, int minute)
		{
			int y = 0;
			foreach(TimeSlot timeSlot in TimeRanges)
			{
				 if(timeSlot.Hour == hour && minute >= timeSlot.Minute)
				{
					y = timeSlot.Y;
					return y;
				}
			}

			return y;
		}
    }
}
