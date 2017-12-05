using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HealthAndCareOffice
{
    public partial class MainWindowForm : Form
    {

       
       

        public MainWindowForm()
        {
            InitializeComponent();
            sceduller1.Height= 2900;
            CenterToParent();
            Debug.WriteLine(sceduller1.Location.X);
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
            
        }

        private void AddNewAppoinmentButton_Click(object sender, EventArgs e)
        {
            
        }
    }
}
