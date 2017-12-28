using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace HealthAndCareOffice
{
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;
        public Login()
        {
            System.Drawing.Icon ico = new System.Drawing.Icon("C:\\Users\\User\\source\\repos\\Health-Care-Office2\\HealthAndCareOffice\\HealthAndCareOffice\\bin\\Debug\\Health_Care_Office 2.ico");
            this.Icon = ico;
            InitializeComponent();
            textBoxPassword.MaxLength = 15;
            textBoxUser.MaxLength = 15;
            CenterToParent();
            this.ActiveControl =  textBoxUser;
            Init_Data();   
        }
        
        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }
        DataTable dt = new DataTable();
        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.StaffTableAdapter sta = new _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.StaffTableAdapter();
                _Vasi_Diaxeirisis_IatreiouDataSet.StaffDataTable dt = sta.GetDataByUsernamePassword(textBoxUser.Text, textBoxPassword.Text);

                if (dt.Rows.Count > 0)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Wrong username/password","Error");
                }

            }catch(Exception ex)
            {
                MessageBox.Show("");
            }

        }
        
        private void Init_Data()
        {
            if (Properties.Settings.Default.Username != string.Empty)
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
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.Remme = "no";
                Properties.Settings.Default.Save();

            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panelLeft_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelRight_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void panelLeft_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void panelRight_Paint(object sender, PaintEventArgs e)
        {
         
            
        }

        private void panelLeft_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelRight_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panelRight_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBoxUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void textBoxPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1.PerformClick();
            }
        }

        private void Regbtn_Click(object sender, EventArgs e)
        {
            Register reg = new Register();
            reg.ShowDialog();
        }

        private void textBoxUser_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBoxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}

