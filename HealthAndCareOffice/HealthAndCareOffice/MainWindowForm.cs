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
            dataGridViewPatients.Width = 1180;
            dataGridViewPatients.Height = 790;
            CenterToParent();
            Debug.WriteLine(sceduller1.Location.X);
        }
        
        private void appointmentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewAppointment na = new NewAppointment();
            na.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm myForm = new AboutForm();
            //this.Hide();
            myForm.ShowDialog();
            
        }

        private void MainWindowForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet.Expenses);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet.Incomes' table. You can move, or remove it, as needed.
            this.incomesTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet.Incomes);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet.Appointment);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet.Patient);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouDataSet.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter.Fill(this._Vasi_Diaxeirisis_IatreiouDataSet.Appointment);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouDataSet.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter.Fill(this._Vasi_Diaxeirisis_IatreiouDataSet.Expenses);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouDataSet.Incomes' table. You can move, or remove it, as needed.
            this.incomesTableAdapter.Fill(this._Vasi_Diaxeirisis_IatreiouDataSet.Incomes);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouDataSet.Patient' table. You can move, or remove it, as needed.
            this.patientTableAdapter.Fill(this._Vasi_Diaxeirisis_IatreiouDataSet.Patient);
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

        private void button4_Click(object sender, EventArgs e)
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
            try
            {
                incomesBindingSource.EndEdit();
                incomesTableAdapter.Update(this._Vasi_Diaxeirisis_IatreiouDataSet.Incomes);
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                incomesBindingSource.ResetBindings(false);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try {
            
                int selectedIndex = dataGridViewPatients.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridViewPatients.Rows.RemoveAt(selectedIndex);
                    dataGridViewPatients.Refresh(); // if needed
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
            
          
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
         

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            int p = 0;
            if(!txtSearch.Text.ToString().Equals(""))
               p =  Convert.ToInt32(txtSearch.Text);
            asd.FillByLastName(patient,txtSearch.Text, p);
            dataGridViewPatients.DataSource = patient;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            asd.FillByPatients(patient);
            dataGridViewPatients.DataSource = patient;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to save changes?", "Message", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
            if(dr == DialogResult.Yes)
            {
                this.patientTableAdapter1.Update(_Vasi_Diaxeirisis_IatreiouV2DataSet.Patient);
                dataGridViewPatients.Refresh();
                MessageBox.Show("Copmpleted");
            }
        }

        private void btnDeleteIncomes_Click(object sender, EventArgs e)
        {
            try
            {

                int selectedIndex = dataGridViewIncome.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridViewIncome.Rows.RemoveAt(selectedIndex);
                    dataGridViewIncome.Refresh(); // if needed
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {
            try
            {

                int selectedIndex = dataGridViewExpenses.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    dataGridViewExpenses.Rows.RemoveAt(selectedIndex);
                    dataGridViewExpenses.Refresh(); // if needed
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show("Unable to remove selected row at this time");
            }
        }
    }
}
