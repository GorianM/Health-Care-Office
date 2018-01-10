using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ModelProject;

namespace ScedullerControlLibrary
{
    public partial class Sceduller: UserControl
    {
        public Day[] days = new Day[7];
        ScedullerTable scedullerTable;
        AppointmentManager appointmentManager;

        List<Appointment> appointments;

        bool readyToPaint = false;
        public Sceduller()
        {
            InitializeComponent();
        }

        public void initScedulerTable()
        {
            SuspendLayout();
            scedullerTable = new ScedullerTable(Width);
            Height = scedullerTable.Height;
            readyToPaint = true;
            ResumeLayout();
        }

        public void initAppointmentManager()
        {
            appointmentManager = new AppointmentManager(this, Width, 15);
            appointmentManager.initAppointments(appointments, DateTime.Now);	           
            
        }

        public void refreshApointmentManager(DateTime now)
        {
            appointmentManager.initAppointments(appointments,now);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (readyToPaint)
            {
                base.OnPaint(e);
                SuspendLayout();
                scedullerTable.onPaint(e, Font);
                ResumeLayout();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            if(readyToPaint)
            {
                base.OnResize(e);
                if (scedullerTable != null) Height = scedullerTable.Height;
                if (scedullerTable != null) scedullerTable.SetWidth(Width);
                if (appointmentManager != null) appointmentManager.resetValues(this, Width, 15);

                Invalidate();
            }
            

        }

        public void SetDataBase(List<Appointment> appointments)
        {
            this.appointments = appointments;
        }

        
    }
}
