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
        bool startAddingPatient = false;
        bool startAddingIncomes = false;
        bool startAddingExpenses = false;
        bool startAddingAppointment = false;
        bool startAddingExpendables = false;

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
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet1.ExpandableProducts' table. You can move, or remove it, as needed.
            this.expandableProductsTableAdapter.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet1.ExpandableProducts);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet1.Appointment' table. You can move, or remove it, as needed.
            this.appointmentTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet1.Appointment);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet1.Expenses' table. You can move, or remove it, as needed.
            this.expensesTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet1.Expenses);
            // TODO: This line of code loads data into the '_Vasi_Diaxeirisis_IatreiouV2DataSet1.Incomes' table. You can move, or remove it, as needed.
            this.incomesTableAdapter1.Fill(this._Vasi_Diaxeirisis_IatreiouV2DataSet1.Incomes);

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
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            try
            {
                int selectedIndex = PatientsGridView.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {               
                    asd.DeletePatientQuery((int)PatientsGridView.Rows[selectedIndex].Cells[0].Value);
                    PatientsGridView.Rows.RemoveAt(selectedIndex);
                }
            }catch(InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            PatientsGridView.Update();
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            int p = 0;
            if (!txtSearch.Text.ToString().Equals(""))
            {
                bool result=Int32.TryParse(txtSearch.Text,out p);
                if (result)
                {
                    asd.FillByLastNameId(patient, ".>", p);
                }
                else
                {
                    asd.FillByLastNameId(patient, txtSearch.Text, -99999);
                }
                PatientsGridView.DataSource = patient;
            }
            else if (txtSearch.Text.Equals(""))
            {
                asd.FillByEverything(patient);
                PatientsGridView.DataSource = patient;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            int p = 0;
            if (!txtSearch.Text.ToString().Equals(""))
            {
                p = Convert.ToInt32(txtSearch.Text);
                asd.FillByLastNameId(patient, txtSearch.Text, p);
                PatientsGridView.DataSource = patient;
            }
            else if (txtSearch.Text.Equals(""))
            {
                asd.FillByEverything(patient);
                PatientsGridView.DataSource = patient;
            }

        }

        private void LoadButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDeleteIncomes_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable incomes = new _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter();
            try
            {
                int selectedIndex = incomesDataGridView.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    asd.DeleteIncomesQuery((int)incomesDataGridView.Rows[selectedIndex].Cells[0].Value);
                    incomesDataGridView.Rows.RemoveAt(selectedIndex);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            incomesDataGridView.Update();
        }

        private void btnDeleteExpenses_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable expenses = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter esd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter();
            try
            {
                int selectedIndex = expensesDataGridView.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    esd.DeleteExpensesQuery((int)expensesDataGridView.Rows[selectedIndex].Cells[0].Value);
                    expensesDataGridView.Rows.RemoveAt(selectedIndex);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            expensesDataGridView.Update();
        }

        private void OnResize(object sender, EventArgs e)
        {
            
        }

        private void PatientsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void PatientsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            int patientId = 0;
            if (!PatientsGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Equals("")) 
            patientId = (int)PatientsGridView.Rows[e.RowIndex].Cells[0].Value;
            
            string phonenumber = PatientsGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            string phonenumber2 = PatientsGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            string firstname = PatientsGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            string lastname = PatientsGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            int amka = 0;
            if (!PatientsGridView.Rows[e.RowIndex].Cells[5].Value.ToString().Equals(""))
                amka = (int)PatientsGridView.Rows[e.RowIndex].Cells[5].Value;
            string sex = PatientsGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
            DateTime dt= new DateTime();
            try
            {
                dt = Convert.ToDateTime(PatientsGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
            }catch(Exception ex)
            {
                
            }
            string address = PatientsGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            string registration = PatientsGridView.Rows[e.RowIndex].Cells[9].Value.ToString();
            int debt = 0;
            if (!PatientsGridView.Rows[e.RowIndex].Cells[10].Value.ToString().Equals(""))
                debt = (int)PatientsGridView.Rows[e.RowIndex].Cells[10].Value;
            string insurance = PatientsGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            string notes = PatientsGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            int weight = 0;
            if (!PatientsGridView.Rows[e.RowIndex].Cells[13].Value.ToString().Equals(""))
                weight = (int)PatientsGridView.Rows[e.RowIndex].Cells[13].Value;
            //if (patientId!=0 && amka != 0 && debt != 0 && weight != 0 && dt!=null)
                asd.UpdateQueryPatients(phonenumber, phonenumber2, firstname, lastname, amka, sex, dt, address, registration, debt, insurance, notes, weight, patientId);
            PatientsGridView.EndEdit();
        }

        private void PatientsGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //startAdding = true;
        }
        
        private void PatientsGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter asd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            if (startAddingPatient)
            {
                int patientId = 0;
                if (!PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[0].Value.ToString().Equals(""))
                    patientId = (int)PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[0].Value;

                string phonenumber = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[1].Value.ToString();
                string phonenumber2 = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[2].Value.ToString();
                string firstname = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[3].Value.ToString();
                string lastname = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[4].Value.ToString();
                int amka = 0;
                if (!PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[5].Value.ToString().Equals(""))
                    amka = (int)PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[5].Value;
                string sex = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[6].Value.ToString();
                DateTime dt = new DateTime();
                try
                {
                    dt = Convert.ToDateTime(PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[7].Value.ToString());
                }
                catch (Exception ex)
                {

                }
                string address = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[8].Value.ToString();
                string registration = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[9].Value.ToString();
                int debt = 0;
                if (!PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[10].Value.ToString().Equals(""))
                    debt = (int)PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[10].Value;
                string insurance = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[11].Value.ToString();
                string notes = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[12].Value.ToString();
                int weight = 0;
                if (!PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[13].Value.ToString().Equals(""))
                    weight = (int)PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[13].Value;
                asd.InsertPatientQuery(patientId, phonenumber, phonenumber2, firstname, lastname, amka, sex, dt, address, registration, debt, insurance, notes, weight);
                PatientsGridView.Refresh();
                PatientsGridView.EndEdit();
                startAddingPatient = false;
            }
        }

        private void PatientsGridView_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

         
        }

        private void PatientsGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingPatient = true;
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
        }
        
        private void incomesDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable income = new _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter isd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter();
            if (startAddingIncomes)
            {
                int incomeid = 0;
                if (!incomesDataGridView.Rows[incomesDataGridView.Rows.Count - 2].Cells[0].Value.ToString().Equals(""))
                {
                    incomeid = (int)incomesDataGridView.Rows[incomesDataGridView.Rows.Count - 2].Cells[0].Value;
                }
                string description = incomesDataGridView.Rows[incomesDataGridView.Rows.Count - 2].Cells[1].Value.ToString();
                int amount = 0;
                if (!incomesDataGridView.Rows[incomesDataGridView.Rows.Count - 2].Cells[2].Value.ToString().Equals(""))
                {
                    amount = (int)incomesDataGridView.Rows[incomesDataGridView.Rows.Count - 2].Cells[2].Value;
                }
                int staffId = GlobalConfig.User.StaffId;
                if (incomeid != 0)
                {
                    isd.InsertIncomesQuery(incomeid, description, amount, staffId);
                }
                startAddingIncomes = false;
                incomesDataGridView.EndEdit();
            }
        }

        private void incomesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingIncomes = true;
        }

        private void expensesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingExpenses = true;
        }

        private void expensesDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable expenses = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter esd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter();
            if (startAddingExpenses)
            {
                int expensesid = 0;
                if (!expensesDataGridView.Rows[expensesDataGridView.Rows.Count - 2].Cells[0].Value.ToString().Equals(""))
                {
                    expensesid = (int)expensesDataGridView.Rows[expensesDataGridView.Rows.Count - 2].Cells[0].Value;
                }
                string description = expensesDataGridView.Rows[expensesDataGridView.Rows.Count - 2].Cells[1].Value.ToString();
                int amount = 0;
                if (!expensesDataGridView.Rows[expensesDataGridView.Rows.Count - 2].Cells[2].Value.ToString().Equals(""))
                {
                    amount = (int)expensesDataGridView.Rows[expensesDataGridView.Rows.Count - 2].Cells[2].Value;
                }
                int staffId = GlobalConfig.User.StaffId;
                if (expensesid != 0)
                {
                    esd.InsertExpensesQuery(expensesid, description, amount, staffId);
                }
                startAddingIncomes = false;
                incomesDataGridView.EndEdit();
            }
        }

        private void incomesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable income = new _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter isd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter();
            int incomeid = 0;
            if (!incomesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(""))
            {
                incomeid = (int)incomesDataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            string description = incomesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            int amount = 0;
            if (!incomesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString().Equals(""))
            {
                amount = (int)incomesDataGridView.Rows[e.RowIndex].Cells[2].Value;
            }
            int staffId = GlobalConfig.User.StaffId;

            isd.UpdateIncomesQuery(description, amount, staffId,incomeid);
                  
            incomesDataGridView.EndEdit();
        }

        private void textBoxSearchIncome_TextChanged(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable income = new _Vasi_Diaxeirisis_IatreiouV2DataSet.IncomesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter isd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.IncomesTableAdapter();
            if (!textBoxSearchIncome.Text.ToString().Equals(""))
            { 
                isd.FillByDescription(income, textBoxSearchIncome.Text);
                incomesDataGridView.DataSource = income;
            }
            else if (textBoxSearchIncome.Text.Equals(""))
            {
                isd.FillByEverything(income);
                incomesDataGridView.DataSource = income;
            }

        }

        private void expensesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable expenses = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter esd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter();
            int expensesid = 0;
            if (!expensesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(""))
            {
                expensesid = (int)expensesDataGridView.Rows[e.RowIndex].Cells[0].Value;
            }
            string description = expensesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            int amount = 0;
            if (!expensesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString().Equals(""))
            {
                amount = (int)expensesDataGridView.Rows[e.RowIndex].Cells[2].Value;
            }
            int staffId = GlobalConfig.User.StaffId;

            esd.UpdateExpensesQuery(description, amount, staffId, expensesid);

            expensesDataGridView.EndEdit();
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable expenses = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpensesDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter esd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpensesTableAdapter();
            if (!textBoxSearchIncome.Text.ToString().Equals(""))
            {
                esd.FillByEverything(expenses, textBoxSearchExpenses.Text);
                expensesDataGridView.DataSource = expenses;
            }
            else if (textBoxSearchIncome.Text.Equals(""))
            {
                esd.FillByEverything(expenses, textBoxSearchExpenses.Text);
                expensesDataGridView.DataSource = expenses;
            }
        }

        private void btnDeleteAppointment_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable appointment = new _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter apsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();
            try
            {
                int selectedIndex = appointmentDataGridView.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    apsd.DeleteAppointmentQuery((int)appointmentDataGridView.Rows[selectedIndex].Cells[0].Value);
                    appointmentDataGridView.Rows.RemoveAt(selectedIndex);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            appointmentDataGridView.Update();
        }

        private void textBoxAppointment_TextChanged(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable appointment = new _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter apsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();
            int appointmentId=0;
            
            if (!textBoxAppointment.Text.ToString().Equals(""))
            {
    
                bool result = Int32.TryParse(textBoxAppointment.Text, out appointmentId);
                if (result)
                {
                    apsd.FillByFields(appointment, appointmentId,"adsm");
                    appointmentDataGridView.DataSource = appointment;
                }
                else
                {
                    apsd.FillByFields(appointment, -999999, textBoxAppointment.Text);
                    appointmentDataGridView.DataSource = appointment;
                }
            }
            else if (textBoxAppointment.Text.Equals(""))
            {
                apsd.Fill(appointment);
                appointmentDataGridView.DataSource = appointment;
            }
        }

        private void appointmentDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable appointment = new _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter apsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();
        }

        private void btnDeleteExpendables_Click(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable expandable = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter exsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter();
            try
            {
                int selectedIndex = dataGridViewExpendables.CurrentCell.RowIndex;
                if (selectedIndex > -1)
                {
                    exsd.DeleteExpendablesQuery((int)dataGridViewExpendables.Rows[selectedIndex].Cells[0].Value);
                    dataGridViewExpendables.Rows.RemoveAt(selectedIndex);
                }
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            dataGridViewExpendables.Update();
        }

        private void dataGridViewExpendables_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable expandable = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter exsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter();
            int expendablesid = 0;     
            int treshhold = 0;
            int quantity = 0;
            if (!dataGridViewExpendables.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(""))
            {
                expendablesid = (int)dataGridViewExpendables.Rows[e.RowIndex].Cells[0].Value;
            }
            string description = dataGridViewExpendables.Rows[e.RowIndex].Cells[1].Value.ToString();
            if (!dataGridViewExpendables.Rows[e.RowIndex].Cells[2].Value.ToString().Equals(""))
            {
                treshhold = (int)dataGridViewExpendables.Rows[e.RowIndex].Cells[2].Value;
            }
            if (!dataGridViewExpendables.Rows[e.RowIndex].Cells[3].Value.ToString().Equals(""))
            {
                quantity = (int)dataGridViewExpendables.Rows[e.RowIndex].Cells[3].Value;
            }
            int staffId = GlobalConfig.User.StaffId;
            exsd.UpdateExpendablesQuery(description, treshhold,quantity,staffId, expendablesid);

            dataGridViewExpendables.EndEdit();
        }

        private void dataGridViewExpendables_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable expandable = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter exsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter();
            if (startAddingExpendables)
            {
                int expendablesid = 0;
                int treshhold = 0;
                int quantity = 0;
                if (!dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count-2].Cells[0].Value.ToString().Equals(""))
                    {
                    expendablesid = (int)dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count - 2].Cells[0].Value;
                    }
                string description = dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count - 2].Cells[1].Value.ToString();
                if (!dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count - 2].Cells[2].Value.ToString().Equals(""))
                {
                    treshhold = (int)dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count - 2].Cells[2].Value;
                }
                if (!dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count - 2].Cells[3].Value.ToString().Equals(""))
                {
                    quantity = (int)dataGridViewExpendables.Rows[dataGridViewExpendables.Rows.Count - 2].Cells[3].Value;
                }
                int staffId = GlobalConfig.User.StaffId;
                exsd.InsertExpendablesQuery(expendablesid, description, treshhold, quantity, staffId);
                startAddingExpendables = false;

            }
        }

        private void dataGridViewExpendables_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingExpendables = true;
        }

        private void textBoxSearchExpendables_TextChanged(object sender, EventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable expendable = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter exsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter();
            int expendablesId = 0;
            if (!textBoxSearchExpendables.Text.ToString().Equals(""))
            {

                bool result = Int32.TryParse(textBoxSearchExpendables.Text, out expendablesId);
                if (result)
                {
                    exsd.FillByFields(expendable, expendablesId, ".,.,");
                    dataGridViewExpendables.DataSource = expendable;
                }
                else
                {
                    exsd.FillByFields(expendable, -999999, textBoxSearchExpendables.Text);
                    dataGridViewExpendables.DataSource = expendable;
                }
            }
            else if (textBoxAppointment.Text.Equals(""))
            {
                exsd.Fill(expendable);
                dataGridViewExpendables.DataSource = expendable;
            }
        }
    }
}
