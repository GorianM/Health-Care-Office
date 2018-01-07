using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HealthAndCareOffice
{
    class Appointment
    {
        public int AppointmentID { get; set; }
        public DateTime AppontmentDateTime { get; set; }
        public DateTime AppointmentTime { get; set; }
        public int EstimatedDurationMinutes { get; set; }
        public string Reason { get; set; }
        public string Diagnosis { get; set; }
        public string Treatment { get; set; }
        public string Notes { get; set; }
        public Patient patient { get; set; }
        public Staff staff { get; set; }

    }
}
