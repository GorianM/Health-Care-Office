using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace HealthAndCareOffice
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            CenterToParent();
            label1.Text = "Create an empty access file and" + Environment.NewLine + "backup all the content of database";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
          
        }

        private void fileSystemWatcher1_Created(object sender, FileSystemEventArgs e)
        {

        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFD1 = new SaveFileDialog();
                string FileName = "";
                SaveFD1.InitialDirectory = "D:";
                SaveFD1.FileName = "";
                SaveFD1.Title = "Backup ";
                SaveFD1.DefaultExt = "accdb";
                SaveFD1.Filter = "Ms-Access Files (*.accdb)|*.accdb|All Files|*.*";
                //SaveFD1.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*"; 
                SaveFD1.FilterIndex = 1;
                SaveFD1.RestoreDirectory = true;
                if (SaveFD1.ShowDialog() == DialogResult.OK)
                {

                    FileName = SaveFD1.FileName;
                    Backup(FileName);
                    MessageBox.Show("Backup Process is Completed Successfully !", "Backup Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while backup " + ex, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        protected void Backup(string path)
        {
            // ----------------------------------- 
            // -- CREATE FILE BACKUP 
            // ----------------------------------- 
            string src = Application.StartupPath + @"\mydb.accdb";
            string dst = path;
            System.IO.File.Copy(src, dst, true);
        }
    }
}
