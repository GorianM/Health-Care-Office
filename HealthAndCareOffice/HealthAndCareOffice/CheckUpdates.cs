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
    public partial class CheckUpdates : Form
    {
        public CheckUpdates()
        {
            InitializeComponent();
            CenterToParent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.progressBar1.Increment(1);
            this.progressBar1.Maximum = 101;
            if (progressBar1.Value >= progressBar1.Maximum)
            {
                timer1.Stop();
                MessageBox.Show("Complete");
            }
        }
       
            private void progressBar1_Validated(object sender, EventArgs e)
        {
           // MessageBox.Show("completed check , no updates were found..");
            progressBar1.Maximum = 100;
           
            if (progressBar1.Value == 100)
            {
                timer1.Stop();
                MessageBox.Show("Complete");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
    }

