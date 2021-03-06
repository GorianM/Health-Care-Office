﻿using ModelProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthAndCareOffice
{
    public partial class NPatient : Form
    {
        public NPatient()
        {
            InitializeComponent();
            CenterToParent();
            this.ActiveControl = textBoxAmka;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            const char Delete = (char)8;
            e.Handled = !Char.IsDigit(e.KeyChar) && e.KeyChar != Delete;
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox10_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void textBox13_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox14_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {

            /*if(!textBoxWeight.Text.Contains(".") || !textBoxWeight.Text.Substring(1,1).Equals("."))
            {
                MessageBox.Show("You forgot to insert dot or wrong validation","Wrong validation");
                textBoxWeight.Text = "";
            }*/
        }
        string dbName = @"C:\Users\User\source\repos\Health-Care-Office2\HealthAndCareOffice\HealthAndCareOffice\Vasi-Diaxeirisis-Iatreiou.accdb";
        private void button2_Click(object sender, EventArgs e)
        {
            string amka = textBoxAmka.Text;
            string lastName = textBoxLastName.Text;
            string firstName = textBoxFirstName.Text;
            string sex;
            if (radioButtonMale.Checked) sex = "m";
            else sex = "f";
            string phoneNumber = textBoxPhoneNumber1.Text;
            string phoneNumber2 = textBoxPhoneNumber2.Text;
            string address = textBoxAddress.Text;
            string regNumber = textBoxRegNumber.Text;
            string insurance = textBoxInsurance.Text;
            int weight = Convert.ToInt32(textBoxWeight.Text);

            Patient patient = new Patient();
            patient.Amka = amka;
            patient.LastName = lastName;
            patient.FirstName = firstName;
            patient.Sex = sex;
            patient.BirthDate = dateTimePicker1.Value;
            patient.PhoneNumber = phoneNumber;
            patient.PhoneNumber2 = phoneNumber2;
            patient.Address = address;
            patient.RegistrationNumber = regNumber;
            patient.Insurance = insurance;
            patient.Weight = weight;

            DataBaseManagement dbm = new DataBaseManagement();
            dbm.addPatient(patient);



        }

        private void NPatient_Load(object sender, EventArgs e)
        {
            textBoxAmka.Focus();
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBoxWeight.MaxLength = 4;
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
