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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox8_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back);
        }

        private void textBox9_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.StaffDataTable staff = new _Vasi_Diaxeirisis_IatreiouV2DataSet.StaffDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.StaffTableAdapter std = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.StaffTableAdapter();
            //Int32 count = std.GetDataByCountStaff();
            foreach (TextBox t in this.Controls)
            {
                if (t.Text.CompareTo("") > 0)
                {
                    MessageBox.Show("You have empty textboxes ","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                }
            }
            int role = 0;
            if (!textBoxFullName.Text.Equals(""))
            {
                if (textBoxFullName.Text.Equals("1") | textBoxFullName.Text.Equals("2"))
                {
                    role = Convert.ToInt32(textBoxFullName.Text);
                }
                else
                {
                    textBoxFullName.Text = "";
                }
            }

            //std.InsertQueryStaff(11, textBoxUsername.Text, textBoxPassword.Text, textBoxMedicalSpeciality.Text, textBoxName.Text, textBoxLastName.Text, textBoxPhonenumber.Text, textBoxPhonenumber2.Text, role);


        }
    }
}
