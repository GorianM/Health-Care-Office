using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScedullerControlLibrary
{
    class AppointmentManager
    {
        List<AppointmentContainer> visibleAppointments;
        int width;
        int minsPerHour;
        Sceduller sceduller;
        public AppointmentManager(Sceduller sceduller, int width, int minsPerHour)
        {
            visibleAppointments = new List<AppointmentContainer>();
            this.sceduller = sceduller;
            this.width = width;
            this.minsPerHour = minsPerHour;
        }

        public void addNewAppointmentContainer(int estimatedTime)
        {
            AppointmentContainer ac = new AppointmentContainer();
            
            ac.Hour = 0;
            ac.Mins = 0;

            int y = 30 + (60 / minsPerHour * 30 * ac.Hour) + (ac.Mins / minsPerHour * 30);
            ac.Height = (estimatedTime / 15 +1) * 30;
            ac.SetBounds(width/8*1,y,width/8,ac.Height);
            ac.BackColor = Color.AliceBlue;
            ac.Parent = sceduller;
            visibleAppointments.Add(ac);
            ac = null;
        }

        internal void resetValues(Sceduller sceduller, int width, int minsPerHour)
        {
            this.sceduller = sceduller;
            this.width = width;
            this.minsPerHour = minsPerHour;

            foreach(AppointmentContainer ac in visibleAppointments)
            {
                
                int y = 30 + (60 / minsPerHour * 30 * ac.Hour) + (ac.Mins / minsPerHour * 30);
                ac.SetBounds(width / 8 * 3, y, width / 8, ac.Height);
                ac.refreshValues();
            }
        }
    }
}
