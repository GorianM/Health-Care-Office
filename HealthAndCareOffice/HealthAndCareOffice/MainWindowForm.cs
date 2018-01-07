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
using System.Data.OleDb;
using HealthAndCareOffice.Properties;
namespace HealthAndCareOffice
{
    public partial class MainWindowForm : Form
    {
        DataTable dt = new DataTable();
        static string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Vasi-Diaxeirisis-IatreiouV2.accdb";
        OleDbConnection conn = new OleDbConnection(connection);
        public MainWindowForm()
        {
            InitializeComponent();
            sceduller1.Height= 2900;
            this.Size = new Size(1224, 900);
            CenterToParent();
            
            DataBaseManagement dataBase = new DataBaseManagement();
            dataBase.getPatients(PatientsGridView);
        }
        
        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAppointment na = new NewAppointment();
            na.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myForm = new AboutForm();
           
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
            NewAppointment np = new NewAppointment();
            np.ShowDialog();
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            NPatient myForm = new NPatient();
            //this.Hide();
            myForm.ShowDialog();
        }

        private void checkForUpdatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CheckUpdates myForm = new CheckUpdates();
            myForm.ShowDialog();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsForm sf = new SettingsForm();
            sf.ShowDialog();
        }

        private void petientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NPatient np = new NPatient();
            np.ShowDialog();
        }

        private void openDocumentationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\User\source\repos\Health-Care-Office2\Health & Care Office Documentation.docx");
        }

        private void button5_Click(object sender, EventArgs e)
        {
        

        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteIncomes_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {
            
        }

        private void OnResize(object sender, EventArgs e)
        {
            
        }
    }
}
