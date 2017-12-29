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

            if(!textBoxWeight.Text.Contains(".") || !textBoxWeight.Text.Substring(1,1).Equals("."))
            {
                MessageBox.Show("You forgot to insert dot or wrong validation","Wrong validation");
                textBoxWeight.Text = "";
            }
        }
        string dbName = @"C:\Users\User\source\repos\Health-Care-Office2\HealthAndCareOffice\HealthAndCareOffice\Vasi-Diaxeirisis-Iatreiou.accdb";
        private void button2_Click(object sender, EventArgs e)
        {
            OleDbConnection connect = new OleDbConnection();
            try
            {
                string sqlQuery = "INSERT INTO [Patient] (`PatientId`,`PhoneNumber`,`PhoneNumber2`,`FirstName`,`LastName`,`Amka`,`Sex`,`BirthDate`,`Adress`,`RegistrationNumber`,`Debt`,`Insurance`,`Notes`,`Weight`) values (?,?,?,?,?,?,?,?,?,?,?,?,?,?)";
                using (OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\User\\source\\repos\\Health-Care-Office2\\HealthAndCareOffice\\HealthAndCareOffice\\Vasi-Diaxeirisis-Iatreiou.accdb")) 
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@PatientId", 53);
                    cmd.Parameters.AddWithValue("@Phonenumber", 12214241);
                    cmd.Parameters.AddWithValue("@Phonenumber2", 5323132);
                    cmd.Parameters.AddWithValue("@FirstName", textBoxFirstName.Text);
                    cmd.Parameters.AddWithValue("@LastName", textBoxLastName.Text);
                    cmd.Parameters.AddWithValue("@Amka", textBoxAmka.Text);
                    cmd.Parameters.AddWithValue("@Sex", "male");
                    cmd.Parameters.AddWithValue("@BirthDate", "29/11/96");
                    cmd.Parameters.AddWithValue("@Adress", "eirinis 7");
                    cmd.Parameters.AddWithValue("@RegistrationNumber", 253);
                    cmd.Parameters.AddWithValue("@Dept", 20);
                    cmd.Parameters.AddWithValue("@Insurance", "IKA");
                    cmd.Parameters.AddWithValue("@Notes", "blabla");
                    cmd.Parameters.AddWithValue("@Weight", 1.60);

                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }
        
    
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
