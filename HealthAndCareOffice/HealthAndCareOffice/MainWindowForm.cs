using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthAndCareOffice
{
    public partial class MainWindowForm : Form
    {

        Label[] daysLabelArray;
        string[] daysArray = {"Time", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday ", "Sunday" };
        public MainWindowForm()
        {
            InitializeComponent();
            

            daysLabelArray = new Label[daysArray.Length];
            for(int i = 0; i < daysArray.Length;i++)
            {
                Label day = new Label();
                day.Text = daysArray[i];
                day.SetBounds(ToolbarPanel.Width / daysArray.Length * i, ToolbarPanel.Height-20, ToolbarPanel.Width / daysArray.Length, 20);
                day.Parent = ToolbarPanel;
                day.Anchor = AnchorStyles.None;
                day.Visible = true;
                day.BorderStyle = BorderStyle.FixedSingle;
                day.TextAlign = ContentAlignment.MiddleCenter;
                daysLabelArray[i] = day;
            }

            AppointmentCalendar appointmentCalendar = new AppointmentCalendar(calendarContainerPanel);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myForm = new AboutForm();
            //this.Hide();
            myForm.ShowDialog();
            
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            Login loginForm = new Login();
            loginForm.BringToFront();
            loginForm.Focus();
            loginForm.ShowDialog();
        }

        private void ToolbarPanel_Resize(object sender, EventArgs e)
        {
            for(int i = 0; i < daysLabelArray.Length;i++)
            {
                daysLabelArray[i].SetBounds(ToolbarPanel.Width / daysArray.Length * i, ToolbarPanel.Height - 20, ToolbarPanel.Width / daysArray.Length, 20);
            }

        }

       
    }
}
