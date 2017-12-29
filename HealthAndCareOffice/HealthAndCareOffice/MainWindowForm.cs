﻿using System;
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
            try
            {
               
             
                this._Vasi_Diaxeirisis_IatreiouDataSet.Incomes.AddIncomesRow(this._Vasi_Diaxeirisis_IatreiouDataSet.Incomes.NewIncomesRow());
                incomesBindingSource.MoveLast();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                incomesBindingSource.ResetBindings(false);
            }

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
    }
}
