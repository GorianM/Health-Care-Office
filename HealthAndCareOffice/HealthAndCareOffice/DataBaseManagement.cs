
using ModelProject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ModelsProject;

namespace HealthAndCareOffice
{
    class DataBaseManagement
    {
        string con;
        string path;
        OleDbConnection connection;
        public DataBaseManagement()
        {
            con = ConfigurationManager.ConnectionStrings["HealthAndCareOffice.Properties.Settings.Vasi_Diaxeirisis_IatreiouV2ConnectionString"].ConnectionString;
            connection = new OleDbConnection();
            connection.ConnectionString = con;
        }

        public void testConnection()
        {
            connection.Open();
            MessageBox.Show("Connection Sccsessful!!");
            connection.Close();
        }

        public Staff getStaffByUserNameAndPassWord(string username, string password)
        {
            List<Staff> staffList = new List<Staff>();
            connection.Open();            
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  Staff WHERE Username='"+username+"' and Password='" + password + "'", connection);
            reader = command.ExecuteReader();
            while(reader.Read())
            {
                Staff sta = new Staff();
                sta.StaffId = (int) reader[0];
                sta.Username = reader[1].ToString();
                sta.Password = reader[2].ToString();
                sta.MedicalSpecialty = reader[3].ToString();
                sta.FirstName = reader[4].ToString();
                sta.LastName = reader[5].ToString();
                sta.PhoneNumber = reader[6].ToString();
                sta.PhoneNumber2 = reader[7].ToString();
                sta.StaffRole = (int)reader[8];
                
                staffList.Add(sta);
            }

            if (staffList.Count >0)
            {
                Staff st = staffList.ElementAt<Staff>(0);
                connection.Close();
                return st;
            }
            
            connection.Close();
            return null;
        }

        public Staff getStaffByID(int id)
        {
            List<Staff> staffList = new List<Staff>();
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  Staff WHERE StaffId = "+id, connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Staff sta = new Staff();
                sta.StaffId = (int)reader[0];
                sta.Username = reader[1].ToString();
                sta.Password = reader[2].ToString();
                sta.MedicalSpecialty = reader[3].ToString();
                sta.FirstName = reader[4].ToString();
                sta.LastName = reader[5].ToString();
                sta.PhoneNumber = reader[6].ToString();
                sta.PhoneNumber2 = reader[7].ToString();
                sta.StaffRole = (int)reader[8];

                staffList.Add(sta);
            }

            if (staffList.Count > 0)
            {
                Staff st = staffList.ElementAt<Staff>(0);
                connection.Close();
                return st;
            }

            connection.Close();
            return null;
        }

        public List<Staff> getStaff()
        {
            List<Staff> staffList = new List<Staff>();
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  Staff;", connection);
            reader = command.ExecuteReader();
            while (reader.Read())
            {
                Staff sta = new Staff();
                sta.StaffId = (int)reader[0];
                sta.Username = reader[1].ToString();
                sta.Password = reader[2].ToString();
                sta.MedicalSpecialty = reader[3].ToString();
                sta.FirstName = reader[4].ToString();
                sta.LastName = reader[5].ToString();
                sta.PhoneNumber = reader[6].ToString();
                sta.PhoneNumber2 = reader[7].ToString();
                sta.StaffRole = (int)reader[8];

                staffList.Add(sta);
            }

            

            connection.Close();
            return staffList;
        }

        public List<Patient> getPatientsForSelection()
        {
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  Patient;", connection);
            reader = command.ExecuteReader();
            List<Patient> patients = new List<Patient>();
            while (reader.Read())
            {
                Patient patient = new Patient();
                patient.PatientID = (int)reader[0];
                patient.PhoneNumber = reader[1].ToString();
                patient.PhoneNumber2 = reader[2].ToString();
                patient.FirstName = reader[3].ToString();
                patient.LastName = reader[4].ToString();
                patient.Amka = reader[5].ToString();
                patient.Sex = reader[6].ToString();
                //skip one for birthDate 7
                patient.Address = reader[8].ToString();
                patient.RegistrationNumber = reader[9].ToString();
                //patient.Debt = (decimal)reader[10];
                patient.Insurance = reader[11].ToString();
                patient.Notes = reader[12].ToString();
                patient.Weight = (int)reader[13];

                patients.Add(patient);
            }
            
            connection.Close();
            return patients;
        }

        public Patient GetPatientByID(int id)
        {
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  Patient where PatientId = "+id, connection);
            reader = command.ExecuteReader();
            Patient patient = new Patient();
            while (reader.Read())
            {
               
                patient.PatientID = (int)reader[0];
                patient.PhoneNumber = reader[1].ToString();
                patient.PhoneNumber2 = reader[2].ToString();
                patient.FirstName = reader[3].ToString();
                patient.LastName = reader[4].ToString();
                patient.Amka = reader[5].ToString();
                patient.Sex = reader[6].ToString();
                patient.BirthDate = reader.GetDateTime(7);
                patient.Address = reader[8].ToString();
                patient.RegistrationNumber = reader[9].ToString();
                //patient.Debt = (decimal)reader[10];
                patient.Insurance = reader[11].ToString();
                patient.Notes = reader[12].ToString();
                patient.Weight = (int)reader[13];

                
            }

            connection.Close();
            return patient;
        }

        public void getPatients(DataGridView dgv)
        {
            connection.Open();
           
            OleDbCommand command = new OleDbCommand("SELECT * from  Patient;", connection);
            

            DataSet dataSet = new DataSet();
            OleDbDataAdapter dbDataAdapter = new OleDbDataAdapter(command);
            dbDataAdapter.Fill(dataSet, "Patient");
            dgv.DataSource = dataSet;
            dgv.DataMember = "Patient";
            connection.Close();
            
        }

        public List<Appointment> getAppointments()
        {
            List<Staff> staff = getStaff();
            List<Patient> patients = getPatientsForSelection();
            connection.Open();
            OleDbDataReader reader = null;
            OleDbCommand command = new OleDbCommand("SELECT * from  Appointment ORDER BY AppointmentID;", connection);
            reader = command.ExecuteReader();
            List<Appointment> appointments = new List<Appointment>();
           
            while (reader.Read())
            {
                Appointment appointment = new Appointment();
                appointment.AppointmentID = (int)reader[0];
				DateTime date = reader.GetDateTime(1).Date;
				DateTime time = new DateTime(1999, 1, 1, reader.GetDateTime(2).Hour, reader.GetDateTime(2).Minute, reader.GetDateTime(2).Second);
				DateTime dateTime = new DateTime(date.Year,date.Month,date.Day,time.Hour,time.Minute,time.Second);

                appointment.AppontmentDateTime = dateTime;
                appointment.EstimatedDurationMinutes = (int)reader[3];
                appointment.Reason = reader[4].ToString();
                appointment.Diagnosis = reader[5].ToString();
                appointment.Treatment = reader[6].ToString();
                appointment.Notes = reader[7].ToString();
                foreach(Patient patient in patients)
                {
                    if(patient.PatientID == (int)reader[8])
                    {
                        appointment.patient = patient;
                    }
                }
                foreach(Staff st in staff)
                {
                    int id = (int)reader[9];
                    if(st.StaffId == id)
                    {
                        appointment.staff = st;
                    }
                }      

                appointments.Add(appointment);
            }

            connection.Close();
            return appointments;
        }

        public void addAppointment(Appointment appointment)
        {
            try
            {
                List<Appointment> appointments = getAppointments();
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.CommandType = CommandType.Text;
                command.CommandText = @"INSERT INTO Appointment
                         (AppointmentID, [DateTime], ExactTime, EstimatedDurationMinutes, Reason, Diagnosis, Treatment, Notes, PatientId, StaffId)
VALUES        (?, ?, ?, ?, ?, '', '', '', ?, ?)";
                
                
                command.Parameters.AddWithValue("AppointmentID", appointments.Last().AppointmentID+1);
                command.Parameters.AddWithValue("[DateTime]", appointment.AppontmentDateTime.Date);
                command.Parameters.AddWithValue("ExactTime", appointment.AppontmentDateTime);
                command.Parameters.AddWithValue("EstimatedDurationMinutes", appointment.EstimatedDurationMinutes);
                command.Parameters.AddWithValue("Reason", appointment.Reason);
                command.Parameters.AddWithValue("PatientId", appointment.patient.PatientID);
                command.Parameters.AddWithValue("StaffId", appointment.staff.StaffId);
                command.Connection = connection;
                int rowsAffected = command.ExecuteNonQuery();
                MessageBox.Show("Rows Affected " + rowsAffected);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
             
            
           
        }

        public void addPatient(Patient patient)
        {
            try
            {
                List<Patient> patientList = getPatientsForSelection();
                int id = patientList.Last<Patient>().PatientID + 1;
                patient.PatientID = id;

                OleDbCommand command = connection.CreateCommand();
                command.CommandText = @"Insert into Patient (PatientId,PhoneNumber,PhoneNumber2,FirstName,LastName,Amka,Sex,BirthDate,Address,RegistrationNumber,Insurance,Weight)
                values (?,?,?,?,?,?,?,?,?,?,?,?)";
                command.Parameters.AddWithValue("PatientId", patient.PatientID);
                command.Parameters.AddWithValue("PhoneNumber", patient.PhoneNumber);
                command.Parameters.AddWithValue("PhoneNumber2", patient.PhoneNumber2);
                command.Parameters.AddWithValue("FirstName", patient.FirstName);
                command.Parameters.AddWithValue("LastName", patient.LastName);
                command.Parameters.AddWithValue("Amka", patient.Amka);
                command.Parameters.AddWithValue("Sex", patient.Sex);
                command.Parameters.AddWithValue("BirthDate", patient.BirthDate);
                command.Parameters.AddWithValue("Address", patient.Address);
                command.Parameters.AddWithValue("RegistrationNumber", patient.RegistrationNumber);
                command.Parameters.AddWithValue("Insurance", patient.Insurance);
                command.Parameters.AddWithValue("Weight", patient.Weight);

                //command.Connection = connection;
                connection.Open();
                int rowsAffected = command.ExecuteNonQuery();

                MessageBox.Show("Rows Affected" + rowsAffected);
                connection.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            
        }

		internal List<ExpandableProdact> getExpandableProdacts()
		{
			OleDbDataReader reader = null;
			OleDbCommand command = new OleDbCommand("SELECT * from  ExpandableProducts WHERE StaffId = ?", connection);
			command.Parameters.AddWithValue("StaffId", GlobalConfig.User.StaffId);
			connection.Open();
			reader = command.ExecuteReader();
			List<ExpandableProdact> expandableProdacts = new List<ExpandableProdact>();

			while (reader.Read())
			{
				ExpandableProdact expandableProdact = new ExpandableProdact();
				expandableProdact.ID = (int)reader[0];
				expandableProdact.Description = reader[1].ToString();
				expandableProdact.MinimumThreshold = (int)reader[2];
				expandableProdact.Quantity = (int)reader[3];
				expandableProdact.staff = GlobalConfig.User;
				
			}

			connection.Close();
			return expandableProdacts;

		}


	}
}
