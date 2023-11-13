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

        private DoctorsForm doctorsForm = new DoctorsForm();
        private List<Doctor> doctors;

        public List<Doctor> Doctors => doctors;

        private List<Patient> registeredPatients = new List<Patient>();
        public List<Patient> RegisteredPatients => registeredPatients;

        public Patient? LoggedInPatient { get; private set; }

        public BookingSystem()
        {
            doctors = doctorsForm.allDoctors;
        }
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
