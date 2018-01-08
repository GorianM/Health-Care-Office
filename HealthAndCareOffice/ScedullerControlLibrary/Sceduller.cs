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
        public Sceduller()
        {
            InitializeComponent();

            scedullerTable= new ScedullerTable(Width);
            Height = scedullerTable.Height;
            appointmentManager = new AppointmentManager(this, Width, 15);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            SuspendLayout();
            scedullerTable.onPaint(e,Font);
            ResumeLayout();
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(scedullerTable!= null)Height = scedullerTable.Height;
            if (scedullerTable != null)scedullerTable.SetWidth(Width);
            if (appointmentManager != null) appointmentManager.resetValues(this, Width, 15);
            
            Invalidate();

        }

        public void SetDataBase(List<Appointment> appointments)
        {
            throw new NotImplementedException();
        }

        
    }
}
