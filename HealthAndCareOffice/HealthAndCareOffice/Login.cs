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
        OleDbConnection con = new OleDbConnection();
        private void label3_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            /* if (textBoxUser.Text == "admin" && textBoxPassword.Text == "123")
             {

                 Save_Data();
                 this.Close();
             }
             else
             {
                 MessageBox.Show("Invalid username/password", "Login error", MessageBoxButtons.OK, MessageBoxIcon.Error);

             }
             */
            if (CheckFunction() == true)
            {
                MessageBox.Show("Congradulations! Now you are logged in!");
                this.Close();
            }
            else
            {
                MessageBox.Show("Sorry, your login information is not correct. Please try again.");
            }
        

    }
        public bool CheckFunction()
        {

            con.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\User\source\repos\Health-Care-Office2\HealthAndCareOffice\HealthAndCareOffice\Vasi-Diaxeirisis-Iatreiou.accdb";
            con.Open();


            //1st ATTEMPT FAILED---BEG
            DataTable dt = new DataTable();
            DataSet ds = new DataSet();
            ds.Tables.Add(dt);

            OleDbDataAdapter da = new OleDbDataAdapter("SELECT Username, Password FROM Staff", con);
            da.Fill(dt);

            foreach (DataRow r in dt.Rows)
            {
                if (r[0].ToString() == textBoxUser.Text && r[1].ToString() == textBoxPassword.Text)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

            con.Close();

            return false;
            //*1st ATTEMPT FAILED---END */

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

