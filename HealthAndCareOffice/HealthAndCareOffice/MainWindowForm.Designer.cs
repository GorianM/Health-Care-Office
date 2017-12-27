namespace HealthAndCareOffice
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
            this.button4 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.currentWeekDate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddNewAppoinmentButton = new System.Windows.Forms.Button();
            this.calendarContainerPanel = new System.Windows.Forms.Panel();
            this.sceduller1 = new ScedullerControlLibrary.Sceduller();
            this.Patients = new System.Windows.Forms.TabPage();
            this.Income_Expenses = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this._Vasi_Diaxeirisis_IatreiouDataSet = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSet();
            this.vasiDiaxeirisisIatreiouDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.patientTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.PatientTableAdapter();
            this.tableAdapterManager = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.TableAdapterManager();
            this.patientIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneNumber2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amkaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthDateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insuranceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.incomesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.incomesTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.IncomesTableAdapter();
            this.incomesIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.staffIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expensesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.expensesTableAdapter = new HealthAndCareOffice._Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.ExpensesTableAdapter();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AppointmentsTabPage.SuspendLayout();
            this.ToolbarPanel.SuspendLayout();
            this.calendarContainerPanel.SuspendLayout();
            this.Patients.SuspendLayout();
            this.Income_Expenses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vasi_Diaxeirisis_IatreiouDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasiDiaxeirisisIatreiouDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
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
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(760, 522);
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
            this.AppointmentsTabPage.Size = new System.Drawing.Size(752, 496);
            this.AppointmentsTabPage.TabIndex = 0;
            this.AppointmentsTabPage.Text = "Appointments";
            // 
            // ToolbarPanel
            // 
            this.ToolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolbarPanel.BackColor = System.Drawing.Color.Transparent;
            this.ToolbarPanel.Controls.Add(this.button4);
            this.ToolbarPanel.Controls.Add(this.currentWeekDate);
            this.ToolbarPanel.Controls.Add(this.button3);
            this.ToolbarPanel.Controls.Add(this.button2);
            this.ToolbarPanel.Controls.Add(this.button1);
            this.ToolbarPanel.Controls.Add(this.AddNewAppoinmentButton);
            this.ToolbarPanel.Location = new System.Drawing.Point(0, 3);
            this.ToolbarPanel.Name = "ToolbarPanel";
            this.ToolbarPanel.Size = new System.Drawing.Size(752, 68);
            this.ToolbarPanel.TabIndex = 0;
            this.ToolbarPanel.Resize += new System.EventHandler(this.ToolbarPanel_Resize);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Franklin Gothic Book", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 0;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(539, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(185, 32);
            this.button4.TabIndex = 5;
            this.button4.Text = "New patient";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
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
            // button3
            // 
            this.button3.ImageIndex = 3;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(509, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 20);
            this.button3.TabIndex = 3;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.ImageIndex = 4;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(276, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(193, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Today";
            this.button1.UseVisualStyleBackColor = true;
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
            this.calendarContainerPanel.Size = new System.Drawing.Size(752, 412);
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
            this.sceduller1.Size = new System.Drawing.Size(743, 399);
            this.sceduller1.TabIndex = 0;
            // 
            // Patients
            // 
            this.Patients.Controls.Add(this.dataGridView1);
            this.Patients.ImageIndex = 1;
            this.Patients.Location = new System.Drawing.Point(4, 22);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(752, 496);
            this.Patients.TabIndex = 1;
            this.Patients.Text = "Patients";
            this.Patients.UseVisualStyleBackColor = true;
            // 
            // Income_Expenses
            // 
            this.Income_Expenses.Controls.Add(this.dataGridView2);
            this.Income_Expenses.ImageIndex = 2;
            this.Income_Expenses.Location = new System.Drawing.Point(4, 22);
            this.Income_Expenses.Name = "Income_Expenses";
            this.Income_Expenses.Padding = new System.Windows.Forms.Padding(3);
            this.Income_Expenses.Size = new System.Drawing.Size(752, 496);
            this.Income_Expenses.TabIndex = 2;
            this.Income_Expenses.Text = "Income/Expenses";
            this.Income_Expenses.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.patientIdDataGridViewTextBoxColumn,
            this.phoneNumberDataGridViewTextBoxColumn,
            this.phoneNumber2DataGridViewTextBoxColumn,
            this.firstNameDataGridViewTextBoxColumn,
            this.lastNameDataGridViewTextBoxColumn,
            this.amkaDataGridViewTextBoxColumn,
            this.sexDataGridViewTextBoxColumn,
            this.birthDateDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.registrationNumberDataGridViewTextBoxColumn,
            this.debtDataGridViewTextBoxColumn,
            this.insuranceDataGridViewTextBoxColumn,
            this.notesDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.patientBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(756, 496);
            this.dataGridView1.TabIndex = 0;
            // 
            // _Vasi_Diaxeirisis_IatreiouDataSet
            // 
            this._Vasi_Diaxeirisis_IatreiouDataSet.DataSetName = "_Vasi_Diaxeirisis_IatreiouDataSet";
            this._Vasi_Diaxeirisis_IatreiouDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vasiDiaxeirisisIatreiouDataSetBindingSource
            // 
            this.vasiDiaxeirisisIatreiouDataSetBindingSource.DataSource = this._Vasi_Diaxeirisis_IatreiouDataSet;
            this.vasiDiaxeirisisIatreiouDataSetBindingSource.Position = 0;
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
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
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
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.incomesIdDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.amountDataGridViewTextBoxColumn,
            this.staffIdDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.incomesBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-4, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(756, 226);
            this.dataGridView2.TabIndex = 0;
            // 
            // incomesBindingSource
            // 
            this.incomesBindingSource.DataMember = "Incomes";
            this.incomesBindingSource.DataSource = this._Vasi_Diaxeirisis_IatreiouDataSet;
            // 
            // incomesTableAdapter
            // 
            this.incomesTableAdapter.ClearBeforeFill = true;
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
            // expensesBindingSource
            // 
            this.expensesBindingSource.DataMember = "Expenses";
            this.expensesBindingSource.DataSource = this._Vasi_Diaxeirisis_IatreiouDataSet;
            // 
            // expensesTableAdapter
            // 
            this.expensesTableAdapter.ClearBeforeFill = true;
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 562);
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
            this.Income_Expenses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._Vasi_Diaxeirisis_IatreiouDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vasiDiaxeirisisIatreiouDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.incomesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expensesBindingSource)).EndInit();
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
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
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
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource vasiDiaxeirisisIatreiouDataSetBindingSource;
        private _Vasi_Diaxeirisis_IatreiouDataSet _Vasi_Diaxeirisis_IatreiouDataSet;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.PatientTableAdapter patientTableAdapter;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneNumber2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amkaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthDateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn debtDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn insuranceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn notesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.IncomesTableAdapter incomesTableAdapter;
        private System.Windows.Forms.BindingSource incomesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomesIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn staffIdDataGridViewTextBoxColumn;
        private _Vasi_Diaxeirisis_IatreiouDataSetTableAdapters.ExpensesTableAdapter expensesTableAdapter;
        private System.Windows.Forms.BindingSource expensesBindingSource;
    }
}

