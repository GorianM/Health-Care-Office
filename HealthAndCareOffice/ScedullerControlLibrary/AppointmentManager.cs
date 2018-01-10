using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelProject;
using System.Windows.Forms;
using System.Diagnostics;

namespace ScedullerControlLibrary
{
    class AppointmentManager
    {
        List<AppointmentContainer> visibleContainers;
        List<Appointment> visibleAppointments;
        int width;
        int minsPerHour;
        Sceduller sceduller;

        DateTime mondayDate;
        DateTime sundayDate;

        private int timeslotHight = 60;
        private int colums = 7;
        private int day = 1;
		private int timeSlotMins = 15;

        int[] hourArray = {8,9,10,11,12,13,14,17,18,19,20,21};
        int[] minuteArray = { 0, 15, 30, 45 };

        public AppointmentManager(Sceduller sceduller, int width, int minsPerHour)
        {
            visibleContainers = new List<AppointmentContainer>();
            visibleAppointments = new List<Appointment>();
            this.sceduller = sceduller;
            this.width = width;
            this.minsPerHour = minsPerHour;

            
            
        }

        

        public void addNewAppointmentContainer(Appointment appointment)
        {
            AppointmentContainer ac = new AppointmentContainer(appointment);
            
            

			int y = TimeRangeHelper.getYByTime(appointment.AppontmentDateTime.Hour, appointment.AppontmentDateTime.Minute);
            ac.Height = (appointment.EstimatedDurationMinutes / timeSlotMins + 1) * timeslotHight;
			day = convertDayOfWeekToInt(appointment.AppontmentDateTime.DayOfWeek);
			ac.SetBounds(width / colums * day, y, width / colums, ac.Height);
            ac.BackColor = Color.AliceBlue;
            ac.Parent = sceduller;
            ac.refreshValues();
            visibleContainers.Add(ac);

            ac = null;
        }

		private int convertDayOfWeekToInt(DayOfWeek dayOfWeek)
		{
			switch(dayOfWeek)
			{
				case DayOfWeek.Monday:
					return 1; 
				case DayOfWeek.Tuesday:
					return 2;
				case DayOfWeek.Wednesday:
					return 3;
				case DayOfWeek.Thursday: 
					return 4;
				case DayOfWeek.Friday:	 
					return 5;
				case DayOfWeek.Saturday: 
					return 6;
				case DayOfWeek.Sunday:	 
					return 7;
				default:
					return -1;
			}
		}

		public void addNewAppointmentContainer(int EstimatedDurationMinutes , Appointment appointment)
        {
            AppointmentContainer ac = new AppointmentContainer(appointment);

			int y = TimeRangeHelper.getYByTime(appointment.AppontmentDateTime.Hour, appointment.AppontmentDateTime.Minute);

			ac.Height = (EstimatedDurationMinutes / timeSlotMins + 1) * timeslotHight;
            ac.SetBounds(width / colums * day, y, width / colums, ac.Height);
            ac.BackColor = Color.AliceBlue;
            ac.Parent = sceduller;
            ac.refreshValues();

			visibleContainers.Add(ac);
            
            ac = null;
        }

        internal void initAppointments(List<Appointment> appointments, DateTime now)
        {
            //MessageBox.Show("Number of Appointments Found in the database: "+appointments.Count);
            DateTime date = now;
            
            //date.Subtract(new TimeSpan(1, 0, 0, 0));
            if(date.DayOfWeek == DayOfWeek.Monday)
            {
                mondayDate = date;
            }
            else
            {
                while(date.DayOfWeek != DayOfWeek.Monday)
                {
                    date = date.Subtract(new TimeSpan(1, 0, 0, 0));
                    Debug.WriteLine(date.ToShortDateString());
                }
                mondayDate = date;
            }

            date = now;
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                sundayDate = date;
            }
            else
            {
                while (date.DayOfWeek != DayOfWeek.Sunday)
                {
                   date =  date.Add(new TimeSpan(1, 0, 0, 0));
                }
                sundayDate = date;
            }

            
			visibleAppointments.Clear();
            foreach (Appointment appointment in appointments)
            {
                if(appointment.AppontmentDateTime.CompareTo(mondayDate)>=0 && appointment.AppontmentDateTime.CompareTo(sundayDate) <= 0)
                {
                    
                    visibleAppointments.Add(appointment);
                }
            }

			for (int i = 0; i<visibleContainers.Count;i++ )
			{
				
				visibleContainers.ElementAt(i).Dispose();
			}
			visibleContainers.Clear();
            foreach(Appointment appointment in visibleAppointments)
            {
                
                
                addNewAppointmentContainer(appointment);
            }

			Debug.WriteLine("Visible Appointments: " + visibleAppointments.Count + "\n" +
				"Appointment Containers: " + visibleContainers.Count);
        }

        internal void resetValues(Sceduller sceduller, int width, int minsPerHour)
        {
            this.sceduller = sceduller;
            this.width = width;
            this.minsPerHour = minsPerHour;

            foreach(AppointmentContainer ac in visibleContainers)
            {

				int y = TimeRangeHelper.getYByTime(ac.appointment.AppontmentDateTime.Hour, ac.appointment.AppontmentDateTime.Minute);
                ac.SetBounds(width / colums * day, y, width / colums, ac.Height);
                ac.refreshValues();
            }
        }
    }
}
