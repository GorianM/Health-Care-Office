using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelProject
{
    public class Patient
    {
        public int PatientID { get; set; }
        public string PhoneNumber { get; set; }
        public string PhoneNumber2 { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Amka { get; set; }
        public string Sex { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public string RegistrationNumber { get; set; }
        public decimal Debt { get; set; }
        public string Insurance { get; set; }
        public string Notes { get; set; }
        public int Weight { get; set; }

        public string getShortString()
        {
            string str = FirstName + " " + LastName + " AMKA: " + Amka;
            return str;
        }
    }
}
