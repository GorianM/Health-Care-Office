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
            this.calendarContainerPanel = new System.Windows.Forms.Panel();
            this.ToolbarPanel = new System.Windows.Forms.Panel();
            this.currentWeekDate = new System.Windows.Forms.DateTimePicker();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.AddNewAppoinmentButton = new System.Windows.Forms.Button();
            this.Patients = new System.Windows.Forms.TabPage();
            this.Income_Expenses = new System.Windows.Forms.TabPage();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.AppointmentsTabPage.SuspendLayout();
            this.ToolbarPanel.SuspendLayout();
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
            this.appointmentToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.appointmentToolStripMenuItem.Text = "Appointment";
            this.appointmentToolStripMenuItem.Click += new System.EventHandler(this.appointmentToolStripMenuItem_Click);
            // 
            // petientToolStripMenuItem
            // 
            this.petientToolStripMenuItem.Name = "petientToolStripMenuItem";
            this.petientToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.petientToolStripMenuItem.Text = "Petient";
            // 
            // windowToolStripMenuItem
            // 
            this.windowToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.windowToolStripMenuItem.Name = "windowToolStripMenuItem";
            this.windowToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.windowToolStripMenuItem.Text = "Window";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
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
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check For Updates";
            // 
            // openDocumentationToolStripMenuItem
            // 
            this.openDocumentationToolStripMenuItem.Name = "openDocumentationToolStripMenuItem";
            this.openDocumentationToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.openDocumentationToolStripMenuItem.Text = "Open Documentation";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.AppointmentsTabPage);
            this.tabControl1.Controls.Add(this.Patients);
            this.tabControl1.Controls.Add(this.Income_Expenses);
            this.tabControl1.ImageList = this.imageList1;
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
<<<<<<< HEAD
            this.AppointmentsTabPage.Controls.Add(this.calendarContainerPanel);
            this.AppointmentsTabPage.Location = new System.Drawing.Point(4, 22);
=======
            this.AppointmentsTabPage.ImageIndex = 0;
            this.AppointmentsTabPage.Location = new System.Drawing.Point(4, 32);
>>>>>>> eac31e132409f729a04bd791d29bbe00e5aa3af9
            this.AppointmentsTabPage.Name = "AppointmentsTabPage";
            this.AppointmentsTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.AppointmentsTabPage.Size = new System.Drawing.Size(752, 486);
            this.AppointmentsTabPage.TabIndex = 0;
            this.AppointmentsTabPage.Text = "Appointments";
            // 
            // calendarContainerPanel
            // 
            this.calendarContainerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.calendarContainerPanel.AutoScroll = true;
            this.calendarContainerPanel.BackColor = System.Drawing.Color.Transparent;
            this.calendarContainerPanel.Location = new System.Drawing.Point(3, 78);
            this.calendarContainerPanel.Name = "calendarContainerPanel";
            this.calendarContainerPanel.Size = new System.Drawing.Size(752, 412);
            this.calendarContainerPanel.TabIndex = 1;
            // 
            // ToolbarPanel
            // 
            this.ToolbarPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ToolbarPanel.BackColor = System.Drawing.Color.Transparent;
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
            // currentWeekDate
            // 
            this.currentWeekDate.Location = new System.Drawing.Point(279, 7);
            this.currentWeekDate.Name = "currentWeekDate";
            this.currentWeekDate.Size = new System.Drawing.Size(197, 20);
            this.currentWeekDate.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(482, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 20);
            this.button3.TabIndex = 3;
            this.button3.Text = ">";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(249, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 20);
            this.button2.TabIndex = 2;
            this.button2.Text = "<";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 20);
            this.button1.TabIndex = 1;
            this.button1.Text = "Today";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // AddNewAppoinmentButton
            // 
            this.AddNewAppoinmentButton.Location = new System.Drawing.Point(4, 6);
            this.AddNewAppoinmentButton.Name = "AddNewAppoinmentButton";
            this.AddNewAppoinmentButton.Size = new System.Drawing.Size(137, 20);
            this.AddNewAppoinmentButton.TabIndex = 0;
            this.AddNewAppoinmentButton.Text = "New Appointment";
            this.AddNewAppoinmentButton.UseVisualStyleBackColor = true;
            this.AddNewAppoinmentButton.Click += new System.EventHandler(this.AddNewAppoinmentButton_Click);
            // 
            // Patients
            // 
            this.Patients.ImageIndex = 1;
            this.Patients.Location = new System.Drawing.Point(4, 32);
            this.Patients.Name = "Patients";
            this.Patients.Padding = new System.Windows.Forms.Padding(3);
            this.Patients.Size = new System.Drawing.Size(752, 486);
            this.Patients.TabIndex = 1;
            this.Patients.Text = "Petients";
            this.Patients.UseVisualStyleBackColor = true;
            // 
            // Income_Expenses
            // 
            this.Income_Expenses.ImageIndex = 2;
            this.Income_Expenses.Location = new System.Drawing.Point(4, 32);
            this.Income_Expenses.Name = "Income_Expenses";
            this.Income_Expenses.Padding = new System.Windows.Forms.Padding(3);
            this.Income_Expenses.Size = new System.Drawing.Size(752, 486);
            this.Income_Expenses.TabIndex = 2;
            this.Income_Expenses.Text = "Income/Expenses";
            this.Income_Expenses.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "event-processing-calendar-appointment-planner-schedule-reminder-374f1aa7463926ff-" +
        "256x256.png");
            this.imageList1.Images.SetKeyName(1, "Medical_Supervision__Treatment-512.png");
            this.imageList1.Images.SetKeyName(2, "wedxnwukiugqjnnfhxmr.png");
            // 
            // MainWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
<<<<<<< HEAD
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(784, 561);
=======
            this.ClientSize = new System.Drawing.Size(784, 562);
>>>>>>> eac31e132409f729a04bd791d29bbe00e5aa3af9
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
        private System.Windows.Forms.ImageList imageList1;
    }
}

