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
            
            int role = 0;
            bool validated = validateRegister(out role);
            MessageBox.Show("Validated: " + validated);
            if(validated)
            {
                int count = std.GetStaffId().Count+1;
                MessageBox.Show("Id: " + count);
                try
                {
                    std.InsertStaffQuery(count, textBoxUsername.Text, textBoxPassword.Text, textBoxMedicalSpeciality.Text, textBoxName.Text, textBoxLastName.Text, textBoxPhonenumber.Text, textBoxPhonenumber2.Text, role);
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
            

            


        }

        private bool validateRegister(out int role)
        {
            bool validated = true;
            role = -1;
            if (!textBoxRole.Text.Equals(""))
            {
                if (textBoxRole.Text.Equals("1") | textBoxRole.Text.Equals("2"))
                {
                    role = Convert.ToInt32(textBoxRole.Text);
                }
                else
                {
                    textBoxRole.Text = "";
                }
                
            }
            else
            {
                validated = false;
            }

            foreach (Control c in this.Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    TextBox t = c as TextBox;
                    if (t.Text.Equals(""))
                    {
                        validated = false;
                    }
                }

            }

            return validated;
        }
    }
}
