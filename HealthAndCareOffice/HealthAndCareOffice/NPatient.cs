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
            this.ActiveControl = textBox2;
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

            if(!textBox14.Text.Contains(".") || !textBox14.Text.Substring(1,1).Equals("."))
            {
                MessageBox.Show("You forgot to insert dot or wrong validation","Wrong validation");
                textBox14.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control c in this.Controls)
            {
                TextBox tb = c as TextBox;
                if (null != tb)
                {
                    MessageBox.Show("Empty text , be carefull");
                    break;
                }
            }
            System.Data.OleDb.OleDbConnection conn = new System.Data.OleDb.OleDbConnection();
            conn.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Health-Care-Office2\HealthAndCareOffice\HealthAndCareOffice\Vasi-Diaxeirisis-Iatreiou.accdb";

            try
            {
                String sex = "";
                if (radioButton1.Checked)
                {
                    sex = "male";
                }
                else
                {
                    sex = "female";
                }
                conn.Open();
                String amka = textBox2.Text.ToString();
                String lastname = textBox3.Text.ToString();
                String firstname = textBox4.Text.ToString();
                String phonenum1 = textBox7.Text.ToString();
                String phonenum2 = textBox8.Text.ToString();
                String address = textBox9.Text.ToString();
                String regnum = textBox10.Text.ToString();
                String insurance = textBox13.Text.ToString();
                String weight = textBox14.Text.ToString();
                String notes = textBox1.Text.ToString();
                String dept = textBox5.Text.ToString();
                String theDate = dateTimePicker1.Value.ToString("yyyy-MM-dd");
                String my_querry = "INSERT INTO Patient(PatientId,PhoneNumber,PhoneNumber2,FirstName,LastName,Amka,Sex,BirthDate,Adress,Registration,Debt,Insurance,Notes,Weight) VALUES('" +phonenum1 + "','" + phonenum2 + "','" + firstname + "',' "+lastname+ "',' "+amka+ "',' " +sex+ "',' " +theDate+ "',' " +address+ "',' " +regnum+ "',' " +dept + "',' "+insurance + "',' "+notes+ "',' "+weight+ "')";

                OleDbCommand cmd = new OleDbCommand(my_querry, conn);
                cmd.ExecuteNonQuery();

                MessageBox.Show("Data saved successfuly...!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed due to" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        private void NPatient_Load(object sender, EventArgs e)
        {
            textBox2.Focus();
        }

        private void textBox14_KeyPress(object sender, KeyPressEventArgs e)
        {
            textBox14.MaxLength = 4;
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
