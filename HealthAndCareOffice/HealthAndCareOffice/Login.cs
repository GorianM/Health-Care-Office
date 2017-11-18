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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            textBoxPassword.MaxLength = 15;
            textBoxUser.MaxLength = 15;
            Init_Data();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBoxUser.Text=="admin" && textBoxPassword.Text == "123")
            {
                MessageBox.Show("Συνδεεστε στο συστημα","Επυτυχια συνδεσης");
                Save_Data();
            }
            else
            {
                MessageBox.Show("Λαθος στοιχεια", "Aπυτυχια συνδεσης");
            }
            
        }
        private void Init_Data()
        {
            if(Properties.Settings.Default.Username != string.Empty)
            {
                if (Properties.Settings.Default.Remme == "yes")
                {
                    textBoxUser.Text = Properties.Settings.Default.Username;
                    textBoxPassword.Text = Properties.Settings.Default.Password;
                    checkRemmer.Checked = true;
                }
                else
                {
                    textBoxUser.Text = Properties.Settings.Default.Username;
                }
            }
        }

        private void Save_Data()
        {
            if (checkRemmer.Checked)
            {
                Properties.Settings.Default.Username = textBoxUser.Text;
                Properties.Settings.Default.Password = textBoxPassword.Text;
                Properties.Settings.Default.Remme = "yes";
                Properties.Settings.Default.Save();
            }
            else
            {            
                    Properties.Settings.Default.Username = textBoxUser.Text;
                    Properties.Settings.Default.Password ="";
                    Properties.Settings.Default.Remme = "no";
                    Properties.Settings.Default.Save();

                }
            }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                checkRemmer.Focus();
            }
        }

       
        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                textBoxPassword.Focus();
            }
        }
    }
   
}

