using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPBookingSystem
{
    public class BookingSystem
    {
        private List<Patient> registeredPatients = new List<Patient>();
        public List<Patient> RegisteredPatients => registeredPatients;

        public Patient? LoggedInPatient { get; private set; }

        public bool AttemptLogin(string email, string password)
        {
            var patient = registeredPatients.FirstOrDefault(p => p.Email == email);
            if (patient != null && patient.VerifyPassword(password))
            {
                LoggedInPatient = patient;
                return true;
            }
            return false;
        }
    }
}
