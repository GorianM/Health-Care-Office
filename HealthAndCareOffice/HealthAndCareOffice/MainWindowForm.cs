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
    public partial class MainWindowForm : Form
    {
        public MainWindowForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

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
    }
}
