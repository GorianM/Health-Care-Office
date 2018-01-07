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
        public int Hour { get; set; }
        public int Mins { get; set; }
        public int height { get; set; }
        Label PatientNameLabel;
        Label AppointmentTimeLabel;
        Button btn;
        public AppointmentContainer()
        {
            this.BorderStyle = BorderStyle.FixedSingle;
            this.ForeColor = Color.Black;

            PatientNameLabel = new Label();
            PatientNameLabel.Text = "Test";
            PatientNameLabel.Parent = this;
            PatientNameLabel.Height = 15;
            PatientNameLabel.Width = Width - 10;
            

            AppointmentTimeLabel = new Label();
            AppointmentTimeLabel.Text = "Test";
            AppointmentTimeLabel.Parent = this;
            AppointmentTimeLabel.Top = 15;

            btn = new Button();
            btn.BackColor = Color.White;
            btn.Top = 0;
            int y = Width - 10;
            btn.Left =  y;
            btn.Width = 10;
            btn.Text = "Open";
            btn.Visible = true;
            btn.Parent = this;
            btn.Click += Btn_Click;
            
            
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            PatientNameLabel.Text = "A very long String that does not fit!";
        }

        internal void refreshValues()
        {
            PatientNameLabel.Width = Width - 20;

            btn.Top = 0;
            int y = Width - 20;
            btn.Left = y;
            btn.Width = 20;
            btn.Text = "^";
            btn.Visible = true;
            btn.Parent = this;
        }
    }
}
