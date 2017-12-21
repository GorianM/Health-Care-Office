using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScedullerControlLibrary
{
    class TimeRangeHelper
    {
        List<String> timeRanges;
        public TimeRangeHelper()
        {
            timeRanges = new List<string>();
            addTimeRange(8, 14, 15);
            addTimeRange(17, 21, 15);
        }

        private void addTimeRange(int startTime,int endTime,int minsPerHour)
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
                
                timeRanges.Add(stringTime);
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

            timeRanges.Add(stringTime);
        }

        public List<string> getTimeRanges()
        {
            return timeRanges;
        }
    }
}
