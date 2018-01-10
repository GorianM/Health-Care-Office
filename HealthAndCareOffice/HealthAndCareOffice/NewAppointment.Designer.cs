namespace HealthAndCareOffice
{
    partial class NewAppointment
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewAppointment));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxEstimatedDuration = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxReasonOfAppointment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.newAppointmentDatePicker = new System.Windows.Forms.DateTimePicker();
            this.newAppointmentTimePicker = new System.Windows.Forms.DateTimePicker();
            this.timeLabel = new System.Windows.Forms.Label();
            this.selectPatientLabel = new System.Windows.Forms.Label();
            this.PatientListBox = new System.Windows.Forms.ListBox();
            this.addNewPatientButton = new System.Windows.Forms.Button();
            this.selectedPatientLabel = new System.Windows.Forms.Label();
            this.wrongDateLabel = new System.Windows.Forms.Label();
            this.wrongTimeLabel = new System.Windows.Forms.Label();
            this.wrongDurationLabel = new System.Windows.Forms.Label();
            this.wrongReasonLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label1.Location = new System.Drawing.Point(132, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date :";
            // 
            // textBoxEstimatedDuration
            // 
            this.textBoxEstimatedDuration.Location = new System.Drawing.Point(186, 261);
            this.textBoxEstimatedDuration.Name = "textBoxEstimatedDuration";
            this.textBoxEstimatedDuration.Size = new System.Drawing.Size(199, 20);
            this.textBoxEstimatedDuration.TabIndex = 3;
            this.textBoxEstimatedDuration.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label2.Location = new System.Drawing.Point(41, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Estimated Duration :";
            // 
            // textBoxReasonOfAppointment
            // 
            this.textBoxReasonOfAppointment.Location = new System.Drawing.Point(186, 302);
            this.textBoxReasonOfAppointment.Name = "textBoxReasonOfAppointment";
            this.textBoxReasonOfAppointment.Size = new System.Drawing.Size(199, 20);
            this.textBoxReasonOfAppointment.TabIndex = 5;
            this.textBoxReasonOfAppointment.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.label3.Location = new System.Drawing.Point(12, 304);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Reason of Appointment :";
            // 
            // btnCancel
            // 
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.ImageIndex = 1;
            this.btnCancel.ImageList = this.imageList1;
            this.btnCancel.Location = new System.Drawing.Point(118, 389);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 34);
            this.btnCancel.TabIndex = 12;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.button1_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "add.png");
            this.imageList1.Images.SetKeyName(1, "remove-remove-exit-icone-7195-128.png");
            // 
            // btnAdd
            // 
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.ImageIndex = 0;
            this.btnAdd.ImageList = this.imageList1;
            this.btnAdd.Location = new System.Drawing.Point(319, 389);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(82, 34);
            this.btnAdd.TabIndex = 13;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // newAppointmentDatePicker
            // 
            this.newAppointmentDatePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.newAppointmentDatePicker.Location = new System.Drawing.Point(186, 186);
            this.newAppointmentDatePicker.Name = "newAppointmentDatePicker";
            this.newAppointmentDatePicker.Size = new System.Drawing.Size(199, 20);
            this.newAppointmentDatePicker.TabIndex = 14;
            this.newAppointmentDatePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // newAppointmentTimePicker
            // 
            this.newAppointmentTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.newAppointmentTimePicker.Location = new System.Drawing.Point(186, 222);
            this.newAppointmentTimePicker.Name = "newAppointmentTimePicker";
            this.newAppointmentTimePicker.Size = new System.Drawing.Size(200, 20);
            this.newAppointmentTimePicker.TabIndex = 15;
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.timeLabel.Location = new System.Drawing.Point(130, 224);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(49, 18);
            this.timeLabel.TabIndex = 16;
            this.timeLabel.Text = "Time :";
            // 
            // selectPatientLabel
            // 
            this.selectPatientLabel.AutoSize = true;
            this.selectPatientLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.selectPatientLabel.Location = new System.Drawing.Point(15, 11);
            this.selectPatientLabel.Name = "selectPatientLabel";
            this.selectPatientLabel.Size = new System.Drawing.Size(98, 18);
            this.selectPatientLabel.TabIndex = 18;
            this.selectPatientLabel.Text = "Select Patient";
            // 
            // PatientListBox
            // 
            this.PatientListBox.FormattingEnabled = true;
            this.PatientListBox.Location = new System.Drawing.Point(13, 33);
            this.PatientListBox.Name = "PatientListBox";
            this.PatientListBox.Size = new System.Drawing.Size(489, 95);
            this.PatientListBox.TabIndex = 19;
            this.PatientListBox.SelectedIndexChanged += new System.EventHandler(this.OnSelectedIndexChanged);
            // 
            // addNewPatientButton
            // 
            this.addNewPatientButton.Location = new System.Drawing.Point(406, 135);
            this.addNewPatientButton.Name = "addNewPatientButton";
            this.addNewPatientButton.Size = new System.Drawing.Size(95, 23);
            this.addNewPatientButton.TabIndex = 20;
            this.addNewPatientButton.Text = "Add New Patient";
            this.addNewPatientButton.UseVisualStyleBackColor = true;
            this.addNewPatientButton.Click += new System.EventHandler(this.addNewPatientButton_Click);
            // 
            // selectedPatientLabel
            // 
            this.selectedPatientLabel.AutoSize = true;
            this.selectedPatientLabel.Location = new System.Drawing.Point(13, 135);
            this.selectedPatientLabel.Name = "selectedPatientLabel";
            this.selectedPatientLabel.Size = new System.Drawing.Size(0, 13);
            this.selectedPatientLabel.TabIndex = 21;
            // 
            // wrongDateLabel
            // 
            this.wrongDateLabel.AutoSize = true;
            this.wrongDateLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongDateLabel.Location = new System.Drawing.Point(186, 167);
            this.wrongDateLabel.Name = "wrongDateLabel";
            this.wrongDateLabel.Size = new System.Drawing.Size(136, 13);
            this.wrongDateLabel.TabIndex = 22;
            this.wrongDateLabel.Text = "You must enter a valid date";
            this.wrongDateLabel.Visible = false;
            // 
            // wrongTimeLabel
            // 
            this.wrongTimeLabel.AutoSize = true;
            this.wrongTimeLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongTimeLabel.Location = new System.Drawing.Point(186, 209);
            this.wrongTimeLabel.Name = "wrongTimeLabel";
            this.wrongTimeLabel.Size = new System.Drawing.Size(138, 13);
            this.wrongTimeLabel.TabIndex = 23;
            this.wrongTimeLabel.Text = "You must enter a valid Time";
            this.wrongTimeLabel.Visible = false;
            // 
            // wrongDurationLabel
            // 
            this.wrongDurationLabel.AutoSize = true;
            this.wrongDurationLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongDurationLabel.Location = new System.Drawing.Point(186, 245);
            this.wrongDurationLabel.Name = "wrongDurationLabel";
            this.wrongDurationLabel.Size = new System.Drawing.Size(155, 13);
            this.wrongDurationLabel.TabIndex = 24;
            this.wrongDurationLabel.Text = "You must enter a valid Duration";
            this.wrongDurationLabel.Visible = false;
            // 
            // wrongReasonLabel
            // 
            this.wrongReasonLabel.AutoSize = true;
            this.wrongReasonLabel.ForeColor = System.Drawing.Color.Firebrick;
            this.wrongReasonLabel.Location = new System.Drawing.Point(186, 286);
            this.wrongReasonLabel.Name = "wrongReasonLabel";
            this.wrongReasonLabel.Size = new System.Drawing.Size(218, 13);
            this.wrongReasonLabel.TabIndex = 25;
            this.wrongReasonLabel.Text = "You must enter a valid reason for Apointment";
            this.wrongReasonLabel.Visible = false;
            // 
            // NewAppointment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(514, 459);
            this.Controls.Add(this.wrongReasonLabel);
            this.Controls.Add(this.wrongDurationLabel);
            this.Controls.Add(this.wrongTimeLabel);
            this.Controls.Add(this.wrongDateLabel);
            this.Controls.Add(this.selectedPatientLabel);
            this.Controls.Add(this.addNewPatientButton);
            this.Controls.Add(this.PatientListBox);
            this.Controls.Add(this.selectPatientLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.newAppointmentTimePicker);
            this.Controls.Add(this.newAppointmentDatePicker);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.textBoxReasonOfAppointment);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxEstimatedDuration);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewAppointment";
            this.Text = "NewAppointment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxEstimatedDuration;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxReasonOfAppointment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.DateTimePicker newAppointmentDatePicker;
        private System.Windows.Forms.DateTimePicker newAppointmentTimePicker;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label selectPatientLabel;
        private System.Windows.Forms.ListBox PatientListBox;
        private System.Windows.Forms.Button addNewPatientButton;
        private System.Windows.Forms.Label selectedPatientLabel;
        private System.Windows.Forms.Label wrongDateLabel;
        private System.Windows.Forms.Label wrongTimeLabel;
        private System.Windows.Forms.Label wrongDurationLabel;
        private System.Windows.Forms.Label wrongReasonLabel;
    }
}