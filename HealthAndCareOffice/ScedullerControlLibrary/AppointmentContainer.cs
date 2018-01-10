using ModelProject;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScedullerControlLibrary
{
    class AppointmentContainer : Panel
    {
       
        public int height { get; set; }
        Label PatientNameLabel;
        Label AppointmentTimeLabel;
        Button btn;

		public Appointment appointment { get; }
        public AppointmentContainer(Appointment appointment)
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ForeColor = Color.Black;
			this.appointment = appointment;


            PatientNameLabel = new Label();
            PatientNameLabel.Text = appointment.patient.FirstName+" "+appointment.patient.LastName;
            
            PatientNameLabel.Parent = this;
            PatientNameLabel.Height = 30;
            PatientNameLabel.Width = Width - 20;
            PatientNameLabel.Top = 20;
            PatientNameLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;


            AppointmentTimeLabel = new Label();
            
            AppointmentTimeLabel.Text = "Date: "+appointment.AppontmentDateTime.ToLongDateString();
            AppointmentTimeLabel.Height = 30;
            AppointmentTimeLabel.Width = Width - 20;
            AppointmentTimeLabel.Anchor = AnchorStyles.Left | AnchorStyles.Right;            
            AppointmentTimeLabel.Parent = this;
            AppointmentTimeLabel.Top = 50;

            btn = new Button();
            btn.BackColor = Color.White;
            btn.Top = 5;
            int y = Width - 25;
            btn.Left =  y;
            btn.Width = 20;
            
            
            btn.Text = "^";
            btn.Visible = true;
            btn.Click += Btn_Click;
            btn.Parent = this;
            

        }

        private void Btn_Click(object sender, EventArgs e)
        {
            PatientNameLabel.Text = "A very long String that does not fit!";
        }

        internal void refreshValues()
        {
            //PatientNameLabel.Width = Width - 20;

            btn.Top = 5;
            int y = Width - 25;
            btn.Left = y;
            btn.Width = 20;
            btn.Height = 20;
            btn.Text = "^";
            btn.Visible = true;
            btn.Parent = this;
        }
    }
}
