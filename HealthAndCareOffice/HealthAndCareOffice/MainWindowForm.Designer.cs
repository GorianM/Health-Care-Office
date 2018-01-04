﻿namespace HealthAndCareOffice
{
    partial class MainWindowForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindowForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.appointmentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openDocumentationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AppointmentsTabPage = new System.Windows.Forms.TabPage();
            this.ToolbarPanel = new System.Windows.Forms.Panel();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.currentWeekDate = new System.Windows.Forms.DateTimePicker();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.TodayButton = new System.Windows.Forms.Button();
            this.AddNewAppoinmentButton = new System.Windows.Forms.Button();
            this.calendarContainerPanel = new System.Windows.Forms.Panel();
            this.sceduller1 = new ScedullerControlLibrary.Sceduller();
            this.Patients = new System.Windows.Forms.TabPage();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.dataGridViewPatients = new System.Windows.Forms.DataGridView();
            this.patientBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.Income_Expenses = new System.Windows.Forms.TabPage();
            this.btnSaveExpenses = new System.Windows.Forms.Button();
            this.btnSaveIncome = new System.Windows.Forms.Button();
            this.InsertExpenses = new System.Windows.Forms.Button();
            this.btnInsertIncome = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.expensesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vasiDiaxeirisisIatreiouDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Vasi_Diaxeirisis_IatreiouDataSet = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSet();
            this.dataGridViewIncome = new System.Windows.Forms.DataGridView();
            this.incomesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.TableAdapterManager();
            this.expensesTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.ExpensesTableAdapter();
            this.incomesTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.IncomesTableAdapter();
            this.patientAppointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.AppointmentTableAdapter();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vasiDiaxeirisisIatreiouV2DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._Vasi_Diaxeirisis_IatreiouV2DataSet = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouV2DataSet();
            this.patientTableAdapter1 = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.appointmentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.appointmentTableAdapter1 = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter();
            this.appointmentIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estimatedDurationMinutesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reasonDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.treatmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientIdDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIdDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AppointmentsTabPage.SuspendLayout();
            this.ToolbarPanel.SuspendLayout();
            this.calendarContainerPanel.SuspendLayout();
            this.Patients.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).BeginInit();
            this.Income_Expenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasiDiaxeirisisIatreiouDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vasi_Diaxeirisis_IatreiouDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAppointmentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasiDiaxeirisisIatreiouV2DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vasi_Diaxeirisis_IatreiouV2DataSet)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.windowToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(861, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.appointmentToolStripMenuItem,
            this.petientToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // appointmentToolStripMenuItem
            // 
            this.appointmentToolStripMenuItem.Name = "appointmentToolStripMenuItem";
            this.appointmentToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // petientToolStripMenuItem
            // 
            this.petientToolStripMenuItem.Name = "petientToolStripMenuItem";
            this.petientToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.petientToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.petientToolStripMenuItem.Text = "Patient";
            this.petientToolStripMenuItem.Click += new System.EventHandler(this.petientToolStripMenuItem_Click);
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.checkForUpdatesToolStripMenuItem,
            this.openDocumentationToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.U)));
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // openDocumentationToolStripMenuItem
            // 
            this.openDocumentationToolStripMenuItem.Name = "openDocumentationToolStripMenuItem";
            this.openDocumentationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.openDocumentationToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
            this.openDocumentationToolStripMenuItem.Text = "Open Documentation";
            this.openDocumentationToolStripMenuItem.Click += new System.EventHandler(this.openDocumentationToolStripMenuItem_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.AppointmentsTabPage);
            this.tabControl1.Controls.Add(this.Patients);
            this.tabControl1.Controls.Add(this.Income_Expenses);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(837, 552);
            this.tabControl1.TabIndex = 1;
            // 
            // AppointmentsTabPage
            // 
            this.AppointmentsTabPage.BackColor = System.Drawing.Color.Transparent;
            this.AppointmentsTabPage.Controls.Add(this.ToolbarPanel);
            this.AppointmentsTabPage.Controls.Add(this.calendarContainerPanel);
            this.AppointmentsTabPage.ImageIndex = 0;
            this.AppointmentsTabPage.Location = new System.Drawing.Point(4, 22);
            this.AppointmentsTabPage.Name = "AppointmentsTabPage";
            this.AppointmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTabPage.Size = new System.Drawing.Size(829, 526);
            this.AppointmentsTabPage.TabIndex = 0;
            this.AppointmentsTabPage.Text = "Appointments";
            // 
            // ToolbarPanel
            // 
            this.ToolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolbarPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarPanel.Controls.Add(this.AddPatientButton);
            this.ToolbarPanel.Controls.Add(this.currentWeekDate);
            this.ToolbarPanel.Controls.Add(this.btnNext);
            this.ToolbarPanel.Controls.Add(this.btnPrev);
            this.ToolbarPanel.Controls.Add(this.TodayButton);
            this.ToolbarPanel.Controls.Add(this.AddNewAppoinmentButton);
            this.ToolbarPanel.Location = new System.Drawing.Point(0, 3);
            this.ToolbarPanel.Name = "ToolbarPanel";
            this.ToolbarPanel.Size = new System.Drawing.Size(829, 68);
            this.ToolbarPanel.TabIndex = 0;
            this.ToolbarPanel.Resize += new System.EventHandler(this.ToolbarPanel_Resize);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddPatientButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddPatientButton.ImageIndex = 0;
            this.AddPatientButton.ImageList = this.imageList1;
            this.AddPatientButton.Location = new System.Drawing.Point(539, 3);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Size = new System.Drawing.Size(185, 32);
            this.AddPatientButton.TabIndex = 5;
            this.AddPatientButton.Text = "New patient";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.button4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "αρχείο λήψης (2).jpg");
            this.imageList1.Images.SetKeyName(1, "icon_grid_1x_de73ba9d-65eb-40f7-8d4e-4cab9f666ad6.png");
            this.imageList1.Images.SetKeyName(2, "αρχείο λήψης (1).jpg");
            this.imageList1.Images.SetKeyName(3, "arrow-right-01-512.png");
            this.imageList1.Images.SetKeyName(4, "left.png");
            // 
            // currentWeekDate
            // 
            this.currentWeekDate.Location = new System.Drawing.Point(306, 7);
            this.currentWeekDate.Name = "currentWeekDate";
            this.currentWeekDate.Size = new System.Drawing.Size(197, 20);
            this.currentWeekDate.TabIndex = 4;
            // 
            // btnNext
            // 
            this.btnNext.ImageIndex = 3;
            this.btnNext.ImageList = this.imageList1;
            this.btnNext.Location = new System.Drawing.Point(509, 6);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(24, 20);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnPrev
            // 
            this.btnPrev.ImageIndex = 4;
            this.btnPrev.ImageList = this.imageList1;
            this.btnPrev.Location = new System.Drawing.Point(276, 6);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(24, 20);
            this.btnPrev.TabIndex = 2;
            this.btnPrev.UseVisualStyleBackColor = true;
            // 
            // TodayButton
            // 
            this.TodayButton.Location = new System.Drawing.Point(193, 6);
            this.TodayButton.Name = "TodayButton";
            this.TodayButton.Size = new System.Drawing.Size(75, 20);
            this.TodayButton.TabIndex = 1;
            this.TodayButton.Text = "Today";
            this.TodayButton.UseVisualStyleBackColor = true;
            // 
            // AddNewAppoinmentButton
            // 
            this.AddNewAppoinmentButton.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.AddNewAppoinmentButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewAppoinmentButton.ImageIndex = 1;
            this.AddNewAppoinmentButton.ImageList = this.imageList1;
            this.AddNewAppoinmentButton.Location = new System.Drawing.Point(4, 6);
            this.AddNewAppoinmentButton.Name = "AddNewAppoinmentButton";
            this.AddNewAppoinmentButton.Size = new System.Drawing.Size(183, 29);
            this.AddNewAppoinmentButton.TabIndex = 0;
            this.AddNewAppoinmentButton.Text = "New Appointment";
            this.AddNewAppoinmentButton.UseVisualStyleBackColor = true;
            this.AddNewAppoinmentButton.Click += new System.EventHandler(this.AddNewAppoinmentButton_Click);
            // 
            // calendarContainerPanel
            // 
            this.calendarContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarContainerPanel.AutoScroll = true;
            this.calendarContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.calendarContainerPanel.Controls.Add(this.sceduller1);
            this.calendarContainerPanel.Location = new System.Drawing.Point(3, 78);
            this.calendarContainerPanel.Name = "calendarContainerPanel";
            this.calendarContainerPanel.Size = new System.Drawing.Size(829, 442);
            this.calendarContainerPanel.TabIndex = 1;
            // 
            // sceduller1
            // 
            this.sceduller1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sceduller1.AutoScroll = true;
            this.sceduller1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sceduller1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sceduller1.Location = new System.Drawing.Point(3, 3);
            this.sceduller1.Name = "sceduller1";
            this.sceduller1.Size = new System.Drawing.Size(820, 399);
            this.sceduller1.TabIndex = 0;
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.button1);
            this.Patients.Controls.Add(this.txtSearch);
            this.Patients.Controls.Add(this.btnSearch);
            this.Patients.Controls.Add(this.btnDelete);
            this.Patients.Controls.Add(this.ButtonSave);
            this.Patients.Controls.Add(this.dataGridViewPatients);
            this.Patients.ImageIndex = 1;
            this.Patients.Location = new System.Drawing.Point(4, 22);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(829, 526);
            this.Patients.TabIndex = 1;
            this.Patients.Text = "Patients";
            this.Patients.UseVisualStyleBackColor = true;
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(9, 205);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(81, 20);
            this.txtSearch.TabIndex = 4;
            this.txtSearch.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(15, 176);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(15, 138);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(17, 29);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(73, 23);
            this.ButtonSave.TabIndex = 1;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // dataGridViewPatients
            // 
            this.dataGridViewPatients.AutoGenerateColumns = false;
            this.dataGridViewPatients.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewPatients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPatients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.phoneNumber2DataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.amkaDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.addressDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.insuranceDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridViewPatients.DataSource = this.patientBindingSource2;
            this.dataGridViewPatients.Location = new System.Drawing.Point(104, 0);
            this.dataGridViewPatients.Name = "dataGridViewPatients";
            this.dataGridViewPatients.Size = new System.Drawing.Size(725, 526);
            this.dataGridViewPatients.TabIndex = 0;
            // 
            // patientBindingSource2
            // 
            this.patientBindingSource2.DataMember = "Patient";
            this.patientBindingSource2.DataSource = this.vasiDiaxeirisisIatreiouV2DataSetBindingSource;
            // 
            // Income_Expenses
            // 
            this.Income_Expenses.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Income_Expenses.Controls.Add(this.btnSaveExpenses);
            this.Income_Expenses.Controls.Add(this.btnSaveIncome);
            this.Income_Expenses.Controls.Add(this.InsertExpenses);
            this.Income_Expenses.Controls.Add(this.btnInsertIncome);
            this.Income_Expenses.Controls.Add(this.dataGridView3);
            this.Income_Expenses.Controls.Add(this.dataGridViewIncome);
            this.Income_Expenses.ImageIndex = 2;
            this.Income_Expenses.Location = new System.Drawing.Point(4, 22);
            this.Income_Expenses.Name = "Income_Expenses";
            this.Income_Expenses.Padding = new System.Windows.Forms.Padding(3);
            this.Income_Expenses.Size = new System.Drawing.Size(829, 526);
            this.Income_Expenses.TabIndex = 2;
            this.Income_Expenses.Text = "Income/Expenses";
            // 
            // btnSaveExpenses
            // 
            this.btnSaveExpenses.Location = new System.Drawing.Point(713, 341);
            this.btnSaveExpenses.Name = "btnSaveExpenses";
            this.btnSaveExpenses.Size = new System.Drawing.Size(110, 23);
            this.btnSaveExpenses.TabIndex = 5;
            this.btnSaveExpenses.Text = "Save";
            this.btnSaveExpenses.UseVisualStyleBackColor = true;
            // 
            // btnSaveIncome
            // 
            this.btnSaveIncome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveIncome.Location = new System.Drawing.Point(713, 75);
            this.btnSaveIncome.Name = "btnSaveIncome";
            this.btnSaveIncome.Size = new System.Drawing.Size(110, 23);
            this.btnSaveIncome.TabIndex = 4;
            this.btnSaveIncome.Text = "Save";
            this.btnSaveIncome.UseVisualStyleBackColor = true;
            this.btnSaveIncome.Click += new System.EventHandler(this.btnSaveIncome_Click);
            // 
            // InsertExpenses
            // 
            this.InsertExpenses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.InsertExpenses.Location = new System.Drawing.Point(713, 285);
            this.InsertExpenses.Name = "InsertExpenses";
            this.InsertExpenses.Size = new System.Drawing.Size(110, 23);
            this.InsertExpenses.TabIndex = 3;
            this.InsertExpenses.Text = "Insert Expenses ";
            this.InsertExpenses.UseVisualStyleBackColor = true;
            // 
            // btnInsertIncome
            // 
            this.btnInsertIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsertIncome.Location = new System.Drawing.Point(713, 36);
            this.btnInsertIncome.Name = "btnInsertIncome";
            this.btnInsertIncome.Size = new System.Drawing.Size(110, 21);
            this.btnInsertIncome.TabIndex = 2;
            this.btnInsertIncome.Text = "Insert Income ";
            this.btnInsertIncome.UseVisualStyleBackColor = true;
            this.btnInsertIncome.Click += new System.EventHandler(this.button5_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView3.AutoGenerateColumns = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.expensesIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn1,
            this.amountDataGridViewTextBoxColumn1,
            this.staffIdDataGridViewTextBoxColumn1});
            this.dataGridView3.DataSource = this.expensesBindingSource;
            this.dataGridView3.Location = new System.Drawing.Point(0, 250);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(707, 267);
            this.dataGridView3.TabIndex = 1;
            // 
            // expensesIdDataGridViewTextBoxColumn
            // 
            this.expensesIdDataGridViewTextBoxColumn.DataPropertyName = "ExpensesId";
            this.expensesIdDataGridViewTextBoxColumn.HeaderText = "ExpensesId";
            this.expensesIdDataGridViewTextBoxColumn.Name = "expensesIdDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn1
            // 
            this.descriptionDataGridViewTextBoxColumn1.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn1.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn1.Name = "descriptionDataGridViewTextBoxColumn1";
            // 
            // amountDataGridViewTextBoxColumn1
            // 
            this.amountDataGridViewTextBoxColumn1.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn1.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn1.Name = "amountDataGridViewTextBoxColumn1";
            // 
            // staffIdDataGridViewTextBoxColumn1
            // 
            this.staffIdDataGridViewTextBoxColumn1.DataPropertyName = "StaffId";
            this.staffIdDataGridViewTextBoxColumn1.HeaderText = "StaffId";
            this.staffIdDataGridViewTextBoxColumn1.Name = "staffIdDataGridViewTextBoxColumn1";
            // 
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this.vasiDiaxeirisisIatreiouDataSetBindingSource;
            // 
            // vasiDiaxeirisisIatreiouDataSetBindingSource
            // 
            this.vasiDiaxeirisisIatreiouDataSetBindingSource.DataSource = this._Vasi_Diaxeirisis_IatreiouDataSet;
            this.vasiDiaxeirisisIatreiouDataSetBindingSource.Position = 0;
            // 
            // _Vasi_Diaxeirisis_IatreiouDataSet
            // 
            this._Vasi_Diaxeirisis_IatreiouDataSet.DataSetName = "_Vasi_Diaxeirisis_IatreiouDataSet";
            this._Vasi_Diaxeirisis_IatreiouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridViewIncome
            // 
            this.dataGridViewIncome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewIncome.AutoGenerateColumns = false;
            this.dataGridViewIncome.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridViewIncome.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewIncome.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomesIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.staffIdDataGridViewTextBoxColumn});
            this.dataGridViewIncome.DataSource = this.incomesBindingSource;
            this.dataGridViewIncome.Location = new System.Drawing.Point(-4, 0);
            this.dataGridViewIncome.Name = "dataGridViewIncome";
            this.dataGridViewIncome.Size = new System.Drawing.Size(711, 250);
            this.dataGridViewIncome.TabIndex = 0;
            // 
            // incomesIdDataGridViewTextBoxColumn
            // 
            this.incomesIdDataGridViewTextBoxColumn.DataPropertyName = "IncomesId";
            this.incomesIdDataGridViewTextBoxColumn.HeaderText = "IncomesId";
            this.incomesIdDataGridViewTextBoxColumn.Name = "incomesIdDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            this.amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            this.amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            this.amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // staffIdDataGridViewTextBoxColumn
            // 
            this.staffIdDataGridViewTextBoxColumn.DataPropertyName = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.HeaderText = "StaffId";
            this.staffIdDataGridViewTextBoxColumn.Name = "staffIdDataGridViewTextBoxColumn";
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "Incomes";
            this.incomesBindingSource.DataSource = this.vasiDiaxeirisisIatreiouDataSetBindingSource;
            // 
            // patientBindingSource1
            // 
            this.patientBindingSource1.DataMember = "Patient";
            this.patientBindingSource1.DataSource = this.vasiDiaxeirisisIatreiouDataSetBindingSource;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataMember = "Patient";
            this.patientBindingSource.DataSource = this._Vasi_Diaxeirisis_IatreiouDataSet;
            // 
            // patientTableAdapter
            // 
            this.patientTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AppointmentTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ExpandableProductsTableAdapter = null;
            this.tableAdapterManager.ExpensesTableAdapter = this.expensesTableAdapter;
            this.tableAdapterManager.IncomesTableAdapter = this.incomesTableAdapter;
            this.tableAdapterManager.PatientTableAdapter = this.patientTableAdapter;
            this.tableAdapterManager.StaffRolesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // incomesTableAdapter
            // 
            this.incomesTableAdapter.ClearBeforeFill = true;
            // 
            // patientAppointmentBindingSource
            // 
            this.patientAppointmentBindingSource.DataMember = "PatientAppointment";
            this.patientAppointmentBindingSource.DataSource = this.patientBindingSource;
            // 
            // appointmentTableAdapter
            // 
            this.appointmentTableAdapter.ClearBeforeFill = true;
            // 
            // patientIdDataGridViewTextBoxColumn
            // 
            this.patientIdDataGridViewTextBoxColumn.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn.Name = "patientIdDataGridViewTextBoxColumn";
            // 
            // phoneNumberDataGridViewTextBoxColumn
            // 
            this.phoneNumberDataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.HeaderText = "PhoneNumber";
            this.phoneNumberDataGridViewTextBoxColumn.Name = "phoneNumberDataGridViewTextBoxColumn";
            // 
            // phoneNumber2DataGridViewTextBoxColumn
            // 
            this.phoneNumber2DataGridViewTextBoxColumn.DataPropertyName = "PhoneNumber2";
            this.phoneNumber2DataGridViewTextBoxColumn.HeaderText = "PhoneNumber2";
            this.phoneNumber2DataGridViewTextBoxColumn.Name = "phoneNumber2DataGridViewTextBoxColumn";
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            // 
            // lastNameDataGridViewTextBoxColumn
            // 
            this.lastNameDataGridViewTextBoxColumn.DataPropertyName = "LastName";
            this.lastNameDataGridViewTextBoxColumn.HeaderText = "LastName";
            this.lastNameDataGridViewTextBoxColumn.Name = "lastNameDataGridViewTextBoxColumn";
            // 
            // amkaDataGridViewTextBoxColumn
            // 
            this.amkaDataGridViewTextBoxColumn.DataPropertyName = "Amka";
            this.amkaDataGridViewTextBoxColumn.HeaderText = "Amka";
            this.amkaDataGridViewTextBoxColumn.Name = "amkaDataGridViewTextBoxColumn";
            // 
            // sexDataGridViewTextBoxColumn
            // 
            this.sexDataGridViewTextBoxColumn.DataPropertyName = "Sex";
            this.sexDataGridViewTextBoxColumn.HeaderText = "Sex";
            this.sexDataGridViewTextBoxColumn.Name = "sexDataGridViewTextBoxColumn";
            // 
            // birthDateDataGridViewTextBoxColumn
            // 
            this.birthDateDataGridViewTextBoxColumn.DataPropertyName = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.HeaderText = "BirthDate";
            this.birthDateDataGridViewTextBoxColumn.Name = "birthDateDataGridViewTextBoxColumn";
            // 
            // addressDataGridViewTextBoxColumn
            // 
            this.addressDataGridViewTextBoxColumn.DataPropertyName = "Address";
            this.addressDataGridViewTextBoxColumn.HeaderText = "Address";
            this.addressDataGridViewTextBoxColumn.Name = "addressDataGridViewTextBoxColumn";
            // 
            // registrationNumberDataGridViewTextBoxColumn
            // 
            this.registrationNumberDataGridViewTextBoxColumn.DataPropertyName = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.HeaderText = "RegistrationNumber";
            this.registrationNumberDataGridViewTextBoxColumn.Name = "registrationNumberDataGridViewTextBoxColumn";
            // 
            // debtDataGridViewTextBoxColumn
            // 
            this.debtDataGridViewTextBoxColumn.DataPropertyName = "Debt";
            this.debtDataGridViewTextBoxColumn.HeaderText = "Debt";
            this.debtDataGridViewTextBoxColumn.Name = "debtDataGridViewTextBoxColumn";
            // 
            // insuranceDataGridViewTextBoxColumn
            // 
            this.insuranceDataGridViewTextBoxColumn.DataPropertyName = "Insurance";
            this.insuranceDataGridViewTextBoxColumn.HeaderText = "Insurance";
            this.insuranceDataGridViewTextBoxColumn.Name = "insuranceDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn
            // 
            this.notesDataGridViewTextBoxColumn.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn.Name = "notesDataGridViewTextBoxColumn";
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            // 
            // vasiDiaxeirisisIatreiouV2DataSetBindingSource
            // 
            this.vasiDiaxeirisisIatreiouV2DataSetBindingSource.DataSource = this._Vasi_Diaxeirisis_IatreiouV2DataSet;
            this.vasiDiaxeirisisIatreiouV2DataSetBindingSource.Position = 0;
            // 
            // _Vasi_Diaxeirisis_IatreiouV2DataSet
            // 
            this._Vasi_Diaxeirisis_IatreiouV2DataSet.DataSetName = "_Vasi_Diaxeirisis_IatreiouV2DataSet";
            this._Vasi_Diaxeirisis_IatreiouV2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // patientTableAdapter1
            // 
            this.patientTableAdapter1.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(829, 526);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Appointment";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.appointmentIDDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.estimatedDurationMinutesDataGridViewTextBoxColumn,
            this.reasonDataGridViewTextBoxColumn,
            this.diagnosisDataGridViewTextBoxColumn,
            this.treatmentDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn1,
            this.patientIdDataGridViewTextBoxColumn1,
            this.staffIdDataGridViewTextBoxColumn2});
            this.dataGridView1.DataSource = this.appointmentBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(837, 530);
            this.dataGridView1.TabIndex = 0;
            // 
            // appointmentBindingSource
            // 
            this.appointmentBindingSource.DataMember = "Appointment";
            this.appointmentBindingSource.DataSource = this.vasiDiaxeirisisIatreiouV2DataSetBindingSource;
            // 
            // appointmentTableAdapter1
            // 
            this.appointmentTableAdapter1.ClearBeforeFill = true;
            // 
            // appointmentIDDataGridViewTextBoxColumn
            // 
            this.appointmentIDDataGridViewTextBoxColumn.DataPropertyName = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.HeaderText = "AppointmentID";
            this.appointmentIDDataGridViewTextBoxColumn.Name = "appointmentIDDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // estimatedDurationMinutesDataGridViewTextBoxColumn
            // 
            this.estimatedDurationMinutesDataGridViewTextBoxColumn.DataPropertyName = "EstimatedDurationMinutes";
            this.estimatedDurationMinutesDataGridViewTextBoxColumn.HeaderText = "EstimatedDurationMinutes";
            this.estimatedDurationMinutesDataGridViewTextBoxColumn.Name = "estimatedDurationMinutesDataGridViewTextBoxColumn";
            // 
            // reasonDataGridViewTextBoxColumn
            // 
            this.reasonDataGridViewTextBoxColumn.DataPropertyName = "Reason";
            this.reasonDataGridViewTextBoxColumn.HeaderText = "Reason";
            this.reasonDataGridViewTextBoxColumn.Name = "reasonDataGridViewTextBoxColumn";
            // 
            // diagnosisDataGridViewTextBoxColumn
            // 
            this.diagnosisDataGridViewTextBoxColumn.DataPropertyName = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.HeaderText = "Diagnosis";
            this.diagnosisDataGridViewTextBoxColumn.Name = "diagnosisDataGridViewTextBoxColumn";
            // 
            // treatmentDataGridViewTextBoxColumn
            // 
            this.treatmentDataGridViewTextBoxColumn.DataPropertyName = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.HeaderText = "Treatment";
            this.treatmentDataGridViewTextBoxColumn.Name = "treatmentDataGridViewTextBoxColumn";
            // 
            // notesDataGridViewTextBoxColumn1
            // 
            this.notesDataGridViewTextBoxColumn1.DataPropertyName = "Notes";
            this.notesDataGridViewTextBoxColumn1.HeaderText = "Notes";
            this.notesDataGridViewTextBoxColumn1.Name = "notesDataGridViewTextBoxColumn1";
            // 
            // patientIdDataGridViewTextBoxColumn1
            // 
            this.patientIdDataGridViewTextBoxColumn1.DataPropertyName = "PatientId";
            this.patientIdDataGridViewTextBoxColumn1.HeaderText = "PatientId";
            this.patientIdDataGridViewTextBoxColumn1.Name = "patientIdDataGridViewTextBoxColumn1";
            // 
            // staffIdDataGridViewTextBoxColumn2
            // 
            this.staffIdDataGridViewTextBoxColumn2.DataPropertyName = "StaffId";
            this.staffIdDataGridViewTextBoxColumn2.HeaderText = "StaffId";
            this.staffIdDataGridViewTextBoxColumn2.Name = "staffIdDataGridViewTextBoxColumn2";
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(861, 592);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainWindowForm";
            this.Text = "Health And Care Office";
            this.Load += new System.EventHandler(this.MainWindowForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.AppointmentsTabPage.ResumeLayout(false);
            this.ToolbarPanel.ResumeLayout(false);
            this.calendarContainerPanel.ResumeLayout(false);
            this.Patients.ResumeLayout(false);
            this.Patients.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource2)).EndInit();
            this.Income_Expenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasiDiaxeirisisIatreiouDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vasi_Diaxeirisis_IatreiouDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewIncome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientAppointmentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasiDiaxeirisisIatreiouV2DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vasi_Diaxeirisis_IatreiouV2DataSet)).EndInit();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.appointmentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AppointmentsTabPage;
        private System.Windows.Forms.TabPage Patients;
        private System.Windows.Forms.Panel ToolbarPanel;
        private System.Windows.Forms.TabPage Income_Expenses;
        private System.Windows.Forms.Panel calendarContainerPanel;
        private System.Windows.Forms.DateTimePicker currentWeekDate;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button TodayButton;
        private System.Windows.Forms.Button AddNewAppoinmentButton;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem appointmentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openDocumentationToolStripMenuItem;
        //private System.Windows.Forms.ImageList imageList1;
        private ScedullerControlLibrary.Sceduller sceduller1;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridViewPatients;
        private System.Windows.Forms.BindingSource vasiDiaxeirisisIatreiouDataSetBindingSource;
        private _Vasi_Diaxeirisis_IatreiouDataSet _Vasi_Diaxeirisis_IatreiouDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView dataGridViewIncome;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.IncomesTableAdapter incomesTableAdapter;
        private System.Windows.Forms.BindingSource incomesBindingSource;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.BindingSource expensesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn expensesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.Button InsertExpenses;
        private System.Windows.Forms.Button btnInsertIncome;
        private System.Windows.Forms.Button btnSaveIncome;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Button btnSaveExpenses;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.BindingSource patientAppointmentBindingSource;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter;
        private System.Windows.Forms.BindingSource patientBindingSource1;
        private System.Windows.Forms.BindingSource vasiDiaxeirisisIatreiouV2DataSetBindingSource;
        private _Vasi_Diaxeirisis_IatreiouV2DataSet _Vasi_Diaxeirisis_IatreiouV2DataSet;
        private System.Windows.Forms.BindingSource patientBindingSource2;
        private _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.PatientTableAdapter patientTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource appointmentBindingSource;
        private _Vasi_Diaxeirisis_IatreiouV2DataSetTableAdapters.AppointmentTableAdapter appointmentTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn appointmentIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estimatedDurationMinutesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn reasonDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn treatmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn2;
    }
}

