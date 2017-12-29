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

namespace HealthAndCareOffice
{
    public partial class MainWindowForm : Form
    {

        public MainWindowForm()
        {
            InitializeComponent();
            sceduller1.Height= 2900;
            this.Size = new Size(1224, 900);
            dataGridView1.Width = 1180;
            dataGridView1.Height = 790;
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
            OleDbConnection connect = new OleDbConnection();
            try
            {
                string sqlQuery = "INSERT INTO [Incomes] (IncomesId,Description,Amount,StaffId) values (?,?,?,?)";
                using (OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source=C:\\Users\\User\\source\\repos\\Health-Care-Office2\\HealthAndCareOffice\\HealthAndCareOffice\\Vasi-Diaxeirisis-Iatreiou.accdb"))
                using (OleDbCommand cmd = new OleDbCommand(sqlQuery, conn))
                {
                    conn.Open();
                    cmd.Parameters.AddWithValue("@IncomesId", 53);
                    cmd.Parameters.AddWithValue("@Description","Επισκεψη για γενικη εξεταση ");
                    cmd.Parameters.AddWithValue("@Amount", 50);
                    cmd.Parameters.AddWithValue("@StaffId", 2);


                    cmd.ExecuteNonQuery();
                    connect.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                connect.Close();
            }

        }

        private void btnSaveIncome_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.incomesBindingSource.EndEdit();
                this.incomesTableAdapter.Update(this._Vasi_Diaxeirisis_IatreiouDataSet.Incomes);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
