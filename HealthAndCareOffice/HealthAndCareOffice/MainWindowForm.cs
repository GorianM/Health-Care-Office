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
using ModelProject;
using ModelsProject;

namespace HealthAndCareOffice
{
    public partial class MainWindowForm : Form
    {
        DataTable dt = new DataTable();
        NewAppointment np;
        //static string connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\Vasi-Diaxeirisis-IatreiouV2.accdb";
        //OleDbConnection conn = new OleDbConnection(connection);
        bool startAddingPatient = false;
        bool startAddingIncomes = false;
        bool startAddingExpenses = false;
        bool startAddingAppointment = false;
        bool startAddingExpendables = false;

		bool allowUpdatePatient = true;
		bool allowUpdateIncomes = true;
		bool allowUpdateExpenses = true;
		bool allowUpdateAppointment = true;
		bool allowUpdateExpandables = true;


		public MainWindowForm()
        {
            try
            {
                InitializeComponent();
            }catch(Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
           
            
            this.Size = new Size(1224, 900);
            CenterToParent();
            
            DataBaseManagement dataBase = new DataBaseManagement();
            dataBase.getPatients(PatientsGridView);
            List<Appointment> appointments = dataBase.getAppointments();
            sceduller1.initScedulerTable();
            sceduller1.SetDataBase(appointments);

			try
			{
				sceduller1.initAppointmentManager();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

			

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
            np = new NewAppointment();
            np.ShowDialog();
            np.FormClosed += Np_FormClosed;
        }

        private void Np_FormClosed(object sender, FormClosedEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable appointment = new _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter apsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();
            apsd.Fill(appointment);
            appointmentDataGridView.DataSource = appointment;

            _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable patient = new _Vasi_Diaxeirisis_IatreiouV2DataSet.PatientDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter psd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            psd.FillByEverything(patient);
            PatientsGridView.DataSource = patient;
        }

        private void AddPatientButton_Click(object sender, EventArgs e)
        {
            NPatient myForm = new NPatient();
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
                    asd.FillByLastNameId(patient, ".>", p,",.,.");
                }
                else
                {
                    asd.FillByLastNameId(patient, txtSearch.Text, -99999,txtSearch.Text);
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
                asd.FillByLastNameId(patient, txtSearch.Text, p,txtSearch.Text);
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
            if (incomesDataGridView != null) incomesDataGridView.SetBounds(0, 0, incomesDataGridView.Width, incomesDataGridView.Parent.Height / 2);
            if (expensesDataGridView != null) expensesDataGridView.SetBounds(0, expensesDataGridView.Parent.Height / 2, expensesDataGridView.Width, expensesDataGridView.Parent.Height / 2);

            if (incomesSearchLabel != null) incomesSearchLabel.Location = new Point(incomesSearchLabel.Location.X,0);
            if (textBoxSearchIncome != null) textBoxSearchIncome.Location = new Point(textBoxSearchIncome.Location.X, 0+incomesSearchLabel.Height+10);
            if (btnDeleteIncomes != null) btnDeleteIncomes.Location = new Point(btnDeleteIncomes.Location.X, 0 + textBoxSearchIncome.Location.Y+ textBoxSearchIncome.Height + 10);

            if (expensesSearchLabel != null) expensesSearchLabel.Location = new Point(expensesSearchLabel.Location.X, expensesSearchLabel.Parent.Height / 2);
            if (textBoxSearchExpenses != null) textBoxSearchExpenses.Location = new Point(textBoxSearchExpenses.Location.X, (textBoxSearchExpenses.Parent.Height / 2)+expensesSearchLabel.Height+10);
            if (btnDeleteExpenses != null)
            {
                btnDeleteExpenses.Location = new Point(btnDeleteExpenses.Location.X,  textBoxSearchExpenses.Location.Y + textBoxSearchExpendables.Height+10);
            }
        }

        private void PatientsGridView_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void PatientsGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if(allowUpdatePatient)
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
				string amka = PatientsGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
				string sex = PatientsGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
				DateTime dt = new DateTime();
				try
				{
					dt = Convert.ToDateTime(PatientsGridView.Rows[e.RowIndex].Cells[7].Value.ToString());
				}
				catch (Exception ex)
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
                string amka = PatientsGridView.Rows[PatientsGridView.Rows.Count - 2].Cells[5].Value.ToString();
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
                asd.InsertPatientQuery(patientId, phonenumber, phonenumber2, firstname, lastname, amka, sex, address, registration, debt, insurance, notes, weight,dt);
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
			allowUpdatePatient = false;
            
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
			allowUpdateIncomes = false;
        }

        private void expensesDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingExpenses = true;
			allowUpdateExpenses = false;
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
                
            }
        }

        private void incomesDataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
			if(allowUpdateIncomes)
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

				isd.UpdateIncomesQuery(description, amount, staffId, incomeid);

				incomesDataGridView.EndEdit();
			}
           
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
			if(allowUpdateExpenses)
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
			if(allowUpdateAppointment)
			{
				_Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable appointment = new _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable();
				_Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter apsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();

				int appointmentid = 0;
				if (!appointmentDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString().Equals(""))
				{
					appointmentid = (int)appointmentDataGridView.Rows[e.RowIndex].Cells[0].Value;
				}
				DateTime dt = new DateTime();
				try
				{
					dt = Convert.ToDateTime(appointmentDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString());
				}
				catch (Exception ex)
				{
				}
				string diagnosis = appointmentDataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
				string treatment = appointmentDataGridView.Rows[e.RowIndex].Cells[6].Value.ToString(); ;
				string reason = appointmentDataGridView.Rows[e.RowIndex].Cells[4].Value.ToString(); ;
				string notes = appointmentDataGridView.Rows[e.RowIndex].Cells[7].Value.ToString(); ;
				DateTime exactTime = new DateTime();
				try
				{
					exactTime = Convert.ToDateTime(appointmentDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString());
				}
				catch (Exception ex)
				{

				}

				int duration = 0; ;
				int patientId = 0;
				if (!appointmentDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString().Equals(""))
				{
					duration = (int)appointmentDataGridView.Rows[e.RowIndex].Cells[3].Value;
				}

				if (!appointmentDataGridView.Rows[e.RowIndex].Cells[8].Value.ToString().Equals(""))
				{
					patientId = (int)appointmentDataGridView.Rows[e.RowIndex].Cells[8].Value;
				}
				int staffId = 0;
				if (!appointmentDataGridView.Rows[e.RowIndex].Cells[9].Value.ToString().Equals(""))
				{
					staffId = (int)appointmentDataGridView.Rows[e.RowIndex].Cells[9].Value;
				}

				apsd.UpdateAppointmentQuery(dt, exactTime, duration, reason, diagnosis, treatment, notes, patientId, staffId, appointmentid);

				appointmentDataGridView.EndEdit();
			}
           
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
			if(allowUpdateExpandables)
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
				exsd.UpdateExpendablesQuery(description, treshhold, quantity, staffId, expendablesid);
				
				dataGridViewExpendables.EndEdit();
			}
            
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
				dataGridViewExpendables.DataSource = expandable;
				startAddingExpendables = false;

            }
        }

        private void dataGridViewExpendables_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingExpendables = true;
			allowUpdateExpandables = false;
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

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void TodayButton_Click(object sender, EventArgs e)
        {
            currentWeekDate.Value = DateTime.Now;
			DataBaseManagement dataBase = new DataBaseManagement();
			List<Appointment> appointments = dataBase.getAppointments();
			
			sceduller1.SetDataBase(appointments);
			sceduller1.refreshApointmentManager(currentWeekDate.Value);
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
			currentWeekDate.Value = DateTime.Now;
			DataBaseManagement dataBase = new DataBaseManagement();
			List<Appointment> appointments = dataBase.getAppointments();

			DateTime date = currentWeekDate.Value;
            if(date.DayOfWeek ==DayOfWeek.Monday)
            {
                currentWeekDate.Value = currentWeekDate.Value.Subtract(new TimeSpan(7, 0, 0, 0));
            }
            else
            {
                while(date.DayOfWeek != DayOfWeek.Monday)
                {
                    date = date.Subtract(new TimeSpan(1, 0, 0, 0));
                }
                currentWeekDate.Value = date.Subtract(new TimeSpan(7, 0, 0, 0));
            }
            sceduller1.refreshApointmentManager(currentWeekDate.Value);
			sceduller1.Invalidate();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
			currentWeekDate.Value = DateTime.Now;
			DataBaseManagement dataBase = new DataBaseManagement();
			List<Appointment> appointments = dataBase.getAppointments();

			DateTime date = currentWeekDate.Value;
            if (date.DayOfWeek == DayOfWeek.Sunday)
            {
                currentWeekDate.Value = currentWeekDate.Value.Add(new TimeSpan(1, 0, 0, 0));
            }
            else
            {
                while (date.DayOfWeek != DayOfWeek.Sunday)
                {
                    date = date.Add(new TimeSpan(1, 0, 0, 0));
                }
                currentWeekDate.Value = date.Add(new TimeSpan(1, 0, 0, 0));
            }
			sceduller1.SuspendLayout();
            sceduller1.refreshApointmentManager(currentWeekDate.Value);
			sceduller1.ResumeLayout();
			sceduller1.Invalidate();
        }

		private void currentWeekDate_ValueChanged(object sender, EventArgs e)
		{
			currentWeekDate.Value = DateTime.Now;
			DataBaseManagement dataBase = new DataBaseManagement();
			List<Appointment> appointments = dataBase.getAppointments();
			sceduller1.refreshApointmentManager(currentWeekDate.Value);
		}

		private void MainWindowForm_Shown(object sender, EventArgs e)
		{

			List<ExpandableProdact> expandableProdacts = new List<ExpandableProdact>();
			_Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable expendable = new _Vasi_Diaxeirisis_IatreiouV2DataSet.ExpandableProductsDataTable();
			_Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter exsd = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.ExpandableProductsTableAdapter();

			DataTable dt =  exsd.GetDataByStaffID(GlobalConfig.User.StaffId);
			

			for(int i = 0; i< dt.Rows.Count;i++)
			{
				object[] row = dt.Rows[i].ItemArray;				
				ExpandableProdact ep = new ExpandableProdact();
				ep.ID = (int)row[0];
				ep.Description = row[1].ToString();
				ep.MinimumThreshold = (int)row[2];
				ep.Quantity = (int)row[3];
				ep.staff = GlobalConfig.User;
				expandableProdacts.Add(ep);
				
			}
			
			string s = "";
			int counter = 0;
			foreach(ExpandableProdact expandableProdact in expandableProdacts)
			{
				if(expandableProdact.Quantity< expandableProdact.MinimumThreshold && expandableProdact.Quantity>0)
				{
					s += expandableProdact.ToString() + "\n";
					s += "The Prodact is going out of stock\n";
					counter++;
				}
				else if(expandableProdact.Quantity == 0)
				{
					s += expandableProdact.ToString() + "\n";
					s += "The Prodact is out of stock\n";
					counter++;
				}
				else { Debug.WriteLine(expandableProdact.ToString()); }
				
			}

			foreach (ExpandableProdact expandableProdact in expandableProdacts)
			{
				Debug.WriteLine(expandableProdact.ToString());

			}
			
			if(counter>0)
			{
				MessageBox.Show(s,"Expandable Prodacts report",MessageBoxButtons.OK,MessageBoxIcon.Information);
			}
			
		}

        private void appointmentDataGridView_RowLeave(object sender, DataGridViewCellEventArgs e)
        {
            _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable ap = new _Vasi_Diaxeirisis_IatreiouV2DataSet.AppointmentDataTable();
            _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter aptb = new _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();
            if (startAddingAppointment)
            {
                int appointmentid = 0;
                int duration = 0;
                int staffid = 0;
                string treatment;
                string notes;
                string diagnosis;
                string reason;
                DateTime dt = new DateTime();
                DateTime exacttime = new DateTime();                
                int patientid = 0;

                if (!appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[0].Value.ToString().Equals(""))
                {
                    appointmentid = (int)appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[0].Value;
                }

                try
                {
                    dt = Convert.ToDateTime(appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[1].Value.ToString());
                }
                catch
                {}
                try
                {
                   exacttime = Convert.ToDateTime(appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[2].Value.ToString());
                }
                catch
                {}
               
                if (!appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[3].Value.ToString().Equals(""))
                {
                    duration = (int)appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[3].Value;
                }
                reason = appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[4].Value.ToString();
                diagnosis = appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[5].Value.ToString();
                treatment = appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[6].Value.ToString();

                notes = appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[7].Value.ToString();

                if (!appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[8].Value.ToString().Equals(""))
                {
                    patientid = (int)appointmentDataGridView.Rows[appointmentDataGridView.Rows.Count - 2].Cells[8].Value;
                }
                staffid = GlobalConfig.User.StaffId;
                aptb.InsertAppointmentQuery(appointmentid,dt,exacttime,duration,reason,diagnosis,treatment,notes,patientid,staffid);
                startAddingAppointment = false;
				allowUpdateAppointment = true;

            }

        }

        private void appointmentDataGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            startAddingAppointment = true;
			allowUpdateAppointment = false;
        }
    }
}
