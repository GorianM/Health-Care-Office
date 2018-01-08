using ModelProject;
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
    public partial class NewAppointment : Form
    {
        List<Patient> patientList;
        Patient selectedPatient = null;

        public NewAppointment()
        {
            InitializeComponent();
            CenterToParent();
            newAppointmentDatePicker.Format = DateTimePickerFormat.Custom;
            newAppointmentDatePicker.CustomFormat = "yyyy-MM-dd hh:mm:ss";

            DataBaseManagement dbm = new DataBaseManagement();
            patientList = dbm.getPatientsForSelection();
            foreach(Patient patient in patientList)
            {
                PatientListBox.Items.Add(patient.getShortString());
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DateTime date = newAppointmentDatePicker.Value;
            DateTime time = newAppointmentTimePicker.Value;
            string reason = textBoxReasonOfAppointment.Text;
            Patient patient = selectedPatient;
            int duration = Convert.ToInt32(textBoxEstimatedDuration.Text);

            bool validated = validateInput();
            if(validated)
            {
                Appointment appointment = new Appointment();
                appointment.AppontmentDateTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute,time.Second);
                appointment.Reason = reason;
                appointment.EstimatedDurationMinutes = duration;
                appointment.patient = patient;
                appointment.staff = GlobalConfig.User;
                DataBaseManagement dbm = new DataBaseManagement();
                dbm.addAppointment(appointment);
                this.Close();
            }

            
        }

        private bool validateInput()
        {
            bool validation = true;
            if(selectedPatient == null)
            {
                validation = false;
                selectedPatientLabel.Text = "You must have a selected Patient";
            }

            return validation;
        }

        private void OnSelectedIndexChanged(object sender, EventArgs e)
        {
            selectedPatient = patientList.ElementAt(PatientListBox.SelectedIndex);
            selectedPatientLabel.Text = selectedPatient.getShortString();
        }
    }
}
